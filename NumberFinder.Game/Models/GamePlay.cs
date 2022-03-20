using NumberFinder.Game.Enums;
using System.Collections.Generic;

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

        public List<int> Predictions { get; set; } = new List<int>();




    }
}
