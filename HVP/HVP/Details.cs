using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.Util;
using Emgu.CV.Structure;

using System.Drawing;

namespace HVP
{
    static class Details
    {
        //Hand Image Property Region

        #region Hand Image Variables

        public static string imagefilepath { get; set; }

        public static Mat sourceimagehand { get; set; }

        public static Mat destinationimagehand { get; set; }

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

        public static string Address { get; set; }

        public static string City { get; set; }

        public static string State { get; set; }

        public static string Country { get; set; }

        public static string HomePhone { get; set; }

        public static string MobilePhone { get; set; }

        public static string OfficePhone { get; set; }

        public static string Fax { get; set; }

        public static string Email { get; set; }

        public static string Skype { get; set; }

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

            Address = string.Empty;

            City = string.Empty;

            State = string.Empty;

            Country = string.Empty;

            HomePhone = string.Empty;

            MobilePhone = string.Empty;

            OfficePhone = string.Empty;

            Fax = string.Empty;

            Email = string.Empty;

            Skype = string.Empty;

            Website = string.Empty;

            //DOB = DateTime.Now;

            AdditionalNotes = string.Empty;

        }

        #endregion

    }
}
