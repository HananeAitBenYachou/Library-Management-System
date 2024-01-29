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
        public static clsUser CurrentUser;
        public static clsMember CurrentMember = clsMember.Find(2);

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
