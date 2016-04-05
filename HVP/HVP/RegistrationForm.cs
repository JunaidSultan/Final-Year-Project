using DevExpress.XtraEditors.Camera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HVP
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            Clipboard.Clear();      //Image Copy Context Menu

            errorprovider();        //Error Provider Function
        }

        #region Context Menu Strip Click Events

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPictureEdit.Image = Clipboard.GetImage();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadimage = new OpenFileDialog();
            if (loadimage.ShowDialog() == DialogResult.OK)
            {
                UserPictureEdit.Image = Image.FromFile(loadimage.FileName);
            }
        }

        private void CameraCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakePictureDialog _cameraCapture = new TakePictureDialog();
            if (_cameraCapture.ShowDialog() == DialogResult.OK)
            {
                UserPictureEdit.Image = _cameraCapture.Image;
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPictureEdit.Image = HVP.Properties.Resources.noprofile;
        }

        private void PictureEditContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                PasteToolStripMenuItem.Enabled = true;
            }
            else
            {
                PasteToolStripMenuItem.Enabled = false;
            }
        }

        #endregion


        #region Error Provider

        private void errorprovider()
        {
            if (FirstNameTextBox.Text == string.Empty)
            {
                FirstNameErrorProvider.SetError(FirstNameTextBox, "First Name Required");
            }

            if (LastNameTextBox.Text == string.Empty)
            {
                LastNameErrorProvider.SetError(LastNameTextBox, "Last Name Required");
            }

            if (TitleTextBox.Text == string.Empty)
            {
                TitleErrorProvider.SetError(TitleTextBox, "Title Required");
            }

            if (GenderComboBoxEdit.SelectedIndex == 0)
            {
                GenderErrorProvider.SetError(GenderComboBoxEdit, "Gender Required");
            }

            if (DOBDateEdit.DateTime.ToString() == string.Empty)
            {
                DOBErrorProvider.SetError(DOBDateEdit, "DOB Required");
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
                FirstNameErrorProvider.SetError(LastNameTextBox, "Last Name Required");
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TitleTextBox.Text != string.Empty)
            {
                TitleErrorProvider.Clear();
            }
            else
            {
                TitleErrorProvider.SetError(LastNameTextBox, "Title Required");
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

        private void DOBDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (DOBDateEdit.DateTime.ToString() != string.Empty)
            {
                DOBErrorProvider.Clear();
            }
            else
            {
                DOBErrorProvider.SetError(DOBDateEdit, "DOB Required");
            }
        }

        #endregion


        #region Registration Click Events

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //Details.ID =

            //Details._facepicture = facepicture();

            Details.FirstName = FirstNameTextBox.Text;

            Details.LastName = LastNameTextBox.Text;

            Details.Prefix = PrefixComboBoxEdit.SelectedItem.ToString();

            Details.Title = TitleTextBox.Text;

            Details.Gender = GenderComboBoxEdit.SelectedItem.ToString();

            Details.Address = AddressTextBox.Text;

            Details.City = CityTextBox.Text;

            Details.State = StateTextBox.Text;

            Details.Country = CountryComboBoxEdit.SelectedItem.ToString();

            Details.HomePhone = HomePhoneButtonEdit.Text;

            Details.MobilePhone = MobilePhoneButtonEdit.Text;

            Details.OfficePhone = OfficePhoneButtonEdit.Text;

            Details.Fax = FaxButtonEdit.Text;

            Details.Email = EmailButtonEdit.Text;

            Details.Website = WebsiteButtonEdit.Text;

            Details.DOB = Convert.ToDateTime(DOBDateEdit.Text).Date;

            Details.AdditionalNotes = AdditionalNotesRichTextBox.Text;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            formreset();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Run(new MainForm());
            this.Close();
        }

        private void AdditionalNotesRichTextBox_TextChanged(object sender, EventArgs e)
        {
            AdditionalNotesLabel.Visible = false;
        }

        #endregion


        #region Form Methods

        private void formreset()
        {
            FirstNameTextBox.Text = string.Empty;

            LastNameTextBox.Text = string.Empty;

            PrefixComboBoxEdit.SelectedIndex = 0;

            TitleTextBox.Text = string.Empty;

            GenderComboBoxEdit.SelectedIndex = 0;

            AddressTextBox.Text = string.Empty;

            CityTextBox.Text = string.Empty;

            StateTextBox.Text = string.Empty;

            CountryComboBoxEdit.SelectedIndex = 0;

            HomePhoneButtonEdit.Text = string.Empty;

            MobilePhoneButtonEdit.Text = string.Empty;

            OfficePhoneButtonEdit.Text = string.Empty;

            FaxButtonEdit.Text = string.Empty;

            EmailButtonEdit.Text = string.Empty;

            WebsiteButtonEdit.Text = string.Empty;

            DOBDateEdit.Text = string.Empty;

            AdditionalNotesRichTextBox.Text = string.Empty;

            AdditionalNotesLabel.Visible = true;

            Details.cleardetails();

        }

        #endregion       

    }
}
