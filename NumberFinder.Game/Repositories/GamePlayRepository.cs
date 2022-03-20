using System;

namespace NumberFinder.Game.Repositories
{
    public class GamePlayRepository : IGamePlayRepository
    {

        public int SetTargetNumber(Enums.GameType gameType)
        {
            Random random = new Random();

            if (gameType == Enums.GameType.type_0_100)
            {
                return random.Next(100);
            }
            else if (gameType == Enums.GameType.type_0_100)
            {
                return random.Next(1000);
            }
            else
            {
                return random.Next(10000);
            }

        }


    }
}
