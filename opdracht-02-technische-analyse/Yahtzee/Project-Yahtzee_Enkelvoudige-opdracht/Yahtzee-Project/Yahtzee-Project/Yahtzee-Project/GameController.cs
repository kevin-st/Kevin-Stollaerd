using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_Project
{
    class GameController
    {
        public YahtzeeController yController;

        public void UpdateScore()
        {
            new ScoreController().UpdateScore(); //new YahtzeeController().model.Teerlingen.Sum(t => t.model.AantalOgen);
        }
    }
}
