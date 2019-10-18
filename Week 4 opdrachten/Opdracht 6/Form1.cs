using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double eindBedrag = 0;
            double startbedrag = int.Parse(txtStartBedrag.Text);
            for (int i = 0; i < 5; i++)
            {
                eindBedrag = startbedrag * 1.05;
                startbedrag = eindBedrag;
            }
            lblEindBedrag.Text = "€ " + eindBedrag.ToString("0.00");
        }
    }
}
