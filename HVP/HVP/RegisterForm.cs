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
    }
}
