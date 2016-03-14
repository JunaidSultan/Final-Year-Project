using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

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
                command.CommandText = "INSERT INTO USERDETAILS()";
                command.Parameters.AddWithValue("@FD", Details.FirstName);
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
