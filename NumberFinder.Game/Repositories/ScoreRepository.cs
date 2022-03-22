using Dapper;
using Microsoft.Data.Sqlite;
using NumberFinder.Game.DataAccess;
using NumberFinder.Game.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NumberFinder.Game.Repositories
{

    public class ScoreRepository : IScoreRepository
    {
        

        public async Task Create(Score score)
        {
            var sqlQuery = "INSERT INTO Scores (ScoreValue, ScoreDate) VALUES (@ScoreValue, @ScoreDate)";

            using (var connection = new SqliteConnection(DbConfig.ConnectionString))
            {
                await connection.ExecuteAsync(sqlQuery, new
                {
                    score.ScoreValue,
                    score.ScoreDate 
                });

              
            }
        }



        public IEnumerable<Score> Get()
        {            
            var sqlQuery = "SELECT ROW_NUMBER() OVER(ORDER BY ScoreValue DESC) as RowNumber, ScoreValue, ScoreDate FROM Scores";

            using (var connection = new SqliteConnection(DbConfig.ConnectionString))
            {
                 return connection.Query<Score>(sqlQuery);
            }

        }



    }


}
