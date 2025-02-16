using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class clsCountry
    {
        public static string GetCountryNameByID(int Country)
        {
            return DataAccessLayer.clsCountryData.GetCountryNameByID(Country);
        }

        public static List<string> GetCountries()
        {
            return DataAccessLayer.clsCountryData.GetCountries();
        }

        public static int GetCountryIDByName(string CountryName)
        {
            return DataAccessLayer.clsCountryData.GetCountryIndexByName(CountryName);
        }
    }
}
