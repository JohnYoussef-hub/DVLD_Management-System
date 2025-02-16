using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsLicense
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }


        public clsLicense()
        {
            LicenseID = 0;
            ApplicationID = 0;
            DriverID = 0;
            LicenseClass = 0;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = 0;
            IsActive = true;
            CreatedByUserID = 0;
        }

        public clsLicense(int applicationID, int driverID, int licenseClass, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive, int createdByUserID)
        {
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }


        public bool AddNewLicense()
        {
            LicenseID = clsLicenseData.AddNewLicense(
                this.ApplicationID,
                this.DriverID,
                this.LicenseClass,
                this.IssueDate,
                this.ExpirationDate,
                this.Notes,
                this.PaidFees,
                this.IsActive,
                this.CreatedByUserID
            );
            return LicenseID > 0;
        }


        public static bool DeleteLicense(int LicenseID)
        {
            return clsLicenseData.DeleteLicense(LicenseID);
        }


        public static int GetLicenseIDbyName(string licenseName)
        {
            switch (licenseName)
            {
                case "Class 1 - Small Motorcycle":
                    return 1;
                case "Class 2 - Heavy Motorcycle License":
                    return 2;
                case "Class 3 - Ordinary driving license":
                    return 3;
                case "Class 4 - Commercial":
                    return 4;
                case "Class 5 - Agricultural":
                    return 5;
                case "Class 6 - Small and medium bus":
                    return 6;
                case "Class 7 - Truck and heavy vehicle":
                    return 7;
                default:
                    throw new ArgumentException("Invalid license name", nameof(licenseName));
            }
        }

        public static string GetLicenseNameByID(int licenseID)
        {
            switch (licenseID)
            {
                case 1:
                    return "Class 1 - Small Motorcycle";
                case 2:
                    return "Class 2 - Heavy Motorcycle License";
                case 3:
                    return "Class 3 - Ordinary driving license";
                case 4:
                    return "Class 4 - Commercial";
                case 5:
                    return "Class 5 - Agricultural";
                case 6:
                    return "Class 6 - Small and medium bus";
                case 7:
                    return "Class 7 - Truck and heavy vehicle";
                default:
                    throw new ArgumentException("Invalid license ID", nameof(licenseID));
            }
        }


        public static bool IsHasLicensebyAppID(int appID)
        {
            return clsLicenseData.IsHasLicensebyAppID(appID);
        }

        public static DataTable GetLicenseInfo(string SearchFor, int id)
        {
            return clsLicenseData.GetLicenseInfo(SearchFor, id);
        }

        public static DataTable GetLicenseHistorybyAppID(int appID)
        {
            return clsLicenseData.GetLicenseHistorybyAppID(appID);
        }

        public static bool IsLicenseFound(int LicenseID)
        {
            return clsLicenseData.IsLicenseFound(LicenseID);
        }

        public static bool IsLicenseActive(int LicenseID)
        {
            return clsLicenseData.IsLicenseActive(LicenseID);
        }

        public static int GetLDLfromLicenseID(int licenseID)
        {
            return clsLicenseData.GetLDLfromLicenseID(licenseID);
        }

        public static bool IsLicenseEligibleForRenewal(int LicenseID)
        {
            return clsLicenseData.IsLicenseEligibleForRenewal(LicenseID);
        }

        public static DataTable GetAllLicensebyPersonID(int PersonID)
        {
            return clsLicenseData.GetAllLicensebyPersonID(PersonID);
        }

        public static int GetPersonIDFromLicenseID(int licenseID)
        {
            return clsLicenseData.GetPersonIDFromLicenseID(licenseID);
        }

    }
}
