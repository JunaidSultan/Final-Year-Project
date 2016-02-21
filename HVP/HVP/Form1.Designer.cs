namespace HVP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OriginalImagePanel = new System.Windows.Forms.Panel();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.OriginalImagePictureBox = new System.Windows.Forms.PictureBox();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.ImageLocationTextBox = new System.Windows.Forms.TextBox();
            this.ImageLocationLabel = new System.Windows.Forms.Label();
            this.ProcessedImagePanel = new System.Windows.Forms.Panel();
            this.ProcessedImagePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.WrapperProcessingButton = new System.Windows.Forms.Button();
            this.OriginalImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePictureBox)).BeginInit();
            this.ProcessedImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalImagePanel
            // 
            this.OriginalImagePanel.Controls.Add(this.WrapperProcessingButton);
            this.OriginalImagePanel.Controls.Add(this.ProcessButton);
            this.OriginalImagePanel.Controls.Add(this.OriginalImagePictureBox);
            this.OriginalImagePanel.Controls.Add(this.LoadImageButton);
            this.OriginalImagePanel.Controls.Add(this.ImageLocationTextBox);
            this.OriginalImagePanel.Controls.Add(this.ImageLocationLabel);
            this.OriginalImagePanel.Location = new System.Drawing.Point(12, 12);
            this.OriginalImagePanel.Name = "OriginalImagePanel";
            this.OriginalImagePanel.Size = new System.Drawing.Size(475, 510);
            this.OriginalImagePanel.TabIndex = 0;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(18, 457);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessButton.TabIndex = 4;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // OriginalImagePictureBox
            // 
            this.OriginalImagePictureBox.Location = new System.Drawing.Point(16, 50);
            this.OriginalImagePictureBox.Name = "OriginalImagePictureBox";
            this.OriginalImagePictureBox.Size = new System.Drawing.Size(441, 384);
            this.OriginalImagePictureBox.TabIndex = 3;
            this.OriginalImagePictureBox.TabStop = false;
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(392, 7);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(75, 23);
            this.LoadImageButton.TabIndex = 2;
            this.LoadImageButton.Text = "Load";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // ImageLocationTextBox
            // 
            this.ImageLocationTextBox.Location = new System.Drawing.Point(99, 9);
            this.ImageLocationTextBox.Name = "ImageLocationTextBox";
            this.ImageLocationTextBox.Size = new System.Drawing.Size(287, 20);
            this.ImageLocationTextBox.TabIndex = 1;
            // 
            // ImageLocationLabel
            // 
            this.ImageLocationLabel.AutoSize = true;
            this.ImageLocationLabel.Location = new System.Drawing.Point(13, 12);
            this.ImageLocationLabel.Name = "ImageLocationLabel";
            this.ImageLocationLabel.Size = new System.Drawing.Size(80, 13);
            this.ImageLocationLabel.TabIndex = 0;
            this.ImageLocationLabel.Text = "Image Location";
            // 
            // ProcessedImagePanel
            // 
            this.ProcessedImagePanel.Controls.Add(this.ProcessedImagePictureBox);
            this.ProcessedImagePanel.Location = new System.Drawing.Point(498, 12);
            this.ProcessedImagePanel.Name = "ProcessedImagePanel";
            this.ProcessedImagePanel.Size = new System.Drawing.Size(474, 510);
            this.ProcessedImagePanel.TabIndex = 1;
            // 
            // ProcessedImagePictureBox
            // 
            this.ProcessedImagePictureBox.Location = new System.Drawing.Point(16, 50);
            this.ProcessedImagePictureBox.Name = "ProcessedImagePictureBox";
            this.ProcessedImagePictureBox.Size = new System.Drawing.Size(441, 384);
            this.ProcessedImagePictureBox.TabIndex = 5;
            this.ProcessedImagePictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(897, 528);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // WrapperProcessingButton
            // 
            this.WrapperProcessingButton.Location = new System.Drawing.Point(131, 457);
            this.WrapperProcessingButton.Name = "WrapperProcessingButton";
            this.WrapperProcessingButton.Size = new System.Drawing.Size(116, 23);
            this.WrapperProcessingButton.TabIndex = 6;
            this.WrapperProcessingButton.Text = "Wrapper Processing";
            this.WrapperProcessingButton.UseVisualStyleBackColor = true;
            this.WrapperProcessingButton.Click += new System.EventHandler(this.WrapperProcessingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProcessedImagePanel);
            this.Controls.Add(this.OriginalImagePanel);
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.OriginalImagePanel.ResumeLayout(false);
            this.OriginalImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePictureBox)).EndInit();
            this.ProcessedImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OriginalImagePanel;
        private System.Windows.Forms.Panel ProcessedImagePanel;
        private System.Windows.Forms.Label ImageLocationLabel;
        private System.Windows.Forms.TextBox ImageLocationTextBox;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.PictureBox OriginalImagePictureBox;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.PictureBox ProcessedImagePictureBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button WrapperProcessingButton;
    }
}

