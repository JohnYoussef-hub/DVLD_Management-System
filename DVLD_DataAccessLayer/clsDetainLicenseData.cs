using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDetainLicenseData
    {
        public static bool IsDetainbyLicenseID(int LicenseID)
        {
            bool isDetained = false;
            string query = "SELECT COUNT(*) FROM DetainedLicenses WHERE LicenseID = @LicenseID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessLink.connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LicenseID", LicenseID);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    isDetained = count > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error checking if license is detained: " + ex.Message, ex);
                }
            }
            return isDetained;
        }

    }
}
