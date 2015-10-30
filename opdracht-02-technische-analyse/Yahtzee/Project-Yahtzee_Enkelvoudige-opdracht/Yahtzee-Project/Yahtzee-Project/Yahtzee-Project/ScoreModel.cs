using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_Project
{
    public class ScoreModel
    {
        private int score;
        private int highscore;

        #region Properties
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public int Highscore
        {
            get { return highscore; }
            set { highscore = value; }
        }
        #endregion 

    }
}
