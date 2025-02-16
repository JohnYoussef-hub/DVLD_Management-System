using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDriverData
    {
        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT 
                    Drivers.DriverID,
                    Licenses.LicenseID,
                    (FirstName + ' ' + SecondName + ' ' + ThirdName + ' ' + LastName) AS 'Full Name',
                    IssueDate,
                    Drivers.CreatedByUserID
                FROM Drivers
                INNER JOIN People ON Drivers.PersonID = People.PersonID
                INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving driver data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static DataTable GetDataByFilter(string ByWhat, string Filter)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT " +
                "DriverID, " +
                "PersonID, " +
                "CreatedByUserID, " +
                "CreatedDate " +
                "FROM Drivers WHERE " + ByWhat + " = '" + Filter + "';";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving driver data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static int AddNewDriver(int personID, DateTime dt, int createdByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate) " +
                           "OUTPUT INSERTED.DriverID " +
                           "VALUES (@PersonID, @CreatedByUserID, @CreatedDate);" +
                           "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@CreatedDate", dt);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && int.TryParse(result.ToString(), out int insertedID)) return insertedID;
                else return -1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new driver: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public static bool DeleteDriver(int DriverID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "DELETE FROM Drivers WHERE DriverID = @DriverID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting driver: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static int GetAppIDFromDriverID(int driverID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                  select ApplicationID from Licenses where DriverID = @DriverID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", driverID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && int.TryParse(result.ToString(), out int applicationID))
                    return applicationID;
                else
                    return -1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving application ID from driver ID: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
