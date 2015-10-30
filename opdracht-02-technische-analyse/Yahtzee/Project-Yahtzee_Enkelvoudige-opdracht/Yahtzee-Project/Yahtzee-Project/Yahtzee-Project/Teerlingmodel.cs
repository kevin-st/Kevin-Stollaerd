using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_Project
{
    public class Teerlingmodel
    {
        private int aantalOgen;

        public int AantalOgen
        {
            get { return aantalOgen; }
            set { aantalOgen = value; }
        }

        public int Werp()
        {
            return new Random().Next(1, 7);
        }
    }
}
