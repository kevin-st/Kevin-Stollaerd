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
    public partial class ScoreBoardView : UserControl
    {
        private ScoreBoardController controller;

        public ScoreBoardView(ScoreBoardController c)
        {
            InitializeComponent();
            controller = c;
        }

        public void UpdateScoreLbl()
        {
            scoreLbl.Text = Yahtzee_Game.yahtzeeController.UpdateScore().ToString();
        }
    }
}
