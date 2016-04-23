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
        static int count;   // Variable To Store The Total Number Of Administrators In The Database

        // Function To Count The Total Number Of Administrators In The Database

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

                count = Convert.ToInt32(reader["COUNT"]);   // Assigns The Value To The Variable 'Count' After Reading It From Database
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

        // Function For Creating An Administrator ID

        public static void autogenerateID()
        {
            IDCount();

            int id_number;

            id_number = count + 1;      // Increments The Current Count Of Administrators By 1 To Create A Next ID

            // Format For Creating An Administrator ID E.g. (ADMIN-20-11-2016-20)
            Details.AdminID = string.Format("ADMIN-{0}-{1}-{2}-{3}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, id_number); 
        }

    }
}
