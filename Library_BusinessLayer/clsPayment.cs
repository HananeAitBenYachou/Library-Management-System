using Library_DataAccessLayer;
using System;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsPayment
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? PaymentID { get; private set; }
        public int? FineID { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? CreatedByUserID { get; set; }

        public clsPayment()
        {
            _Mode = enMode.AddNew;
            PaymentID = null;
            FineID = null;
            PaymentDate = null;
            CreatedByUserID = null;
        }
        private clsPayment(int? PaymentID, int? FineID, DateTime? PaymentDate, int? CreatedByUserID)
        {
            _Mode = enMode.Update;
            this.PaymentID = PaymentID;
            this.FineID = FineID;
            this.PaymentDate = PaymentDate;
            this.CreatedByUserID = CreatedByUserID;
        }

        public static clsPayment Find(int PaymentID)
        {
            int? FineID = null;
            DateTime? PaymentDate = null;
            int? CreatedByUserID = null;

            bool IsFound = clsPaymentData.GetPaymentInfoByID(PaymentID, ref FineID, ref PaymentDate, ref CreatedByUserID);

            if (IsFound)
                return new clsPayment(PaymentID, FineID, PaymentDate, CreatedByUserID);
            else
                return null;
        }

        public static bool IsPaymentExist(int PaymentID)
        {
            return clsPaymentData.IsPaymentExist(PaymentID);
        }

        private bool _AddNewPayment()
        {
            PaymentID = clsPaymentData.AddNewPayment(FineID, PaymentDate, CreatedByUserID);
            return PaymentID.HasValue;
        }

        private bool _UpdatePayment()
        {
            return clsPaymentData.UpdatePaymentInfo(PaymentID, FineID, PaymentDate, CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPayment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePayment();

            }
            return false;
        }

        public static bool DeletePayment(int PaymentID)
        {
            return clsPaymentData.DeletePayment(PaymentID);
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentData.GetAllPayments();
        }

    }
}