using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBeginKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBedragen_Click(object sender, EventArgs e)
        {
            const double btw = 0.21;
            int beginKm = int.Parse(txtBeginKm.Text);
            int eindKm = int.Parse(txtEindKm.Text);
            double prijsKm = double.Parse(txtPrijsPerKm.Text);
            int geredenKm = eindKm - beginKm;
            double prijsExclBtw = geredenKm * prijsKm;
            double btwPrijs = prijsExclBtw * btw;
            double prijsInclBtw = btwPrijs + prijsExclBtw;
            lblPrijsExclBtwShow.Text = prijsExclBtw.ToString(".00");
            lblBtwShow.Text = btwPrijs.ToString(".00");
            lblPrijsInclBtwShow.Text = prijsInclBtw.ToString(".00");

        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            txtBeginKm.Text = "";
            txtEindKm.Text = "";
            txtPrijsPerKm.Text = "";
            lblPrijsExclBtwShow.Text = "";
            lblBtwShow.Text = "";
            lblPrijsInclBtwShow.Text = "";

        }
    }
}
