using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_Project
{
    public class YahtzeeController
    {
        private Yahtzeeview view;
        public Yahtzeemodel model = new Yahtzeemodel();

        public YahtzeeController()
        {
            view = new Yahtzeeview(this);
        }

        public Yahtzeeview GetView()
        {
            return view;
        }
    }
}
