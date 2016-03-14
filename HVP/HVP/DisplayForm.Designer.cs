namespace HVP
{
    partial class DisplayForm
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
            this.ContinueLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ContinueLinkLabel
            // 
            this.ContinueLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ContinueLinkLabel.AutoSize = true;
            this.ContinueLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ContinueLinkLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueLinkLabel.LinkColor = System.Drawing.Color.White;
            this.ContinueLinkLabel.Location = new System.Drawing.Point(860, 575);
            this.ContinueLinkLabel.Name = "ContinueLinkLabel";
            this.ContinueLinkLabel.Size = new System.Drawing.Size(112, 27);
            this.ContinueLinkLabel.TabIndex = 0;
            this.ContinueLinkLabel.TabStop = true;
            this.ContinueLinkLabel.Text = "Continue";
            this.ContinueLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ContinueLinkLabel_LinkClicked);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HVP.Properties.Resources.biometric_91;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.ContinueLinkLabel);
            this.Name = "DisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hand Vein Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ContinueLinkLabel;
    }
}