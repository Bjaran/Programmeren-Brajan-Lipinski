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
        int[] getallen = new int[20];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            i = 0;
            for (i = 0; i < 20; i++)
            {
                getallen[i] = rnd.Next(0, 500);
            }
            i = 0;
            foreach (int getal in getallen)
            {
                lbl_tabelVoor.Text += $"Element {i.ToString("00")} ={getal}\n";
                i++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_getal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_vergelijk_Click(object sender, EventArgs e)
        {
            btn_vergelijk.Enabled = false;
            int vergelijkingsgetal = int.Parse(txt_getal.Text);
            i = 0;
            foreach (int getal in getallen)
            {
                if (vergelijkingsgetal <= getal)
                {
                    lbl_tableNa.Text += $"Element {i.ToString("00")} ={getal + 10}\n";
                }
                else
                {
                    lbl_tableNa.Text += $"Element {i.ToString("00")} ={getal - 5}\n";
                }
                i++;
            }
        }
    }
}
