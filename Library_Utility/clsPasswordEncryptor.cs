using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Library_Utility
{
    public static class clsPasswordEncryptor
    {
        public static string ComputeHash(string inputData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(inputData));

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

    }
}
