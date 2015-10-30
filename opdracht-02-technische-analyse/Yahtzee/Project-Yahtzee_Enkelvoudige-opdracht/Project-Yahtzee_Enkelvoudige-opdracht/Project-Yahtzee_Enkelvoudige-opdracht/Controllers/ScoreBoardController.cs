using Project_Yahtzee_Enkelvoudige_opdracht.Views;
using Project_Yahtzee_Enkelvoudige_opdracht.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahtzee_Enkelvoudige_opdracht.Controllers
{
    public class ScoreBoardController
    {
        private ScoreBoardView view;
        public ScoreBoardModel model = new ScoreBoardModel();

        public ScoreBoardController()
        {
            view = new ScoreBoardView(this);
        }

        public ScoreBoardView GetView()
        {
            return view;
        }
    }
}
