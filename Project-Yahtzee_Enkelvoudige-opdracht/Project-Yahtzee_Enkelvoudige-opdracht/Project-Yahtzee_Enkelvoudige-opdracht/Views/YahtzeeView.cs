using Project_Yahtzee_Enkelvoudige_opdracht.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Yahtzee_Enkelvoudige_opdracht.Views
{
    public partial class YahtzeeView : UserControl
    {
        private YahtzeeController controller;

        public YahtzeeView(YahtzeeController c)
        {
            InitializeComponent();
            controller = c;

            controller.model.MaximumAantalWorpen = 3;

            maxAantalWorpenLbl.Text = controller.model.MaximumAantalWorpen.ToString();
        }

        private void throwAllBtn_Click(object sender, EventArgs e)
        {
            if (controller.model.HuidigAantalWorpen < controller.model.MaximumAantalWorpen)
            {
                UpdateAantalWorpen();
                controller.model.Teerlingen.ForEach(t => t.GetView().UpdateUI());
            }
            else
                throwAllBtn.Enabled = false;

            Yahtzee_Game.scoreBoardController.GetView().UpdateScoreLbl();
        }

        public void UpdateAantalWorpen()
        {
            aantalWorpenLbl.Text = controller.model.AantalWorpenUpdate().ToString();
        }

        public int UpdateScore()
        {
            return controller.model.Teerlingen.Sum(x => x.model.AantalOgen);
        }
    }
}
