namespace HVP
{
    partial class LoginForm
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
            this.LoginGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.LoginButton = new DevExpress.XtraEditors.SimpleButton();
            this.LoginPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginGroupControl)).BeginInit();
            this.LoginGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginGroupControl
            // 
            this.LoginGroupControl.Controls.Add(this.CancelButton);
            this.LoginGroupControl.Controls.Add(this.LoginButton);
            this.LoginGroupControl.Controls.Add(this.PasswordTextEdit);
            this.LoginGroupControl.Controls.Add(this.UsernameTextEdit);
            this.LoginGroupControl.Controls.Add(this.PasswordLabel);
            this.LoginGroupControl.Controls.Add(this.UsernameLabel);
            this.LoginGroupControl.Controls.Add(this.LoginPictureEdit);
            this.LoginGroupControl.Location = new System.Drawing.Point(27, 43);
            this.LoginGroupControl.Name = "LoginGroupControl";
            this.LoginGroupControl.Size = new System.Drawing.Size(582, 243);
            this.LoginGroupControl.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(198, 59);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(115, 24);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(198, 128);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(109, 24);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameTextEdit
            // 
            this.UsernameTextEdit.Location = new System.Drawing.Point(366, 56);
            this.UsernameTextEdit.Name = "UsernameTextEdit";
            this.UsernameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.UsernameTextEdit.Size = new System.Drawing.Size(166, 30);
            this.UsernameTextEdit.TabIndex = 3;
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.Location = new System.Drawing.Point(366, 125);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextEdit.Properties.Appearance.Options.UseFont = true;
            this.PasswordTextEdit.Size = new System.Drawing.Size(166, 30);
            this.PasswordTextEdit.TabIndex = 4;
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::HVP.Properties.Resources._33;
            this.CancelButton.Location = new System.Drawing.Point(439, 192);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 32);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            // 
            // LoginButton
            // 
            this.LoginButton.Image = global::HVP.Properties.Resources.tick;
            this.LoginButton.Location = new System.Drawing.Point(240, 192);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(93, 32);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            // 
            // LoginPictureEdit
            // 
            this.LoginPictureEdit.EditValue = global::HVP.Properties.Resources.LoginRed;
            this.LoginPictureEdit.Location = new System.Drawing.Point(18, 35);
            this.LoginPictureEdit.Name = "LoginPictureEdit";
            this.LoginPictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.LoginPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.LoginPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.LoginPictureEdit.Size = new System.Drawing.Size(157, 189);
            this.LoginPictureEdit.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 331);
            this.Controls.Add(this.LoginGroupControl);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LoginGroupControl)).EndInit();
            this.LoginGroupControl.ResumeLayout(false);
            this.LoginGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl LoginGroupControl;
        private DevExpress.XtraEditors.PictureEdit LoginPictureEdit;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit UsernameTextEdit;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.SimpleButton LoginButton;

    }
}