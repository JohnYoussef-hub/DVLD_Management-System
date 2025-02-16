using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsTestAppointments
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int? RetakeTestApplicationID { get; set; }

        public clsTestAppointments()
        {
            TestAppointmentID = 0;
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = false;
            RetakeTestApplicationID = null;
        }

        public clsTestAppointments(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate,
            int paidFees, int createdByUserID, bool isLocked, int? retakeTestApplicationID)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            RetakeTestApplicationID = retakeTestApplicationID;
        }

        public static DataTable GetTestAppointments()
        {
            return clsTestAppointmentsData.GetTestAppointments();
        }

        public static DataTable GetTestAppointmentsByApplicationID(int applicationID)
        {
            return clsTestAppointmentsData.GetTestAppointmentsByApplicationID(applicationID);
        }

        public static DataTable GetTestAppointmentsByType(int LDLid, int applicationID)
        {
            return clsTestAppointmentsData.GetTestAppointmentsByType(LDLid ,applicationID);
        }

        public static bool IsEligibleToMakeNewAppo(int LDLid, int type)
        {
            return clsTestAppointmentsData.IsEligibleToMakeNewAppo(LDLid, type);
        }

        public static int GetLDLidByAppID(int AppID)
        {
            return clsTestAppointmentsData.GetLDLidByAppID(AppID);
        }

        public static int GetAppIDByLDLid(int LDLid)
        {
            return clsTestAppointmentsData.GetAppIDByLDLid(LDLid);
        }

        public static int GetAppoIDByLDLid(int LDLid)
        {
            return clsTestAppointmentsData.GetAppoIDByLDLid(LDLid);
        }

        public static bool ChangeToLocked(int testAppointmentID)
        {
            return clsTestAppointmentsData.ChangeToLocked(testAppointmentID);
        }

        public bool AddNewAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentsData.AddNewAppointment(this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees, this.IsLocked, this.TestTypeID, this.CreatedByUserID, this.RetakeTestApplicationID);
            if (this.TestAppointmentID == -1) return false;
            else return true;
        }

        public static decimal GetFeesbyAppoID(int appointmentID)
        {
            return clsTestAppointmentsData.GetFeesbyAppoID(appointmentID);
        }
    }
}
