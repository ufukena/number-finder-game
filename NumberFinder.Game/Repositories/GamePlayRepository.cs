using NumberFinder.Game.Models;
using System;

namespace NumberFinder.Game.Repositories
{
    public class GamePlayRepository : IGamePlayRepository
    {
       

        public void CalculateScore(ref GamePlay gamePlay)
        {
            int multiplier = 0;

            if (gamePlay.GameType == Enums.GameType.type_0_100) {
                multiplier = 1;
            }
            else if (gamePlay.GameType == Enums.GameType.type_0_100) {
                multiplier = 3;
            }
            else {
                multiplier = 6;
            }

            gamePlay.CurrentScore += multiplier * (100 - gamePlay.PredictionCount);

        }

       

        public void SetTargetNumber(ref GamePlay gamePlay)
        {
            Random random = new Random();

            if (gamePlay.GameType == Enums.GameType.type_0_100)
            {
                gamePlay.TargetNumber =  random.Next(100);
            }
            else if (gamePlay.GameType == Enums.GameType.type_0_1000)
            {
                gamePlay.TargetNumber = random.Next(1000);
            }
            else
            {
                gamePlay.TargetNumber = random.Next(10000);
            }

        }


    }
}
