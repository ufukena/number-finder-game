using NumberFinder.Game.Enums;

namespace NumberFinder.Game.Models
{
    public class GameSession
    {
        public GameType gameType { get; set; }

        public int targetNumber { get; set; }

        public int predictionCount { get; set; } = 50;

        public int currentScore { get; set; } 
        


    }
}
