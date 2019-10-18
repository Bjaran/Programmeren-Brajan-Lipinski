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

        private void btnBerekenReference_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(txtGetal.Text);
            KwadraatByReference(ref getal);
            lbl_Uitkomst_Getal.Text = getal.ToString();
        }

        private void btnBerekenReferenceOut_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(txtGetal.Text);
            KwadraatByReferenceOut(getal, out int kwadraat);
            lbl_Uitkomst_Getal.Text = kwadraat.ToString();
        }

        private void btnBerekenValue_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(txtGetal.Text);
            lbl_Uitkomst_Getal.Text = KwadraatByValue(getal).ToString();
        }
        static void KwadraatByReference (ref int getal)
        {
            getal = getal * getal;
        }
        static void KwadraatByReferenceOut(int getal, out int kwadraat)
        {
            kwadraat = getal * getal;
        }
        static int KwadraatByValue (int getal)
        {
            int kwadraat = getal * getal;
            return kwadraat;
        }
    }
}
