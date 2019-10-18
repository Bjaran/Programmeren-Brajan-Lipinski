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

        private void BtnVergelijk_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtGetal.Text);
            int som = 0;
            for (int i = 1; i <= n; i++)
            {
                som += i;
            }
            int formule = (n * (n + 1) / 2);
            if (som == formule)
            {
                lblGelijk.Text = "De som en formule zijn gelijk";
            }
            else
            {
                lblGelijk.Text = "De som en formule zijn niet gelijk";
            }
            lblUitslag1.Text = som.ToString();
            lblUitslag2.Text = formule.ToString();
        }
    }
}
