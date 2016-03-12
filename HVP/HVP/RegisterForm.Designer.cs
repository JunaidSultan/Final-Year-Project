namespace HVP
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.UserRegistrationGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.UserPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.PictureEditContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UserRegistrationGroupControl)).BeginInit();
            this.UserRegistrationGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureEdit.Properties)).BeginInit();
            this.PictureEditContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UserRegistrationGroupControl
            // 
            this.UserRegistrationGroupControl.Controls.Add(this.LastNameTextBox);
            this.UserRegistrationGroupControl.Controls.Add(this.label1);
            this.UserRegistrationGroupControl.Controls.Add(this.FirstNameTextBox);
            this.UserRegistrationGroupControl.Controls.Add(this.FirstNameLabel);
            this.UserRegistrationGroupControl.Controls.Add(this.UserPictureEdit);
            this.UserRegistrationGroupControl.Location = new System.Drawing.Point(12, 84);
            this.UserRegistrationGroupControl.Name = "UserRegistrationGroupControl";
            this.UserRegistrationGroupControl.Size = new System.Drawing.Size(960, 494);
            this.UserRegistrationGroupControl.TabIndex = 0;
            this.UserRegistrationGroupControl.Text = "User Registration";
            // 
            // UserPictureEdit
            // 
            this.UserPictureEdit.EditValue = global::HVP.Properties.Resources.noprofile;
            this.UserPictureEdit.Location = new System.Drawing.Point(16, 33);
            this.UserPictureEdit.Name = "UserPictureEdit";
            this.UserPictureEdit.Properties.ContextMenuStrip = this.PictureEditContextMenuStrip;
            this.UserPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.UserPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.UserPictureEdit.Size = new System.Drawing.Size(273, 327);
            this.UserPictureEdit.TabIndex = 1;
            // 
            // PictureEditContextMenuStrip
            // 
            this.PictureEditContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasteToolStripMenuItem,
            this.ToolStripSeparator1,
            this.LoadToolStripMenuItem,
            this.ToolStripSeparator2,
            this.DeleteToolStripMenuItem});
            this.PictureEditContextMenuStrip.Name = "PictureEditContextMenuStrip";
            this.PictureEditContextMenuStrip.Size = new System.Drawing.Size(108, 82);
            this.PictureEditContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.PictureEditContextMenuStrip_Opening);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Enabled = false;
            this.PasteToolStripMenuItem.Image = global::HVP.Properties.Resources.paste;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Image = global::HVP.Properties.Resources.folder_PNG8773;
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::HVP.Properties.Resources.DeleteRed;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(306, 44);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(93, 23);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(438, 41);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(145, 31);
            this.FirstNameTextBox.TabIndex = 5;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // FirstNameErrorProvider
            // 
            this.FirstNameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.FirstNameErrorProvider.ContainerControl = this;
            this.FirstNameErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("FirstNameErrorProvider.Icon")));
            this.FirstNameErrorProvider.RightToLeft = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(438, 101);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(145, 31);
            this.LastNameTextBox.TabIndex = 7;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // LastNameErrorProvider
            // 
            this.LastNameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.LastNameErrorProvider.ContainerControl = this;
            this.LastNameErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("LastNameErrorProvider.Icon")));
            this.LastNameErrorProvider.RightToLeft = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.UserRegistrationGroupControl);
            this.Name = "RegisterForm";
            this.Text = "Register (User)";
            ((System.ComponentModel.ISupportInitialize)(this.UserRegistrationGroupControl)).EndInit();
            this.UserRegistrationGroupControl.ResumeLayout(false);
            this.UserRegistrationGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureEdit.Properties)).EndInit();
            this.PictureEditContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl UserRegistrationGroupControl;
        private DevExpress.XtraEditors.PictureEdit UserPictureEdit;
        private System.Windows.Forms.ContextMenuStrip PictureEditContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.ErrorProvider FirstNameErrorProvider;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider LastNameErrorProvider;

    }
}