using NumberFinder.Game.Enums;
using NumberFinder.Game.Models;

namespace NumberFinder.Game.Repositories
{
    public interface IGamePlayRepository
    {
        public void SetTargetNumber(ref GamePlay gamePlay);

        public void CalculateScore(ref GamePlay gamePlay);


    }
}