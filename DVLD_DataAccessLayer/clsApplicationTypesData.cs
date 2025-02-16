using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsApplicationTypesData
    {
        public static DataTable GetApplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select * from ApplicationTypes";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving application types data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static bool UpdateApplicationType(int appID, string Title, double Fees)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "update ApplicationTypes set ApplicationTypeTitle = @Title, ApplicationFees = @Fees where ApplicationTypeID = @appID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@appID", appID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating application type: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return res;
        }


        public static int GetApplicationType(int appID)
        {
            int res = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select ApplicationTypeID from Applications where ApplicationID = @appID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@appID", appID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    res = Convert.ToInt32(result.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving application type: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return res;
        }
    }
}
