using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_Project
{
    public class ScoreController
    {
        private Scoreview view;
        public ScoreModel model = new ScoreModel();

        public ScoreController()
        {
            view = new Scoreview(this);
        }

        public Scoreview GetView()
        {
            return view;
        }

        //public void UpdateScore()
        //{
        //    view.UpdateScore();
        //}
    }
}
