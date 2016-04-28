namespace HandVeinPattern
{
    partial class Dashboard
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ImageProcessingBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.SkinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ExitBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ProfileManagementBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ChangePasswordBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.LogoutBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.AboutBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.MatchingBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.NavigationRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ImageProcessingBibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ImageMatchingRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.AccountRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.AccountSettingsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.LogoutRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ActionsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SkinRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ActionsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DashboardPanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.AdminStatusTabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.OnlineStatusTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.OnlineStatusDataGridView = new System.Windows.Forms.DataGridView();
            this.DashboardPanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.PerformanceTabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.PerformanceTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.AdminManagementTabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.AddAdminTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.AddAdminSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.RemoveAdminTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.RemoveAdminSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardPanelControl2)).BeginInit();
            this.DashboardPanelControl2.SuspendLayout();
            this.AdminStatusTabPane.SuspendLayout();
            this.OnlineStatusTabNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineStatusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardPanelControl1)).BeginInit();
            this.DashboardPanelControl1.SuspendLayout();
            this.PerformanceTabPane.SuspendLayout();
            this.AdminManagementTabPane.SuspendLayout();
            this.AddAdminTabNavigationPage.SuspendLayout();
            this.RemoveAdminTabNavigationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ImageProcessingBarButtonItem,
            this.SkinRibbonGalleryBarItem,
            this.ExitBarButtonItem,
            this.ProfileManagementBarButtonItem,
            this.ChangePasswordBarButtonItem,
            this.LogoutBarButtonItem,
            this.barEditItem1,
            this.ribbonGalleryBarItem1,
            this.AboutBarButtonItem,
            this.MatchingBarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.NavigationRibbonPage,
            this.AccountRibbonPage,
            this.ActionsRibbonPage});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(825, 162);
            // 
            // ImageProcessingBarButtonItem
            // 
            this.ImageProcessingBarButtonItem.Caption = "Image Processing";
            this.ImageProcessingBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.technology_32x32;
            this.ImageProcessingBarButtonItem.Id = 2;
            this.ImageProcessingBarButtonItem.Name = "ImageProcessingBarButtonItem";
            this.ImageProcessingBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ImageProcessingBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ImageProcessingBarButtonItem_ItemClick);
            // 
            // SkinRibbonGalleryBarItem
            // 
            this.SkinRibbonGalleryBarItem.Caption = "Skins";
            // 
            // 
            // 
            this.SkinRibbonGalleryBarItem.Gallery.ShowItemText = true;
            this.SkinRibbonGalleryBarItem.Id = 3;
            this.SkinRibbonGalleryBarItem.Name = "SkinRibbonGalleryBarItem";
            // 
            // ExitBarButtonItem
            // 
            this.ExitBarButtonItem.Caption = "Exit";
            this.ExitBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.close_32x32;
            this.ExitBarButtonItem.Id = 4;
            this.ExitBarButtonItem.Name = "ExitBarButtonItem";
            this.ExitBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ExitBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ExitBarButtonItem_ItemClick);
            // 
            // ProfileManagementBarButtonItem
            // 
            this.ProfileManagementBarButtonItem.Caption = "Profile";
            this.ProfileManagementBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.customer_32x32;
            this.ProfileManagementBarButtonItem.Id = 5;
            this.ProfileManagementBarButtonItem.Name = "ProfileManagementBarButtonItem";
            this.ProfileManagementBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ProfileManagementBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ProfileManagementBarButtonItem_ItemClick);
            // 
            // ChangePasswordBarButtonItem
            // 
            this.ChangePasswordBarButtonItem.Caption = "Change Password";
            this.ChangePasswordBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.Security_Password_2_icon;
            this.ChangePasswordBarButtonItem.Id = 6;
            this.ChangePasswordBarButtonItem.Name = "ChangePasswordBarButtonItem";
            this.ChangePasswordBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ChangePasswordBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChangePasswordBarButtonItem_ItemClick);
            // 
            // LogoutBarButtonItem
            // 
            this.LogoutBarButtonItem.Caption = "Logout";
            this.LogoutBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.logout;
            this.LogoutBarButtonItem.Id = 7;
            this.LogoutBarButtonItem.Name = "LogoutBarButtonItem";
            this.LogoutBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.LogoutBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LogoutBarButtonItem_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemPictureEdit1;
            this.barEditItem1.Id = 8;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 9;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // AboutBarButtonItem
            // 
            this.AboutBarButtonItem.Caption = "About";
            this.AboutBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.about_32x32;
            this.AboutBarButtonItem.Id = 10;
            this.AboutBarButtonItem.Name = "AboutBarButtonItem";
            this.AboutBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.AboutBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AboutBarButtonItem_ItemClick);
            // 
            // MatchingBarButtonItem
            // 
            this.MatchingBarButtonItem.Caption = "Matching";
            this.MatchingBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.CulpepperJobMatchingIcon;
            this.MatchingBarButtonItem.Id = 11;
            this.MatchingBarButtonItem.Name = "MatchingBarButtonItem";
            this.MatchingBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.MatchingBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MatchingBarButtonItem_ItemClick);
            // 
            // NavigationRibbonPage
            // 
            this.NavigationRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ImageProcessingBibbonPageGroup,
            this.ImageMatchingRibbonPageGroup});
            this.NavigationRibbonPage.Image = global::HandVeinPattern.Properties.Resources.navigationbar_32x32;
            this.NavigationRibbonPage.Name = "NavigationRibbonPage";
            this.NavigationRibbonPage.Text = "Navigation";
            // 
            // ImageProcessingBibbonPageGroup
            // 
            this.ImageProcessingBibbonPageGroup.AllowTextClipping = false;
            this.ImageProcessingBibbonPageGroup.ItemLinks.Add(this.ImageProcessingBarButtonItem);
            this.ImageProcessingBibbonPageGroup.Name = "ImageProcessingBibbonPageGroup";
            this.ImageProcessingBibbonPageGroup.Text = "Image Processing";
            // 
            // ImageMatchingRibbonPageGroup
            // 
            this.ImageMatchingRibbonPageGroup.AllowTextClipping = false;
            this.ImageMatchingRibbonPageGroup.ItemLinks.Add(this.MatchingBarButtonItem);
            this.ImageMatchingRibbonPageGroup.Name = "ImageMatchingRibbonPageGroup";
            this.ImageMatchingRibbonPageGroup.Text = "Image Matching";
            // 
            // AccountRibbonPage
            // 
            this.AccountRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.AccountSettingsRibbonPageGroup,
            this.LogoutRibbonPageGroup});
            this.AccountRibbonPage.Image = global::HandVeinPattern.Properties.Resources.publicfix_32x32;
            this.AccountRibbonPage.Name = "AccountRibbonPage";
            this.AccountRibbonPage.Text = "Account";
            // 
            // AccountSettingsRibbonPageGroup
            // 
            this.AccountSettingsRibbonPageGroup.AllowTextClipping = false;
            this.AccountSettingsRibbonPageGroup.ItemLinks.Add(this.ProfileManagementBarButtonItem);
            this.AccountSettingsRibbonPageGroup.ItemLinks.Add(this.ChangePasswordBarButtonItem);
            this.AccountSettingsRibbonPageGroup.Name = "AccountSettingsRibbonPageGroup";
            this.AccountSettingsRibbonPageGroup.Text = "Account Settings";
            // 
            // LogoutRibbonPageGroup
            // 
            this.LogoutRibbonPageGroup.AllowTextClipping = false;
            this.LogoutRibbonPageGroup.ItemLinks.Add(this.LogoutBarButtonItem);
            this.LogoutRibbonPageGroup.Name = "LogoutRibbonPageGroup";
            this.LogoutRibbonPageGroup.Text = "Logout";
            // 
            // ActionsRibbonPage
            // 
            this.ActionsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.SkinRibbonPageGroup,
            this.ActionsRibbonPageGroup});
            this.ActionsRibbonPage.Image = global::HandVeinPattern.Properties.Resources.technology_32x32;
            this.ActionsRibbonPage.Name = "ActionsRibbonPage";
            this.ActionsRibbonPage.Text = "Actions";
            // 
            // SkinRibbonPageGroup
            // 
            this.SkinRibbonPageGroup.AllowTextClipping = false;
            this.SkinRibbonPageGroup.ItemLinks.Add(this.SkinRibbonGalleryBarItem);
            this.SkinRibbonPageGroup.Name = "SkinRibbonPageGroup";
            this.SkinRibbonPageGroup.Text = "Skins";
            // 
            // ActionsRibbonPageGroup
            // 
            this.ActionsRibbonPageGroup.AllowTextClipping = false;
            this.ActionsRibbonPageGroup.ItemLinks.Add(this.AboutBarButtonItem);
            this.ActionsRibbonPageGroup.ItemLinks.Add(this.ExitBarButtonItem);
            this.ActionsRibbonPageGroup.Name = "ActionsRibbonPageGroup";
            this.ActionsRibbonPageGroup.Text = "Actions";
            // 
            // DashboardPanelControl2
            // 
            this.DashboardPanelControl2.Controls.Add(this.AdminStatusTabPane);
            this.DashboardPanelControl2.Location = new System.Drawing.Point(422, 168);
            this.DashboardPanelControl2.Name = "DashboardPanelControl2";
            this.DashboardPanelControl2.Size = new System.Drawing.Size(390, 325);
            this.DashboardPanelControl2.TabIndex = 1;
            // 
            // AdminStatusTabPane
            // 
            this.AdminStatusTabPane.Controls.Add(this.OnlineStatusTabNavigationPage);
            this.AdminStatusTabPane.Location = new System.Drawing.Point(5, 15);
            this.AdminStatusTabPane.Name = "AdminStatusTabPane";
            this.AdminStatusTabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.OnlineStatusTabNavigationPage});
            this.AdminStatusTabPane.RegularSize = new System.Drawing.Size(380, 305);
            this.AdminStatusTabPane.SelectedPage = this.OnlineStatusTabNavigationPage;
            this.AdminStatusTabPane.SelectedPageIndex = 0;
            this.AdminStatusTabPane.Size = new System.Drawing.Size(380, 305);
            this.AdminStatusTabPane.TabIndex = 0;
            this.AdminStatusTabPane.Text = "Admin Status";
            // 
            // OnlineStatusTabNavigationPage
            // 
            this.OnlineStatusTabNavigationPage.Caption = "Online Status";
            this.OnlineStatusTabNavigationPage.Controls.Add(this.OnlineStatusDataGridView);
            this.OnlineStatusTabNavigationPage.Name = "OnlineStatusTabNavigationPage";
            this.OnlineStatusTabNavigationPage.Size = new System.Drawing.Size(362, 260);
            // 
            // OnlineStatusDataGridView
            // 
            this.OnlineStatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OnlineStatusDataGridView.Location = new System.Drawing.Point(3, 3);
            this.OnlineStatusDataGridView.Name = "OnlineStatusDataGridView";
            this.OnlineStatusDataGridView.Size = new System.Drawing.Size(356, 246);
            this.OnlineStatusDataGridView.TabIndex = 0;
            // 
            // DashboardPanelControl1
            // 
            this.DashboardPanelControl1.Controls.Add(this.PerformanceTabPane);
            this.DashboardPanelControl1.Controls.Add(this.AdminManagementTabPane);
            this.DashboardPanelControl1.Location = new System.Drawing.Point(12, 168);
            this.DashboardPanelControl1.Name = "DashboardPanelControl1";
            this.DashboardPanelControl1.Size = new System.Drawing.Size(382, 325);
            this.DashboardPanelControl1.TabIndex = 3;
            // 
            // PerformanceTabPane
            // 
            this.PerformanceTabPane.Controls.Add(this.PerformanceTabNavigationPage);
            this.PerformanceTabPane.Location = new System.Drawing.Point(14, 151);
            this.PerformanceTabPane.Name = "PerformanceTabPane";
            this.PerformanceTabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PerformanceTabNavigationPage});
            this.PerformanceTabPane.RegularSize = new System.Drawing.Size(354, 169);
            this.PerformanceTabPane.SelectedPage = this.PerformanceTabNavigationPage;
            this.PerformanceTabPane.SelectedPageIndex = 0;
            this.PerformanceTabPane.Size = new System.Drawing.Size(354, 169);
            this.PerformanceTabPane.TabIndex = 1;
            this.PerformanceTabPane.Text = "tabPane1";
            // 
            // PerformanceTabNavigationPage
            // 
            this.PerformanceTabNavigationPage.Caption = "CPU Performance";
            this.PerformanceTabNavigationPage.Name = "PerformanceTabNavigationPage";
            this.PerformanceTabNavigationPage.Size = new System.Drawing.Size(336, 124);
            // 
            // AdminManagementTabPane
            // 
            this.AdminManagementTabPane.Controls.Add(this.AddAdminTabNavigationPage);
            this.AdminManagementTabPane.Controls.Add(this.RemoveAdminTabNavigationPage);
            this.AdminManagementTabPane.Location = new System.Drawing.Point(5, 5);
            this.AdminManagementTabPane.Name = "AdminManagementTabPane";
            this.AdminManagementTabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.AddAdminTabNavigationPage,
            this.RemoveAdminTabNavigationPage});
            this.AdminManagementTabPane.RegularSize = new System.Drawing.Size(372, 130);
            this.AdminManagementTabPane.SelectedPage = this.AddAdminTabNavigationPage;
            this.AdminManagementTabPane.SelectedPageIndex = 1;
            this.AdminManagementTabPane.Size = new System.Drawing.Size(372, 130);
            this.AdminManagementTabPane.TabIndex = 0;
            this.AdminManagementTabPane.Text = "New Admin";
            // 
            // AddAdminTabNavigationPage
            // 
            this.AddAdminTabNavigationPage.Caption = "Add Admin";
            this.AddAdminTabNavigationPage.Controls.Add(this.AddAdminSimpleButton);
            this.AddAdminTabNavigationPage.Name = "AddAdminTabNavigationPage";
            this.AddAdminTabNavigationPage.Size = new System.Drawing.Size(354, 85);
            // 
            // AddAdminSimpleButton
            // 
            this.AddAdminSimpleButton.Image = global::HandVeinPattern.Properties.Resources.add_16x16;
            this.AddAdminSimpleButton.Location = new System.Drawing.Point(104, 30);
            this.AddAdminSimpleButton.Name = "AddAdminSimpleButton";
            this.AddAdminSimpleButton.Size = new System.Drawing.Size(116, 33);
            this.AddAdminSimpleButton.TabIndex = 0;
            this.AddAdminSimpleButton.Text = "Add Admin";
            this.AddAdminSimpleButton.Click += new System.EventHandler(this.AddAdminSimpleButton_Click);
            // 
            // RemoveAdminTabNavigationPage
            // 
            this.RemoveAdminTabNavigationPage.Caption = "Remove Admin";
            this.RemoveAdminTabNavigationPage.Controls.Add(this.RemoveAdminSimpleButton);
            this.RemoveAdminTabNavigationPage.Name = "RemoveAdminTabNavigationPage";
            this.RemoveAdminTabNavigationPage.Size = new System.Drawing.Size(354, 85);
            // 
            // RemoveAdminSimpleButton
            // 
            this.RemoveAdminSimpleButton.Image = global::HandVeinPattern.Properties.Resources.delete_16x16;
            this.RemoveAdminSimpleButton.Location = new System.Drawing.Point(104, 30);
            this.RemoveAdminSimpleButton.Name = "RemoveAdminSimpleButton";
            this.RemoveAdminSimpleButton.Size = new System.Drawing.Size(116, 33);
            this.RemoveAdminSimpleButton.TabIndex = 1;
            this.RemoveAdminSimpleButton.Text = "Remove Admin";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 504);
            this.Controls.Add(this.DashboardPanelControl1);
            this.Controls.Add(this.DashboardPanelControl2);
            this.Controls.Add(this.ribbonControl1);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardPanelControl2)).EndInit();
            this.DashboardPanelControl2.ResumeLayout(false);
            this.AdminStatusTabPane.ResumeLayout(false);
            this.OnlineStatusTabNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OnlineStatusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardPanelControl1)).EndInit();
            this.DashboardPanelControl1.ResumeLayout(false);
            this.PerformanceTabPane.ResumeLayout(false);
            this.AdminManagementTabPane.ResumeLayout(false);
            this.AddAdminTabNavigationPage.ResumeLayout(false);
            this.RemoveAdminTabNavigationPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage NavigationRibbonPage;
        private DevExpress.XtraBars.BarButtonItem ImageProcessingBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ImageProcessingBibbonPageGroup;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem SkinRibbonGalleryBarItem;
        private DevExpress.XtraBars.BarButtonItem ExitBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ActionsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup SkinRibbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ActionsRibbonPageGroup;
        private DevExpress.XtraEditors.PanelControl DashboardPanelControl2;
        private DevExpress.XtraEditors.PanelControl DashboardPanelControl1;
        private DevExpress.XtraBars.Navigation.TabPane AdminStatusTabPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage OnlineStatusTabNavigationPage;
        private System.Windows.Forms.DataGridView OnlineStatusDataGridView;
        private DevExpress.XtraBars.Navigation.TabPane AdminManagementTabPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage AddAdminTabNavigationPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage AccountRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup AccountSettingsRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem ProfileManagementBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ChangePasswordBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem LogoutBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup LogoutRibbonPageGroup;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem AboutBarButtonItem;
        private DevExpress.XtraEditors.SimpleButton AddAdminSimpleButton;
        private DevExpress.XtraBars.Navigation.TabPane PerformanceTabPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage PerformanceTabNavigationPage;
        private DevExpress.XtraBars.Navigation.TabNavigationPage RemoveAdminTabNavigationPage;
        private DevExpress.XtraEditors.SimpleButton RemoveAdminSimpleButton;
        private DevExpress.XtraBars.BarButtonItem MatchingBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ImageMatchingRibbonPageGroup;
    }
}