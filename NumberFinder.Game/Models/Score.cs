using System;
using System.ComponentModel.DataAnnotations;

namespace NumberFinder.Game.Models
{
    public class Score
    {

        public int RowNumber { get; set; }

        public int ScoreValue { get; set; }

        public DateTime ScoreDate { get; set; }

    }

}
