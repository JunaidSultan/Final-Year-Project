namespace HandVeinPattern
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.LoginSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.UsernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ArduinoSerialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginGroupControl)).BeginInit();
            this.LoginGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginGroupControl
            // 
            this.LoginGroupControl.Controls.Add(this.LoginSimpleButton);
            this.LoginGroupControl.Controls.Add(this.CancelSimpleButton);
            this.LoginGroupControl.Controls.Add(this.PasswordTextBox);
            this.LoginGroupControl.Controls.Add(this.UsernameTextBox);
            this.LoginGroupControl.Controls.Add(this.PasswordLabel);
            this.LoginGroupControl.Controls.Add(this.UsernameLabel);
            this.LoginGroupControl.Controls.Add(this.LoginPictureEdit);
            this.LoginGroupControl.Location = new System.Drawing.Point(43, 50);
            this.LoginGroupControl.Name = "LoginGroupControl";
            this.LoginGroupControl.Size = new System.Drawing.Size(703, 305);
            this.LoginGroupControl.TabIndex = 0;
            this.LoginGroupControl.Text = "Login";
            // 
            // LoginSimpleButton
            // 
            this.LoginSimpleButton.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginSimpleButton.Appearance.Options.UseFont = true;
            this.LoginSimpleButton.Image = global::HandVeinPattern.Properties.Resources.apply_16x16;
            this.LoginSimpleButton.Location = new System.Drawing.Point(390, 253);
            this.LoginSimpleButton.Name = "LoginSimpleButton";
            this.LoginSimpleButton.Size = new System.Drawing.Size(96, 32);
            this.LoginSimpleButton.TabIndex = 6;
            this.LoginSimpleButton.Text = "Login";
            this.LoginSimpleButton.Click += new System.EventHandler(this.LoginSimpleButton_Click);
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSimpleButton.Appearance.Options.UseFont = true;
            this.CancelSimpleButton.Image = global::HandVeinPattern.Properties.Resources.cancel_16x16;
            this.CancelSimpleButton.Location = new System.Drawing.Point(561, 253);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(94, 32);
            this.CancelSimpleButton.TabIndex = 5;
            this.CancelSimpleButton.Text = "Cancel";
            this.CancelSimpleButton.Click += new System.EventHandler(this.CancelSimpleButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(444, 165);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '.';
            this.PasswordTextBox.Size = new System.Drawing.Size(171, 27);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(444, 79);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(171, 27);
            this.UsernameTextBox.TabIndex = 3;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(254, 168);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(80, 19);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(254, 82);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 19);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // LoginPictureEdit
            // 
            this.LoginPictureEdit.EditValue = global::HandVeinPattern.Properties.Resources.LoginRed;
            this.LoginPictureEdit.Location = new System.Drawing.Point(19, 59);
            this.LoginPictureEdit.Name = "LoginPictureEdit";
            this.LoginPictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.LoginPictureEdit.Properties.Appearance.Options.UseBackColor = true;
            this.LoginPictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LoginPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.LoginPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.LoginPictureEdit.Size = new System.Drawing.Size(206, 205);
            this.LoginPictureEdit.TabIndex = 0;
            // 
            // UsernameErrorProvider
            // 
            this.UsernameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.UsernameErrorProvider.ContainerControl = this;
            this.UsernameErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("UsernameErrorProvider.Icon")));
            // 
            // PasswordErrorProvider
            // 
            this.PasswordErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.PasswordErrorProvider.ContainerControl = this;
            this.PasswordErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("PasswordErrorProvider.Icon")));
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 411);
            this.Controls.Add(this.LoginGroupControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginGroupControl)).EndInit();
            this.LoginGroupControl.ResumeLayout(false);
            this.LoginGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl LoginGroupControl;
        private DevExpress.XtraEditors.SimpleButton LoginSimpleButton;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private DevExpress.XtraEditors.PictureEdit LoginPictureEdit;
        private System.Windows.Forms.ErrorProvider UsernameErrorProvider;
        private System.Windows.Forms.ErrorProvider PasswordErrorProvider;
        private System.IO.Ports.SerialPort ArduinoSerialPort;

    }
}