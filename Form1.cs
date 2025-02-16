using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formdortislem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);

            if(rbTopla.Checked )
            {
                sonuc = sayi1 + sayi2;
            }
            else if(rbCikar.Checked )
            {
                sonuc = sayi1 - sayi2;
            }
            else if(rbCarp.Checked )
            {
                sonuc = sayi1 * sayi2;
            }
            else
            {
                sonuc = sayi1 / sayi2;
            }

            lblSonuc.Text = "Sonuc: " + sonuc;
        }
    }
}
