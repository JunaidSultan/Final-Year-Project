using Emgu.CV;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

        public static Mat keypointsimage { get; set; }

        public static Mat processedimage { get; set; }

        public static VectorOfKeyPoint modelKeyPoints { get; set; }

        public static VectorOfKeyPoint matchedmodelKeyPoints { get; set; }

        public static Image DBImage { get; set; }

        #endregion

        //User Registration Property Region

        #region User Registration

        public static string UserImageFilePath { get; set; }

        public static string ProcessedHandImage { get; set; }

        public static string ID { get; set; }

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

        #region Admin Login & Registrarion 

        public static string AdminLoginID { get; set; }

        public static string AdminID { get; set; }

        public static string Username { get; set; }

        public static string Password { get; set; }

        public static string AdminFirstName { get; set; }

        public static string AdminLastName { get; set; }

        public static string AdminGender { get; set; }

        public static string AdminEmail { get; set; }

        public static string AdminImageFilePath { get; set; }

        #endregion

        //Matching Property Region
        
        #region Matching Variables

        public static string matchedID { get; set; }

        public static DataTable matchedUserDetails { get; set; }

        //public static DataTable matchedUserDetails;

        #endregion

        //Step Images View Property Region

        #region Step Images Views

        public static Image stepimage { get; set; }

        public static string imagelabel { get; set; }

        #endregion

        //Methods For Forms

        #region Methods

        //Clears User Regestration Properties

        public static void clear_user_details()
        {
            ID = string.Empty;

            UserImageFilePath = string.Empty;

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

            DOB = DateTime.Now;

            AdditionalNotes = string.Empty;

        }

        //Clears Admin Regesitration Properties

        public static void clear_admin_details()
        {
            AdminID = string.Empty;

            Username = string.Empty;

            Password = string.Empty;

            AdminFirstName = string.Empty;

            AdminLastName = string.Empty;

            AdminGender = string.Empty;

            AdminEmail = string.Empty;

            AdminImageFilePath = string.Empty;
        }

        #endregion

    }
}
