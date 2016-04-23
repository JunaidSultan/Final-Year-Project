using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors.Camera;

namespace HandVeinPattern
{
    public partial class Register_Form__Admin_ : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string filepath;

        public Register_Form__Admin_()
        {
            InitializeComponent();

            Clipboard.Clear();

            errorprovider();

        }

        #region ID Generation Button Click Event

        private void GenerateIDSimpleButton_Click(object sender, EventArgs e)
        {
            AdminIDGeneration.autogenerateID();
            IDTextBox.Text = Details.AdminID;
        }

        #endregion


        #region Database Operations Button Click Events
 
        private void CreateBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Details.AdminID = IDTextBox.Text;

            Details.Username = UsernameTextBox.Text;

            Details.Password = PasswordTextBox.Text;

            Details.AdminFirstName = FirstNameTextBox.Text;

            Details.AdminLastName = LastNameTextBox.Text;

            Details.AdminGender = GenderComboBoxEdit.SelectedItem.ToString();

            Details.AdminEmail = EmailButtonEdit.Text;

            Details.AdminImageFilePath = filepath;

            AdminRegistrationDetailHandler.AdminLoginEntry();

            AdminRegistrationDetailHandler.AdminDetailsEntry();

            MessageBox.Show("Admin Added Successfully", "Result", MessageBoxButtons.OKCancel);
        }

        private void ResetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formreset();
        }

        private void CancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        #endregion


        #region Admin Image Picture Edit Context Menu Strip

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminImagePictureEdit.Image = Clipboard.GetImage();
        }

        private void CameraCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakePictureDialog _cameracapture = new TakePictureDialog();
            if (_cameracapture.ShowDialog() == DialogResult.OK)
            {
                AdminImagePictureEdit.Image = _cameracapture.Image;
            }
            AdminImagePictureEdit.Image = _cameracapture.Image;
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadimage = new OpenFileDialog();
            if (loadimage.ShowDialog() == DialogResult.OK)
            {
                AdminImagePictureEdit.Image = Image.FromFile(loadimage.FileName);
                filepath = loadimage.FileName;
            }
        }      

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminImagePictureEdit.Image = HandVeinPattern.Properties.Resources.noprofile;
        }

        #endregion


        #region Form Methods

        private void formreset()
        {
            IDTextBox.Text = string.Empty;

            UsernameTextBox.Text = string.Empty;

            PasswordTextBox.Text = string.Empty;

            FirstNameTextBox.Text = string.Empty;

            LastNameTextBox.Text = string.Empty;

            AdminImagePictureEdit.Image = HandVeinPattern.Properties.Resources.noprofile;

            GenderComboBoxEdit.SelectedIndex = 0;

            EmailButtonEdit.Text = string.Empty;

            Details.clear_admin_details();
        }

        #endregion


        #region Error Provider

        private void errorprovider()
        {
            if (AdminImagePictureEdit.Image == HandVeinPattern.Properties.Resources.noprofile)
            {
                ImageErrorProvider.SetError(AdminImagePictureEdit, "Admin Image Required");
            }

            if (IDTextBox.Text == string.Empty)
            {
                IDErrorProvider.SetError(IDTextBox, "Admin ID Required");
            }

            if (UsernameTextBox.Text == string.Empty)
            {
                UsernameErrorProvider.SetError(UsernameTextBox, "Username Required");
            }

            if (PasswordTextBox.Text == string.Empty)
            {
                PasswordErrorProvider.SetError(PasswordTextBox, "Password Required");
            }

            if (FirstNameTextBox.Text == string.Empty)
            {
                FirstNameErrorProvider.SetError(FirstNameTextBox, "First Name Required");
            }

            if (LastNameTextBox.Text == string.Empty)
            {
                LastNameErrorProvider.SetError(LastNameTextBox, "Last Name Required");
            }

            if (GenderComboBoxEdit.SelectedIndex == 0)
            {
                GenderErrorProvider.SetError(GenderComboBoxEdit, "Gender Required");
            }

            if (EmailButtonEdit.Text == string.Empty)
            {
                EmailErrorProvider.SetError(EmailButtonEdit, "Email Required");
            }
        }

        private void AdminImagePictureEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (AdminImagePictureEdit.Image != HandVeinPattern.Properties.Resources.noprofile)
            {
                ImageErrorProvider.Clear();
            }
            else
            {
                ImageErrorProvider.SetError(AdminImagePictureEdit, "Admin Image Required");
            }
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IDTextBox.Text != string.Empty)
            {
                IDErrorProvider.Clear();
            }
            else
            {
                IDErrorProvider.SetError(IDTextBox, "Admin ID Required");
            }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != string.Empty)
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
            if (PasswordTextBox.Text != string.Empty)
            {
                PasswordErrorProvider.Clear();
            }
            else
            {
                PasswordErrorProvider.SetError(PasswordTextBox, "Password Required");
            }
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text != string.Empty)
            {
                FirstNameErrorProvider.Clear();
            }
            else
            {
                FirstNameErrorProvider.SetError(FirstNameTextBox, "First Name Required");
            }
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text != string.Empty)
            {
                LastNameErrorProvider.Clear();
            }
            else
            {
                LastNameErrorProvider.SetError(LastNameTextBox, "Last Name Required");
            }
        }

        private void GenderComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenderComboBoxEdit.SelectedIndex != 0)
            {
                GenderErrorProvider.Clear();
            }
            else
            {
                GenderErrorProvider.SetError(GenderComboBoxEdit, "Gender Required");
            }
        }

        private void EmailButtonEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (EmailButtonEdit.Text != string.Empty)
            {
                EmailErrorProvider.Clear();
            }
            else
            {
                EmailErrorProvider.SetError(EmailButtonEdit, "Email Required");
            }
        }

        #endregion

    }
}
