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
            this.HelpRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ApplicationInformationRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.AboutBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.DashboardRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.MainMenuBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ImageProcessingBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.UserRegistrationBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.NavigationRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.MainMenuRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ImageProcessingRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.UserRegistrationRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.UserDetailsChartPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDetailsChartPanelControl)).BeginInit();
            this.UserDetailsChartPanelControl.SuspendLayout();
            this.tabPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpRibbonPage
            // 
            this.HelpRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ApplicationInformationRibbonPageGroup});
            this.HelpRibbonPage.Image = global::HandVeinPattern.Properties.Resources.index_32x32;
            this.HelpRibbonPage.Name = "HelpRibbonPage";
            this.HelpRibbonPage.Text = "Help";
            // 
            // ApplicationInformationRibbonPageGroup
            // 
            this.ApplicationInformationRibbonPageGroup.ItemLinks.Add(this.AboutBarButtonItem);
            this.ApplicationInformationRibbonPageGroup.Name = "ApplicationInformationRibbonPageGroup";
            this.ApplicationInformationRibbonPageGroup.Text = "Application Information";
            // 
            // AboutBarButtonItem
            // 
            this.AboutBarButtonItem.Caption = "About";
            this.AboutBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.about_32x32;
            this.AboutBarButtonItem.Id = 1;
            this.AboutBarButtonItem.Name = "AboutBarButtonItem";
            this.AboutBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.AboutBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AboutBarButtonItem_ItemClick);
            // 
            // DashboardRibbonControl
            // 
            this.DashboardRibbonControl.ExpandCollapseItem.Id = 0;
            this.DashboardRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.DashboardRibbonControl.ExpandCollapseItem,
            this.AboutBarButtonItem,
            this.MainMenuBarButtonItem,
            this.ImageProcessingBarButtonItem,
            this.UserRegistrationBarButtonItem});
            this.DashboardRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.DashboardRibbonControl.MaxItemId = 7;
            this.DashboardRibbonControl.Name = "DashboardRibbonControl";
            this.DashboardRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.NavigationRibbonPage,
            this.HelpRibbonPage});
            this.DashboardRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.DashboardRibbonControl.Size = new System.Drawing.Size(1234, 162);
            // 
            // MainMenuBarButtonItem
            // 
            this.MainMenuBarButtonItem.Caption = "Main Menu";
            this.MainMenuBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.home_32x32;
            this.MainMenuBarButtonItem.Id = 3;
            this.MainMenuBarButtonItem.Name = "MainMenuBarButtonItem";
            this.MainMenuBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.MainMenuBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MainMenuBarButtonItem_ItemClick);
            // 
            // ImageProcessingBarButtonItem
            // 
            this.ImageProcessingBarButtonItem.Caption = "Image Processing";
            this.ImageProcessingBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.technology_32x32;
            this.ImageProcessingBarButtonItem.Id = 5;
            this.ImageProcessingBarButtonItem.Name = "ImageProcessingBarButtonItem";
            this.ImageProcessingBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ImageProcessingBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ImageProcessingBarButtonItem_ItemClick);
            // 
            // UserRegistrationBarButtonItem
            // 
            this.UserRegistrationBarButtonItem.Caption = "User Registration";
            this.UserRegistrationBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.database_32x32;
            this.UserRegistrationBarButtonItem.Id = 6;
            this.UserRegistrationBarButtonItem.Name = "UserRegistrationBarButtonItem";
            this.UserRegistrationBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.UserRegistrationBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UserRegistrationBarButtonItem_ItemClick);
            // 
            // NavigationRibbonPage
            // 
            this.NavigationRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.MainMenuRibbonPageGroup,
            this.ImageProcessingRibbonPageGroup,
            this.UserRegistrationRibbonPageGroup});
            this.NavigationRibbonPage.Image = global::HandVeinPattern.Properties.Resources.navigationbar_32x32;
            this.NavigationRibbonPage.Name = "NavigationRibbonPage";
            this.NavigationRibbonPage.Text = "Navigation";
            // 
            // MainMenuRibbonPageGroup
            // 
            this.MainMenuRibbonPageGroup.AllowTextClipping = false;
            this.MainMenuRibbonPageGroup.ItemLinks.Add(this.MainMenuBarButtonItem);
            this.MainMenuRibbonPageGroup.Name = "MainMenuRibbonPageGroup";
            this.MainMenuRibbonPageGroup.Text = "Main Menu";
            // 
            // ImageProcessingRibbonPageGroup
            // 
            this.ImageProcessingRibbonPageGroup.AllowTextClipping = false;
            this.ImageProcessingRibbonPageGroup.ItemLinks.Add(this.ImageProcessingBarButtonItem);
            this.ImageProcessingRibbonPageGroup.Name = "ImageProcessingRibbonPageGroup";
            this.ImageProcessingRibbonPageGroup.Text = "Image Processing";
            // 
            // UserRegistrationRibbonPageGroup
            // 
            this.UserRegistrationRibbonPageGroup.AllowTextClipping = false;
            this.UserRegistrationRibbonPageGroup.ItemLinks.Add(this.UserRegistrationBarButtonItem);
            this.UserRegistrationRibbonPageGroup.Name = "UserRegistrationRibbonPageGroup";
            this.UserRegistrationRibbonPageGroup.Text = "User Registration";
            // 
            // UserDetailsChartPanelControl
            // 
            this.UserDetailsChartPanelControl.Controls.Add(this.tabPane1);
            this.UserDetailsChartPanelControl.Location = new System.Drawing.Point(13, 169);
            this.UserDetailsChartPanelControl.Name = "UserDetailsChartPanelControl";
            this.UserDetailsChartPanelControl.Size = new System.Drawing.Size(387, 480);
            this.UserDetailsChartPanelControl.TabIndex = 1;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(5, 5);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(377, 470);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.SelectedPageIndex = 0;
            this.tabPane1.Size = new System.Drawing.Size(377, 470);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "tabNavigationPage1";
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(359, 425);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(359, 425);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.UserDetailsChartPanelControl);
            this.Controls.Add(this.DashboardRibbonControl);
            this.Name = "Dashboard";
            this.Ribbon = this.DashboardRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.DashboardRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserDetailsChartPanelControl)).EndInit();
            this.UserDetailsChartPanelControl.ResumeLayout(false);
            this.tabPane1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage HelpRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ApplicationInformationRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem AboutBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl DashboardRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage NavigationRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup MainMenuRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem MainMenuBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ImageProcessingRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem ImageProcessingBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup UserRegistrationRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem UserRegistrationBarButtonItem;
        private DevExpress.XtraEditors.PanelControl UserDetailsChartPanelControl;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;

    }
}