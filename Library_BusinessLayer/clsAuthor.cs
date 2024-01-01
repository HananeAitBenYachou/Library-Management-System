using Library_DataAccessLayer;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsAuthor
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? AuthorID { get; private set; }
        public int? PersonID { get; set; }
        public string Biography { get; set; }

        public clsAuthor()
        {
            _Mode = enMode.AddNew;
            AuthorID = null;
            PersonID = null;
            Biography = null;
        }
        private clsAuthor(int? AuthorID, int? PersonID, string Biography)
        {
            _Mode = enMode.Update;
            this.AuthorID = AuthorID;
            this.PersonID = PersonID;
            this.Biography = Biography;
        }

        public static clsAuthor Find(int AuthorID)
        {
            int? PersonID = null;
            string Biography = null;

            bool IsFound = clsAuthorData.GetAuthorInfoByID(AuthorID, ref PersonID, ref Biography);

            if (IsFound)
                return new clsAuthor(AuthorID, PersonID, Biography);
            else
                return null;
        }

        public static bool IsAuthorExist(int AuthorID)
        {
            return clsAuthorData.IsAuthorExist(AuthorID);
        }

        private bool _AddNewAuthor()
        {
            AuthorID = clsAuthorData.AddNewAuthor(PersonID, Biography);
            return AuthorID.HasValue;
        }

        private bool _UpdateAuthor()
        {
            return clsAuthorData.UpdateAuthorInfo(AuthorID, PersonID, Biography);
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

        public static bool DeleteAuthor(int AuthorID)
        {
            return clsAuthorData.DeleteAuthor(AuthorID);
        }

        public static DataTable GetAllAuthors()
        {
            return clsAuthorData.GetAllAuthors();
        }

    }
}