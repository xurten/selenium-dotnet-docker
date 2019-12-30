using System;
namespace NUnitTestProject.AutomationLibrary.Database
{
    public class LogInformation
    {
        public int Id { get; set; }
        public string LogDetails { get; set; }
        public DateTime LogDate { get; set; }

        public LogInformation(string logDetails)
        {
            LogDetails = logDetails;
            LogDate = DateTime.Now;
        }
    }
}
