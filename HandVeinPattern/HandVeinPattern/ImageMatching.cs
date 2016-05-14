using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Shape;
using Emgu.CV.Structure;
using Emgu.CV.XFeatures2D;
using Emgu.CV.Util;
using Emgu.CV.Cuda;

using Wrapper;

using ThinningProcess;
using System.IO;
using System.Data.SqlClient;

namespace HandVeinPattern
{
    public partial class ImageMatching : Form
    {
        DataTable userID_datatable;

        DataTable features_datatable;

        int matchedfeatures_count;

        int non_matched_userid_count = 0;

        bool result;

        byte[] photo_array;

        static string _userID;

        MKeyPoint[] mKeyPoints;

        OpenCVWrapper opencvwrapper;

        ThinningOpenCVWrapper thinningopencvwrapper;

        public ImageMatching()
        {
            InitializeComponent();

            opencvwrapper = new OpenCVWrapper();

            thinningopencvwrapper = new ThinningOpenCVWrapper();

            ProcessedImagePictureEdit.ContextMenu = new ContextMenu();

            //ArduinoSerialPort.PortName = "COM4";

            //ArduinoSerialPort.BaudRate = 9600;

        }

        
        #region Original Context menu Strip Click Events

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OriginalImagePictureEdit.Image = Clipboard.GetImage();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadimage = new OpenFileDialog();
            if (loadimage.ShowDialog() == DialogResult.OK)
            {
                OriginalImagePictureEdit.Image = Image.FromFile(loadimage.FileName);
                Details.imagefilepath = loadimage.FileName;
            }
        }

        private void LoadImageSimpleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadimage = new OpenFileDialog();
            if (loadimage.ShowDialog() == DialogResult.OK)
            {
                OriginalImagePictureEdit.Image = Image.FromFile(loadimage.FileName);
                Details.imagefilepath = loadimage.FileName;
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OriginalImagePictureEdit.Image = HandVeinPattern.Properties.Resources.Blank_Hand_Image;
        }

