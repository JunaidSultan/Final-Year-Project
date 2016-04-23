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
    public static class AdminRegistrationDetailHandler
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

        public static void AdminLoginEntry()
        {
            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;

                command.CommandText = "ADDADMIN";

                command.Parameters.AddWithValue("@ADMINID", Details.AdminID);

                command.Parameters.AddWithValue("@USERNAME", Details.Username);

                command.Parameters.AddWithValue("@PASSWORD", Details.Password);

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

        public static void AdminDetailsEntry()
        {
            SqlConnection connection =  new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                byte[] photo = GetPhoto(Details.AdminImageFilePath);

                command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;

                command.CommandText = "ADDADMINDETAILS";

                command.Parameters.AddWithValue("@ADMINID", Details.AdminID);

                command.Parameters.AddWithValue("@FIRSTNAME", Details.AdminFirstName);

                command.Parameters.AddWithValue("@LASTNAME", Details.AdminLastName);

                command.Parameters.Add("@IMAGE", SqlDbType.Image, photo.Length).Value = photo;

                command.Parameters.AddWithValue("@GENDER", Details.AdminGender);

                command.Parameters.AddWithValue("@EMAIL", Details.AdminEmail);

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

    }
}
