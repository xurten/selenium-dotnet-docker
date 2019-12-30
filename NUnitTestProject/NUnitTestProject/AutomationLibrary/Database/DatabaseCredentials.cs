namespace NUnitTestProject.AutomationLibrary.Database
{
    public class DatabaseCredentials
    {
        public static string DatabasePath = $@"{System.IO.Path.GetFullPath(@"..\..\..\")}AutomationLibrary\Database\Database.mdf";
        public static string ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename={DatabasePath}; Integrated Security=True";
    }
}