using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsCountryData
    {

        public static string GetCountryNameByID(int CountryID)
        {
            string CountryName = "";
            //bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select * from Countries where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        CountryName = reader["CountryName"].ToString();
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving country data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return CountryName;
        }


        public static List<string> GetCountries()
        {
            List<string> Countries = new List<string>();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select * from Countries";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        Countries.Add(reader["CountryName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving countries data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return Countries;
        }




        public static int GetCountryIndexByName(string countryName)
        {
            int CountryID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select CountryID from Countries where CountryName = @CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", countryName);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    CountryID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving country data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return CountryID;
        }

    }
}
