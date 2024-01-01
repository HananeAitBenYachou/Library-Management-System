using Library_DataAccessLayer;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsCountry
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? CountryID { get; private set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            _Mode = enMode.AddNew;
            CountryID = null;
            CountryName = null;
        }
        private clsCountry(int? CountryID, string CountryName)
        {
            _Mode = enMode.Update;
            this.CountryID = CountryID;
            this.CountryName = CountryName;
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = null;

            bool IsFound = clsCountryData.GetCountryInfoByID(CountryID, ref CountryName);

            if (IsFound)
                return new clsCountry(CountryID, CountryName);
            else
                return null;
        }

        public static bool IsCountryExist(int CountryID)
        {
            return clsCountryData.IsCountryExist(CountryID);
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }

    }
}