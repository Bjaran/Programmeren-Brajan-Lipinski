using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            const int prijsShirt = 30;
            const int prijsBroek = 100;
            const double btw = 0.21;
            int shirts = int.Parse(txtThirts.Text);
            int broeken = int.Parse(txtBroeken.Text); 
            int totaalPrijsShirts = shirts * prijsShirt;
            int totaalPrijsBroeken = broeken * prijsBroek;
            int totaalPrijsExclBtw = totaalPrijsBroeken + totaalPrijsShirts;
            double btwPrijs = totaalPrijsExclBtw * btw;
            double totaalPrijs = btwPrijs + totaalPrijsExclBtw;
            lblDatumShow.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            lblPrijsShow.Text = "€ " + totaalPrijsExclBtw.ToString(".00");
            lblBtwShow.Text = "€ " + btwPrijs.ToString(".00");
            lblTotaalPrijsShow.Text = "€ " + totaalPrijs.ToString(".00");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblTotaalPrijs_Click(object sender, EventArgs e)
        {

        }
    }
}
