using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            int leeftijd = int.Parse(txtLeeftijd.Text);
            int duur = int.Parse(txtDuur.Text);
            int prijsN = 0;
            if (rdHandbal.Checked)
            {
              int prijs = 225;
                if (leeftijd > 40)
                {
                    prijsN = (prijs - 25);   
                }
                if (duur > 10)
                {
                    // prijsN = prijsN - 20;\
                    prijsN -= 20;
                    int prijsNN = (prijsN - 20);
                    lblContributieShow.Text = "€" + prijsNN;
                }
            }
            if (rdVoetbal.Checked)
            {
                int prijs = 175;
                if (leeftijd > 40)
                {
                    prijsN = (prijs - 25);
                }
                if (duur > 10)
                {
                    int prijsNN = (prijsN - 20);
                    lblContributieShow.Text = "€" + prijsNN;
                }
            }
        }

        private void RdVoetbal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdHandbal_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
