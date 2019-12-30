using System.Data.SqlClient;

namespace NUnitTestProject.AutomationLibrary.Database
{
    public class LogInformationDatabaseImplementation : IRepository
    {
        public int Add(LogInformation information)
        {
            var sqlConnection = new SqlConnection(DatabaseCredentials.ConnectionString);
            sqlConnection.Open();
            var insertQuery = $"insert into LogInformation(LogDetails, LogDate) values ('{information.LogDetails}', {information.LogDate.ToString("MM/dd/yyyy").Replace('.','/')})";
            var insertCommand = new SqlCommand(insertQuery, sqlConnection);
            var affectedRowCount = insertCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return affectedRowCount;
        }
    }
}