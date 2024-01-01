using Library_DataAccessLayer;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsFine
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? FineID { get; private set; }
        public int? MemberID { get; set; }
        public int? BorrowingRecordID { get; set; }
        public short? NumberOfLateDays { get; set; }
        public double? FineAmount { get; set; }
        public bool? PaymentStatus { get; set; }
        public int? CreatedByUserID { get; set; }

        public clsFine()
        {
            _Mode = enMode.AddNew;
            FineID = null;
            MemberID = null;
            BorrowingRecordID = null;
            NumberOfLateDays = null;
            FineAmount = null;
            PaymentStatus = null;
            CreatedByUserID = null;
        }
        private clsFine(int? FineID, int? MemberID, int? BorrowingRecordID, short? NumberOfLateDays, double? FineAmount, bool? PaymentStatus, int? CreatedByUserID)
        {
            _Mode = enMode.Update;
            this.FineID = FineID;
            this.MemberID = MemberID;
            this.BorrowingRecordID = BorrowingRecordID;
            this.NumberOfLateDays = NumberOfLateDays;
            this.FineAmount = FineAmount;
            this.PaymentStatus = PaymentStatus;
            this.CreatedByUserID = CreatedByUserID;
        }

        public static clsFine Find(int FineID)
        {
            int? MemberID = null;
            int? BorrowingRecordID = null;
            short? NumberOfLateDays = null;
            double? FineAmount = null;
            bool? PaymentStatus = null;
            int? CreatedByUserID = null;

            bool IsFound = clsFineData.GetFineInfoByID(FineID, ref MemberID, ref BorrowingRecordID, ref NumberOfLateDays, ref FineAmount, ref PaymentStatus, ref CreatedByUserID);

            if (IsFound)
                return new clsFine(FineID, MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus, CreatedByUserID);
            else
                return null;
        }

        public static bool IsFineExist(int FineID)
        {
            return clsFineData.IsFineExist(FineID);
        }

        private bool _AddNewFine()
        {
            FineID = clsFineData.AddNewFine(MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus, CreatedByUserID);
            return FineID.HasValue;
        }

        private bool _UpdateFine()
        {
            return clsFineData.UpdateFineInfo(FineID, MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus, CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewFine())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateFine();

            }
            return false;
        }

        public static bool DeleteFine(int FineID)
        {
            return clsFineData.DeleteFine(FineID);
        }

        public static DataTable GetAllFines()
        {
            return clsFineData.GetAllFines();
        }

    }
}