using Library_DataAccessLayer;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int? UserID { get; private set; }
        public int? PersonID { get; set; }
        public string UserName { get; set; }
        public short? Permissions { get; set; }
        public bool? IsActive { get; set; }

        public clsPerson PersonInfo { get; }

        public enum enPermissions
        {
            enManageUsers = 1,
            enManageMemebers = 2,
            enManageBooks = 4,
            enManageBooksBorrowings = 8,
            enManageBooksReservations = 16,
            enManageFines = 32,
            eAll = -1
        }

        public enum enUserRole { Admin = 1 , Assistant = 2 }

        public enUserRole UserRole
        {
            get
            {
                return this.Permissions == -1 ? enUserRole.Admin : enUserRole.Assistant;
            }
        }

        public clsUser()
        {
            _Mode = enMode.AddNew;
            UserID = null;
            PersonID = null;
            UserName = null;
            Permissions = null;
            IsActive = null;
        }
        private clsUser(int? UserID, int? PersonID, string UserName, short? Permissions, bool? IsActive)
        {
            _Mode = enMode.Update;
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Permissions = Permissions;
            this.IsActive = IsActive;
            PersonInfo = clsPerson.Find(PersonID);
        }

        public static clsUser Find(int? UserID)
        {
            int? PersonID = null;
            string UserName = null;
            short? Permissions = null;
            bool? IsActive = null;

            bool IsFound = clsUserData.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Permissions, ref IsActive);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Permissions, IsActive);
            else
                return null;
        }

        public static clsUser Find(string UserName)
        {
            int? PersonID = null;
            int? UserID = null;
            short? Permissions = null;
            bool? IsActive = null;

            bool IsFound = clsUserData.GetUserInfoByName(UserName ,ref UserID, ref PersonID, ref Permissions, ref IsActive);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Permissions, IsActive);
            else
                return null;
        }

        public static clsUser FindByPersonID(int? PersonID)
        {
            string UserName = null;
            int? UserID = null;
            short? Permissions = null;
            bool? IsActive = null;

            bool IsFound = clsUserData.GetUserInfoByPersonID(PersonID , ref UserName, ref UserID, ref Permissions, ref IsActive);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Permissions, IsActive);
            else
                return null;
        }

        public static bool IsUserExist(int? UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        public static bool IsUserExistByPersonID(int? PersonID)
        {
            return clsUserData.IsUserExistByPersonID(PersonID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserData.IsUserExist(UserName);
        }

        private bool _AddNewUser()
        {
            UserID = clsUserData.AddNewUser(PersonID, UserName, Permissions, IsActive);
            return UserID.HasValue;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUserInfo(UserID, PersonID, UserName, Permissions, IsActive);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUser();

            }
            return false;
        }

        public static bool DeleteUser(int? UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public bool CheckAccessPermissions(enPermissions permissions)
        {
            if (Permissions == -1)
                return true;

            if (((short)permissions & Permissions) == (short)(permissions))
                return true;

            return false;
        }

        public bool UpdateUserPassword(string NewPassword)
        {
            return this.PersonInfo.UpdatePersonPassword(PersonID, NewPassword);
        }

        public static int GetUsersCount()
        {
            return clsUserData.GetUsersCount();
        }

    }
}