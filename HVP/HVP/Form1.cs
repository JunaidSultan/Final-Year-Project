using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.Util;
using Emgu.CV.Structure;

using MYopencv;

namespace HVP
{
    public partial class Form1 : Form
    {
        MYGui cvGui;

        string filename;

        public Form1()
        {
            InitializeComponent();

            cvGui = new MYGui();
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ImageLocationTextBox.Text = ofd.FileName;
                filename = ofd.FileName;
                OriginalImagePictureBox.ImageLocation = filename;
            }
        }

        void imageprocessing()
        {
            Directory.CreateDirectory(@"D:\Eighth Semester\HVP\\RuntimeDirectory");

            Mat sourceimage = new Mat(filename, LoadImageType.Grayscale);

            Mat whitebalanceimage = new Mat();

            Mat adaptivethresholdimage = new Mat();

            CvInvoke.BalanceWhite(sourceimage, whitebalanceimage, WhiteBalanceMethod.Simple, 0f, 255f, 0f, 255f);

            CvInvoke.AdaptiveThreshold(whitebalanceimage, adaptivethresholdimage, 255, AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 11, -3);

            CvInvoke.Imwrite(@"D:\Eighth Semester\HVP\RuntimeDirectory\AdaptiveThreshold.jpg", adaptivethresholdimage);

            ProcessedImagePictureBox.Image = adaptivethresholdimage.Bitmap;

        }
        void wrapperimageprocessing()
        {
            cvGui.process();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            imageprocessing();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"D:\Eighth Semester\HVP\RuntimeDirectory\ResultImage.jpg"))
            {
                try
                {
                    File.Delete(@"D:\Eighth Semester\HVP\RuntimeDirectory\ResultImage.jpg");
                }
                catch (IOException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            if (File.Exists(@"D:\Eighth Semester\HVP\RuntimeDirectory\AdaptiveThreshold.jpg"))
            {
                try
                {
                    File.Delete(@"D:\Eighth Semester\HVP\RuntimeDirectory\AdaptiveThreshold.jpg");
                }
                catch (IOException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            if (Directory.Exists(@"D:\Eighth Semester\HVP\RuntimeDirectory"))
            {
                try
                {
                    Directory.Delete(@"D:\Eighth Semester\HVP\RuntimeDirectory");
                }
                catch (IOException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            Environment.Exit(1);

        }

        private void WrapperProcessingButton_Click(object sender, EventArgs e)
        {
            wrapperimageprocessing();

            ProcessedImagePictureBox.ImageLocation = @"D:\Eighth Semester\HVP\RuntimeDirectory\ResultImage.jpg";

            Program.filepath = @"D:\Eighth Semester\HVP\RuntimeDirectory\ResultImage.jpg";

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();

            mainform.Show();

            this.Hide();
        }

        private void InsertDatabaseButton_Click(object sender, EventArgs e)
        {
            DatabaseRecordForm databaserecordform = new DatabaseRecordForm();

            databaserecordform.Show();

            this.Hide();
        }
    }
}
