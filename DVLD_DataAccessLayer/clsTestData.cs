using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestData
    {


        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int newTestID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = @"
                INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                newTestID = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new test: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return newTestID;
        }


        

    }
}
