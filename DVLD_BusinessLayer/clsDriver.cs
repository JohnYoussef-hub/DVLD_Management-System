using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriver()
        {
            DriverID = 0;
            PersonID = 0;
            CreatedByUserID = 0;
            CreatedDate = DateTime.Now;
        }

        public clsDriver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
        }

        public static DataTable GetAllDrivers()
        {
            return DataAccessLayer.clsDriverData.GetAllDrivers();
        }

        public static DataTable GetDataByFilter(string ByWhat, string Filter)
        {
            return DataAccessLayer.clsDriverData.GetDataByFilter(ByWhat, Filter);
        }


        public bool AddNewDriver()
        {
            this.DriverID = DataAccessLayer.clsDriverData.AddNewDriver(this.PersonID, this.CreatedDate, this.CreatedByUserID);
            if (DriverID == -1) return false;
            else return true;
        }

        public static bool DeleteDriver(int DriverID)
        {
            return DataAccessLayer.clsDriverData.DeleteDriver(DriverID);
        }

        public static int GetAppIDFromDriverID(int driverID)
        {
            return DataAccessLayer.clsDriverData.GetAppIDFromDriverID(driverID);
        }
    }
}
