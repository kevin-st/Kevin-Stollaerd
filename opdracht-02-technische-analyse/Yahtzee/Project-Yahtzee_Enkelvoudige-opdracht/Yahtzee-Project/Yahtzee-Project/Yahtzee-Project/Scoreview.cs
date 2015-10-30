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
    public partial class Scoreview : UserControl
    {
        private ScoreController controller;
        private GameController gController = new GameController();

        public Scoreview(ScoreController c)
        {
            InitializeComponent();
            controller = c;
        }

        public void UpdateScoreLbl()
        {
            gController.yController = new YahtzeeController();

            scoreLbl.Text = gController.yController.model.Teerlingen.Sum(t => t.model.AantalOgen).ToString();
        }
    }
}
