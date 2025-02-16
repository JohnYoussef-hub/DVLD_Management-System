using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsInternationalDrivingLicenseApp
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssueUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }


        public clsInternationalDrivingLicenseApp()
        {
            InternationalLicenseID = 0;
            ApplicationID = 0;
            DriverID = 0;
            IssueUsingLocalLicenseID = 0;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedByUserID = 0;
        }

        public clsInternationalDrivingLicenseApp(int internationalLicenseID, int applicationID, int driverID, int issueUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssueUsingLocalLicenseID = issueUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }


        public static DataTable GetAllInternationalLicenses()
        {
            return DataAccessLayer.clsInternationalDrivingLicenseAppData.GetAllInternationalLicenses();
        }


        public static bool IsLDLhasIDL(int LDLid)
        {
            return DataAccessLayer.clsInternationalDrivingLicenseAppData.IsLDLhasIDL(LDLid);
        }


        public bool AddNewInternationalLicense()
        {
            this.InternationalLicenseID = DataAccessLayer.clsInternationalDrivingLicenseAppData.AddNewInternationalLicense(
                this.ApplicationID,
                this.DriverID,
                this.IssueUsingLocalLicenseID,
                this.IssueDate,
                this.ExpirationDate,
                this.IsActive,
                this.CreatedByUserID
                );

            return this.InternationalLicenseID != -1;
        }

        public static DataTable GetSomeInfoFromLicense(int LicenseID)
        {
            return DataAccessLayer.clsInternationalDrivingLicenseAppData.GetSomeInfoFromLicense(LicenseID);
        }

        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            return DataAccessLayer.clsInternationalDrivingLicenseAppData.DeleteInternationalLicense(InternationalLicenseID);
        }

        public static bool IsInterActive(int InternationalLicenseID)
        {
            return DataAccessLayer.clsInternationalDrivingLicenseAppData.IsActive(InternationalLicenseID);
        }

    }
}
