using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsTestAppointmentsData
    {
        public static DataTable GetTestAppointments()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = "select TestAppointmentID, AppointmentDate, PaidFees, IsLocked from TestAppointments";
            SqlCommand command = new SqlCommand(sql, connection);
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

        public static DataTable GetTestAppointmentsByApplicationID(int applicationID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = "select TestAppointmentID, AppointmentDate, PaidFees, IsLocked from TestAppointments where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", applicationID);
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

        public static DataTable GetTestAppointmentsByType(int LDLid, int TestType)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = "select TestAppointmentID, AppointmentDate, PaidFees, IsLocked from TestAppointments where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLid);
            command.Parameters.AddWithValue("@TestTypeID", TestType);
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

        public static bool IsEligibleToMakeNewAppo(int LDLid, int type)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = @"
                    SELECT TOP 1
                        Tests.TestResult
                    FROM 
                        TestAppointments
                    JOIN 
                        Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                    WHERE 
                        TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                        AND TestAppointments.TestTypeID = @TestTypeID
                    ORDER BY 
                    TestAppointments.AppointmentDate DESC;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLid);
            command.Parameters.AddWithValue("@TestTypeID", type);
            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null && Convert.ToInt32(result) == 0)
                    return true;

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if eligible to make new appointment: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }

        }

        public static int GetAppoIDByLDLid(int LDLid)
        {
            int appoid = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = @"
                SELECT 
                    TestAppointments.TestAppointmentID
                FROM 
                    TestAppointments
                WHERE 
                TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLid);
            try
            {
                connection.Open();
                appoid = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving appointment ID: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return appoid;
        }

        public static bool ChangeToLocked(int testAppointmentID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = "UPDATE TestAppointments SET IsLocked = 1 WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error changing test appointment to locked: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }



        public static int GetAppIDByLDLid(int LDLid)
        {
            int appID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = @"
                SELECT 
                    Applications.ApplicationID
                FROM 
                    Applications 
                INNER JOIN 
                    LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                WHERE 
                LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLid);
            try
            {
                connection.Open();
                appID = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving application ID: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return appID;
        }



        public static int GetLDLidByAppID(int AppID)
        {
            int id = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = @"
                        SELECT 
                            LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                        FROM 
                            Applications 
                        INNER JOIN 
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                        WHERE 
                        Applications.ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ApplicationID", AppID);
            try
            {
                connection.Open();
                id = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving application ID: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return id;

        }


        public static int AddNewAppointment(int LDLid, DateTime appointmentDate, decimal paidFees, bool isLocked, int testTypeID, int CreatedByUserID, int? RetakeTestApplicationID)
        {
            int newAppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = @"
                INSERT INTO TestAppointments (LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, IsLocked, TestTypeID, CreatedByUserID, RetakeTestApplicationID)
                VALUES (@LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @IsLocked, @TestTypeID, @CreatedByUserID, @RetakeTestApplicationID);
                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLid);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@IsLocked", isLocked);
            command.Parameters.AddWithValue("@TestTypeID", testTypeID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID ?? (object)DBNull.Value);
            try
            {
                connection.Open();
                newAppointmentID = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new appointment: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return newAppointmentID;
        }


        public static decimal GetFeesbyAppoID(int appointmentID)
        {
            decimal newAppointmentID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = @"
                SELECT 
                    TestAppointments.PaidFees
                FROM 
                    TestAppointments
                WHERE 
                    TestAppointments.TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", appointmentID);
            try
            {
                connection.Open();
                newAppointmentID = Convert.ToDecimal(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving fees: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return newAppointmentID;

        }
    }
}
