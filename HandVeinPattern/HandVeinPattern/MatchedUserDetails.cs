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
    public partial class MatchedUserDetails : Form
    {
        public MatchedUserDetails()
        {
            InitializeComponent();

            MatchedUserImagePictureEdit.ContextMenu = new ContextMenu();

            displayResults();
        }

        // Function To Diplay The Results Of Current User From The Database.

        void displayResults()
        {
            byte[] photo_array;
            
            //  Displays The Matched Results

            UserDetailsGroupControl.Text = Details.matchedUserDetails.Rows[0].Field<string>(0).ToString();

            if (Details.matchedUserDetails.Rows[0]["Image"] != DBNull.Value)
            {
                photo_array = (byte[])Details.matchedUserDetails.Rows[0]["Image"];

                MemoryStream memorystream = new MemoryStream(photo_array);

                MatchedUserImagePictureEdit.Image = Image.FromStream(memorystream);
            }

            FirstNameResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("FirstName").ToString();

            LastNameResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("LastName").ToString();

            PrefixResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("Prefix").ToString();

            GenderResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("Gender").ToString();

            AddressResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("Address").ToString();

            CityResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("City").ToString();

            StateResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("State").ToString();

            CountryResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("Country").ToString();

            HomePhoneResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("HomePhone").ToString();

            MobilePhoneResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("MobilePhone").ToString();

            OfficePhoneResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("OfficePhone").ToString();

            FaxResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("Fax").ToString();

            EmailResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("Email").ToString();

            WebsiteResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<string>("Website").ToString();

            DOBResultLabel.Text = Details.matchedUserDetails.Rows[0].Field<DateTime>("DOB").Date.ToString();

            AdditionalNotesRichTextBox.Text = Details.matchedUserDetails.Rows[0].Field<string>("AdditionalNotes").ToString();
        }
    }
}
