using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsInternationalDrivingLicenseAppData
    {

        public static DataTable GetAllInternationalLicenses()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT InternationalLicenseID, DriverID, IssuedUsingLocalLicenseID as LocalLicenseID, ExpirationDate, IsActive FROM InternationalLicenses";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving all international licenses: " + ex.Message, ex);
            }
        }


        public static bool IsLDLhasIDL(int LDLid)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "  select count(*) from InternationalLicenses where IssuedUsingLocalLicenseID = @LDLid";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLid", LDLid);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();
                found = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if LDL has IDL: " + ex.Message, ex);
            }
            return found;
        }




        public static int AddNewInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) " +
                           "OUTPUT INSERTED.InternationalLicenseID " +
                           "VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);" +
                           "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    return insertedID;
                else
                    return -1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new international license: " + ex.Message, ex);
            }
        }


        public static DataTable GetSomeInfoFromLicense(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT ApplicationID, DriverID, LicenseID FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving some info from license: " + ex.Message, ex);
            }
        }


        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting international license: " + ex.Message, ex);
            }
        }

        public static bool IsActive(int InternationalLicenseID)
        {
            bool isActive = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT IsActive FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();
                if (result != null && bool.TryParse(result.ToString(), out bool activeStatus))
                {
                    isActive = activeStatus;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if international license is active: " + ex.Message, ex);
            }
            return isActive;
        }



    }
}

