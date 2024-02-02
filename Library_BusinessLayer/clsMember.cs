using Library_DataAccessLayer;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsMember
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? MemberID { get; private set; }
        public string LibraryCardNumber { get; set; }
        public int? PersonID { get; set; }

        public clsPerson PersonInfo { get; }
        public clsMember()
        {
            _Mode = enMode.AddNew;
            MemberID = null;
            LibraryCardNumber = null;
            PersonID = null;
        }
        private clsMember(int? MemberID, string LibraryCardNumber, int? PersonID)
        {
            _Mode = enMode.Update;
            this.MemberID = MemberID;
            this.LibraryCardNumber = LibraryCardNumber;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(this.PersonID);
        }

        public static clsMember Find(int? MemberID)
        {
            string LibraryCardNumber = null;
            int? PersonID = null;

            bool IsFound = clsMemberData.GetMemberInfoByID(MemberID, ref LibraryCardNumber, ref PersonID);

            if (IsFound)
                return new clsMember(MemberID, LibraryCardNumber, PersonID);
            else
                return null;
        }

        public static clsMember FindByPersonID(int? PersonID)
        {
            string LibraryCardNumber = null;
            int? MemberID = null;

            bool IsFound = clsMemberData.GetMemberInfoByPersonID(PersonID, ref MemberID, ref LibraryCardNumber);

            if (IsFound)
                return new clsMember(MemberID, LibraryCardNumber, PersonID);
            else
                return null;
        }

        public static clsMember Find(string LibraryCardNumber)
        {
            int? MemberID = null;
            int? PersonID = null;

            bool IsFound = clsMemberData.GetMemberInfoByLibraryCardNo(LibraryCardNumber, ref MemberID, ref PersonID);

            if (IsFound)
                return new clsMember(MemberID, LibraryCardNumber, PersonID);
            else
                return null;
        }

        public static bool IsMemberExist(int? MemberID)
        {
            return clsMemberData.IsMemberExist(MemberID);
        }

        public static bool IsMemberExistByPersonID(int? PersonID)
        {
            return clsMemberData.IsMemberExistByPersonID(PersonID);
        }

        public static bool IsMemberExist(string LibraryCardNumber)
        {
            return clsMemberData.IsMemberExist(LibraryCardNumber);
        }

        private bool _AddNewMember()
        {
            MemberID = clsMemberData.AddNewMember(LibraryCardNumber, PersonID);
            return MemberID.HasValue;
        }

        private bool _UpdateMember()
        {
            return clsMemberData.UpdateMemberInfo(MemberID, LibraryCardNumber, PersonID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMember())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateMember();

            }
            return false;
        }

        public static bool DeleteMember(int? MemberID)
        {
            return clsMemberData.DeleteMember(MemberID);
        }

        public static DataTable GetAllMembers()
        {
            return clsMemberData.GetAllMembers();
        }

        public bool UpdateMemberPassword(string NewPassword)
        {
            return this.PersonInfo.UpdatePersonPassword(PersonID, NewPassword);
        }

        public static int GetMembersCount()
        {
            return clsMemberData.GetMembersCount();
        }
    }
}