using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Utility
{
    public class clsUtility
    {
        public static bool CreateFolderIfNotExist(string folderPath)
        {
            if(!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                    return true;
                }
                catch (Exception ex)
                {
                    clsErrorLogger.LogError(ex);
                    return false;
                }
            }

            return true;
        }

        public static string ReplaceFileNameWithGuid(string sourceFilePath)
        {
            FileInfo fileInfo = new FileInfo(sourceFilePath);

            return Guid.NewGuid().ToString() + fileInfo.Extension;              
        }

        public static bool CopyImageToProjectImagesFolder(string destinationFolder , ref string sourceFile)
        {
            if (!CreateFolderIfNotExist(destinationFolder))
                return false;

            try
            {
                string distinationFile = Path.Combine(destinationFolder, ReplaceFileNameWithGuid(sourceFile));

                File.Copy(sourceFile, distinationFile);
                File.Delete(sourceFile);

                sourceFile = distinationFile;

                return true;
            }

            catch(Exception ex) 
            {
                clsErrorLogger.LogError(ex);
                return false;
            }
        }

        public static bool StorePersonCredintialsToRegistery(string Email , string Password)
        {
            // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\Software\YourSoftware";
            string valueName1 = "Email";
            string valueName2 = "Password";

            string key = ConfigurationManager.AppSettings["Key"];

            try
            {
                // Write the email and password to the Registry
                Registry.SetValue(keyPath, valueName1, clsCryptoUtility.Encrypt(Email, key), RegistryValueKind.String);
                Registry.SetValue(keyPath, valueName2, clsCryptoUtility.Encrypt(Password, key), RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                return false;
            }
        }

        public static bool GetPersonCredintialsFromRegistery(ref string Email, ref string Password)
        {
            // Specify the Registry key and path
            string keyPath = @"HKEY_CURRENT_USER\Software\YourSoftware";
            string valueName1 = "Email";
            string valueName2 = "Password";

            string key = ConfigurationManager.AppSettings["Key"];

            try
            {
                // Read the email and password from the Registry
                string emailData = Registry.GetValue(keyPath, valueName1, null) as string;
                string passwordData = Registry.GetValue(keyPath, valueName2, null) as string;

                if(emailData != null && passwordData != null) 
                {  
                    Email = clsCryptoUtility.Decrypt(emailData,key);
                    Password = clsCryptoUtility.Decrypt(passwordData, key);
                    return true;
                }

                return false;
            }

            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                return false;
            }
        }

        public static bool DeletePersonCredintialsFromRegistery(string Email, string Password)
        {
            // Specify the Registry key and path
            string keyPath = @"SOFTWARE\YourSoftware";
            string valueName1 = "Email";
            string valueName2 = "Password";

            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                    {
                        if (key != null)
                        {
                            // Delete the email and password 
                            key.DeleteValue(valueName1);
                            key.DeleteValue(valueName2);

                            return true;
                        }
                        else
                            return false;
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                clsErrorLogger.LogError(ex);
                return false;
            }
            catch (Exception ex)
            {
                clsErrorLogger.LogError(ex);
                return false;
            }
        }

    }
}
