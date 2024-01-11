using System;
using System.Windows.Forms;
using LibraryManagementSystem.Authors;
using LibraryManagementSystem.Books;
using LibraryManagementSystem.Members;
using LibraryManagementSystem.People;
using LibraryManagementSystem.Users;

namespace LibraryManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmListBooks());

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}