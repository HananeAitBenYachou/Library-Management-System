using Library_DataAccessLayer;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsGenre
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? GenreID { get; private set; }
        public string GenreName { get; set; }
        public string Description { get; set; }

        public clsGenre()
        {
            _Mode = enMode.AddNew;
            GenreID = null;
            GenreName = null;
            Description = null;
        }
        private clsGenre(int? GenreID, string GenreName, string Description)
        {
            _Mode = enMode.Update;
            this.GenreID = GenreID;
            this.GenreName = GenreName;
            this.Description = Description;
        }

        public static clsGenre Find(int?  GenreID)
        {
            string GenreName = null;
            string Description = null;

            bool IsFound = clsGenreData.GetGenreInfoByID(GenreID, ref GenreName, ref Description);

            if (IsFound)
                return new clsGenre(GenreID, GenreName, Description);
            else
                return null;
        }

        public static clsGenre Find(string GenreName)
        {
            int? GenreID = null;
            string Description = null;

            bool IsFound = clsGenreData.GetGenreInfoByName(GenreName, ref GenreID, ref Description);

            if (IsFound)
                return new clsGenre(GenreID, GenreName, Description);
            else
                return null;
        }

        public static bool IsGenreExist(int? GenreID)
        {
            return clsGenreData.IsGenreExist(GenreID);
        }

        public static bool IsGenreExist(string GenreName)
        {
            return clsGenreData.IsGenreExist(GenreName);
        }

        private bool _AddNewGenre()
        {
            GenreID = clsGenreData.AddNewGenre(GenreName, Description);
            return GenreID.HasValue;
        }

        private bool _UpdateGenre()
        {
            return clsGenreData.UpdateGenreInfo(GenreID, GenreName, Description);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewGenre())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateGenre();

            }
            return false;
        }

        public static bool DeleteGenre(int? GenreID)
        {
            return clsGenreData.DeleteGenre(GenreID);
        }

        public static DataTable GetAllGenres()
        {
            return clsGenreData.GetAllGenres();
        }

    }
}