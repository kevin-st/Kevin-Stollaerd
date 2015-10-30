using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Project
{
    public partial class Yahtzeeview : UserControl
    {

        private YahtzeeController controller;

        public Yahtzeeview(YahtzeeController c)
        {
            InitializeComponent();
            controller = c;

            controller.model.MaximumAantalWorpen = 3;
            maxAantalWorpenLbl.Text = controller.model.MaximumAantalWorpen.ToString();
        }

        private void throwAllDice_Click(object sender, EventArgs e)
        {
            if (controller.model.HuidigAantalWorpen < controller.model.MaximumAantalWorpen)
            {
                UpdateAantalWorpen();
                controller.model.Teerlingen.ForEach(t => t.GetView().UpdateUI());
            }
            else
                throwAllDice.Enabled = false;

            //Yahtzee.scoreController.GetView().UpdateScoreLbl();
        }

        public void UpdateAantalWorpen()
        {
            aantalWorpenLbl.Text = controller.model.AantalWorpenUpdate().ToString();
        }
    }
}
