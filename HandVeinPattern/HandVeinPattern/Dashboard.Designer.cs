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
            ((System.ComponentModel.ISupportInitialize)(this.DashboardRibbonControl)).BeginInit();
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
            // 
            // DashboardRibbonControl
            // 
            this.DashboardRibbonControl.ExpandCollapseItem.Id = 0;
            this.DashboardRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.DashboardRibbonControl.ExpandCollapseItem,
            this.AboutBarButtonItem});
            this.DashboardRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.DashboardRibbonControl.MaxItemId = 2;
            this.DashboardRibbonControl.Name = "DashboardRibbonControl";
            this.DashboardRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HelpRibbonPage});
            this.DashboardRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.DashboardRibbonControl.Size = new System.Drawing.Size(1234, 162);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.DashboardRibbonControl);
            this.Name = "Dashboard";
            this.Ribbon = this.DashboardRibbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.DashboardRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage HelpRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ApplicationInformationRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem AboutBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl DashboardRibbonControl;

    }
}