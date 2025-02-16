using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsLocalDrivingLicenseAppData
    {
        public static bool AddNewLDLApplication(int ApplicationID, int LicenseClass)
        {
            bool res = false;
            SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString);
            string sql = "insert into LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) values (@ApplicationID, @LicenseClassID)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClass);
            try
            {
                connection.Open();
                int count = command.ExecuteNonQuery();
                if (count > 0) res = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding new application: " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
            }
            return res;
        }
    }
}
