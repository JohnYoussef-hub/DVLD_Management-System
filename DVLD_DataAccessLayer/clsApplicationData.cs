using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsApplicationData
    {
        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                select 
                ApplicationID as 'AppID',
                    CASE 
                        WHEN ApplicationTypeID = 1 THEN 'Class 1 - Small Motorcycle'
                        WHEN ApplicationTypeID = 2 THEN 'Class 2 - Heavy Motorcycle License'
                        WHEN ApplicationTypeID = 3 THEN 'Class 3 - Ordinary driving license'
                        WHEN ApplicationTypeID = 4 THEN 'Class 4 - Commercial'
                        WHEN ApplicationTypeID = 5 THEN 'Class 5 - Agricultural'
                        WHEN ApplicationTypeID = 6 THEN 'Class 6 - Small and medium bus'
                        WHEN ApplicationTypeID = 7 THEN 'Class 7 - Truck and heavy vehicle'
                        ELSE 'Unknown Class' 
                    END AS 'Driving Class',
                    NationalNo as 'National No.',
                    (FirstName+' '+SecondName+' '+ThirdName+' '+LastName) as 'Full Name',
                    ApplicationDate,
                    PassedTests as 'Passed Tests',
                    case
                    when ApplicationStatus = 1 then 'New'
                    when ApplicationStatus = 2 then 'Cancelled'
                    when ApplicationStatus = 3 or PassedTests = 3 then 'Completed'
                    else 'Unknown'
                    end as 'Status'
                from Applications 
                inner join People on ApplicantPersonID = People.PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving application data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool UpdatePassedTests(int applicationId)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                UPDATE Applications
                SET PassedTests = PassedTests + 1
                WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating PassedTests: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public static bool UpdateValue(int applicationId, string fieldName, object newValue)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = $@"
                UPDATE Applications
                SET {fieldName} = @NewValue
                WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewValue", newValue);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating {fieldName}: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateApplication(int applicationId, int applicantPersonID, int applicationTypeID, DateTime applicationDate, int applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID, int passedTests)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
        UPDATE Applications
        SET ApplicantPersonID = @ApplicantPersonID,
            ApplicationTypeID = @ApplicationTypeID,
            ApplicationDate = @ApplicationDate,
            ApplicationStatus = @ApplicationStatus,
            LastStatusDate = @LastStatusDate,
            PaidFees = @PaidFees,
            CreatedByUserID = @CreatedByUserID,
            PassedTests = @PassedTests
        WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
            command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
            command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@PassedTests", passedTests);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating application: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public static int AddApplication(int applicantPersonID, int applicationTypeID, DateTime applicationDate, int applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID, int passedTests)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                INSERT INTO Applications 
                (ApplicantPersonID, ApplicationTypeID, ApplicationDate, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID, PassedTests) 
                VALUES 
                (@ApplicantPersonID, @ApplicationTypeID, @ApplicationDate, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID, @PassedTests);
                select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
            command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
            command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@PassedTests", passedTests);
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
                throw new Exception("Error adding application: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public static bool DeleteApplication(int applicationId)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                DELETE FROM Applications
                WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting application: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool GetApplicationByID(int applicationId, ref int applicantPersonID, ref int applicationTypeID, ref DateTime applicationDate, ref int applicationStatus, ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID, ref int passedTests)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT *
                FROM Applications
                WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    applicantPersonID = (int)reader["ApplicantPersonID"];
                    applicationTypeID = (int)reader["ApplicationTypeID"];
                    applicationDate = (DateTime)reader["ApplicationDate"];
                    applicationStatus = (byte)reader["ApplicationStatus"];
                    lastStatusDate = (DateTime)reader["LastStatusDate"];
                    paidFees = (decimal)reader["PaidFees"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    passedTests = (int)reader["PassedTests"];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving application by ID: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }


        }



        public static DataTable FilterTableWithNationalNo(string NationalNo)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
        select * from (SELECT 
            ApplicationID as 'L.D.L AppID',
            CASE 
                WHEN ApplicationTypeID = 1 THEN 'Class 1 - Small Motorcycle'
                WHEN ApplicationTypeID = 2 THEN 'Class 2 - Heavy Motorcycle License'
                WHEN ApplicationTypeID = 3 THEN 'Class 3 - Ordinary driving license'
                WHEN ApplicationTypeID = 4 THEN 'Class 4 - Commercial'
                WHEN ApplicationTypeID = 5 THEN 'Class 5 - Agricultural'
                WHEN ApplicationTypeID = 6 THEN 'Class 6 - Small and medium bus'
                WHEN ApplicationTypeID = 7 THEN 'Class 7 - Truck and heavy vehicle'
                ELSE 'Unknown Class' 
            END AS 'Driving Class',
            NationalNo as 'National No.',
            (FirstName+' '+SecondName+' '+ThirdName+' '+LastName) as 'Full Name',
            ApplicationDate,
            PassedTests as 'Passed Tests',
            CASE
                WHEN ApplicationStatus = 1 THEN 'New'
                WHEN ApplicationStatus = 2 THEN 'Cancelled'
                WHEN ApplicationStatus = 3 THEN 'Completed'
                ELSE 'Unknown'
            END as 'Status'
        FROM Applications 
        INNER JOIN People ON ApplicantPersonID = People.PersonID) as v
        WHERE [National No.] like '%' + @NationalNo + '%'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                throw new Exception("Error filtering application data by National No: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool IsEligibleToMakeNewApp(int PersonID, int typeID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT COUNT(*) FROM Applications
                WHERE ApplicantPersonID = @PersonID AND ApplicationTypeID = @TypeID AND (ApplicationStatus = 1 or ApplicationStatus = 3)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@TypeID", typeID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count == 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking eligibility to make new application: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }

        }

        public static bool CancelApplication(int applicationId)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                UPDATE Applications
                SET ApplicationStatus = 2
                WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error cancelling application: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public static string GetApplicantNameByID(int applicationId)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT (FirstName+' '+SecondName+' '+ThirdName+' '+LastName) as 'Full Name'
                FROM Applications 
                INNER JOIN People ON ApplicantPersonID = People.PersonID
                WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                return result?.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving applicant name by ID: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public static bool ChangeAppToCompleted(int applicationId)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                UPDATE Applications
                SET ApplicationStatus = 3
                WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error changing application status to completed: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public static int GetPersonIDbyAppID(int applicationId)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = @"
                SELECT ApplicantPersonID
                FROM Applications
                WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                return (int)result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving person ID by application ID: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
