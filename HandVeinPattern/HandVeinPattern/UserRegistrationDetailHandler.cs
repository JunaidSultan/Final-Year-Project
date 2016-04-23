using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandVeinPattern
{
    public static class UserRegistrationDetailHandler
    {
        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();

            stream.Close();

            return photo;
        }

        public static void recordentry()
        {
            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                byte[] photo = GetPhoto(Details.UserImageFilePath);

                command = connection.CreateCommand();

                command.CommandText = "INSERT INTO USERDETAILS(ID, IMAGE, FIRSTNAME, LASTNAME, PREFIX, TITLE, GENDER, ADDRESS, CITY, STATE, COUNTRY, HOMEPHONE, MOBILEPHONE, OFFICEPHONE, FAX, EMAIL, WEBSITE, DOB, ADDITIONALNOTES) VALUES(@ID, @IMAGE, @FN, @LN, @PF, @TITLE, @GEN, @ADD, @CITY, @STATE, @COUNTRY, @HP, @MP, @OP, @FAX, @EM, @SKYPE, @WEB, @DOB, @AN)";

                command.Parameters.AddWithValue("@ID", Details.ID);

                command.Parameters.Add("@IMAGE", SqlDbType.Image, photo.Length).Value = photo;

                command.Parameters.AddWithValue("@FN", Details.FirstName);

                command.Parameters.AddWithValue("@LN", Details.LastName);

                command.Parameters.AddWithValue("@PF", Details.Prefix);

                command.Parameters.AddWithValue("@TITLE", Details.Title);

                command.Parameters.AddWithValue("@GEN", Details.Gender);

                command.Parameters.AddWithValue("@ADD", Details.Address);

                command.Parameters.AddWithValue("@CITY", Details.City);

                command.Parameters.AddWithValue("@STATE", Details.State);

                command.Parameters.AddWithValue("@COUNTRY", Details.Country);

                command.Parameters.AddWithValue("@HP", Details.HomePhone);

                command.Parameters.AddWithValue("@MP", Details.MobilePhone);

                command.Parameters.AddWithValue("@OP", Details.OfficePhone);

                command.Parameters.AddWithValue("@FAX", Details.Fax);

                command.Parameters.AddWithValue("@WEB", Details.Website);

                command.Parameters.AddWithValue("@DOB", Details.DOB);

                command.Parameters.AddWithValue("@AN", Details.AdditionalNotes);
                
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static void featuresentry()
        {
            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                for (int i = 0; i < Details.modelKeyPoints.Size; i++)
                {
                    command = connection.CreateCommand();

                    command.CommandText = "INSERT INTO FEATURES(UserID, Angle, ClassID, Octave, PointX, PointY, Response, Size) VALUES(@UserID, @Angle, @ClassID, @Octave, @PointX, @PointY, @Response, @Size)";

                    command.Parameters.AddWithValue("@UserID", Details.ID);

                    command.Parameters.AddWithValue("@Angle", Convert.ToDouble(Details.modelKeyPoints[i].Angle));

                    command.Parameters.AddWithValue("@ClassID", Convert.ToDouble(Details.modelKeyPoints[i].ClassId));

                    command.Parameters.AddWithValue("@Octave", Convert.ToDouble(Details.modelKeyPoints[i].Octave));

                    command.Parameters.AddWithValue("@PointX", Convert.ToDouble(Details.modelKeyPoints[i].Point.X));

                    command.Parameters.AddWithValue("@PointY", Convert.ToDouble(Details.modelKeyPoints[i].Point.Y));

                    command.Parameters.AddWithValue("@Response", Convert.ToDouble(Details.modelKeyPoints[i].Response));

                    command.Parameters.AddWithValue("@Size", Convert.ToDouble(Details.modelKeyPoints[i].Size));

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
