using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnBereken_Click(object sender, EventArgs e)
        {
          double prijs = double.Parse(txtPrijs.Text);
          const double btw = 0.21;
          double prijsBtw = prijs * btw;
          double totaalPrijs = prijsBtw + prijs;
            lblPrijs.Text = prijs.ToString();
            lblBtw.Text = prijsBtw.ToString("0.00");
            lblTotaalPrijs.Text = totaalPrijs.ToString("0.00");
        }

        private void TxtPrijs_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblGeefPrijs_Click(object sender, EventArgs e)
        {

        }

        private void LblPrijs_Click(object sender, EventArgs e)
        {

        }

        private void LblBtw_Click(object sender, EventArgs e)
        {

        }

        private void LblTotaalPrijs_Click(object sender, EventArgs e)
        {

        }

        private void LblTotaalPrijsDis_Click(object sender, EventArgs e)
        {

        }

        private void LblBtwDis_Click(object sender, EventArgs e)
        {

        }

        private void LblPrijsDis_Click(object sender, EventArgs e)
        {

        }
    }
}
