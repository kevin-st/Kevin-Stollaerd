using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_Project
{
    public partial class Yahtzee : Form
    {
        TeerlingController teerlingController;
        Teerlingview tView;

        public static YahtzeeController yahtzeeController;
        Yahtzeeview yView;

        public static ScoreController scoreController;
        Scoreview sView;

        internal void Initialize()
        {
            teerlingController = new TeerlingController();
            yahtzeeController = new YahtzeeController();
            scoreController = new ScoreController();

            yahtzeeController.model.AantalTeerlingen = 3;
            yahtzeeController.model.MaximumAantalWorpen = 3;
        }

        public Yahtzee()
        {
            InitializeComponent();
            Initialize();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            sView = scoreController.GetView();
            sView.Location = new Point(0, 0);
            Controls.Add(sView);

            for (int i = 0; i < yahtzeeController.model.AantalTeerlingen; i++)
            {
                yahtzeeController.model.AddTeerling(new TeerlingController());
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

