using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsApplication
    {
        public enum enMode { AddNew = 1, Update = 2 }
        enMode _Mode;


        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public int ApplicationTypeID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public int PassedTests { get; set; }


        public clsApplication()
        {
            ApplicationID = 0;
            ApplicantPersonID = 0;
            ApplicationTypeID = 0;
            ApplicationDate = DateTime.Now;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            PassedTests = 0;
            _Mode = enMode.AddNew;
        }

        public clsApplication(int applicationID, int applicantPersonID, int applicationTypeID, DateTime applicationDate,
                      int applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID,
                      int passedTests)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationTypeID = applicationTypeID;
            ApplicationDate = applicationDate;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            PassedTests = passedTests;
            _Mode = enMode.Update;
        }

        public static DataTable GetAllApplications()
        {
            return clsApplicationData.GetAllApplications();
        }

        public static DataTable FilterWithNationalNo(string nationalNo)
        {
            return clsApplicationData.FilterTableWithNationalNo(nationalNo);
        }


        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddApplication(this.ApplicantPersonID, this.ApplicationTypeID,
                this.ApplicationDate, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID,
                this.PassedTests);
            return this.ApplicationID > 0;
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationTypeID,
                this.ApplicationDate, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID,
                this.PassedTests);
        }

        public static bool DeleteApplication(int applicationID)
        {
            return clsApplicationData.DeleteApplication(applicationID);
        }

        public static bool IsEligibleToMakeNewApp(int AppID, int TypeID)
        {
            return clsApplicationData.IsEligibleToMakeNewApp(AppID, TypeID);
        }

        public static bool CancelApplication(int AppID)
        {
            return clsApplicationData.CancelApplication(AppID);
        }

        public static clsApplication GetApplicationByID(int AppID)
        {
            int ApplicationID = AppID;
            int ApplicantPersonID = 0;
            int ApplicationTypeID = 0;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;
            int CreatedByUserID = 0;
            int PassedTests = 0;

            if(clsApplicationData.GetApplicationByID(AppID, ref ApplicantPersonID, ref ApplicationTypeID, ref ApplicationDate,
                ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID, ref PassedTests))
            {
                return new clsApplication(AppID, ApplicantPersonID, ApplicationTypeID, ApplicationDate,
                      ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID, PassedTests);
            }
            else
            {
                return null;
            }


        }


        public static string GetApplicantNameByID(int AppID)
        {
            return clsApplicationData.GetApplicantNameByID(AppID);
        }


        public static bool UpdatePassedTests(int applicationId)
        {
            return clsApplicationData.UpdatePassedTests(applicationId);
        }

        public static bool ChangeAppToCompleted(int applicationId)
        {
            return clsApplicationData.ChangeAppToCompleted(applicationId);
        }

        public static int GetPersonIDbyAppID(int applicationId)
        {
            return clsApplicationData.GetPersonIDbyAppID(applicationId);
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return _UpdateApplication();
                default:
                    return false;
            }
        }



    }
}
