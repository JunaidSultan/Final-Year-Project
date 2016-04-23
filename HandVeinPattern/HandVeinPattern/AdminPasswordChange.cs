using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandVeinPattern
{
    public partial class AdminPasswordChange : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AdminPasswordChange()
        {
            InitializeComponent();
        }

        // Button Click Event To Change The Administrator's Password
 
        private void ChangeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (OldPasswordTextBox.Text.Equals(NewPasswordTextBox.Text))
            {
                SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

                SqlCommand command = new SqlCommand();

                connection.Open();

                try
                {
                    command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ADMINPASSWORDCHANGE";

                    command.Parameters.AddWithValue("@ADMINID", IDTextBox.Text);

                    command.Parameters.AddWithValue("@NEWPASSWORD", NewPasswordTextBox.Text);

                    command.ExecuteNonQuery();
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

                MessageBox.Show("Password Successfuly Changed", "Password Change", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords Don't Match. Please Enter The Correct Password.", "Invalid Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }

            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        // Resets The Password Fields

        private void ResetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OldPasswordTextBox.Text = string.Empty;

            NewPasswordTextBox.Text = string.Empty;

            ConfirmPasswordTextBox.Text = string.Empty;
        }

        // Closes The Password Management Form

        private void CloseBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }        
    }
}
