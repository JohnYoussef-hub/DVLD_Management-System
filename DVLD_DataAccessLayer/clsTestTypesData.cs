
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestTypesData
    {
        public static DataTable GetTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select * from TestTypes";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving test types data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool UpdateTestType(int testID, string Title, string Description, double Fees)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "update TestTypes set TestTypeTitle = @Title, TestTypeDescription = @Description, TestTypeFees = @Fees where TestTypeID = @testID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@testID", testID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating test type: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return res;
        }

        public static decimal GetTestFees(int TestType)
        {
            decimal fees = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select TestTypeFees from TestTypes where TestTypeID = @TestType";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestType", TestType);

            try
            {
                connection.Open();
                fees = (decimal)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving test fees: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return fees;
        }
    }
}




