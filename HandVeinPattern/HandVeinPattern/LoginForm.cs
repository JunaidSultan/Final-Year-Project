﻿using System;
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
    public partial class LoginForm : Form
    {
        int AdminID = 0;

        string username = string.Empty;

        string password = string.Empty;

        public LoginForm()
        {
            InitializeComponent();

            LoginPictureEdit.ContextMenuStrip = new ContextMenuStrip();     // Empty Context Menu Strip For The Picture Edit Box

            errorprovider();                                                // Checks For The TextBox Errors
        }

        #region Error Provider

        private void errorprovider()
        {
            if(UsernameTextBox.Text == string.Empty)
            {
                UsernameErrorProvider.SetError(UsernameTextBox, "Username Required");
            }

            if(PasswordTextBox.Text == string.Empty)
            {
                PasswordErrorProvider.SetError(PasswordTextBox, "Password Required");
            }
        }


        void clear()
        {
            UsernameTextBox.Text = string.Empty;

            PasswordTextBox.Text = string.Empty;

            username = string.Empty;

            password = string.Empty;

            Details.AdminName = string.Empty;
        }


        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text != string.Empty)
            {
                UsernameErrorProvider.Clear();
            }
            else
            {
                UsernameErrorProvider.SetError(UsernameTextBox, "Username Required");
            }
        }


        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if(PasswordTextBox.Text != string.Empty)
            {
                PasswordErrorProvider.Clear();
            }
            else
            {
                PasswordErrorProvider.SetError(PasswordTextBox, "Password Required");
            }
        }

        #endregion


        #region Login Form Button Click Events


        private void LoginSimpleButton_Click(object sender, EventArgs e)
        {
            username = UsernameTextBox.Text;

            password = PasswordTextBox.Text;

            using (SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString))
            {
                using (SqlCommand command = new SqlCommand("AUTHENTICATE_ADMIN"))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@username", username);

                    command.Parameters.AddWithValue("@password", password);

                    command.Connection = connection;

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();

                    AdminID = Convert.ToInt32(reader["AdminID"]);

                    Details.AdminName = reader["FirstName"].ToString();

                    connection.Close();
                }
                switch (AdminID)
                {
                    case -1:
                        MessageBox.Show("Invalid Username Or Password", "Authentication Failed", MessageBoxButtons.OK);
                        clear();
                        break;
                    default:
                        clear();
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                        break;
                }
            }
        }

        private void CancelSimpleButton_Click(object sender, EventArgs e)
        {
            clear();
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }


        #endregion

    }
}
