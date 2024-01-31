using Library_BusinessLayer;
using Library_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.GlobalClasses
{
    public static class clsGlobal
    {
        public enum enLoginMode { User= 1 , Member = 2};

        public static enLoginMode LoginMode { get; private set; }

        private static clsUser _CurrentUser;
        public static clsUser CurrentUser
        {
            set
            {
                _CurrentUser = value;
                LoginMode = enLoginMode.User;
            }

            get
            {
                return _CurrentUser;
            }
        }

        private static clsMember _CurrentMember;
        public static clsMember CurrentMember
        {
            set
            {
                _CurrentMember = value;
                LoginMode = enLoginMode.Member;
            }

            get
            {
                return _CurrentMember;
            }

        }

        public static bool StorePersonCredentials(string Email ,string Password)
        {
            if(Email == string.Empty || Password == string.Empty)
            {
                return clsUtility.DeletePersonCredintialsFromRegistery(Email, Password);
            }

            return clsUtility.StorePersonCredintialsToRegistery(Email, Password);
        }

        public static bool GetStoredPersonCredentials(ref string Email, ref string Password)
        {
            return clsUtility.GetPersonCredintialsFromRegistery(ref Email, ref Password);
        }

    }
}
