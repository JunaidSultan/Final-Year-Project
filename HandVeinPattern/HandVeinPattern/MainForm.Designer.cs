﻿namespace HandVeinPattern
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContinueSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ExitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // ContinueSimpleButton
            // 
            this.ContinueSimpleButton.Image = global::HandVeinPattern.Properties.Resources.apply_16x16;
            this.ContinueSimpleButton.Location = new System.Drawing.Point(861, 526);
            this.ContinueSimpleButton.Name = "ContinueSimpleButton";
            this.ContinueSimpleButton.Size = new System.Drawing.Size(111, 23);
            this.ContinueSimpleButton.TabIndex = 0;
            this.ContinueSimpleButton.Text = "Continue";
            this.ContinueSimpleButton.Click += new System.EventHandler(this.ContinueSimpleButton_Click);
            // 
            // ExitSimpleButton
            // 
            this.ExitSimpleButton.Image = global::HandVeinPattern.Properties.Resources.close_16x16;
            this.ExitSimpleButton.Location = new System.Drawing.Point(12, 526);
            this.ExitSimpleButton.Name = "ExitSimpleButton";
            this.ExitSimpleButton.Size = new System.Drawing.Size(111, 23);
            this.ExitSimpleButton.TabIndex = 1;
            this.ExitSimpleButton.Text = "Exit";
            this.ExitSimpleButton.Click += new System.EventHandler(this.ExitSimpleButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HandVeinPattern.Properties.Resources.Main_Form_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ExitSimpleButton);
            this.Controls.Add(this.ContinueSimpleButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hand Vein Pattern";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ContinueSimpleButton;
        private DevExpress.XtraEditors.SimpleButton ExitSimpleButton;
    }
}