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

namespace HandVeinPattern
{
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Dashboard()
        {
            InitializeComponent();

            admin_onlinestatus();

            //admin_status_colorchange();
        }

        void admin_onlinestatus()
        {
            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;

                command.CommandText = "AdminOnlineStatus";

                DataTable datatable = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(datatable);

                OnlineStatusDataGridView.DataSource = datatable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        void admin_status_colorchange()
        {
            for (int i = 0; i < OnlineStatusDataGridView.Rows.Count - 1; i++)
            {
                if (OnlineStatusDataGridView.Rows[i].Cells[3].Value.ToString() == "Online")
                {
                    OnlineStatusDataGridView.Rows[i].Cells[3].Style.BackColor = Color.GreenYellow;
                }
                else
                {
                    OnlineStatusDataGridView.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
            }
        }


        private void ExitBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Environment.Exit(1);
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

    }
}
