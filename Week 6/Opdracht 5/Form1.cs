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

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txt_Getal_1.Text);
            int getal2 = int.Parse(txt_Getal_2.Text);
            lbl_Uitkomst_Getal.Text = Plus(getal1, getal2).ToString();
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txt_Getal_1.Text);
            int getal2 = int.Parse(txt_Getal_2.Text);
            lbl_Uitkomst_Getal.Text = Min(getal1, getal2).ToString();
        }

        private void btn_Keer_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txt_Getal_1.Text);
            int getal2 = int.Parse(txt_Getal_2.Text);
            lbl_Uitkomst_Getal.Text = Keer(getal1, getal2).ToString();
        }

        private void btn_Delen_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txt_Getal_1.Text);
            int getal2 = int.Parse(txt_Getal_2.Text);
            lbl_Uitkomst_Getal.Text = Delen(getal1, getal2).ToString();
        }
        static int Plus(int getal1, int getal2)
        {
            int uitslag = getal1 + getal2;
            return uitslag;
        }
        static int Min(int getal1, int getal2)
        {
            int uitslag = getal1 - getal2;
            return uitslag;
        }
        static int Keer(int getal1, int getal2)
        {
            int uitslag = getal1 * getal2;
            return uitslag;
        }
        static double Delen(int getal1, int getal2)
        {
            double uitslag = (double)getal1 / getal2;
            return uitslag;
        }
    }
}
