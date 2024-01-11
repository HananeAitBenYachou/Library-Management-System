using Library_DataAccessLayer;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsAuthor
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? AuthorID { get; private set; }
        public int? NationalityCountryID { get; set; }
        public string Biography { get; set; }
        public string FullName { get; set; }
        public clsCountry CountryInfo { get; }

        public clsAuthor()
        {
            _Mode = enMode.AddNew;
            AuthorID = null;
            NationalityCountryID = null;
            Biography = null;
            FullName = null;
        }
        private clsAuthor(int? AuthorID, int? NationalityCountryID, string Biography, string FullName)
        {
            _Mode = enMode.Update;
            this.AuthorID = AuthorID;
            this.NationalityCountryID = NationalityCountryID;
            this.Biography = Biography;
            this.FullName = FullName;

            this.CountryInfo = clsCountry.Find(NationalityCountryID);
        }

        public static clsAuthor Find(int? AuthorID)
        {
            int? NationalityCountryID = null;
            string Biography = null;
            string FullName = null;

            bool IsFound = clsAuthorData.GetAuthorInfoByID(AuthorID, ref NationalityCountryID, ref Biography, ref FullName);

            if (IsFound)
                return new clsAuthor(AuthorID, NationalityCountryID, Biography, FullName);
            else
                return null;
        }

        public static clsAuthor Find(string FullName)
        {
            int? NationalityCountryID = null;
            string Biography = null;
            int? AuthorID = null;

            bool IsFound = clsAuthorData.GetAuthorInfoByName(FullName, ref AuthorID, ref NationalityCountryID, ref Biography);

            if (IsFound)
                return new clsAuthor(AuthorID, NationalityCountryID, Biography, FullName);
            else
                return null;
        }

        public static bool IsAuthorExist(int? AuthorID)
        {
            return clsAuthorData.IsAuthorExist(AuthorID);
        }

        public static bool IsAuthorExist(string FullName)
        {
            return clsAuthorData.IsAuthorExist(FullName);
        }

        private bool _AddNewAuthor()
        {
            AuthorID = clsAuthorData.AddNewAuthor(NationalityCountryID, Biography, FullName);
            return AuthorID.HasValue;
        }

        private bool _UpdateAuthor()
        {
            return clsAuthorData.UpdateAuthorInfo(AuthorID, NationalityCountryID, Biography, FullName);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAuthor())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateAuthor();

            }
            return false;
        }

        public static bool DeleteAuthor(int? AuthorID)
        {
            return clsAuthorData.DeleteAuthor(AuthorID);
        }

        public static DataTable GetAllAuthors()
        {
            return clsAuthorData.GetAllAuthors();
        }

    }

}