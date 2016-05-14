using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace HandVeinPattern
{
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int lockTimerCounter = 0;

        Timer timer;

        public Dashboard()
        {
            InitializeComponent();

            timer = new Timer();

            timer.Start();
                        
            OnTimerTick(null, null);

            this.timer.Tick += new System.EventHandler(this.OnTimerTick);

        }

        int GetStringLength(string str) {
            int counter = 0;
            int pos = 0;
            while(pos < str.Length) {
                if(str[pos] != ':')
                    counter++;
                pos++;
            }
            return counter;
        }

        void OnTimerTick(object sender, EventArgs e) {
            if(lockTimerCounter == 0) {
                lockTimerCounter++;
                UpdateTime();
                lockTimerCounter--;
            }
        }

        void UpdateTime() {
            string time = DateTime.Now.ToLongTimeString();
            if(GetStringLength(time) > ClockDigitalGauge.DigitCount)
                ClockDigitalGauge.DigitCount = GetStringLength(time);
            ClockDigitalGauge.Text = time;
        }

        private void ImageProcessingBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImageProcessing imageprocessing = new ImageProcessing();
            imageprocessing.Show();
            this.Hide();
        }

        private void ChangePasswordBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AdminPasswordChange adminpasswordchange = new AdminPasswordChange();
            adminpasswordchange.Show();
            this.Hide();
        }

        private void ProfileManagementBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AdminProfile adminprofile = new AdminProfile();
            adminprofile.Show();
        }

        private void LogoutBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Details.AdminLoginID = string.Empty;
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void AboutBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutForm aboutform = new AboutForm();
            aboutform.Show();
        }

        private void AddAdminSimpleButton_Click(object sender, EventArgs e)
        {
            Register_Form__Admin_ register_form_admin = new Register_Form__Admin_();
            register_form_admin.Show();
            this.Hide();
        }

        private void MatchingBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImageMatching imagematching = new ImageMatching();
            imagematching.Show();
            this.Hide();
        }

        private void ImageProcessingSimpleButton_Click(object sender, EventArgs e)
        {
            ImageProcessing imageprocessing = new ImageProcessing();
            imageprocessing.Show();
            this.Hide();
        }

        private void ImageMatchingSimpleButton_Click(object sender, EventArgs e)
        {
            ImageMatching imagematching = new ImageMatching();
            imagematching.Show();
            this.Hide();
        }
    }
}
