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

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            int zijde = int.Parse(txtZijde.Text);
            string vierkant = "";
            for (int i = 1; i <= zijde; i++)
            {
                string lijn = "X";
                for (int j = 0; j <= (zijde - 2); j++)
                {
                    if (i == 1 || i == zijde)
                    {
                        lijn += "X";
                    }
                    else
                    {
                        lijn += " ";
                    }
                }
                lijn += "X\n";
                vierkant += lijn;
            }
            lblVierkant.Text = vierkant;
        }
    }
}
