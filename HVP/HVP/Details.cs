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

        #endregion
    }
}
