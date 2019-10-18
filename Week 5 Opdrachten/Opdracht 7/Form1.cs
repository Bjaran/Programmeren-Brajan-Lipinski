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
        int[] dobbelsteen = new int[6];
        int i = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            i = 0;
            for (i = 0; i < 6; i++)
            {
                dobbelsteen[i] = 0;
            }
        }

        private void btn_gooien_Click(object sender, EventArgs e)
        {
            lbl_text.Text = "";
            for (i = 0; i < 6; i++)
            {
                dobbelsteen[i] = 0;
            }
            for (int tel = 0; tel < 6000; tel++)
            {
                int random = rnd.Next(1, 7);
                dobbelsteen[random - 1]++;
            }
            i = 0;
            foreach (int waarde in dobbelsteen)
            {
                lbl_text.Text += $"Waarde {i + 1} is {dobbelsteen[i]} keer gegooid.\n";
                i++;
            }

        }
    }
}
