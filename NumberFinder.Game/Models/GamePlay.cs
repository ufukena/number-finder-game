using NumberFinder.Game.Enums;

namespace NumberFinder.Game.Models
{
    public class GamePlay
    {
        public GameType GameType { get; set; }

        public int TargetNumber { get; set; }

        public int KnowNumber { get; set; }

        public int PredictionCount { get; set; } 

        public int GeneralPredictionCount { get; set; } = 50;

        public int CurrentScore { get; set; } 



    }
}
