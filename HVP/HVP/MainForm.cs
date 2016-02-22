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

namespace HVP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username, password;
            
            int UserID = 0;

            username = UsernameTextBox.Text;

            password = PasswordTextBox.Text;
            
            using (SqlConnection connection = new SqlConnection(HVP.Properties.Settings.Default.HandVeinPatternConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Authenticate"))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", username);
                    
                    command.Parameters.AddWithValue("@Password", password);
                    
                    command.Connection = connection;

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    
                    UserID = Convert.ToInt32(reader["UserID"]);

                    connection.Close();
                }
                switch (UserID)
                {
                    case 1:
                        Form1 f1 = new Form1();
                        
                        f1.Show();
                        
                        this.Hide();

                        break;

                    case -1:

                        clear();

                        MessageBox.Show("Invalid Username Or Password", "Invalid Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        break;
                }
            }
        }

        void clear()
        {
            UsernameTextBox.Text = string.Empty;
            
            UsernameTextBox.Text = "";

            PasswordTextBox.Text = string.Empty;

            PasswordTextBox.Text = "";
        }
    }
}