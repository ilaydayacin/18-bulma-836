using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_bulma_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sonuc, sayi;
            sayi = Convert.ToDouble(txtSayi.Text);

            sonuc = (sayi * 0.18);

            MessageBox.Show("Sonucunuz: " + sonuc);
        }
    }
}
