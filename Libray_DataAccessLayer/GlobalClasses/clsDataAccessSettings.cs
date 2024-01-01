using System.Configuration;

namespace Libray_DataAccessLayer
{
    internal static class clsDataAccessSettings
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
    }
}
