using Project_Yahtzee_Enkelvoudige_opdracht.Controllers;
using Project_Yahtzee_Enkelvoudige_opdracht.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Yahtzee_Enkelvoudige_opdracht
{
    public partial class Yahtzee_Game : Form
    {
        Teerlingcontroller teerlingController;
        Teerlingview tView;

        public static YahtzeeController yahtzeeController;
        YahtzeeView yView;

        public static ScoreBoardController scoreBoardController;
        ScoreBoardView sView;

        internal void Initialize()
        {
            teerlingController = new Teerlingcontroller();
            yahtzeeController = new YahtzeeController();
            scoreBoardController = new ScoreBoardController();

            yahtzeeController.model.AantalTeerlingen = 3;
        }

        public Yahtzee_Game()
        {
            InitializeComponent();
            Initialize();
        }

        private void Yahtzee_Game_Load(object sender, EventArgs e)
        {
            sView = scoreBoardController.GetView();
            sView.Location = new Point(0, 0);
            Controls.Add(sView);

            for (int i = 0; i < yahtzeeController.model.AantalTeerlingen; i++)
            {
                yahtzeeController.model.AddTeerling(new Teerlingcontroller());
                tView = yahtzeeController.model.Teerlingen[i].GetView();
                tView.Location = new Point((i * tView.Width), sView.Height);
                Controls.Add(tView);
            }

            yView = yahtzeeController.GetView();
            yView.Location = new Point(0, tView.Height + 135);
            Controls.Add(yView);
        }
    }
}
