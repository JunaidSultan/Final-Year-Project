using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandVeinPattern
{
    public partial class AdminProfile : Form
    {
        DataSet admindetails_dataset;

        public AdminProfile()
        {
            InitializeComponent();

            AdminImagePictureEdit.ContextMenu = new ContextMenu();

            loadadminrecords();

            showadminrecords();
        }

        // Function To Load The Admin Records

        private void loadadminrecords()
        {
            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "SELECT * FROM AdminDetails WHERE AdminID = '" + Details.AdminLoginID + "'";

                admindetails_dataset = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(admindetails_dataset);
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

        // Function To Display Records On The Form

        private void showadminrecords()
        {
            if (admindetails_dataset.Tables[0].Rows.Count > 0)
            {
                AdminIDDBLabel.Text = Details.AdminLoginID;

                FirstNameDBLabel.Text = admindetails_dataset.Tables[0].Rows[0][1].ToString();

                LastNameDBLabel.Text = admindetails_dataset.Tables[0].Rows[0][2].ToString();

                GenderDBLabel.Text = admindetails_dataset.Tables[0].Rows[0][4].ToString();

                EmailDBLabel.Text = admindetails_dataset.Tables[0].Rows[0][5].ToString();

                AdminImagePictureEdit.Image = null;

                if (admindetails_dataset.Tables[0].Rows[0][3] != DBNull.Value)
                {
                    byte[] photo_array = (byte[])admindetails_dataset.Tables[0].Rows[0][3];

                    MemoryStream memorystream = new MemoryStream(photo_array);

                    AdminImagePictureEdit.Image = Image.FromStream(memorystream);
                }
            }
        }
    }
}
