using Project_Yahtzee_Enkelvoudige_opdracht.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Yahtzee_Enkelvoudige_opdracht.Models
{
    public class YahtzeeModel
    {
        private List<Teerlingcontroller> teerlingen = new List<Teerlingcontroller>();
        
        private int aantalTeerlingen, huidigAantalWorpen, maximumAantalWorpen;

        #region Properties
        public List<Teerlingcontroller> Teerlingen {
            get { return teerlingen; }
            set { teerlingen = value; }
        }

        public int AantalTeerlingen {
            get { return aantalTeerlingen; }
            set { aantalTeerlingen = value; }
        }

        public int HuidigAantalWorpen {
            get { return huidigAantalWorpen; }
            set { huidigAantalWorpen = value; }
        }

        public int MaximumAantalWorpen
        {
            get { return maximumAantalWorpen; }
            set { maximumAantalWorpen = value; }
        }
        #endregion

        public int AantalWorpenUpdate()
        { 
            if (huidigAantalWorpen < maximumAantalWorpen)
                return ++huidigAantalWorpen;

            return huidigAantalWorpen;
        }

        public void AddTeerling(Teerlingcontroller t)
        {
            teerlingen.Add(t);
        }
    }
}
