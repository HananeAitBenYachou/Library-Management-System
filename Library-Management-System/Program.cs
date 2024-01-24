﻿using System;
using System.Windows.Forms;
using LibraryManagementSystem.Books;
using LibraryManagementSystem.Books.BookCopies;
using LibraryManagementSystem.Borrowings_Returns;
using LibraryManagementSystem.Genres;
using LibraryManagementSystem.Members;

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
           Application.Run(new frmLogin());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}