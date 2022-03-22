using NumberFinder.Game.Models;
using System;

namespace NumberFinder.Game.Repositories
{
    public class GamePlayRepository : IGamePlayRepository
    {
       

        public void CalculateScore(ref GamePlay gamePlay)
        {
            int multiplier = 0;
            int bonus = 0;

            // Adding Game Level Multiplier            
            switch (gamePlay.GameType)
            {
                case Enums.GameType.type_0_100:
                    multiplier = 1; break;
                case Enums.GameType.type_0_1000:
                    multiplier = 3; break;
                case Enums.GameType.type_0_10000:
                    multiplier = 6; break;                
            }

            //Adding Bonus
            switch (gamePlay.PredictionCount)
            {
                case 1:
                    bonus = multiplier * 500; break;
                case 2:
                    bonus = multiplier * 200; break;
                case 3:
                    bonus = multiplier * 100; break;
                case 4:
                    bonus = multiplier * 80; break;
                case 5:
                    bonus = multiplier * 60; break;
                case 6:
                    bonus = multiplier * 45; break;
                case 7:
                    bonus = multiplier * 30; break;
                case 8:
                    bonus = multiplier * 20; break;
                case 9:
                    bonus = multiplier * 10; break;
                case 10:
                    bonus = multiplier * 5; break;
                default:
                    bonus = 0;
                    break;
            }

            gamePlay.CurrentScore += multiplier * (100 - gamePlay.PredictionCount) + bonus;

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
