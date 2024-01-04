using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library_Utility
{
    public class clsValidation
    {
        private static bool IsMatch(string pattern , string value)
        {
            return Regex.IsMatch(pattern, value);
        }

        public static bool ValidateFloat(string number)
        {
            string pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            return IsMatch(pattern , number);
        }

        public static bool ValidateInteger(string number)
        {
            string pattern = @"^[0-9]*$";

            return IsMatch(pattern, number);
        }

        public static bool IsValidNumber(string number)
        {
            return ValidateInteger(number) || ValidateFloat(number);
        }

        public static bool IsValidEmailAddress(string email)
        {
            string pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            return IsMatch(pattern, email);
        }

    }
}
