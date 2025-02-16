using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsUserData
    {

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT " +
                "Users.UserID, " +
                "Users.PersonID, " +
                "CONCAT(People.FirstName, ' ', People.SecondName, ' ', People.ThirdName, ' ', People.LastName) AS FullName, " +
                "Users.UserName, " +
                "Users.IsActive " +
                "FROM Users " +
                "INNER JOIN People ON Users.PersonID = People.PersonID;";
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
                throw new Exception("Error retrieving user data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static int AddNewUser(int PersonID, string userName, string password, bool isActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "INSERT INTO Users (PersonID, UserName, Password, IsActive) " +
                "VALUES (@PersonID, @UserName, @Password, @IsActive); " +
                "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);
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
                throw new Exception("Error adding new person: " + ex.Message, ex);
            }
        }


        public static bool DeleteUser(int userID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "DELETE FROM Users WHERE UserID = @UserID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", userID);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting user: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


        public static bool UpdateUser(int userID, string userName, string password, bool isActive)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "UPDATE Users SET " +
                "UserName = @UserName, " +
                "Password = @Password, " +
                "IsActive = @IsActive " +
                "WHERE UserID = @UserID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@UserID", userID);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating user: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


        public static bool IsUserExistByUserName(string userName)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", userName);
            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


        public static bool IsUserExistByUserID(int userID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", userID);
            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static bool IsUserExistByNationalNo(string NationalNo)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE PersonID = " +
                "(SELECT PersonID FROM People WHERE NationalNo = @NationalNo);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


        public static DataTable GetUserByUserID(int userID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select * from Users where UserID = @UserID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", userID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving user data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static DataTable GetUsersByFilter(string query)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
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
                throw new Exception("Error retrieving people data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static bool IsPersonHasUserByPersonID(int PersonID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE PersonID = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


        public static bool IsPersonHasUserByNationalNo(string NationalNo)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE PersonID = " +
                "(SELECT PersonID FROM People WHERE NationalNo = @NationalNo);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static bool IsUserNameUsed(string UserName)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


        public static bool IsUserActive(string UserName)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT IsActive FROM Users WHERE UserName = @UserName;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                result = Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public static bool Login(string UserName, string Password)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName AND Password = @Password;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


        public static int GetUserIDbyUserName(string UserName)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT UserID FROM Users WHERE UserName = @UserName;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return result;
        }


        public static bool IsCorrectPass(int UserID, string Pass)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID AND Password = @Password;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Pass);
            try
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public static bool UpdatePassword(int UserID, string Pass)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Pass);
            try
            {
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking user existence: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }


        
    }
}
