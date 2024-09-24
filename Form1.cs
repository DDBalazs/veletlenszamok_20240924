using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veletlenszamok_20240924
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btgeneral_Click(object sender, EventArgs e)
        {
            if (txkezdo.Text == "")
            {
                MessageBox.Show("Kérem adja meg a kezdő értéket!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txkezdo.Focus();
            }
            else if (txveg.Text == "")
            {
                MessageBox.Show("Kérem adja meg a vég értéket!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txveg.Focus();
            }
            else if (txveg.Text == "" && txkezdo.Text == "")
            {
                MessageBox.Show("Kérem adja meg a kezdő és a vég értékeket!", "Üzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txkezdo.Focus();
            }
            lbtomb.Text = "";
            Random rnd = new Random();
            int[] tomb = new int[15];
            int kezdoszam = Convert.ToInt32(txkezdo.Text);
            int vegszam = Convert.ToInt32(txveg.Text);
            for (int i = 0; i < 15; i++)
            {
                tomb[i] = rnd.Next(kezdoszam, vegszam + 1);
            }
            for (int i = 0;i < tomb.Length; i++)
            {
                lbtomb.Text = lbtomb.Text + tomb[i]+" ";
            }
            lbtomb.Visible = true;
            lbparatlan.Text = "";
            int max = 0;
            int negy = 0;
            int paratlan = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%4 == 0) { negy++; }
                if (tomb[i] > max) { max = tomb[i]; }
                if (tomb[i]%2 == 1) { lbparatlan.Text = lbparatlan.Text + tomb[i] + " "; }

            }
            lbparatlan.Visible = true;
            txlegna.Text = max.ToString();
            txnegy.Text = negy.ToString();
            
            
        }
    }
}
