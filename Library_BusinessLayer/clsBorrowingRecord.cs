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
        public int? CreatedByUserID { get; set; }

        public clsBorrowingRecord()
        {
            _Mode = enMode.AddNew;
            BorrowingRecordID = null;
            MemberID = null;
            BookCopyID = null;
            BorrowingDate = null;
            DueDate = null;
            ActualReturnDate = null;
            CreatedByUserID = null;
        }
        private clsBorrowingRecord(int? BorrowingRecordID, int? MemberID, int? BookCopyID, DateTime? BorrowingDate, DateTime? DueDate, DateTime? ActualReturnDate, int? CreatedByUserID)
        {
            _Mode = enMode.Update;
            this.BorrowingRecordID = BorrowingRecordID;
            this.MemberID = MemberID;
            this.BookCopyID = BookCopyID;
            this.BorrowingDate = BorrowingDate;
            this.DueDate = DueDate;
            this.ActualReturnDate = ActualReturnDate;
            this.CreatedByUserID = CreatedByUserID;
        }

        public static clsBorrowingRecord Find(int BorrowingRecordID)
        {
            int? MemberID = null;
            int? BookCopyID = null;
            DateTime? BorrowingDate = null;
            DateTime? DueDate = null;
            DateTime? ActualReturnDate = null;
            int? CreatedByUserID = null;

            bool IsFound = clsBorrowingRecordData.GetBorrowingRecordInfoByID(BorrowingRecordID, ref MemberID, ref BookCopyID, ref BorrowingDate, ref DueDate, ref ActualReturnDate, ref CreatedByUserID);

            if (IsFound)
                return new clsBorrowingRecord(BorrowingRecordID, MemberID, BookCopyID, BorrowingDate, DueDate, ActualReturnDate, CreatedByUserID);
            else
                return null;
        }

        public static bool IsBorrowingRecordExist(int BorrowingRecordID)
        {
            return clsBorrowingRecordData.IsBorrowingRecordExist(BorrowingRecordID);
        }

        private bool _AddNewBorrowingRecord()
        {
            BorrowingRecordID = clsBorrowingRecordData.AddNewBorrowingRecord(MemberID, BookCopyID, BorrowingDate, DueDate, ActualReturnDate, CreatedByUserID);
            return BorrowingRecordID.HasValue;
        }

        private bool _UpdateBorrowingRecord()
        {
            return clsBorrowingRecordData.UpdateBorrowingRecordInfo(BorrowingRecordID, MemberID, BookCopyID, BorrowingDate, DueDate, ActualReturnDate, CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBorrowingRecord())
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

        public static bool DeleteBorrowingRecord(int BorrowingRecordID)
        {
            return clsBorrowingRecordData.DeleteBorrowingRecord(BorrowingRecordID);
        }

        public static DataTable GetAllBorrowingRecords()
        {
            return clsBorrowingRecordData.GetAllBorrowingRecords();
        }

    }
}