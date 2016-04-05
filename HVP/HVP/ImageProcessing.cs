﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MYopencv;
using System.IO;
using DevExpress.XtraEditors.Camera;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace HVP
{
    public partial class ImageProcessing : Form
    {
        WrapperImageProcessing _imageprocessing;

        public ImageProcessing()
        {
            InitializeComponent();

            _imageprocessing = new WrapperImageProcessing();

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

        }

        #region Original Image Context Menu Strip Click Events

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(OriginalImagePictureEdit.Image);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OriginalImagePictureEdit.Image = Clipboard.GetImage();
        }

        private void CameraCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakePictureDialog _cameraCapture = new TakePictureDialog();
            if (_cameraCapture.ShowDialog() == DialogResult.OK)
            {
                OriginalImagePictureEdit.Image = _cameraCapture.Image;
            }
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
            OriginalImagePictureEdit.Image = HVP.Properties.Resources.Blank_Hand_Image;
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


        #region Step View Context Menu Strip Click Events

        private void ViewToolStripImage1MenuItem_Click(object sender, EventArgs e)
        {
            Details.stepimage = Step1PictureEdit.Image;
            Details.imagelabel = "Gray Scale Image";
            ViewForm viewform = new ViewForm();
            viewform.Show();
        }

        private void ViewToolStripImage2MenuItem_Click(object sender, EventArgs e)
        {
            Details.stepimage = Step2PictureEdit.Image;
            Details.imagelabel = "White Balanced Image";
            ViewForm viewform = new ViewForm();
            viewform.Show();
        }

        private void ViewToolStripImage3MenuItem_Click(object sender, EventArgs e)
        {
            Details.stepimage = Step3PictureEdit.Image;
            Details.imagelabel = "Adpative Threshold Image";
            ViewForm viewform = new ViewForm();
            viewform.Show();
        }

        private void ViewToolStripImage4MenuItem_Click(object sender, EventArgs e)
        {
            Details.stepimage = Step4PictureEdit.Image;
            Details.imagelabel = "White Masked Image";
            ViewForm viewform = new ViewForm();
            viewform.Show();
        }

        private void ViewToolStripImage5MenuItem_Click(object sender, EventArgs e)
        {
            Details.stepimage = Step5PictureEdit.Image;
            Details.imagelabel = "Eroded Image";
            ViewForm viewform = new ViewForm();
            viewform.Show();
        }

        private void ViewToolStripImage6MenuItem_Click(object sender, EventArgs e)
        {
            Details.stepimage = Step6PictureEdit.Image;
            Details.imagelabel = "Laplacian Filtered Image";
            ViewForm viewform = new ViewForm();
            viewform.Show();
        }

        private void ViewToolStripImage7MenuItem_Click(object sender, EventArgs e)
        {
            Details.stepimage = Step7PictureEdit.Image;
            Details.imagelabel = "Noise Free Image";
            ViewForm viewform = new ViewForm();
            viewform.Show();
        }

        private void ViewToolStripImage8MenuItem_Click(object sender, EventArgs e)
        {
            Details.stepimage = Step8PictureEdit.Image;
            Details.imagelabel = "Details Extracted Image";
            ViewForm viewform = new ViewForm();
            viewform.Show();
        }

        private void ViewToolStripImage9MenuItem_Click(object sender, EventArgs e)
        {
            Details.stepimage = Step9PictureEdit.Image;
            Details.imagelabel = "Thinned Image";
            ViewForm viewform = new ViewForm();
            viewform.Show();
        }

        #endregion


        #region Image Processing Ribbon Control Button Click Events

        private void GrayScaleConversionBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Details.sourceimagehand = new Mat(Details.imagefilepath, LoadImageType.Grayscale);

            Step1PictureEdit.Image = Details.sourceimagehand.Bitmap;
        }

        private void WhiteBalanceBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Details.whitebalance = new Mat();

            CvInvoke.BalanceWhite(Details.sourceimagehand, Details.whitebalance, WhiteBalanceMethod.Simple, 0f, 255f, 0f, 255f);

            Step2PictureEdit.Image = Details.whitebalance.Bitmap;
        }

        private void AdaptiveThresholdingBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Directory.CreateDirectory(@"D:\Eighth Semester\HVP\\RuntimeDirectory");

            Details.adaptivethreshold = new Mat();

            CvInvoke.AdaptiveThreshold(Details.whitebalance, Details.adaptivethreshold, 255, AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 11, -3);

            Step3PictureEdit.Image = Details.adaptivethreshold.Bitmap;

            CvInvoke.Imwrite(@"D:\Eighth Semester\HVP\RuntimeDirectory\AdaptiveThreshold.jpg", Details.adaptivethreshold);
        }

        void wrapperprocessing()
        {
            _imageprocessing.process();
        }

        private void WrapperProcessingBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wrapperprocessing();

            Details.maskedimage = new Mat();

            Details.maskedimage = new Mat(@"D:\Eighth Semester\HVP\RuntimeDirectory\ResultImage.jpg", LoadImageType.Grayscale);

            Step4PictureEdit.Image = Details.maskedimage.Bitmap;

            //Step4PictureEdit.Image = Image.FromFile(@"D:\Eighth Semester\HVP\RuntimeDirectory\ResultImage.jpg"); // Details.maskedimage.Bitmap;

            //Details.maskedimage = new Mat(@"D:\Eighth Semester\HVP\RuntimeDirectory\ResultImage.jpg", LoadImageType.Grayscale);
        }

        private void MorphologicalOperationBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Details.erode_step1 = new Mat();

            CvInvoke.MorphologyEx(Details.maskedimage, Details.erode_step1, MorphOp.Erode, CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(3, 3), new Point(-1, -1)), new Point(-1, -1), 2, BorderType.Constant, new MCvScalar(0));

            Step5PictureEdit.Image = Details.erode_step1.Bitmap;
        }

        private void LaplacianFilterBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Details.laplacian = new Mat();

            CvInvoke.Laplacian(Details.sourceimagehand, Details.laplacian, DepthType.Cv8U, 11, 1.0, 0.0, BorderType.Constant);

            Step6PictureEdit.Image = Details.laplacian.Bitmap;
        }

        private void MorphologicalOperation2BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Details.erode_step2 = new Mat();

            CvInvoke.MorphologyEx(Details.erode_step1, Details.erode_step2, MorphOp.Erode, CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(3, 3), new Point(-1, -1)), new Point(-1, -1), 7, BorderType.Constant, new MCvScalar(0));
        }

        private void ImageMultiplicationBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Details.multipliedimage = new Mat();

            CvInvoke.Multiply(Details.laplacian, Details.erode_step2, Details.multipliedimage, 1.0, DepthType.Cv8U);

            Step7PictureEdit.Image = Details.multipliedimage.Bitmap;
        }

        private void ThinningBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        #endregion
    }
}