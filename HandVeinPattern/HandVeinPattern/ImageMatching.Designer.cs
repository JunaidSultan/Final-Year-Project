namespace HandVeinPattern
{
    partial class ImageMatching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageMatching));
            this.ImageMatchingRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ProcessImageBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.MatchBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.CancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ClearBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.MatchingRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ActionsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ActionsRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.OriginalImageContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageMatchingGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.ImageMatchingProgressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            this.DetailsPanelControl = new DevExpress.XtraEditors.PanelControl();
            this.ResultGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.ViewDetailsSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.UserTitleResultLabel = new System.Windows.Forms.Label();
            this.UserTitleLabel = new System.Windows.Forms.Label();
            this.UserIDResultLabel = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.ResultImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.ProcessedImagePanelControl = new DevExpress.XtraEditors.PanelControl();
            this.ProcessedImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.ProcessedImageLabel = new System.Windows.Forms.Label();
            this.OriginalImagePanelControl = new DevExpress.XtraEditors.PanelControl();
            this.LoadImageSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OriginalImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.OriginalImageLabel = new System.Windows.Forms.Label();
            this.ArduinoSerialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImageMatchingRibbonControl)).BeginInit();
            this.OriginalImageContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMatchingGroupControl)).BeginInit();
            this.ImageMatchingGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageMatchingProgressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsPanelControl)).BeginInit();
            this.DetailsPanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGroupControl)).BeginInit();
            this.ResultGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImagePanelControl)).BeginInit();
            this.ProcessedImagePanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePanelControl)).BeginInit();
            this.OriginalImagePanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePictureEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageMatchingRibbonControl
            // 
            this.ImageMatchingRibbonControl.ExpandCollapseItem.Id = 0;
            this.ImageMatchingRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ImageMatchingRibbonControl.ExpandCollapseItem,
            this.ProcessImageBarButtonItem,
            this.MatchBarButtonItem,
            this.CancelBarButtonItem,
            this.ClearBarButtonItem});
            this.ImageMatchingRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.ImageMatchingRibbonControl.MaxItemId = 5;
            this.ImageMatchingRibbonControl.Name = "ImageMatchingRibbonControl";
            this.ImageMatchingRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ActionsRibbonPage});
            this.ImageMatchingRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ImageMatchingRibbonControl.Size = new System.Drawing.Size(1234, 144);
            // 
            // ProcessImageBarButtonItem
            // 
            this.ProcessImageBarButtonItem.Caption = "Process Image";
            this.ProcessImageBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.viewsetting_32x32;
            this.ProcessImageBarButtonItem.Id = 1;
            this.ProcessImageBarButtonItem.Name = "ProcessImageBarButtonItem";
            this.ProcessImageBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ProcessImageBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ProcessImageBarButtonItem_ItemClick);
            // 
            // MatchBarButtonItem
            // 
            this.MatchBarButtonItem.Caption = "Match";
            this.MatchBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.CulpepperJobMatchingIcon;
            this.MatchBarButtonItem.Id = 2;
            this.MatchBarButtonItem.Name = "MatchBarButtonItem";
            this.MatchBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.MatchBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MatchBarButtonItem_ItemClick);
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
            // ClearBarButtonItem
            // 
            this.ClearBarButtonItem.Caption = "Clear";
            this.ClearBarButtonItem.Glyph = global::HandVeinPattern.Properties.Resources.clear_32x32;
            this.ClearBarButtonItem.Id = 4;
            this.ClearBarButtonItem.Name = "ClearBarButtonItem";
            this.ClearBarButtonItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.ClearBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ClearBarButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.MatchingRibbonPageGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Matching";
            // 
            // MatchingRibbonPageGroup
            // 
            this.MatchingRibbonPageGroup.AllowTextClipping = false;
            this.MatchingRibbonPageGroup.ItemLinks.Add(this.ProcessImageBarButtonItem);
            this.MatchingRibbonPageGroup.ItemLinks.Add(this.MatchBarButtonItem);
            this.MatchingRibbonPageGroup.ItemLinks.Add(this.ClearBarButtonItem);
            this.MatchingRibbonPageGroup.Name = "MatchingRibbonPageGroup";
            this.MatchingRibbonPageGroup.Text = "Matching";
            // 
            // ActionsRibbonPage
            // 
            this.ActionsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ActionsRibbonPageGroup});
            this.ActionsRibbonPage.Image = global::HandVeinPattern.Properties.Resources.technology_16x16;
            this.ActionsRibbonPage.Name = "ActionsRibbonPage";
            this.ActionsRibbonPage.Text = "Actions";
            // 
            // ActionsRibbonPageGroup
            // 
            this.ActionsRibbonPageGroup.AllowTextClipping = false;
            this.ActionsRibbonPageGroup.ItemLinks.Add(this.CancelBarButtonItem);
            this.ActionsRibbonPageGroup.Name = "ActionsRibbonPageGroup";
            this.ActionsRibbonPageGroup.Text = "Actions";
            // 
            // OriginalImageContextMenuStrip
            // 
            this.OriginalImageContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasteToolStripMenuItem,
            this.toolStripSeparator1,
            this.LoadToolStripMenuItem,
            this.toolStripSeparator2,
            this.DeleteToolStripMenuItem});
            this.OriginalImageContextMenuStrip.Name = "OriginalImageContextMenuStrip";
            this.OriginalImageContextMenuStrip.Size = new System.Drawing.Size(108, 82);
            this.OriginalImageContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.OriginalImageContextMenuStrip_Opening);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Image = global::HandVeinPattern.Properties.Resources.paste;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Image = global::HandVeinPattern.Properties.Resources.folder_PNG8773;
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::HandVeinPattern.Properties.Resources.DeleteRed;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ImageMatchingGroupControl
            // 
            this.ImageMatchingGroupControl.Controls.Add(this.ImageMatchingProgressBarControl);
            this.ImageMatchingGroupControl.Controls.Add(this.DetailsPanelControl);
            this.ImageMatchingGroupControl.Controls.Add(this.ProcessedImagePanelControl);
            this.ImageMatchingGroupControl.Controls.Add(this.OriginalImagePanelControl);
            this.ImageMatchingGroupControl.Location = new System.Drawing.Point(13, 148);
            this.ImageMatchingGroupControl.Name = "ImageMatchingGroupControl";
            this.ImageMatchingGroupControl.Size = new System.Drawing.Size(1209, 428);
            this.ImageMatchingGroupControl.TabIndex = 3;
            this.ImageMatchingGroupControl.Text = "Image Matching";
            // 
            // ImageMatchingProgressBarControl
            // 
            this.ImageMatchingProgressBarControl.Location = new System.Drawing.Point(6, 402);
            this.ImageMatchingProgressBarControl.MenuManager = this.ImageMatchingRibbonControl;
            this.ImageMatchingProgressBarControl.Name = "ImageMatchingProgressBarControl";
            this.ImageMatchingProgressBarControl.Properties.ShowTitle = true;
            this.ImageMatchingProgressBarControl.Properties.Step = 20;
            this.ImageMatchingProgressBarControl.Size = new System.Drawing.Size(308, 18);
            this.ImageMatchingProgressBarControl.TabIndex = 2;
            // 
            // DetailsPanelControl
            // 
            this.DetailsPanelControl.Controls.Add(this.ResultGroupControl);
            this.DetailsPanelControl.Location = new System.Drawing.Point(687, 24);
            this.DetailsPanelControl.Name = "DetailsPanelControl";
            this.DetailsPanelControl.Size = new System.Drawing.Size(517, 372);
            this.DetailsPanelControl.TabIndex = 1;
            // 
            // ResultGroupControl
            // 
            this.ResultGroupControl.Controls.Add(this.ViewDetailsSimpleButton);
            this.ResultGroupControl.Controls.Add(this.UserTitleResultLabel);
            this.ResultGroupControl.Controls.Add(this.UserTitleLabel);
            this.ResultGroupControl.Controls.Add(this.UserIDResultLabel);
            this.ResultGroupControl.Controls.Add(this.UserIDLabel);
            this.ResultGroupControl.Controls.Add(this.ResultImagePictureEdit);
            this.ResultGroupControl.Location = new System.Drawing.Point(5, 5);
            this.ResultGroupControl.Name = "ResultGroupControl";
            this.ResultGroupControl.Size = new System.Drawing.Size(507, 362);
            this.ResultGroupControl.TabIndex = 0;
            this.ResultGroupControl.Text = "Result";
            // 
            // ViewDetailsSimpleButton
            // 
            this.ViewDetailsSimpleButton.Image = global::HandVeinPattern.Properties.Resources.contact_16x16;
            this.ViewDetailsSimpleButton.Location = new System.Drawing.Point(20, 325);
            this.ViewDetailsSimpleButton.Name = "ViewDetailsSimpleButton";
            this.ViewDetailsSimpleButton.Size = new System.Drawing.Size(97, 23);
            this.ViewDetailsSimpleButton.TabIndex = 8;
            this.ViewDetailsSimpleButton.Text = "View Details";
            this.ViewDetailsSimpleButton.Click += new System.EventHandler(this.ViewDetailsSimpleButton_Click);
            // 
            // UserTitleResultLabel
            // 
            this.UserTitleResultLabel.AutoSize = true;
            this.UserTitleResultLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTitleResultLabel.Location = new System.Drawing.Point(16, 258);
            this.UserTitleResultLabel.Name = "UserTitleResultLabel";
            this.UserTitleResultLabel.Size = new System.Drawing.Size(14, 19);
            this.UserTitleResultLabel.TabIndex = 7;
            this.UserTitleResultLabel.Text = "-";
            // 
            // UserTitleLabel
            // 
            this.UserTitleLabel.AutoSize = true;
            this.UserTitleLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTitleLabel.Location = new System.Drawing.Point(16, 198);
            this.UserTitleLabel.Name = "UserTitleLabel";
            this.UserTitleLabel.Size = new System.Drawing.Size(46, 19);
            this.UserTitleLabel.TabIndex = 6;
            this.UserTitleLabel.Text = "Title :";
            // 
            // UserIDResultLabel
            // 
            this.UserIDResultLabel.AutoSize = true;
            this.UserIDResultLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDResultLabel.Location = new System.Drawing.Point(16, 139);
            this.UserIDResultLabel.Name = "UserIDResultLabel";
            this.UserIDResultLabel.Size = new System.Drawing.Size(14, 19);
            this.UserIDResultLabel.TabIndex = 5;
            this.UserIDResultLabel.Text = "-";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDLabel.Location = new System.Drawing.Point(16, 79);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(31, 19);
            this.UserIDLabel.TabIndex = 4;
            this.UserIDLabel.Text = "ID :";
            // 
            // ResultImagePictureEdit
            // 
            this.ResultImagePictureEdit.EditValue = global::HandVeinPattern.Properties.Resources.noprofile;
            this.ResultImagePictureEdit.Location = new System.Drawing.Point(266, 57);
            this.ResultImagePictureEdit.MenuManager = this.ImageMatchingRibbonControl;
            this.ResultImagePictureEdit.Name = "ResultImagePictureEdit";
            this.ResultImagePictureEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ResultImagePictureEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ResultImagePictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ResultImagePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ResultImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ResultImagePictureEdit.Size = new System.Drawing.Size(226, 257);
            this.ResultImagePictureEdit.TabIndex = 3;
            // 
            // ProcessedImagePanelControl
            // 
            this.ProcessedImagePanelControl.Controls.Add(this.ProcessedImagePictureEdit);
            this.ProcessedImagePanelControl.Controls.Add(this.ProcessedImageLabel);
            this.ProcessedImagePanelControl.Location = new System.Drawing.Point(347, 24);
            this.ProcessedImagePanelControl.Name = "ProcessedImagePanelControl";
            this.ProcessedImagePanelControl.Size = new System.Drawing.Size(308, 372);
            this.ProcessedImagePanelControl.TabIndex = 1;
            // 
            // ProcessedImagePictureEdit
            // 
            this.ProcessedImagePictureEdit.EditValue = global::HandVeinPattern.Properties.Resources.Blank_Hand_Image;
            this.ProcessedImagePictureEdit.Location = new System.Drawing.Point(42, 74);
            this.ProcessedImagePictureEdit.MenuManager = this.ImageMatchingRibbonControl;
            this.ProcessedImagePictureEdit.Name = "ProcessedImagePictureEdit";
            this.ProcessedImagePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ProcessedImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ProcessedImagePictureEdit.Size = new System.Drawing.Size(226, 257);
            this.ProcessedImagePictureEdit.TabIndex = 2;
            // 
            // ProcessedImageLabel
            // 
            this.ProcessedImageLabel.AutoSize = true;
            this.ProcessedImageLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessedImageLabel.Location = new System.Drawing.Point(81, 26);
            this.ProcessedImageLabel.Name = "ProcessedImageLabel";
            this.ProcessedImageLabel.Size = new System.Drawing.Size(154, 26);
            this.ProcessedImageLabel.TabIndex = 1;
            this.ProcessedImageLabel.Text = "Processed Image";
            // 
            // OriginalImagePanelControl
            // 
            this.OriginalImagePanelControl.Controls.Add(this.LoadImageSimpleButton);
            this.OriginalImagePanelControl.Controls.Add(this.OriginalImagePictureEdit);
            this.OriginalImagePanelControl.Controls.Add(this.OriginalImageLabel);
            this.OriginalImagePanelControl.Location = new System.Drawing.Point(6, 24);
            this.OriginalImagePanelControl.Name = "OriginalImagePanelControl";
            this.OriginalImagePanelControl.Size = new System.Drawing.Size(308, 372);
            this.OriginalImagePanelControl.TabIndex = 0;
            // 
            // LoadImageSimpleButton
            // 
            this.LoadImageSimpleButton.Image = global::HandVeinPattern.Properties.Resources.open_16x16;
            this.LoadImageSimpleButton.Location = new System.Drawing.Point(82, 338);
            this.LoadImageSimpleButton.Name = "LoadImageSimpleButton";
            this.LoadImageSimpleButton.Size = new System.Drawing.Size(131, 23);
            this.LoadImageSimpleButton.TabIndex = 2;
            this.LoadImageSimpleButton.Text = "Load Image";
            this.LoadImageSimpleButton.Click += new System.EventHandler(this.LoadImageSimpleButton_Click);
            // 
            // OriginalImagePictureEdit
            // 
            this.OriginalImagePictureEdit.EditValue = global::HandVeinPattern.Properties.Resources.Blank_Hand_Image;
            this.OriginalImagePictureEdit.Location = new System.Drawing.Point(37, 74);
            this.OriginalImagePictureEdit.MenuManager = this.ImageMatchingRibbonControl;
            this.OriginalImagePictureEdit.Name = "OriginalImagePictureEdit";
            this.OriginalImagePictureEdit.Properties.ContextMenuStrip = this.OriginalImageContextMenuStrip;
            this.OriginalImagePictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.OriginalImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.OriginalImagePictureEdit.Size = new System.Drawing.Size(226, 257);
            this.OriginalImagePictureEdit.TabIndex = 1;
            // 
            // OriginalImageLabel
            // 
            this.OriginalImageLabel.AutoSize = true;
            this.OriginalImageLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalImageLabel.Location = new System.Drawing.Point(77, 26);
            this.OriginalImageLabel.Name = "OriginalImageLabel";
            this.OriginalImageLabel.Size = new System.Drawing.Size(136, 26);
            this.OriginalImageLabel.TabIndex = 0;
            this.OriginalImageLabel.Text = "Original Image";
            // 
            // ImageMatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 581);
            this.Controls.Add(this.ImageMatchingGroupControl);
            this.Controls.Add(this.ImageMatchingRibbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageMatching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching";
            this.Load += new System.EventHandler(this.ImageMatching_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageMatchingRibbonControl)).EndInit();
            this.OriginalImageContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageMatchingGroupControl)).EndInit();
            this.ImageMatchingGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageMatchingProgressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsPanelControl)).EndInit();
            this.DetailsPanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultGroupControl)).EndInit();
            this.ResultGroupControl.ResumeLayout(false);
            this.ResultGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImagePanelControl)).EndInit();
            this.ProcessedImagePanelControl.ResumeLayout(false);
            this.ProcessedImagePanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePanelControl)).EndInit();
            this.OriginalImagePanelControl.ResumeLayout(false);
            this.OriginalImagePanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImagePictureEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ImageMatchingRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup MatchingRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem ProcessImageBarButtonItem;
        private System.Windows.Forms.ContextMenuStrip OriginalImageContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private DevExpress.XtraEditors.GroupControl ImageMatchingGroupControl;
        private DevExpress.XtraEditors.PanelControl DetailsPanelControl;
        private DevExpress.XtraEditors.PanelControl ProcessedImagePanelControl;
        private DevExpress.XtraEditors.PanelControl OriginalImagePanelControl;
        private DevExpress.XtraEditors.ProgressBarControl ImageMatchingProgressBarControl;
        private System.Windows.Forms.Label ProcessedImageLabel;
        private System.Windows.Forms.Label OriginalImageLabel;
        private DevExpress.XtraEditors.PictureEdit ProcessedImagePictureEdit;
        private DevExpress.XtraEditors.PictureEdit OriginalImagePictureEdit;
        private DevExpress.XtraEditors.GroupControl ResultGroupControl;
        private DevExpress.XtraEditors.PictureEdit ResultImagePictureEdit;
        private System.Windows.Forms.Label UserTitleLabel;
        private System.Windows.Forms.Label UserIDResultLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.Label UserTitleResultLabel;
        private DevExpress.XtraBars.BarButtonItem MatchBarButtonItem;
        private DevExpress.XtraEditors.SimpleButton ViewDetailsSimpleButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage ActionsRibbonPage;
        private DevExpress.XtraBars.BarButtonItem CancelBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ActionsRibbonPageGroup;
        private System.IO.Ports.SerialPort ArduinoSerialPort;
        private DevExpress.XtraBars.BarButtonItem ClearBarButtonItem;
        private DevExpress.XtraEditors.SimpleButton LoadImageSimpleButton;
    }
}