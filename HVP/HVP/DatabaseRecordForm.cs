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

using Microsoft.VisualBasic;
using System.IO;

using System.Drawing.Imaging;

namespace HVP
{
    public partial class DatabaseRecordForm : Form
    {
        string facepicture_filepath;

        public DatabaseRecordForm()
        {
            InitializeComponent();

            HandImagePictureBox.ImageLocation = Program.filepath;
        }

        private void LoadFacePictureImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog facepicture_ofd = new OpenFileDialog();

            if (facepicture_ofd.ShowDialog() == DialogResult.OK)
            {
                facepicture_filepath = facepicture_ofd.FileName;

                FacePictureBox.ImageLocation = facepicture_ofd.FileName;
            }
        }

        void PersonInsert()
        {
            SqlConnection connection = new SqlConnection(HVP.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "INSERT INTO PERSONS (ID, NAME, IMAGE) VALUES (@ID, @NAME, @IMAGE)";

                command.Parameters.AddWithValue("@ID", Convert.ToInt32(IDTextBox.Text));

                command.Parameters.AddWithValue("@NAME", NameTextBox.Text);
                
                FileStream facepicture_filestream = new FileStream(facepicture_filepath, FileMode.Open, FileAccess.Read);
                    
                byte[] facepicturebyte = new byte[facepicture_filestream.Length];

                facepicture_filestream.Read(facepicturebyte, 0, System.Convert.ToInt32(facepicture_filestream.Length));
                    
                SqlParameter facepictureparameter = new SqlParameter();
                    
                facepictureparameter.SqlDbType = SqlDbType.Image;

                facepictureparameter.ParameterName = "IMAGE";
                    
                facepictureparameter.Value = facepicturebyte;
 
                command.Parameters.Add(facepictureparameter);
 
                command.ExecuteNonQuery();
            }
          
            catch(Exception)
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

        void ImageInsert()
        {
            SqlConnection connection = new SqlConnection(HVP.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "INSERT INTO IMAGE (ID, HANDIMAGE) VALUES (@ID, @IMAGE)";

                command.Parameters.AddWithValue("@ID", Convert.ToInt32(IDTextBox.Text));

                FileStream handpicture_filestream = new FileStream(Program.filepath, FileMode.Open, FileAccess.Read);

                byte[] handpicturebyte = new byte[handpicture_filestream.Length];

                handpicture_filestream.Read(handpicturebyte, 0, System.Convert.ToInt32(handpicture_filestream.Length));

                SqlParameter handpictureparameter = new SqlParameter();

                handpictureparameter.SqlDbType = SqlDbType.Image;

                handpictureparameter.ParameterName = "IMAGE";

                handpictureparameter.Value = handpicturebyte;

                command.Parameters.Add(handpictureparameter);

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

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            PersonInsert();
            
            ImageInsert();

            MessageBox.Show("Records Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void cancel()
        {
            IDTextBox.Text = string.Empty;

            IDTextBox.Text = "";

            NameTextBox.Text = string.Empty;

            NameTextBox.Text = "";

            FacePictureBox.Image = null;

            HandImagePictureBox.Image = null;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();

            mainform.Show();

            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Program.filepath = string.Empty;

            Program.filepath = "";
            
            Environment.Exit(1);
        }
        
    }
}
