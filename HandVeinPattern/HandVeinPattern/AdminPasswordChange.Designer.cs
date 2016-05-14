namespace HandVeinPattern
{
    partial class AdminPasswordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPasswordChange));
            this.PasswordChangeRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ChangeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.CloseBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ResetBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ActionsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ActionsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ChangePasswordGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.AdminIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordChangeRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePasswordGroupControl)).BeginInit();
            this.ChangePasswordGroupControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordChangeRibbonControl
            // 
            this.PasswordChangeRibbonControl.ExpandCollapseItem.Id = 0;
            this.PasswordChangeRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.PasswordChangeRibbonControl.ExpandCollapseItem,
            this.ChangeBarButtonItem,
            this.CloseBarButtonItem,
            this.ResetBarButtonItem});
            this.PasswordChangeRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.PasswordChangeRibbonControl.MaxItemId = 4;
            this.PasswordChangeRibbonControl.Name = "PasswordChangeRibbonControl";
            this.PasswordChangeRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ActionsRibbonPage});
            this.PasswordChangeRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.PasswordChangeRibbonControl.Size = new System.Drawing.Size(446, 162);
            // 
            // ChangeBarButtonItem
            // 
            this.ChangeBarButtonItem.Caption = "Change";
            this.ChangeBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.changeview_32x32;
            this.ChangeBarButtonItem.Id = 1;
            this.ChangeBarButtonItem.Name = "ChangeBarButtonItem";
            this.ChangeBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ChangeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChangeBarButtonItem_ItemClick);
            // 
            // CloseBarButtonItem
            // 
            this.CloseBarButtonItem.Caption = "Close";
            this.CloseBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.close_32x32;
            this.CloseBarButtonItem.Id = 2;
            this.CloseBarButtonItem.Name = "CloseBarButtonItem";
            this.CloseBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.CloseBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CloseBarButtonItem_ItemClick);
            // 
            // ResetBarButtonItem
            // 
            this.ResetBarButtonItem.Caption = "Reset";
            this.ResetBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.reset_32x32;
            this.ResetBarButtonItem.Id = 3;
            this.ResetBarButtonItem.Name = "ResetBarButtonItem";
            this.ResetBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ResetBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ResetBarButtonItem_ItemClick);
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
            this.ActionsRibbonPageGroup.ItemLinks.Add(this.ChangeBarButtonItem);
            this.ActionsRibbonPageGroup.ItemLinks.Add(this.ResetBarButtonItem);
            this.ActionsRibbonPageGroup.ItemLinks.Add(this.CloseBarButtonItem);
            this.ActionsRibbonPageGroup.Name = "ActionsRibbonPageGroup";
            this.ActionsRibbonPageGroup.Text = "Actions";
            // 
            // ChangePasswordGroupControl
            // 
            this.ChangePasswordGroupControl.Controls.Add(this.ConfirmPasswordTextBox);
            this.ChangePasswordGroupControl.Controls.Add(this.ConfirmPasswordLabel);
            this.ChangePasswordGroupControl.Controls.Add(this.NewPasswordTextBox);
            this.ChangePasswordGroupControl.Controls.Add(this.OldPasswordTextBox);
            this.ChangePasswordGroupControl.Controls.Add(this.IDTextBox);
            this.ChangePasswordGroupControl.Controls.Add(this.NewPasswordLabel);
            this.ChangePasswordGroupControl.Controls.Add(this.OldPasswordLabel);
            this.ChangePasswordGroupControl.Controls.Add(this.AdminIDLabel);
            this.ChangePasswordGroupControl.Location = new System.Drawing.Point(10, 168);
            this.ChangePasswordGroupControl.Name = "ChangePasswordGroupControl";
            this.ChangePasswordGroupControl.Size = new System.Drawing.Size(424, 270);
            this.ChangePasswordGroupControl.TabIndex = 1;
            this.ChangePasswordGroupControl.Text = "Change Password";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(219, 210);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '.';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(130, 27);
            this.ConfirmPasswordTextBox.TabIndex = 7;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(37, 213);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(125, 19);
            this.ConfirmPasswordLabel.TabIndex = 6;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordTextBox.Location = new System.Drawing.Point(219, 156);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '.';
            this.NewPasswordTextBox.Size = new System.Drawing.Size(130, 27);
            this.NewPasswordTextBox.TabIndex = 5;
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPasswordTextBox.Location = new System.Drawing.Point(219, 104);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.PasswordChar = '.';
            this.OldPasswordTextBox.Size = new System.Drawing.Size(130, 27);
            this.OldPasswordTextBox.TabIndex = 4;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Enabled = false;
            this.IDTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.Location = new System.Drawing.Point(219, 47);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(130, 27);
            this.IDTextBox.TabIndex = 3;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(37, 159);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(104, 19);
            this.NewPasswordLabel.TabIndex = 2;
            this.NewPasswordLabel.Text = "New Password";
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPasswordLabel.Location = new System.Drawing.Point(37, 107);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(98, 19);
            this.OldPasswordLabel.TabIndex = 1;
            this.OldPasswordLabel.Text = "Old Password";
            // 
            // AdminIDLabel
            // 
            this.AdminIDLabel.AutoSize = true;
            this.AdminIDLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIDLabel.Location = new System.Drawing.Point(37, 50);
            this.AdminIDLabel.Name = "AdminIDLabel";
            this.AdminIDLabel.Size = new System.Drawing.Size(23, 19);
            this.AdminIDLabel.TabIndex = 0;
            this.AdminIDLabel.Text = "ID";
            // 
            // AdminPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 446);
            this.Controls.Add(this.ChangePasswordGroupControl);
            this.Controls.Add(this.PasswordChangeRibbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPasswordChange";
            this.Ribbon = this.PasswordChangeRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordChangeRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePasswordGroupControl)).EndInit();
            this.ChangePasswordGroupControl.ResumeLayout(false);
            this.ChangePasswordGroupControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl PasswordChangeRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ActionsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ActionsRibbonPageGroup;
        private DevExpress.XtraEditors.GroupControl ChangePasswordGroupControl;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label AdminIDLabel;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.TextBox OldPasswordTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private DevExpress.XtraBars.BarButtonItem ChangeBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem CloseBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ResetBarButtonItem;
    }
}