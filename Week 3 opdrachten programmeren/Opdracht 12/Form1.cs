using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            const int basisPrijs = 12;
            int leeftijd = int.Parse(txtLeeftijd.Text);
            if (leeftijd < 5)
            {
                lblPrijsShow.Text = "€ 0,00";
            }
            else if (leeftijd <= 12)
            {
                lblPrijsShow.Text = "€ " + (basisPrijs/2).ToString("0.00") ;
            }
            else if (leeftijd <= 54)
            {
                lblPrijsShow.Text = "€ " + basisPrijs.ToString("0.00") ;
            }
            else
            {
                lblPrijsShow.Text = "€ 0,00";
            }
        }
    }
}
