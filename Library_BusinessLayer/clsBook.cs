using Library_DataAccessLayer;
using System;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsBook
    {

        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? BookID { get; private set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int? GenreID { get; set; }
        public string AdditionalDetails { get; set; }
        public int? AuthorID { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? PublicationDate { get; set; }

        public clsBook()
        {
            _Mode = enMode.AddNew;
            BookID = null;
            Title = null;
            ISBN = null;
            GenreID = null;
            AdditionalDetails = null;
            AuthorID = null;
            CreatedByUserID = null;
            PublicationDate = null;
        }
        private clsBook(int? BookID, string Title, string ISBN, int? GenreID, string AdditionalDetails, int? AuthorID, int? CreatedByUserID, DateTime? PublicationDate)
        {
            _Mode = enMode.Update;
            this.BookID = BookID;
            this.Title = Title;
            this.ISBN = ISBN;
            this.GenreID = GenreID;
            this.AdditionalDetails = AdditionalDetails;
            this.AuthorID = AuthorID;
            this.CreatedByUserID = CreatedByUserID;
            this.PublicationDate = PublicationDate;
        }

        public static clsBook Find(int BookID)
        {
            string Title = null;
            string ISBN = null;
            int? GenreID = null;
            string AdditionalDetails = null;
            int? AuthorID = null;
            int? CreatedByUserID = null;
            DateTime? PublicationDate = null;

            bool IsFound = clsBookData.GetBookInfoByID(BookID, ref Title, ref ISBN, ref GenreID, ref AdditionalDetails, ref AuthorID, ref CreatedByUserID, ref PublicationDate);

            if (IsFound)
                return new clsBook(BookID, Title, ISBN, GenreID, AdditionalDetails, AuthorID, CreatedByUserID, PublicationDate);
            else
                return null;
        }

        public static bool IsBookExist(int BookID)
        {
            return clsBookData.IsBookExist(BookID);
        }

        private bool _AddNewBook()
        {
            BookID = clsBookData.AddNewBook(Title, ISBN, GenreID, AdditionalDetails, AuthorID, CreatedByUserID, PublicationDate);
            return BookID.HasValue;
        }

        private bool _UpdateBook()
        {
            return clsBookData.UpdateBookInfo(BookID, Title, ISBN, GenreID, AdditionalDetails, AuthorID, CreatedByUserID, PublicationDate);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBook())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateBook();

            }
            return false;
        }

        public static bool DeleteBook(int BookID)
        {
            return clsBookData.DeleteBook(BookID);
        }

        public static DataTable GetAllBooks()
        {
            return clsBookData.GetAllBooks();
        }
    }
}