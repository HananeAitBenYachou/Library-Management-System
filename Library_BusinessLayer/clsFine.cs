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
        public clsBorrowingRecord BorrowingInfo { get; }
        public clsMember MemberInfo { get;}

        public clsFine()
        {
            _Mode = enMode.AddNew;
            FineID = null;
            MemberID = null;
            BorrowingRecordID = null;
            NumberOfLateDays = null;
            FineAmount = null;
            PaymentStatus = null;
        }
        private clsFine(int? FineID, int? MemberID, int? BorrowingRecordID, short? NumberOfLateDays, 
            double? FineAmount, bool? PaymentStatus)
        {
            _Mode = enMode.Update;
            this.FineID = FineID;
            this.MemberID = MemberID;
            this.BorrowingRecordID = BorrowingRecordID;
            this.NumberOfLateDays = NumberOfLateDays;
            this.FineAmount = FineAmount;
            this.PaymentStatus = PaymentStatus;

            this.BorrowingInfo = clsBorrowingRecord.Find(this.BorrowingRecordID);
            this.MemberInfo = clsMember.Find(this.MemberID);
        }

        public static clsFine Find(int? FineID)
        {
            int? MemberID = null;
            int? BorrowingRecordID = null;
            short? NumberOfLateDays = null;
            double? FineAmount = null;
            bool? PaymentStatus = null;

            bool IsFound = clsFineData.GetFineInfoByID(FineID, ref MemberID, ref BorrowingRecordID, ref NumberOfLateDays, ref FineAmount, ref PaymentStatus);

            if (IsFound)
                return new clsFine(FineID, MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus);
            else
                return null;
        }

        public static bool IsFineExist(int? FineID)
        {
            return clsFineData.IsFineExist(FineID);
        }

        private bool _AddNewFine()
        {
            FineID = clsFineData.AddNewFine(MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus);
            return FineID.HasValue;
        }

        private bool _UpdateFine()
        {
            return clsFineData.UpdateFineInfo(FineID, MemberID, BorrowingRecordID, NumberOfLateDays, FineAmount, PaymentStatus);
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

        public static bool DeleteFine(int? FineID)
        {
            return clsFineData.DeleteFine(FineID);
        }

        public static DataTable GetAllFines()
        {
            return clsFineData.GetAllFines();
        }

        public static DataTable GetMemberFines(int? MemberID)
        {
            return clsFineData.GetMemberFines(MemberID);
        }

        public bool Pay()
        {
            return clsFineData.Pay(this.FineID);
        }

    }
}