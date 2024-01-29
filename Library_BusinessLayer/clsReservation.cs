using Library_DataAccessLayer;
using System;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsReservation
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? ReservationID { get; private set; }
        public int? MemberID { get; set; }
        public int? BookCopyID { get; set; }
        public DateTime? ReservationDate { get; set; }

        public clsMember MemberInfo { get;}
        public clsBookCopy BookCopyInfo { get; }

        public clsReservation()
        {
            _Mode = enMode.AddNew;
            ReservationID = null;
            MemberID = null;
            BookCopyID = null;
            ReservationDate = null;
        }
        private clsReservation(int? ReservationID, int? MemberID, int? BookCopyID, DateTime? ReservationDate)
        {
            _Mode = enMode.Update;
            this.ReservationID = ReservationID;
            this.MemberID = MemberID;
            this.BookCopyID = BookCopyID;
            this.ReservationDate = ReservationDate;

            this.MemberInfo = clsMember.Find(this.MemberID);
            this.BookCopyInfo = clsBookCopy.Find(this.BookCopyID);
        }

        public static clsReservation Find(int? ReservationID)
        {
            int? MemberID = null;
            int? BookCopyID = null;
            DateTime? ReservationDate = null;

            bool IsFound = clsReservationData.GetReservationInfoByID(ReservationID, ref MemberID, ref BookCopyID, ref ReservationDate);

            if (IsFound)
                return new clsReservation(ReservationID, MemberID, BookCopyID, ReservationDate);
            else
                return null;
        }

        public static bool IsReservationExist(int? ReservationID)
        {
            return clsReservationData.IsReservationExist(ReservationID);
        }

        private bool _AddNewReservation()
        {
            ReservationID = clsReservationData.AddNewReservation(MemberID, BookCopyID, ReservationDate);
            return ReservationID.HasValue;
        }

        private bool _UpdateReservation()
        {
            return clsReservationData.UpdateReservationInfo(ReservationID, MemberID, BookCopyID, ReservationDate);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewReservation())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateReservation();

            }
            return false;
        }

        public static bool DeleteReservation(int? ReservationID)
        {
            return clsReservationData.DeleteReservation(ReservationID);
        }

        public static DataTable GetAllReservations()
        {
            return clsReservationData.GetAllReservations();
        }

        public static DataTable GetMemberReservations(int? MemberID)
        {
            return clsReservationData.GetMemberReservations(MemberID);
        }

        public static DataTable GetBookCopyReservations(int? BookCopyID)
        {
            return clsReservationData.GetBookCopyReservations(BookCopyID);
        }

    }
}