using Project_Yahtzee_Enkelvoudige_opdracht.Models;
using Project_Yahtzee_Enkelvoudige_opdracht.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahtzee_Enkelvoudige_opdracht.Controllers
{
    public class Teerlingcontroller
    {
        private Teerlingview view;
        public Teerlingmodel model;

        public Teerlingcontroller()
        {
            view = new Teerlingview(this);
            model = new Teerlingmodel();
        }

        public Teerlingview GetView()
        {
            return view;
        }
    }
}
