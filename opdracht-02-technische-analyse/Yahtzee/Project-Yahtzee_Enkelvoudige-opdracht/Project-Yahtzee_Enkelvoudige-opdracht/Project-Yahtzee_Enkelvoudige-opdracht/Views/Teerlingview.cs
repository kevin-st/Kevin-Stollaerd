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
    public partial class Teerlingview : UserControl
    {
        private Teerlingcontroller controller;

        public Teerlingview(Teerlingcontroller c)
        {
            InitializeComponent();
            controller = c;
        }

        #region Didn't need Load function
        private void Teerlingview_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        private void werpBtn_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        public void UpdateUI()
        {
            scoreLbl.Text = controller.model.Werp().ToString();
        }
    }
}
