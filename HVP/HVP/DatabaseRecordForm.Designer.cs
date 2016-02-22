namespace HVP
{
    partial class DatabaseRecordForm
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
            this.DatabaseRecordPanel = new System.Windows.Forms.Panel();
            this.InsertRecordGroupBox = new System.Windows.Forms.GroupBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FacePictureLabel = new System.Windows.Forms.Label();
            this.HandPictureLabel = new System.Windows.Forms.Label();
            this.HandImagePictureBox = new System.Windows.Forms.PictureBox();
            this.FacePictureBox = new System.Windows.Forms.PictureBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LoadFacePictureImageButton = new System.Windows.Forms.Button();
            this.DatabaseRecordPanel.SuspendLayout();
            this.InsertRecordGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HandImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseRecordPanel
            // 
            this.DatabaseRecordPanel.Controls.Add(this.InsertRecordGroupBox);
            this.DatabaseRecordPanel.Location = new System.Drawing.Point(12, 12);
            this.DatabaseRecordPanel.Name = "DatabaseRecordPanel";
            this.DatabaseRecordPanel.Size = new System.Drawing.Size(960, 498);
            this.DatabaseRecordPanel.TabIndex = 0;
            // 
            // InsertRecordGroupBox
            // 
            this.InsertRecordGroupBox.Controls.Add(this.LoadFacePictureImageButton);
            this.InsertRecordGroupBox.Controls.Add(this.CancelButton);
            this.InsertRecordGroupBox.Controls.Add(this.InsertButton);
            this.InsertRecordGroupBox.Controls.Add(this.FacePictureBox);
            this.InsertRecordGroupBox.Controls.Add(this.HandImagePictureBox);
            this.InsertRecordGroupBox.Controls.Add(this.HandPictureLabel);
            this.InsertRecordGroupBox.Controls.Add(this.FacePictureLabel);
            this.InsertRecordGroupBox.Controls.Add(this.NameTextBox);
            this.InsertRecordGroupBox.Controls.Add(this.NameLabel);
            this.InsertRecordGroupBox.Controls.Add(this.IDTextBox);
            this.InsertRecordGroupBox.Controls.Add(this.IDLabel);
            this.InsertRecordGroupBox.Location = new System.Drawing.Point(12, 15);
            this.InsertRecordGroupBox.Name = "InsertRecordGroupBox";
            this.InsertRecordGroupBox.Size = new System.Drawing.Size(932, 467);
            this.InsertRecordGroupBox.TabIndex = 0;
            this.InsertRecordGroupBox.TabStop = false;
            this.InsertRecordGroupBox.Text = "Insert Record";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(7, 29);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(55, 26);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(215, 20);
            this.IDTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(528, 29);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(608, 26);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(215, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // FacePictureLabel
            // 
            this.FacePictureLabel.AutoSize = true;
            this.FacePictureLabel.Location = new System.Drawing.Point(7, 77);
            this.FacePictureLabel.Name = "FacePictureLabel";
            this.FacePictureLabel.Size = new System.Drawing.Size(67, 13);
            this.FacePictureLabel.TabIndex = 5;
            this.FacePictureLabel.Text = "Face Picture";
            // 
            // HandPictureLabel
            // 
            this.HandPictureLabel.AutoSize = true;
            this.HandPictureLabel.Location = new System.Drawing.Point(528, 77);
            this.HandPictureLabel.Name = "HandPictureLabel";
            this.HandPictureLabel.Size = new System.Drawing.Size(69, 13);
            this.HandPictureLabel.TabIndex = 6;
            this.HandPictureLabel.Text = "Hand Picture";
            // 
            // HandImagePictureBox
            // 
            this.HandImagePictureBox.Location = new System.Drawing.Point(531, 106);
            this.HandImagePictureBox.Name = "HandImagePictureBox";
            this.HandImagePictureBox.Size = new System.Drawing.Size(395, 296);
            this.HandImagePictureBox.TabIndex = 7;
            this.HandImagePictureBox.TabStop = false;
            // 
            // FacePictureBox
            // 
            this.FacePictureBox.Location = new System.Drawing.Point(10, 106);
            this.FacePictureBox.Name = "FacePictureBox";
            this.FacePictureBox.Size = new System.Drawing.Size(395, 296);
            this.FacePictureBox.TabIndex = 8;
            this.FacePictureBox.TabStop = false;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(10, 428);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 9;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(122, 428);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(897, 526);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 526);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LoadFacePictureImageButton
            // 
            this.LoadFacePictureImageButton.Location = new System.Drawing.Point(97, 72);
            this.LoadFacePictureImageButton.Name = "LoadFacePictureImageButton";
            this.LoadFacePictureImageButton.Size = new System.Drawing.Size(75, 23);
            this.LoadFacePictureImageButton.TabIndex = 11;
            this.LoadFacePictureImageButton.Text = "Load";
            this.LoadFacePictureImageButton.UseVisualStyleBackColor = true;
            this.LoadFacePictureImageButton.Click += new System.EventHandler(this.LoadFacePictureImageButton_Click);
            // 
            // DatabaseRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DatabaseRecordPanel);
            this.Name = "DatabaseRecordForm";
            this.Text = "Insert Record";
            this.DatabaseRecordPanel.ResumeLayout(false);
            this.InsertRecordGroupBox.ResumeLayout(false);
            this.InsertRecordGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HandImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DatabaseRecordPanel;
        private System.Windows.Forms.GroupBox InsertRecordGroupBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label FacePictureLabel;
        private System.Windows.Forms.Label HandPictureLabel;
        private System.Windows.Forms.PictureBox HandImagePictureBox;
        private System.Windows.Forms.PictureBox FacePictureBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LoadFacePictureImageButton;
    }
}