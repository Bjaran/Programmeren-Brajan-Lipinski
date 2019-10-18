using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LblGetal1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBerekenGemiddelde_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            int getal3 = int.Parse(txtGetal3.Text);
            double gemmideld = ((double)getal1 + getal2 + getal3) / 3;
            lblGemiddeldeShow.Text = gemmideld.ToString("0.00");
        }
    }
}
