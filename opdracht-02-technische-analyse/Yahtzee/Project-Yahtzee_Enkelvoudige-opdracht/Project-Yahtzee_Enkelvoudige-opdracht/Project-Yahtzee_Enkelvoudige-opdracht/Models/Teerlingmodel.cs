using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Yahtzee_Enkelvoudige_opdracht.Models
{
    public class Teerlingmodel
    {
        // Variable to store the number of eyes
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
