using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsLicenseData
    {
        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, CreatedByUserID) " +
                           "OUTPUT INSERTED.LicenseID " +
                           "VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @CreatedByUserID);" +
                           "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
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
                throw new Exception("Error adding new license: " + ex.Message, ex);
            }
        }


        public static bool IsHasLicensebyAppID(int appID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(*) FROM Licenses WHERE ApplicationID = @appID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@appID", appID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking license by application ID: " + ex.Message, ex);
            }
        }


        public static bool DeleteLicense(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "DELETE FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting license: " + ex.Message, ex);
            }
        }


        public static DataTable GetLicenseInfo(string SearchFor, int id)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT 
                    CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName, ' ', People.LastName) AS FullName,
                    People.NationalNo,
                    case
		                when People.Gendor = 0 then 'Male'
		                when People.Gendor = 1 then 'Female'
		                else 'Unknown' end as Gendor,
                    People.ImagePath,
                    Licenses.LicenseID,
                    Licenses.ApplicationID,
                    Licenses.LicenseClass,
                    Licenses.IssueDate,
                    Licenses.ExpirationDate,
                    Licenses.IsActive,
                    Licenses.Notes,
                    Licenses.DriverID
                FROM People
                JOIN Applications ON People.PersonID = Applications.ApplicantPersonID
                JOIN Licenses ON Applications.ApplicationID = Licenses.ApplicationID
                WHERE "+ SearchFor +" = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", id);
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
                throw new Exception("Error getting license info by application ID: " + ex.Message, ex);
            }
        }

        public static int GetPersonIDFromLicenseID(int licenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT 
                    People.PersonID
                FROM People
                INNER JOIN Drivers ON People.PersonID = Drivers.PersonID
                INNER JOIN Licenses ON Licenses.DriverID = Drivers.DriverID
                WHERE Licenses.LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && int.TryParse(result.ToString(), out int personID))
                    return personID;
                else
                    return -1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving PersonID from LicenseID: " + ex.Message, ex);
            }
        }



        public static DataTable GetLicenseHistorybyAppID(int appID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT 
                    LicenseID, 
                    CASE 
                        WHEN LicenseClass = 1 THEN 'Class 1 - Small Motorcycle'
                        WHEN LicenseClass = 2 THEN 'Class 2 - Heavy Motorcycle License'
                        WHEN LicenseClass = 3 THEN 'Class 3 - Ordinary driving license'
                        WHEN LicenseClass = 4 THEN 'Class 4 - Commercial'
                        WHEN LicenseClass = 5 THEN 'Class 5 - Agricultural'
                        WHEN LicenseClass = 6 THEN 'Class 6 - Small and medium bus'
                        WHEN LicenseClass = 7 THEN 'Class 7 - Truck and heavy vehicle'
                        ELSE 'Unknown Class'
                    END AS LicenseClass,
                    ExpirationDate, 
                    IsActive
                FROM Licenses
                WHERE Licenses.ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", appID);
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
                throw new Exception("Error getting license history by application ID: " + ex.Message, ex);
            }
        }


        public static DataTable GetAllLicensebyPersonID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT 
                    LicenseID, 
                    CASE 
                        WHEN LicenseClass = 1 THEN 'Class 1 - Small Motorcycle'
                        WHEN LicenseClass = 2 THEN 'Class 2 - Heavy Motorcycle License'
                        WHEN LicenseClass = 3 THEN 'Class 3 - Ordinary driving license'
                        WHEN LicenseClass = 4 THEN 'Class 4 - Commercial'
                        WHEN LicenseClass = 5 THEN 'Class 5 - Agricultural'
                        WHEN LicenseClass = 6 THEN 'Class 6 - Small and medium bus'
                        WHEN LicenseClass = 7 THEN 'Class 7 - Truck and heavy vehicle'
                        ELSE 'Unknown Class'
                    END AS LicenseClass,
                    ExpirationDate, 
                    IsActive
                FROM Licenses 
                INNER JOIN Drivers ON Licenses.DriverID = Drivers.DriverID
                INNER JOIN People ON Drivers.PersonID = People.PersonID
                WHERE People.PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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
                throw new Exception("Error getting license history by application ID: " + ex.Message, ex);
            }
        }


        public static bool IsLicenseFound(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(*) FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking license by license ID: " + ex.Message, ex);
            }
        }


        public static bool IsLicenseActive(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT IsActive FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && bool.TryParse(result.ToString(), out bool isActive))
                    return isActive;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if license is active: " + ex.Message, ex);
            }
        }


        public static int GetLDLfromLicenseID(int licenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT 
                    LocalDrivingLicenseApplicationID
                FROM Licenses
                INNER JOIN LocalDrivingLicenseApplications ON Licenses.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                WHERE Licenses.LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", licenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && int.TryParse(result.ToString(), out int localDrivingLicenseApplicationID))
                    return localDrivingLicenseApplicationID;
                else
                    return -1;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving Local Driving License Application ID: " + ex.Message, ex);
            }
        }


        public static bool IsLicenseEligibleForRenewal(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT 
                    CASE 
                        WHEN l.ExpirationDate < GETDATE() THEN 1
                        ELSE 0
                    END AS IsEligibleForRenewal
                FROM Licenses l
                WHERE l.LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && int.TryParse(result.ToString(), out int isEligible))
                    return isEligible == 1;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if license is eligible for renewal: " + ex.Message, ex);
            }
        }



    }
}