        private void OriginalImageContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                PasteToolStripMenuItem.Enabled = true;
            }
            else
            {
                PasteToolStripMenuItem.Enabled = false;
            }
        }

        #endregion


        #region Image Processing

        private void ProcessImageBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Details.sourceimagehand = new Mat(Details.imagefilepath, LoadImageType.Grayscale);

            Details.whitebalance = new Mat();

            CvInvoke.BalanceWhite(Details.sourceimagehand, Details.whitebalance, WhiteBalanceMethod.Simple, 0f, 255f, 0f, 255f);

            Directory.CreateDirectory(@"D:\Eighth Semester\HandVeinPattern\\RuntimeDirectory");

            Details.adaptivethreshold = new Mat();

            CvInvoke.AdaptiveThreshold(Details.whitebalance, Details.adaptivethreshold, 255, AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 11, -3);

            CvInvoke.Imwrite(@"D:\Eighth Semester\HandVeinPattern\RuntimeDirectory\AdaptiveThreshold.jpg", Details.adaptivethreshold);

            opencvwrapper.process();

            Details.maskedimage = new Mat();

            Details.maskedimage = new Mat(@"D:\Eighth Semester\HandVeinPattern\RuntimeDirectory\ResultImage.jpg", LoadImageType.Grayscale);

            Details.erode_step1 = new Mat();

            Details.erode_step2 = new Mat();

            CvInvoke.MorphologyEx(Details.maskedimage, Details.erode_step1, MorphOp.Erode, CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(3, 3), new Point(-1, -1)), new Point(-1, -1), 9, BorderType.Constant, new MCvScalar(0));

            CvInvoke.MorphologyEx(Details.erode_step1, Details.erode_step2, MorphOp.Erode, CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(3, 3), new Point(-1, -1)), new Point(-1, -1), 7, BorderType.Constant, new MCvScalar(0));

            Details.laplacian = new Mat();

            CvInvoke.Laplacian(Details.sourceimagehand, Details.laplacian, DepthType.Cv8U, 11, 1.0, 0.0, BorderType.Constant);

            Details.multipliedimage = new Mat();

            Mat _newFilteredImage = new Mat();

            CvInvoke.Multiply(Details.laplacian, Details.maskedimage, _newFilteredImage, 1.0, DepthType.Cv8U);

            CvInvoke.Multiply(Details.laplacian, Details.erode_step2, Details.multipliedimage, 1.0, DepthType.Cv8U);

            Mat newsource = new Mat();

            newsource = Details.multipliedimage.Clone();

            Details.thinnedimage = new Mat();

            CvInvoke.Threshold(newsource, Details.thinnedimage, 10, 255, ThresholdType.Binary);

            CvInvoke.Imwrite(@"D:\Eighth Semester\HandVeinPattern\RuntimeDirectory\MultipliedImage.jpg", Details.thinnedimage);

            thinningopencvwrapper.process();

            Details.thinnedimage = new Mat();

            Details.thinnedimage = new Mat(@"D:\Eighth Semester\HandVeinPattern\RuntimeDirectory\ThinnedImage.jpg", LoadImageType.Grayscale);

            Details.keypointsimage = new Mat();

            Details.keypointsimage = PutFeaturesOnImage();

            ProcessedImagePictureEdit.Image = Details.keypointsimage.Bitmap;

            ImageMatchingProgressBarControl.PerformStep();

            ImageMatchingProgressBarControl.Update();
        }

        public Mat PutFeaturesOnImage()
        {
            SIFT siftCPU = new SIFT();

            Details.modelKeyPoints = new VectorOfKeyPoint();

            mKeyPoints = siftCPU.Detect(Details.thinnedimage, null);

            Details.modelKeyPoints.Push(mKeyPoints);

            Mat o = new Mat();

            siftCPU.Compute(Details.thinnedimage, Details.modelKeyPoints, o);

            Mat resultimage = new Mat();

            Features2DToolbox.DrawKeypoints(Details.thinnedimage, Details.modelKeyPoints, resultimage, new Bgr(Color.Red), Features2DToolbox.KeypointDrawType.Default);

            return resultimage;
        }

        #endregion


        #region User Matching

        // Function To Get All The Users ID From The Database

        void getUserID()
        {
            // Creates SQL Connection

            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            // Creates SQL Command

            SqlCommand command = new SqlCommand();

            // Opens The SQL Connection

            connection.Open();

            // Exception Handling

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "SELECT ID FROM USERS";

                // Data Adapter To Read Data From Database Using SQL Command

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Creates An Instance OF DataTable

                userID_datatable = new DataTable();

                // Fills The DataTable Using The Adapter

                adapter.Fill(userID_datatable);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                // Displays The Exception 

                throw;
            }
            finally
            {
                // Checks The State Of Connection 

                if (connection.State == ConnectionState.Open)
                {
                    // Closes The Connection

                    connection.Close();
                }
            }

            ImageMatchingProgressBarControl.PerformStep();

            ImageMatchingProgressBarControl.Update();
        }

        // Function To Get All The Features Stored In The Database For Each User

        void getFeatures(string UID)
        {
            // Creates SQL Connection

            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            // Creates SQL Command

            SqlCommand command = new SqlCommand();

            // Opens The SQL Connection

            connection.Open();

            // Exception Handling

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "SELECT FeatureID, UserID, Angle, ClassID, Octave, PointX, PointY, Response, Size FROM Features WHERE UserID = '" + UID + "'";

                // Data Adapter To Read Data From Database Using SQL Command

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Creates An Instance OF DataTable

                features_datatable = new DataTable();

                // Fills The DataTable Using The Adapter

                adapter.Fill(features_datatable);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                // Displays The Exception 

                throw;
            }
            finally
            {
                // Checks The State Of Connection 

                if (connection.State == ConnectionState.Open)
                {
                    // Closes The Connection

                    connection.Close();
                }
            }

            ImageMatchingProgressBarControl.PerformStep();

            ImageMatchingProgressBarControl.Update();
        }

        // Function To Match All The Features Of Current User Hand Image With All The Features Stored In The Database

        void features_match()
        {
            // Counts The Features

            matchedfeatures_count = 0;

            int i = 0;

            // Matches Each Feature In Vector Of Key Points With The Features In Stored In The Database
         
            if (Details.modelKeyPoints.Size == features_datatable.Rows.Count)
            {
                while(i < Details.modelKeyPoints.Size)
                {
                    if (Convert.ToDouble(Details.modelKeyPoints[i].Angle) == Convert.ToDouble(features_datatable.Rows[i].Field<Double>(2)) && Convert.ToDouble(Details.modelKeyPoints[i].ClassId) == Convert.ToDouble(features_datatable.Rows[i].Field<Double>(3)) && Convert.ToDouble(Details.modelKeyPoints[i].Octave) == Convert.ToDouble(features_datatable.Rows[i].Field<Double>(4)) && Convert.ToDouble(Details.modelKeyPoints[i].Point.X) == Convert.ToDouble(features_datatable.Rows[i].Field<Double>(5)) && Convert.ToDouble(Details.modelKeyPoints[i].Point.Y) == Convert.ToDouble(features_datatable.Rows[i].Field<Double>(6)) && Convert.ToDouble(Details.modelKeyPoints[i].Response) == Convert.ToDouble(features_datatable.Rows[i].Field<Double>(7)) && Convert.ToDouble(Details.modelKeyPoints[i].Size) == Convert.ToDouble(features_datatable.Rows[i].Field<Double>(8)))
                    {
                        i++;
                        matchedfeatures_count += 1;
                    }
                }

                ImageMatchingProgressBarControl.PerformStep();

                ImageMatchingProgressBarControl.Update();
            }

            else
            {
                non_matched_userid_count += 1;
            }
        }

        // Function To Diplay The Results Of Current User From The Database.

        void displayResult(string id)
        {
            // Creates SQL Connection

            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            // Creates SQL Command

            SqlCommand command = new SqlCommand();

            // Opens The SQL Connection

            connection.Open();

            // Exception Handling

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "SELECT * FROM USERS WHERE ID ='" + id + "'";

                // Data Adapter To Read Data From Database Using SQL Command

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Creates An Instance OF DataTable

                Details.matchedUserDetails = new DataTable();

                // Fills The DataTable Using The Adapter
                
                adapter.Fill(Details.matchedUserDetails);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                // Displays The Exception 

                throw;
            }
            finally
            {
                // Checks The State Of Connection 

                if (connection.State == ConnectionState.Open)
                {
                    // Closes The Connection

                    connection.Close();
                }
            }

            //  Displays The Matched Results

            UserIDResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>(0).ToString();

            UserTitleResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>(5).ToString();

            if (Details.matchedUserDetails.Rows[0]["Image"] != DBNull.Value)
            {
                photo_array = (byte[])Details.matchedUserDetails.Rows[0]["Image"];
                
                MemoryStream memorystream = new MemoryStream(photo_array);

                ResultImagePictureEdit.Image = Image.FromStream(memorystream);
            }

            ImageMatchingProgressBarControl.PerformStep();

            ImageMatchingProgressBarControl.Update();

        }

        // Match Button Click Event

        private void MatchBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            getUserID();

            for (int i = 0; i < userID_datatable.Rows.Count; i++)
            {
                _userID = userID_datatable.Rows[i].Field<string>(0).ToString();
                
                getFeatures(_userID);

                features_match();

                if (matchedfeatures_count == Details.modelKeyPoints.Size)
                {
                    Details.matchedID = _userID;

                    displayResult(_userID);

                    //ArduinoSerialPort.WriteLine("1");

                    ImageMatchingProgressBarControl.PerformStep();
                    
                    ImageMatchingProgressBarControl.Update();
                    
                    break;
                }
            }

            if (non_matched_userid_count == userID_datatable.Rows.Count)
            {
                MessageBox.Show("User Doesn't Exists.", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //ArduinoSerialPort.WriteLine("0");
            }

            ImageMatchingProgressBarControl.PerformStep();

            ImageMatchingProgressBarControl.Update();
        }

        #endregion

        // Button Click Event To See Full Details Of The User

        private void ViewDetailsSimpleButton_Click(object sender, EventArgs e)
        {
            MatchedUserDetails matcheduserdetails = new MatchedUserDetails();

            matcheduserdetails.Show();
        }


        private void CancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            dashboard.Show();

            this.Hide();
        }


        private void ImageMatching_Load(object sender, EventArgs e)
        {
            //if (ArduinoSerialPort.IsOpen)
            //{
            //    ArduinoSerialPort.Close();
            //}
            //else
            //{
            //    ArduinoSerialPort.Open();
            //}
        }

        private void ClearBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OriginalImagePictureEdit.Image = HandVeinPattern.Properties.Resources.Blank_Hand_Image;

            ProcessedImagePictureEdit.Image = HandVeinPattern.Properties.Resources.Blank_Hand_Image;

            ResultImagePictureEdit.Image = HandVeinPattern.Properties.Resources.noprofile;

            UserIDResultLabel.Text = "-";

            UserTitleResultLabel.Text = "-";

            ImageMatchingProgressBarControl.Position = 0;
        }
    }
}
