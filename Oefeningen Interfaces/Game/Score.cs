using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Score
    {
        public Score()
        {
            GameTurns = 0; // max 500
            ShotsFired = 0;
            MonstersKilled = 0;
            RockDestroyed = 0;
        }
        public int GameTurns { get; set; }
        public int ShotsFired { get; set; }
        public int MonstersKilled { get; set; }
        public int RockDestroyed { get; set; }

        public override string ToString()
        {
            //theorethical max score = 10 000 with 20 turns, 0 monsters killed and 0 shots missed
            //more normal score would be one with +-30 turns and 0-5 monsters killed with 80% accuracy

            double score = 20000/ (GameTurns/10.0);
            score += ( MonstersKilled*100 )*( (MonstersKilled + RockDestroyed) / (double)ShotsFired );

            score = Math.Min(10000, score);
            string scoreString = Convert.ToString(Math.Round(score));
            return scoreString;
        }
    }
}
