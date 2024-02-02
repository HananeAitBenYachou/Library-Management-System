using Library_DataAccessLayer;
using System;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsBorrowingRecord
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? BorrowingRecordID { get; private set; }
        public int? MemberID { get; set; }
        public int? BookCopyID { get; set; }
        public DateTime? BorrowingDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public clsMember MemberInfo { get; }

        public clsBorrowingRecord()
        {
            _Mode = enMode.AddNew;
            BorrowingRecordID = null;
            MemberID = null;
            BookCopyID = null;
            BorrowingDate = null;
            DueDate = null;
            ActualReturnDate = null;
        }

        private clsBorrowingRecord(int? BorrowingRecordID, int? MemberID, int? BookCopyID, DateTime? BorrowingDate, 
            DateTime? DueDate, DateTime? ActualReturnDate)
        {
            _Mode = enMode.Update;
            this.BorrowingRecordID = BorrowingRecordID;
            this.MemberID = MemberID;
            this.BookCopyID = BookCopyID;
            this.BorrowingDate = BorrowingDate;
            this.DueDate = DueDate;
            this.ActualReturnDate = ActualReturnDate;
           
            this.MemberInfo = clsMember.Find(this.MemberID);        
        }

        public static clsBorrowingRecord Find(int? BorrowingRecordID)
        {
            int? MemberID = null;
            int? BookCopyID = null;
            DateTime? BorrowingDate = null;
            DateTime? DueDate = null;
            DateTime? ActualReturnDate = null;

            bool IsFound = clsBorrowingRecordData.GetBorrowingRecordInfoByID(BorrowingRecordID, ref MemberID, ref BookCopyID, ref BorrowingDate, ref DueDate, 
                ref ActualReturnDate);

            if (IsFound)
                return new clsBorrowingRecord(BorrowingRecordID, MemberID, BookCopyID, BorrowingDate, DueDate, 
                    ActualReturnDate);
            else
                return null;
        }

        public static clsBorrowingRecord FindByBookCopyID(int? BookCopyID)
        {
            int? MemberID = null;
            int? BorrowingRecordID = null;
            DateTime? BorrowingDate = null;
            DateTime? DueDate = null;
            DateTime? ActualReturnDate = null;

            bool IsFound = clsBorrowingRecordData.GetBorrowingRecordInfoByBookCopyID(BookCopyID,ref BorrowingRecordID, ref MemberID,ref BorrowingDate,
                ref DueDate, ref ActualReturnDate);

            if (IsFound)
                return new clsBorrowingRecord(BorrowingRecordID, MemberID, BookCopyID, BorrowingDate, DueDate, 
                    ActualReturnDate);
            else
                return null;
        }

        public static bool IsBorrowingRecordExist(int? BorrowingRecordID)
        {
            return clsBorrowingRecordData.IsBorrowingRecordExist(BorrowingRecordID);
        }

        private bool _AddNewBorrowingRecord()
        {
            BorrowingRecordID = clsBorrowingRecordData.AddNewBorrowingRecord(MemberID, BookCopyID, BorrowingDate, DueDate, ActualReturnDate);
            return BorrowingRecordID.HasValue;
        }

        private bool _UpdateBorrowingRecord()
        {
            return clsBorrowingRecordData.UpdateBorrowingRecordInfo(BorrowingRecordID, MemberID, 
                BookCopyID, BorrowingDate, DueDate, ActualReturnDate);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBorrowingRecord() && clsBookCopy.Find(BookCopyID).Borrow())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateBorrowingRecord();

            }
            return false;
        }

        public static bool DeleteBorrowingRecord(int? BorrowingRecordID)
        {
            return clsBorrowingRecordData.DeleteBorrowingRecord(BorrowingRecordID);
        }

        public static DataTable GetAllBorrowingRecords()
        {
            return clsBorrowingRecordData.GetAllBorrowingRecords();
        }

        public static DataTable GetMemberBorrowingRecords(int? MemberID)
        {
            return clsBorrowingRecordData.GetMemberBorrowingRecords(MemberID);
        }

        public static DataTable GetBookCopyBorrowingRecords(int? BookCopyID)
        {
            return clsBorrowingRecordData.GetBookCopyBorrowingRecords(BookCopyID);
        }

        public bool ReturnBorrowedBookCopy()
        {
            return clsBorrowingRecordData.ReturnBorrowedBook(this.BorrowingRecordID);
        }

        public static int GetBorrowingsCount()
        {
            return clsBorrowingRecordData.GetBorrowingsCount();
        }

        public static int GetReturnsCount()
        {
            return clsBorrowingRecordData.GetReturnsCount();
        }

    }
}