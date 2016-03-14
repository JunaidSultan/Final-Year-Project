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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            Clipboard.Clear();

            errorprovider();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPictureEdit.Image = Clipboard.GetImage();
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

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadimage = new OpenFileDialog();
            if (loadimage.ShowDialog() == DialogResult.OK)
            {
                UserPictureEdit.Image = Image.FromFile(loadimage.FileName);
            }
        }

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

            if (DOBDateEdit.Text == string.Empty)
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

        private void DOBDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (DOBDateEdit.Text != string.Empty)
            {
                DOBErrorProvider.Clear();
            }
            else
            {
                DOBErrorProvider.SetError(DOBDateEdit, "DOB Required");
            }
        }

        #endregion

        private void AdditionalNotesRichTextBox_TextChanged(object sender, EventArgs e)
        {
            AdditionalNotesLabel.Visible = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

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

        #region Form Methods

        private void formreset()
        {
            FirstNameTextBox.Text = string.Empty;

            LastNameTextBox.Text = string.Empty;

            PrefixComboBoxEdit.SelectedIndex = 0;

            TitleTextBox.Text = string.Empty;

            AddressTextBox.Text = string.Empty;

            CityTextBox.Text = string.Empty;

            StateTextBox.Text = string.Empty;

            CountryComboBoxEdit.SelectedIndex = 0;

            HomePhoneTextBox.Text = string.Empty;

            MobilePhoneTextBox.Text = string.Empty;

            OfficePhoneTextBox.Text = string.Empty;

            FaxTextBox.Text = string.Empty;

            EmailTextBox.Text = string.Empty;

            SkypeTextBox.Text = string.Empty;

            WebsiteTextBox.Text = string.Empty;

            DOBDateEdit.Text = string.Empty;

            AdditionalNotesRichTextBox.Text = string.Empty;

            AdditionalNotesLabel.Visible = true;

            Details.cleardetails();

        }

        #endregion

    }
}
