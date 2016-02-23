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
            
            int UserID = -1;

            username = UsernameTextBox.Text;

            password = PasswordTextBox.Text;

            SqlConnection connection = new SqlConnection(HVP.Properties.Settings.Default.HandVeinPatternConnectionString);
            
            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "SELECT USERID FROM USERS WHERE USERNAME = '" + username + "' AND PASSWORD = '" + password + "'";

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                    
                UserID = Convert.ToInt32(reader["UserID"]);
            
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
            
            switch (UserID)
            {
                case -1:
                    
                    clear();

                    MessageBox.Show("Invalid Username Or Password", "Invalid Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;

                default:
                
                    Form1 f1 = new Form1();
                        
                    f1.Show();
                        
                    this.Hide();

                    break;
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