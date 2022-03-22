using Dapper;
using Microsoft.Data.Sqlite;

namespace NumberFinder.Game.DataAccess
{
    public static class DbConfig
    {
        public static  string ConnectionString => "Data Source=NumberFinder.db";

        
        public static void CheckDb()
        {

            using var connection = new SqliteConnection(ConnectionString);

            //Check Table exists
            var tableName = connection.QueryFirstOrDefault<string>("SELECT name FROM sqlite_master WHERE type='table' AND name = 'Scores';");

            if (!string.IsNullOrEmpty(tableName))
                return;

            var sqlQuery = "CREATE TABLE Scores (Id INTEGER PRIMARY KEY AUTOINCREMENT, ScoreValue INTEGER NOT NULL, ScoreDate DATE NOT NULL)";

            connection.ExecuteAsync(sqlQuery);


        }

    }

}
