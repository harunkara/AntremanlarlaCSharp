using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            int sonuç;
            sonuç =Convert.ToInt32(txtSayı1.Text) + Convert.ToInt32(txtSayı2.Text);
            txtSonuc.Text = sonuç.ToString();
        }

        private void btnCıkarma_Click(object sender, EventArgs e)
        {
            int sonuç;
            sonuç = Convert.ToInt32(txtSayı1.Text) - Convert.ToInt32(txtSayı2.Text);
            txtSonuc.Text = sonuç.ToString();
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            int sonuç;
            sonuç = Convert.ToInt32(txtSayı1.Text) * Convert.ToInt32(txtSayı2.Text);
            txtSonuc.Text = sonuç.ToString();

        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            int sonuç;
            if (Convert.ToInt32(txtSayı2.Text) == 0)
                txtSonuc.Text=("sayı 0'a bolunemez");
            else
            {
                sonuç = Convert.ToInt32(txtSayı1.Text) / Convert.ToInt32(txtSayı2.Text);
                txtSonuc.Text = sonuç.ToString();

            }

          
        }
    }
}
