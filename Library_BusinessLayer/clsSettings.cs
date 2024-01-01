using Library_DataAccessLayer;
using System.Data;

namespace Library_BusinessLayer
{
    public class clsSettings
    {
        public byte? DefaultBorrowDays { get; private set; }
        public float? DefaultFinePerDay { get; set; }

        public clsSettings()
        {
            DefaultBorrowDays = null;
            DefaultFinePerDay = null;
        }

        private bool _UpdateSettings()
        {
            return clsSettingsData.UpdateSettingsInfo(DefaultBorrowDays, DefaultFinePerDay);
        }

        public bool Save()
        {
            return _UpdateSettings();
        }

        public static DataTable GetAllSettings()
        {
            return clsSettingsData.GetAllSettings();
        }

    }
}