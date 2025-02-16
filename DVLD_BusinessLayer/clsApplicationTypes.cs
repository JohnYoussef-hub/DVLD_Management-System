using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsApplicationTypes
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public double ApplicationTypeFees { get; set; }

        public clsApplicationTypes()
        {
            ApplicationTypeID = 0;
            ApplicationTypeTitle = "";
            ApplicationTypeFees = 0;
        }


        public static DataTable GetApplicationTypes()
        {
            DataTable dt = new DataTable();
            dt = clsApplicationTypesData.GetApplicationTypes();
            return dt;
        }

        public static bool UpdateApplicationType(int appID, string Title, double Fees)
        {
            return clsApplicationTypesData.UpdateApplicationType(appID, Title, Fees);
        }

        public static int GetApplicationType(int appID)
        {
            return clsApplicationTypesData.GetApplicationType(appID);
        }

        public static int GetAppTypeIDbyName(string appTitle)
        {
            switch (appTitle)
            {
                case "New Local Driving License Service":
                    return 1;
                case "Renew Driving License Services":
                    return 2;
                case "Replacement for a Lost Driving License":
                    return 3;
                case "Replacement for a Damaged Driving License":
                    return 4;
                case "Release Detained Driving License":
                    return 5;
                case "New International License":
                    return 6;
                case "Retake Test":
                    return 7;
                default:
                    throw new ArgumentException("Invalid application title", nameof(appTitle));
            }
        }


    }
}
