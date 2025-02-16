using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsLocalDrivingLicenseApp
    {
        public static bool AddNewLDLApplication(int ApplicationID, int LicenseClass)
        {
            return clsLocalDrivingLicenseAppData.AddNewLDLApplication(ApplicationID, LicenseClass);
        }
    }
}
