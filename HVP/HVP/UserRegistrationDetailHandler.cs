using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVP
{
    public static class UserRegistrationDetailHandler
    {
        public static void recordentry()
        {
            SqlConnection connecion = new SqlConnection(HVP.Properties.Settings.Default.HandVeinPatternConnectionString);
            SqlCommand command = new SqlCommand();
            connecion.Open();
            try
            {
                command = connecion.CreateCommand();

                command.CommandText = "INSERT INTO USERDETAILS(ID, IMAGE, FIRSTNAME, LASTNAME, PREFIX, TITLE, GENDER, ADDRESS, CITY, STATE, COUNTRY, HOMEPHONE, MOBILEPHONE, OFFICEPHONE, FAX, EMAIL, WEBSITE, DOB, ADDITIONALNOTES) VALUES(@ID, @IMAGE, @FN, @LN, @PF, @TITLE, @GEN, @ADD, @CITY, @STATE, @COUNTRY, @HP, @MP, @OP, @FAX, @EM, @SKYPE, @WEB, @DOB, @AN)";

                command.Parameters.AddWithValue("@ID", Details.ID);

                command.Parameters.AddWithValue("@IMAGE", Details._facepicture);

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
                if (connecion.State == ConnectionState.Open)
                {
                    connecion.Close();
                }
            }
        }
    }
}
