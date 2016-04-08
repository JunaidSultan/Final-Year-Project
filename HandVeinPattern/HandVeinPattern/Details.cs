using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandVeinPattern
{
    static class Details
    {
        //Hand Image Property Region

        #region Hand Image Variables

        public static string imagefilepath { get; set; }

        public static Mat sourceimagehand { get; set; }

        public static Mat destinationimagehand { get; set; }

        public static Mat whitebalance { get; set; }

        public static Mat adaptivethreshold { get; set; }

        public static Mat maskedimage { get; set; }

        public static Mat erode_step1 { get; set; }

        public static Mat erode_step2 { get; set; }

        public static Mat laplacian { get; set; }

        public static Mat multipliedimage { get; set; }

        public static Mat thinnedimage { get; set; }

        #endregion

        //User Registration Property Region

        #region User Registration

        public static string userimagefilepath { get; set; }

        public static string ID { get; set; }

        public static Image Faceimage { get; set; }

        public static string FirstName { get; set; }

        public static string LastName { get; set; }

        public static string Prefix { get; set; }

        public static string Title { get; set; }

        public static string Gender { get; set; }

        public static string Address { get; set; }

        public static string City { get; set; }

        public static string State { get; set; }

        public static string Country { get; set; }

        public static string HomePhone { get; set; }

        public static string MobilePhone { get; set; }

        public static string OfficePhone { get; set; }

        public static string Fax { get; set; }

        public static string Email { get; set; }

        public static string Website { get; set; }

        public static DateTime DOB { get; set; }

        public static string AdditionalNotes { get; set; }

        #endregion

        //Admin Registration Property Region

        #region Admin Registrarion

        public static string adminimagefilepath { get; set; }

        #endregion

        //File Stream Property Region

        #region File Stream

        public static FileStream _handpicture { get; set; }

        public static FileStream _facepicture { get; set; }

        public static byte _handpicturebyte { get; set; }

        public static byte _facepicturebyte { get; set; }

        #endregion

        //Step Images View Property Region

        #region Step Images Views

        public static Image stepimage { get; set; }

        public static string imagelabel { get; set; }

        #endregion

        //Methods For Forms

        #region Methods

        public static void cleardatabaseentry()
        {
            _handpicture = null;
            _facepicture = null;
        }

        //Clears All Properties

        public static void cleardetails()
        {
            FirstName = string.Empty;

            LastName = string.Empty;

            Prefix = string.Empty;

            Title = string.Empty;

            Gender = string.Empty;

            Address = string.Empty;

            City = string.Empty;

            State = string.Empty;

            Country = string.Empty;

            HomePhone = string.Empty;

            MobilePhone = string.Empty;

            OfficePhone = string.Empty;

            Fax = string.Empty;

            Email = string.Empty;

            Website = string.Empty;

            //DOB = DateTime.Now;

            AdditionalNotes = string.Empty;

        }

        #endregion


        #region ProgressBar

        public static int progressbar_value { get; set; }

        #endregion

    }
}
