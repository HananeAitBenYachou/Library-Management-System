using Library_DataAccessLayer;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsBookCopy
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? BookCopyID { get; private set; }
        public int? BookID { get; set; }
        public bool? AvailabilityStatus { get; set; }

        public clsBookCopy()
        {
            _Mode = enMode.AddNew;
            BookCopyID = null;
            BookID = null;
            AvailabilityStatus = null;
        }
        private clsBookCopy(int? BookCopyID, int? BookID, bool? AvailabilityStatus)
        {
            _Mode = enMode.Update;
            this.BookCopyID = BookCopyID;
            this.BookID = BookID;
            this.AvailabilityStatus = AvailabilityStatus;
        }

        public static clsBookCopy Find(int BookCopyID)
        {
            int? BookID = null;
            bool? AvailabilityStatus = null;

            bool IsFound = clsBookCopyData.GetBookCopyInfoByID(BookCopyID, ref BookID, ref AvailabilityStatus);

            if (IsFound)
                return new clsBookCopy(BookCopyID, BookID, AvailabilityStatus);
            else
                return null;
        }

        public static bool IsBookCopyExist(int BookCopyID)
        {
            return clsBookCopyData.IsBookCopyExist(BookCopyID);
        }

        private bool _AddNewBookCopy()
        {
            BookCopyID = clsBookCopyData.AddNewBookCopy(BookID, AvailabilityStatus);
            return BookCopyID.HasValue;
        }

        private bool _UpdateBookCopy()
        {
            return clsBookCopyData.UpdateBookCopyInfo(BookCopyID, BookID, AvailabilityStatus);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBookCopy())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateBookCopy();

            }
            return false;
        }

        public static bool DeleteBookCopy(int BookCopyID)
        {
            return clsBookCopyData.DeleteBookCopy(BookCopyID);
        }

        public static DataTable GetAllBookCopies()
        {
            return clsBookCopyData.GetAllBookCopies();
        }

    }
}