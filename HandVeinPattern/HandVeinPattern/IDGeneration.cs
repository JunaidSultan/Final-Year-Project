using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandVeinPattern
{
    public class IDGeneration
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

                command.CommandText = "SELECT COUNT(ID) AS COUNT FROM USERS";

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
            
            ID = string.Format("USR-{0}-{1}-{2}-{3}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, id_number);
            
            Details.ID = ID;
        }
    }
}
