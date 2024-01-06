using Library_DataAccessLayer;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsCountry
    {
        public int? CountryID { get; private set; }
        public string CountryName { get; set; }

        private clsCountry(int? CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static clsCountry Find(int? CountryID)
        {
            string CountryName = null;

            bool IsFound = clsCountryData.GetCountryInfoByID(CountryID, ref CountryName);

            if (IsFound)
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }

        public static clsCountry Find(string CountryName)
        {
            int? CountryID = null;

            bool IsFound = clsCountryData.GetCountryInfoByName(CountryName, ref CountryID);

            if (IsFound)
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }

        public static bool IsCountryExist(int? CountryID)
        {
            return clsCountryData.IsCountryExist(CountryID);
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

    }
}