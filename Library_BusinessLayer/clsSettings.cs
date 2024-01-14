using Library_DataAccessLayer;
using System;
using System.Data;

namespace Library_BusinessLayer
{
    public static class clsSettings
    {
        public static byte? DefaultBorrowDays { get; private set; }
        public static float? DefaultFinePerDay { get; private set; }

        static clsSettings()
        {
            GetSettings();
        }

        public static void GetSettings()
        {
            byte? defaultBorrowDays = null;
            float? defaultFinePerDay = null;

            clsSettingsData.GetSettingsInfo(ref defaultBorrowDays, ref defaultFinePerDay);

            DefaultBorrowDays = defaultBorrowDays;
            DefaultFinePerDay = defaultFinePerDay;
        }

        private static bool _UpdateSettings()
        {
            return clsSettingsData.UpdateSettingsInfo(DefaultBorrowDays, DefaultFinePerDay);
        }

        public static bool Save()
        {
            return _UpdateSettings();
        }

        public static DataTable GetAllSettings()
        {
            return clsSettingsData.GetAllSettings();
        }

    }
}