using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public double TestTypeFees { get; set; }

        public clsTestTypes()
        {
            TestTypeID = 0;
            TestTypeTitle = "";
            TestTypeDescription = "";
            TestTypeFees = 0;
        }

        public static DataTable GetTestTypes()
        {
            DataTable dt = new DataTable();
            dt = clsTestTypesData.GetTestTypes();
            return dt;
        }

        public static bool UpdateTestType(int testID, string Title, string Description, double Fees)
        {
            return clsTestTypesData.UpdateTestType(testID, Title, Description, Fees);
        }

        public static decimal GetTestFees(int TestType)
        {
            return clsTestTypesData.GetTestFees(TestType);
        }
    }
}

