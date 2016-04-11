using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace HandVeinPattern
{
    public class AdminIDGeneration
    {
        static int count;

        public static void IDCount()
        {
            SqlConnection connection = new SqlConnection(HandVeinPattern.Properties.Settings.Default.HandVeinPatternConnectionString);

            SqlCommand command = new SqlCommand();

            connection.Open();

            try
            {
                command = connection.CreateCommand();

                command.CommandText = "SELECT COUNT(AdminID) AS COUNT FROM AdminLogin";

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();

                count = Convert.ToInt32(reader["COUNT"]);
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

        public static void autogenerateID()
        {
            IDCount();

            string ID;

            int id_number;

            id_number = count + 1;

            ID = string.Format("ADMIN-{0}-{1}-{2}-{3}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, id_number);

            Details.AdminID = ID;
        }
    }
}
