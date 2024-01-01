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

        public clsUser()
        {
            _Mode = enMode.AddNew;
            UserID = null;
            PersonID = null;
            UserName = null;
            Permissions = null;
        }
        private clsUser(int? UserID, int? PersonID, string UserName, short? Permissions)
        {
            _Mode = enMode.Update;
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Permissions = Permissions;
        }

        public static clsUser Find(int UserID)
        {
            int? PersonID = null;
            string UserName = null;
            short? Permissions = null;

            bool IsFound = clsUserData.GetUserInfoByID(UserID, ref PersonID, ref UserName, ref Permissions);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Permissions);
            else
                return null;
        }

        public static bool IsUserExist(int UserID)
        {
            return clsUserData.IsUserExist(UserID);
        }

        private bool _AddNewUser()
        {
            UserID = clsUserData.AddNewUser(PersonID, UserName, Permissions);
            return UserID.HasValue;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUserInfo(UserID, PersonID, UserName, Permissions);
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

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

    }
}