using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_Project
{
    public class Yahtzeemodel
    {
        private List<TeerlingController> teerlingen = new List<TeerlingController>();
        private int aantalTeerlingen, huidigAantalWorpen, maximumAantalWorpen;

        #region Properties
        public List<TeerlingController> Teerlingen
        {
            get { return teerlingen; }
            set { teerlingen = value; }
        }

        public int AantalTeerlingen
        {
            get { return aantalTeerlingen; }
            set { aantalTeerlingen = value; }
        }

        public int HuidigAantalWorpen
        {
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

        public void AddTeerling(TeerlingController t)
        {
            teerlingen.Add(t);
        }
    }
}
