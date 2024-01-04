using System;
using System.Collections.Generic;
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

    }
}
