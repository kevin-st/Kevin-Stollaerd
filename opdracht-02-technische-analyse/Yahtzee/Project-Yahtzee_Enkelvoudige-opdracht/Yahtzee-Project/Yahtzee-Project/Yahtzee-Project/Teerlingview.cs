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
    public partial class Teerlingview : UserControl
    {
        TeerlingController controller;

        public Teerlingview(TeerlingController c)
        {
            InitializeComponent();
            controller = c;
        }

        private void werpBtn_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        public void UpdateUI()
        {
            aantalOgenLbl.Text = controller.model.Werp().ToString();
        }
    }
}
