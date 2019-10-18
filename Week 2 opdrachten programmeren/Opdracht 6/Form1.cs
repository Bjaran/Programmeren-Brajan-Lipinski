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
            int seconden = int.Parse(txtSeconden.Text);
            int uren = seconden / 3600;
            int urenOver = uren * 3600;
            int secondenOver = seconden - urenOver;
            int minuten = secondenOver / 60;
            int minutenOver = minuten * 60;
            int secondenResterend = secondenOver - minutenOver;
            string urenTxt = uren.ToString("00");
            string minutenTxt = minuten.ToString("00");
            string secondenTxt = secondenResterend.ToString("00");
            lblTijd.Text = urenTxt + ":" + minutenTxt + ":" + secondenTxt;

        }
    }
}
