using Library_DataAccessLayer;
using System;
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
        public string AvailabilityStatusText
        {
            get
            {
                return AvailabilityStatus.Value ? "Available" : "Borrowed";
            }
        }
        public clsBook BookInfo { get; }
        public clsBorrowingRecord BorrowingInfo { get; }

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

            this.BookInfo = clsBook.Find(BookID);
            this.BorrowingInfo = clsBorrowingRecord.FindByBookCopyID(BookCopyID);
        }

        public static clsBookCopy Find(int? BookCopyID)
        {
            int? BookID = null;
            bool? AvailabilityStatus = null;

            bool IsFound = clsBookCopyData.GetBookCopyInfoByID(BookCopyID, ref BookID, ref AvailabilityStatus);

            if (IsFound)
                return new clsBookCopy(BookCopyID, BookID, AvailabilityStatus);
            else
                return null;
        }

        public static bool IsBookCopyExist(int? BookCopyID)
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

        public bool Borrow()
        {
            return clsBookCopyData.UpdateBookCopyAvailabilityStatus(BookCopyID, false);
        }

        public bool ReturnBorrowedBookCopy(ref double? FineFees)
        {
            short NumberOfLateDays = (short)DateTime.Now.Subtract(this.BorrowingInfo.DueDate.Value).Days;

            if(NumberOfLateDays > 0)
            {
                clsFine Fine = new clsFine();

                Fine.MemberID = this.BorrowingInfo.MemberID;
                Fine.BorrowingRecordID = this.BorrowingInfo.BorrowingRecordID;
                Fine.NumberOfLateDays = (short?)DateTime.Now.Subtract(this.BorrowingInfo.DueDate.Value).Days;
                Fine.FineAmount = Fine.NumberOfLateDays * clsSettings.DefaultFinePerDay;
                Fine.PaymentStatus = false;

                FineFees = Fine.FineAmount;

                if (!Fine.Save())
                    return false;
            }
            
            if (!this.BorrowingInfo.ReturnBorrowedBookCopy())
                return false;

            return clsBookCopyData.UpdateBookCopyAvailabilityStatus(BookCopyID, true);
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

        public static bool DeleteBookCopy(int? BookCopyID)
        {
            return clsBookCopyData.DeleteBookCopy(BookCopyID);
        }

        public static bool DeleteBookCopies(int? BookID)
        {
            return clsBookCopyData.DeleteBookCopies(BookID);
        }

        public static DataTable GetAllBookCopies()
        {
            return clsBookCopyData.GetAllBookCopies();
        }

        public static DataTable GetAllBookCopies(int? BookID)
        {
            return clsBookCopyData.GetAllBookCopies(BookID);
        }

        public static int? GetAvailableBookCopy(int? BookID)
        {
            return clsBookCopyData.GetAvailableBookCopy(BookID);
        }

        public static int? GetBorrowedBookCopy(int? BookID)
        {
            return clsBookCopyData.GetBorrowedBookCopy(BookID);
        }

    }
}