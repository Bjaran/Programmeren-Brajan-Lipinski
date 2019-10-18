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

        private void btnBereken_Click(object sender, EventArgs e)
        {
            double graden = double.Parse(txtGetal.Text);
            if (radioButton1.Checked)
            {
                lblNieuweGraden.Text = CK(graden).ToString("0.00");
            }
            else if (radioButton2.Checked)
            {
                lblNieuweGraden.Text = CF(graden).ToString("0.00");
            }
             else if (radioButton3.Checked)
            {
                lblNieuweGraden.Text = FC(graden).ToString("0.00");
            }
        }
        static double CK(double graden)
        {
            double nieuweGraden = graden + 273;
            return nieuweGraden;
        }
        static double CF(double graden)
        {
            double nieuweGraden = (graden * 9/5) + 32;
            return nieuweGraden;
        }
        static double FC(double graden)
        {
            double nieuweGraden = ((graden - 32) * 5 / 9);
            return nieuweGraden;
        }
    }
}
