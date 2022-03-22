using NumberFinder.Game.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NumberFinder.Game.Repositories
{
    public interface IScoreRepository
    {
        Task Create(Score score);
        IEnumerable<Score> Get();
    }
}