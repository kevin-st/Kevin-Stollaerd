using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahtzee_Enkelvoudige_opdracht.Models
{
    public class ScoreBoardModel
    {
        private int score;
        private int highscore;

        #region Properties
        public int Score {
            get { return score; }
            set { score = value; }
        }

        public int Highscore
        {
            get { return highscore; }
            set { highscore = value; }
        }
        #endregion 

        public int UpdateScore()
        {
            if (score < highscore)
                return Yahtzee_Game.yahtzeeController.UpdateScore();
            else
                return score;
        }
    }
}
