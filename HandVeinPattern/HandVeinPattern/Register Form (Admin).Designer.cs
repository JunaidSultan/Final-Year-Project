namespace HandVeinPattern
{
    partial class Register_Form__Admin_
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Form__Admin_));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.CreateBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ResetBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.CancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ActionsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ActionsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RegisterAdminGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.AdminImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.PictureContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CameraCaptureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmailButtonEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.GenderComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.GenerateIDSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.AdminIDLabel = new System.Windows.Forms.Label();
            this.ImageErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IDErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsernameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasswordErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FirstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LastNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.GenderErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EmailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterAdminGroupControl)).BeginInit();
            this.RegisterAdminGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminImagePictureEdit.Properties)).BeginInit();
            this.PictureContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailButtonEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.CreateBarButtonItem,
            this.ResetBarButtonItem,
            this.CancelBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ActionsRibbonPage});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(938, 162);
            // 
            // CreateBarButtonItem
            // 
            this.CreateBarButtonItem.Caption = "Create";
            this.CreateBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.apply_32x32;
            this.CreateBarButtonItem.Id = 1;
            this.CreateBarButtonItem.Name = "CreateBarButtonItem";
            this.CreateBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.CreateBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CreateBarButtonItem_ItemClick);
            // 
            // ResetBarButtonItem
            // 
            this.ResetBarButtonItem.Caption = "Reset";
            this.ResetBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.reset_32x32;
            this.ResetBarButtonItem.Id = 2;
            this.ResetBarButtonItem.Name = "ResetBarButtonItem";
            this.ResetBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ResetBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ResetBarButtonItem_ItemClick);
            // 
            // CancelBarButtonItem
            // 
            this.CancelBarButtonItem.Caption = "Cancel";
            this.CancelBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.cancel_32x32;
            this.CancelBarButtonItem.Id = 3;
            this.CancelBarButtonItem.Name = "CancelBarButtonItem";
            this.CancelBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.CancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CancelBarButtonItem_ItemClick);
            // 
            // ActionsRibbonPage
            // 
            this.ActionsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ActionsRibbonPageGroup});
            this.ActionsRibbonPage.Image = global::HandVeinPattern.Properties.Resources.technology_32x32;
            this.ActionsRibbonPage.Name = "ActionsRibbonPage";
            this.ActionsRibbonPage.Text = "Actions";
            // 
            // ActionsRibbonPageGroup
            // 
            this.ActionsRibbonPageGroup.ItemLinks.Add(this.CreateBarButtonItem);
            this.ActionsRibbonPageGroup.ItemLinks.Add(this.ResetBarButtonItem);
            this.ActionsRibbonPageGroup.ItemLinks.Add(this.CancelBarButtonItem);
            this.ActionsRibbonPageGroup.Name = "ActionsRibbonPageGroup";
            this.ActionsRibbonPageGroup.Text = "Actions";
            // 
            // RegisterAdminGroupControl
            // 
            this.RegisterAdminGroupControl.Controls.Add(this.AdminImagePictureEdit);
            this.RegisterAdminGroupControl.Controls.Add(this.EmailButtonEdit);
            this.RegisterAdminGroupControl.Controls.Add(this.GenderComboBoxEdit);
            this.RegisterAdminGroupControl.Controls.Add(this.GenerateIDSimpleButton);
            this.RegisterAdminGroupControl.Controls.Add(this.GenderLabel);
            this.RegisterAdminGroupControl.Controls.Add(this.LastNameLabel);
            this.RegisterAdminGroupControl.Controls.Add(this.EmailLabel);
            this.RegisterAdminGroupControl.Controls.Add(this.LastNameTextBox);
            this.RegisterAdminGroupControl.Controls.Add(this.FirstNameLabel);
            this.RegisterAdminGroupControl.Controls.Add(this.FirstNameTextBox);
            this.RegisterAdminGroupControl.Controls.Add(this.PasswordLabel);
            this.RegisterAdminGroupControl.Controls.Add(this.PasswordTextBox);
            this.RegisterAdminGroupControl.Controls.Add(this.UsernameTextBox);
            this.RegisterAdminGroupControl.Controls.Add(this.UsernameLabel);
            this.RegisterAdminGroupControl.Controls.Add(this.IDTextBox);
            this.RegisterAdminGroupControl.Controls.Add(this.AdminIDLabel);
            this.RegisterAdminGroupControl.Location = new System.Drawing.Point(12, 168);
            this.RegisterAdminGroupControl.Name = "RegisterAdminGroupControl";
            this.RegisterAdminGroupControl.Size = new System.Drawing.Size(913, 317);
            this.RegisterAdminGroupControl.TabIndex = 1;
            this.RegisterAdminGroupControl.Text = "Register (Admin)";
            // 
            // AdminImagePictureEdit
            // 
            this.AdminImagePictureEdit.EditValue = global::HandVeinPattern.Properties.Resources.noprofile;
            this.AdminImagePictureEdit.Location = new System.Drawing.Point(6, 24);
            this.AdminImagePictureEdit.MenuManager = this.ribbonControl1;
            this.AdminImagePictureEdit.Name = "AdminImagePictureEdit";
            this.AdminImagePictureEdit.Properties.ContextMenuStrip = this.PictureContextMenuStrip;
            this.AdminImagePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.AdminImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.AdminImagePictureEdit.Size = new System.Drawing.Size(272, 275);
            this.AdminImagePictureEdit.TabIndex = 19;
            this.AdminImagePictureEdit.EditValueChanged += new System.EventHandler(this.AdminImagePictureEdit_EditValueChanged);
            // 
            // PictureContextMenuStrip
            // 
            this.PictureContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasteToolStripMenuItem,
            this.toolStripSeparator1,
            this.CameraCaptureToolStripMenuItem,
            this.toolStripSeparator2,
            this.LoadToolStripMenuItem,
            this.toolStripSeparator3,
            this.DeleteToolStripMenuItem});
            this.PictureContextMenuStrip.Name = "PictureContextMenuStrip";
            this.PictureContextMenuStrip.Size = new System.Drawing.Size(161, 110);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Image = global::HandVeinPattern.Properties.Resources.paste;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // CameraCaptureToolStripMenuItem
            // 
            this.CameraCaptureToolStripMenuItem.Image = global::HandVeinPattern.Properties.Resources.dslr_camera;
            this.CameraCaptureToolStripMenuItem.Name = "CameraCaptureToolStripMenuItem";
            this.CameraCaptureToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.CameraCaptureToolStripMenuItem.Text = "Camera Capture";
            this.CameraCaptureToolStripMenuItem.Click += new System.EventHandler(this.CameraCaptureToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Image = global::HandVeinPattern.Properties.Resources.folder_PNG8773;
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::HandVeinPattern.Properties.Resources.DeleteRed;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // EmailButtonEdit
            // 
            this.EmailButtonEdit.Location = new System.Drawing.Point(718, 252);
            this.EmailButtonEdit.MenuManager = this.ribbonControl1;
            this.EmailButtonEdit.Name = "EmailButtonEdit";
            this.EmailButtonEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailButtonEdit.Properties.Appearance.Options.UseFont = true;
            this.EmailButtonEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::HandVeinPattern.Properties.Resources._1458091589_mail, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.EmailButtonEdit.Size = new System.Drawing.Size(148, 26);
            this.EmailButtonEdit.TabIndex = 18;
            this.EmailButtonEdit.EditValueChanged += new System.EventHandler(this.EmailButtonEdit_EditValueChanged);
            // 
            // GenderComboBoxEdit
            // 
            this.GenderComboBoxEdit.EditValue = "Select An Option";
            this.GenderComboBoxEdit.Location = new System.Drawing.Point(405, 252);
            this.GenderComboBoxEdit.MenuManager = this.ribbonControl1;
            this.GenderComboBoxEdit.Name = "GenderComboBoxEdit";
            this.GenderComboBoxEdit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderComboBoxEdit.Properties.Appearance.Options.UseFont = true;
            this.GenderComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GenderComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Select An Option",
            "Male",
            "Female",
            "Other"});
            this.GenderComboBoxEdit.Size = new System.Drawing.Size(148, 26);
            this.GenderComboBoxEdit.TabIndex = 17;
            this.GenderComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.GenderComboBoxEdit_SelectedIndexChanged);
            // 
            // GenerateIDSimpleButton
            // 
            this.GenerateIDSimpleButton.Image = global::HandVeinPattern.Properties.Resources.apply_16x16;
            this.GenerateIDSimpleButton.Location = new System.Drawing.Point(602, 32);
            this.GenerateIDSimpleButton.Name = "GenerateIDSimpleButton";
            this.GenerateIDSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateIDSimpleButton.TabIndex = 16;
            this.GenerateIDSimpleButton.Text = "Generate";
            this.GenerateIDSimpleButton.Click += new System.EventHandler(this.GenerateIDSimpleButton_Click);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.GenderLabel.Location = new System.Drawing.Point(295, 255);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(56, 19);
            this.GenderLabel.TabIndex = 13;
            this.GenderLabel.Text = "Gender";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.LastNameLabel.Location = new System.Drawing.Point(598, 183);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(78, 19);
            this.LastNameLabel.TabIndex = 12;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.EmailLabel.Location = new System.Drawing.Point(598, 255);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(45, 19);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(718, 180);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(148, 27);
            this.LastNameTextBox.TabIndex = 10;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.FirstNameLabel.Location = new System.Drawing.Point(295, 183);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(79, 19);
            this.FirstNameLabel.TabIndex = 8;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(405, 180);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(148, 27);
            this.FirstNameTextBox.TabIndex = 7;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(598, 108);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(71, 19);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(718, 105);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '.';
            this.PasswordTextBox.Size = new System.Drawing.Size(148, 27);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(405, 105);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(148, 27);
            this.UsernameTextBox.TabIndex = 4;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(295, 108);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 19);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(405, 30);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(148, 27);
            this.IDTextBox.TabIndex = 2;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // AdminIDLabel
            // 
            this.AdminIDLabel.AutoSize = true;
            this.AdminIDLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIDLabel.Location = new System.Drawing.Point(295, 33);
            this.AdminIDLabel.Name = "AdminIDLabel";
            this.AdminIDLabel.Size = new System.Drawing.Size(68, 19);
            this.AdminIDLabel.TabIndex = 1;
            this.AdminIDLabel.Text = "Admin ID";
            // 
            // ImageErrorProvider
            // 
            this.ImageErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ImageErrorProvider.ContainerControl = this;
            this.ImageErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ImageErrorProvider.Icon")));
            // 
            // IDErrorProvider
            // 
            this.IDErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.IDErrorProvider.ContainerControl = this;
            this.IDErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("IDErrorProvider.Icon")));
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
            // FirstNameErrorProvider
            // 
            this.FirstNameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.FirstNameErrorProvider.ContainerControl = this;
            this.FirstNameErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("FirstNameErrorProvider.Icon")));
            // 
            // LastNameErrorProvider
            // 
            this.LastNameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.LastNameErrorProvider.ContainerControl = this;
            this.LastNameErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("LastNameErrorProvider.Icon")));
            // 
            // GenderErrorProvider
            // 
            this.GenderErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.GenderErrorProvider.ContainerControl = this;
            this.GenderErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("GenderErrorProvider.Icon")));
            // 
            // EmailErrorProvider
            // 
            this.EmailErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EmailErrorProvider.ContainerControl = this;
            this.EmailErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("EmailErrorProvider.Icon")));
            // 
            // Register_Form__Admin_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 497);
            this.Controls.Add(this.RegisterAdminGroupControl);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register_Form__Admin_";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register (Admin)";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterAdminGroupControl)).EndInit();
            this.RegisterAdminGroupControl.ResumeLayout(false);
            this.RegisterAdminGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminImagePictureEdit.Properties)).EndInit();
            this.PictureContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmailButtonEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenderErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ActionsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ActionsRibbonPageGroup;
        private DevExpress.XtraEditors.GroupControl RegisterAdminGroupControl;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label AdminIDLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private DevExpress.XtraEditors.SimpleButton GenerateIDSimpleButton;
        private DevExpress.XtraEditors.ComboBoxEdit GenderComboBoxEdit;
        private DevExpress.XtraEditors.ButtonEdit EmailButtonEdit;
        private DevExpress.XtraBars.BarButtonItem CreateBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ResetBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem CancelBarButtonItem;
        private DevExpress.XtraEditors.PictureEdit AdminImagePictureEdit;
        private System.Windows.Forms.ContextMenuStrip PictureContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CameraCaptureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ErrorProvider ImageErrorProvider;
        private System.Windows.Forms.ErrorProvider IDErrorProvider;
        private System.Windows.Forms.ErrorProvider UsernameErrorProvider;
        private System.Windows.Forms.ErrorProvider PasswordErrorProvider;
        private System.Windows.Forms.ErrorProvider FirstNameErrorProvider;
        private System.Windows.Forms.ErrorProvider LastNameErrorProvider;
        private System.Windows.Forms.ErrorProvider GenderErrorProvider;
        private System.Windows.Forms.ErrorProvider EmailErrorProvider;
    }
}