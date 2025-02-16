using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class clsPersonData
    {
        public static bool GetPersonByID(int PersonID, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref string NationalNo,
                ref int Gendor, ref string Email, ref string Address, ref DateTime DateOfBirth,
                ref string Phone, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select * from people where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.HasRows)
                    {

                        FirstName = reader["FirstName"].ToString();
                        SecondName = reader["SecondName"].ToString();
                        ThirdName = reader["ThirdName"].ToString();
                        LastName = reader["LastName"].ToString();
                        NationalNo = reader["NationalNo"].ToString();
                        Gendor = Convert.ToInt32(reader["Gendor"]);
                        Email = reader["Email"].ToString();
                        Address = reader["Address"].ToString();
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                        Phone = reader["Phone"].ToString();
                        NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);

                        if (reader["ImagePath"] != DBNull.Value)
                        {
                            ImagePath = reader["ImagePath"].ToString();
                        }
                        else ImagePath = "NULL";



                        IsFound = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving person data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }


        public static DataTable GetPersonByID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select * from people where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                reader.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving person data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
        }


        public static bool GetPersonByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
        ref string ThirdName, ref string LastName,
        ref int Gendor, ref string Email, ref string Address, ref DateTime DateOfBirth,
        ref string Phone, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "select * from people where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        PersonID = Convert.ToInt32(reader["PersonID"]);
                        FirstName = reader["FirstName"].ToString();
                        SecondName = reader["SecondName"].ToString();
                        ThirdName = reader["ThirdName"].ToString();
                        LastName = reader["LastName"].ToString();
                        Gendor = Convert.ToInt32(reader["Gendor"]);
                        Email = reader["Email"].ToString();
                        Address = reader["Address"].ToString();
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                        Phone = reader["Phone"].ToString();
                        NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);

                        if (reader["ImagePath"] != DBNull.Value)
                        {
                            ImagePath = reader["ImagePath"].ToString();
                        }
                        else ImagePath = "NULL";



                        IsFound = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving person data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }





        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT People.PersonID, People.NationalNo, People.FirstName, " +
                "People.SecondName, People.ThirdName, People.LastName, " +
                "CASE WHEN People.Gendor = 0 THEN 'Male' WHEN People.Gendor = 1 THEN 'Female' ELSE 'Unknown' " +
                "END AS Gendor, People.DateOfBirth, Countries.CountryName AS Nationality, People.Phone, " +
                "People.Email FROM People INNER JOIN " +
                "Countries ON People.NationalityCountryID = Countries.CountryID;";
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


        public static DataTable GetPeopleByFilter(string query)
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


        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo,
            int Gendor, string Email, string Phone, string Address, DateTime DateOfBirth, int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "INSERT INTO People (FirstName, SecondName, ThirdName, LastName, NationalNo, Gendor, Email, Phone, Address, DateOfBirth, NationalityCountryID, ImagePath) " +
                "VALUES (@FirstName, @SecondName, @ThirdName, @LastName, @NationalNo, @Gendor, @Email, @Phone, @Address, @DateOfBirth, @NationalityCountryID, @ImagePath); "
                + "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath ?? (object)DBNull.Value);

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



        public static bool UpdatePerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo,
            int Gendor, string Email, string Phone, string Address, DateTime DateOfBirth, int NationalityCountryID, string ImagePath)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "UPDATE People SET FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName, " +
                "NationalNo = @NationalNo, Gendor = @Gendor, Email = @Email, Phone = @Phone, Address = @Address, DateOfBirth = @DateOfBirth, " +
                "NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = (object)ImagePath ?? DBNull.Value;
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0) IsUpdated = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating person data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return IsUpdated;
        }


        public static bool DeletePerson(int id)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "DELETE FROM People WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", id);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0) IsDeleted = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting person data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return IsDeleted;
        }

        public static bool IsPersonExistByPersonID(int PersonID)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(1) FROM People WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    IsExist = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if person exists: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }

            return IsExist;
        }


        public static bool IsPersonExistByNationalNo(string NationalNo)
        {
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT COUNT(1) FROM People WHERE NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    IsExist = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking if person exists: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }

            return IsExist;
        }


        public static DataTable GetPersonByUserID(int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string query = "SELECT People.PersonID, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.NationalNo, People.Gendor, People.Email, People.Address, People.DateOfBirth, People.Phone, People.NationalityCountryID, People.ImagePath " +
                           "FROM People " +
                           "INNER JOIN Users ON People.PersonID = Users.PersonID " +
                           "WHERE Users.UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving person data: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }




    }
}

