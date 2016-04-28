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

        DataTable handimage_datatable;

        int matchedfeatures_count;

        byte[] photo_array;

        static string _userID;

        int noOfFeatures;

        MKeyPoint[] mKeyPoints;

        MKeyPoint[] matching_mKeyPoints;

        OpenCVWrapper opencvwrapper;

        ThinningOpenCVWrapper thinningopencvwrapper;

        public ImageMatching()
        {
            InitializeComponent();

            opencvwrapper = new OpenCVWrapper();

            thinningopencvwrapper = new ThinningOpenCVWrapper();

            ProcessedImagePictureEdit.ContextMenu = new ContextMenu();
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

        void getUserID()
        {
            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);
            
            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "SELECT ID FROM USERS"; //"SELECT ID FROM HANDIMAGES WHERE USERS.ID = HANDIMAGES.ID";

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                userID_datatable = new DataTable();

                adapter.Fill(userID_datatable);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        void getFeatures(string UID)
        {
            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "SELECT FeatureID, UserID, Angle, ClassID, Octave, PointX, PointY, Response, Size FROM Features WHERE UserID = '" + UID + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                features_datatable = new DataTable();

                adapter.Fill(features_datatable);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        void feaetures_match()
        {
            matchedfeatures_count = 0;

            int i = 0;
         
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
            }
        }

        void getimage()
        {
            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "SELECT HANDIMAGE FROM HANDIMAGES WHERE ID = '" + _userID + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                handimage_datatable = new DataTable();

                adapter.Fill(handimage_datatable);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        void match1()
        {
            for (int i = 0; i < handimage_datatable.Rows.Count; i++)
            {
                photo_array = (byte[])handimage_datatable.Rows[i][0];

                MemoryStream ms = new MemoryStream(photo_array);

                Details.DBImage = Image.FromStream(ms);

                //Details.sourceimagehand =  new Mat((Image.FromStream(ms), LoadImageType.Grayscale);

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
            }
            
        }

        void displayResult(string id)
        {
            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "SELECT * FROM USERS WHERE ID ='" + id + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                Details.matchedUserDetails = new DataTable();
                
                adapter.Fill(Details.matchedUserDetails);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            UserIDResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>(0).ToString();

            UserTitleResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>(5).ToString();

        }

        private void MatchBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            getUserID();

            for (int i = 0; i < userID_datatable.Rows.Count; i++)
            {
                _userID = userID_datatable.Rows[i].Field<string>(0).ToString();
                
                getFeatures(_userID);

                feaetures_match();

                if (matchedfeatures_count == Details.modelKeyPoints.Size)
                {
                    Details.matchedID = _userID;
                    displayResult(_userID);
                    break;
                }
            }

        }

    }
}
