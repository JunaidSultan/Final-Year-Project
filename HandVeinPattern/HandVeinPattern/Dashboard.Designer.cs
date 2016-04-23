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
            this.NavigationRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ImageProcessingBibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.AccountRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.AccountSettingsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.LogoutRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ActionsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.SkinRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ActionsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DashboardPanelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.AdminStatusTabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.OnlineStatusTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.OnlineStatusDataGridView = new System.Windows.Forms.DataGridView();
            this.DashboardPanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.NewAdminTabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.AddAdminTabNavigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardPanelControl3)).BeginInit();
            this.DashboardPanelControl3.SuspendLayout();
            this.AdminStatusTabPane.SuspendLayout();
            this.OnlineStatusTabNavigationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OnlineStatusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardPanelControl2)).BeginInit();
            this.DashboardPanelControl2.SuspendLayout();
            this.NewAdminTabPane.SuspendLayout();
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
            this.ribbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
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
            // NavigationRibbonPage
            // 
            this.NavigationRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ImageProcessingBibbonPageGroup});
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
            this.ActionsRibbonPage.Image = global::HandVeinPattern.Properties.Resources.viewsetting_32x32;
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
            this.ActionsRibbonPageGroup.ItemLinks.Add(this.ExitBarButtonItem);
            this.ActionsRibbonPageGroup.Name = "ActionsRibbonPageGroup";
            this.ActionsRibbonPageGroup.Text = "Actions";
            // 
            // DashboardPanelControl3
            // 
            this.DashboardPanelControl3.Controls.Add(this.AdminStatusTabPane);
            this.DashboardPanelControl3.Location = new System.Drawing.Point(422, 168);
            this.DashboardPanelControl3.Name = "DashboardPanelControl3";
            this.DashboardPanelControl3.Size = new System.Drawing.Size(390, 325);
            this.DashboardPanelControl3.TabIndex = 1;
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
            // DashboardPanelControl2
            // 
            this.DashboardPanelControl2.Controls.Add(this.NewAdminTabPane);
            this.DashboardPanelControl2.Location = new System.Drawing.Point(12, 168);
            this.DashboardPanelControl2.Name = "DashboardPanelControl2";
            this.DashboardPanelControl2.Size = new System.Drawing.Size(382, 325);
            this.DashboardPanelControl2.TabIndex = 3;
            // 
            // NewAdminTabPane
            // 
            this.NewAdminTabPane.Controls.Add(this.AddAdminTabNavigationPage);
            this.NewAdminTabPane.Location = new System.Drawing.Point(5, 5);
            this.NewAdminTabPane.Name = "NewAdminTabPane";
            this.NewAdminTabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.AddAdminTabNavigationPage});
            this.NewAdminTabPane.RegularSize = new System.Drawing.Size(372, 315);
            this.NewAdminTabPane.SelectedPage = this.AddAdminTabNavigationPage;
            this.NewAdminTabPane.SelectedPageIndex = 0;
            this.NewAdminTabPane.Size = new System.Drawing.Size(372, 315);
            this.NewAdminTabPane.TabIndex = 0;
            this.NewAdminTabPane.Text = "New Admin";
            // 
            // AddAdminTabNavigationPage
            // 
            this.AddAdminTabNavigationPage.Caption = "Add Admin";
            this.AddAdminTabNavigationPage.Name = "AddAdminTabNavigationPage";
            this.AddAdminTabNavigationPage.Size = new System.Drawing.Size(354, 270);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 504);
            this.Controls.Add(this.DashboardPanelControl2);
            this.Controls.Add(this.DashboardPanelControl3);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Dashboard";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardPanelControl3)).EndInit();
            this.DashboardPanelControl3.ResumeLayout(false);
            this.AdminStatusTabPane.ResumeLayout(false);
            this.OnlineStatusTabNavigationPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OnlineStatusDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardPanelControl2)).EndInit();
            this.DashboardPanelControl2.ResumeLayout(false);
            this.NewAdminTabPane.ResumeLayout(false);
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
        private DevExpress.XtraEditors.PanelControl DashboardPanelControl3;
        private DevExpress.XtraEditors.PanelControl DashboardPanelControl2;
        private DevExpress.XtraBars.Navigation.TabPane AdminStatusTabPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage OnlineStatusTabNavigationPage;
        private System.Windows.Forms.DataGridView OnlineStatusDataGridView;
        private DevExpress.XtraBars.Navigation.TabPane NewAdminTabPane;
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
    }
}