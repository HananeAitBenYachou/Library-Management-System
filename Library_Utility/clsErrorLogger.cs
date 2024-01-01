using System;
using System.Diagnostics;
using System.Reflection;

namespace Library_Utility
{
    public static class clsErrorLogger
    {
        public static void LogError(Exception ex)
        {
            string sourceName = Assembly.GetEntryAssembly().GetName().Name;

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }

            string errorMessage = $"Exception occurred in: {ex.Source}\n" +
                $"Exception Message: {ex.Message}\n" +
                $"Exception Type: {ex.GetType().Name}\n" +
                $"Stack Trace: {ex.StackTrace}\n" +
                $"Error Location: {ex.TargetSite.Name}\n";

            EventLog.WriteEntry(sourceName, errorMessage, EventLogEntryType.Error);
        }

    }

}
