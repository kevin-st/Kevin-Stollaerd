using Project_Yahtzee_Enkelvoudige_opdracht.Views;
using Project_Yahtzee_Enkelvoudige_opdracht.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahtzee_Enkelvoudige_opdracht.Controllers
{
    public class YahtzeeController
    {
        private YahtzeeView view;
        public YahtzeeModel model = new YahtzeeModel();

        public YahtzeeController()
        {
            view = new YahtzeeView(this);
        }

        public YahtzeeView GetView()
        {
            return view;
        }

        public int UpdateScore()
        {
            return view.UpdateScore();
        }
    }
}
