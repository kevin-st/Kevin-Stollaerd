using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_Project
{
    public class TeerlingController
    {
        private Teerlingview view;
        public Teerlingmodel model = new Teerlingmodel();

        public TeerlingController()
        {
            view = new Teerlingview(this);
        }

        public Teerlingview GetView()
        {
            return view;
        }
    }
}
