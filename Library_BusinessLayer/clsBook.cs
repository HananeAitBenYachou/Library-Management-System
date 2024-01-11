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
        public string BookImagePath { get; set; }

        public clsUser UserInfo { get; }
        public clsAuthor AuthorInfo { get; }
        public clsGenre GenreInfo { get;}

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
            BookImagePath = null;
        }
        private clsBook(int? BookID, string Title, string ISBN, 
            int? GenreID, string AdditionalDetails, int? AuthorID,
            int? CreatedByUserID, DateTime? PublicationDate, string BookImagePath)
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
            this.BookImagePath = BookImagePath;

            this.UserInfo = clsUser.Find(CreatedByUserID);
            this.AuthorInfo = clsAuthor.Find(AuthorID);
            this.GenreInfo = clsGenre.Find(GenreID);
        }

        public static clsBook Find(int? BookID)
        {
            string Title = null;
            string ISBN = null;
            int? GenreID = null;
            string AdditionalDetails = null;
            int? AuthorID = null;
            int? CreatedByUserID = null;
            DateTime? PublicationDate = null;
            string BookImagePath = null;

            bool IsFound = clsBookData.GetBookInfoByID(BookID, ref Title, ref ISBN, ref GenreID, ref AdditionalDetails, ref AuthorID, ref CreatedByUserID, ref PublicationDate, ref BookImagePath);

            if (IsFound)
                return new clsBook(BookID, Title, ISBN, GenreID, AdditionalDetails, AuthorID, CreatedByUserID, PublicationDate, BookImagePath);
            else
                return null;
        }

        public static bool IsBookExist(int? BookID)
        {
            return clsBookData.IsBookExist(BookID);
        }

        public static bool IsBookExistByISBN(string ISBN)
        {
            return clsBookData.IsBookExistByISBN(ISBN);
        }

        public static bool IsBookExistByTitle(string Title)
        {
            return clsBookData.IsBookExistByTitle(Title);
        }

        private bool _AddNewBook()
        {
            BookID = clsBookData.AddNewBook(Title, ISBN, GenreID, AdditionalDetails, AuthorID, CreatedByUserID, PublicationDate, BookImagePath);
            return BookID.HasValue;
        }

        private bool _UpdateBook()
        {
            return clsBookData.UpdateBookInfo(BookID, Title, ISBN, GenreID, AdditionalDetails, AuthorID, CreatedByUserID, PublicationDate, BookImagePath);
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

        public static bool DeleteBook(int? BookID)
        {
            return _DeleteBookCopies(BookID) ? clsBookData.DeleteBook(BookID) : false;
        }

        private static bool _DeleteBookCopies(int? BookID)
        {
            return clsBookCopy.DeleteBookCopies(BookID);
        }

        public static DataTable GetAllBooks()
        {
            return clsBookData.GetAllBooks();
        }

        public int? AddCopy()
        {
            clsBookCopy copy = new clsBookCopy();

            copy.AvailabilityStatus = true;
            copy.BookID = this.BookID;

            return copy.Save() ? copy.BookCopyID : null;         
        }


    }
}