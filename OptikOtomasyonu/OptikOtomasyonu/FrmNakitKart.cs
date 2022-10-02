using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptikOtomasyonu
{
    public partial class FrmNakitKart : Form
    {
        public FrmNakitKart()
        {
            InitializeComponent();
        }
        private void Hesapla()
        {

            FrmSatis f = (FrmSatis)Application.OpenForms["FrmSatis"];
            decimal nakit = islemler.decimalyap(TxtNakit.Text);
            decimal geneltoplam = islemler.decimalyap(f.txtgeneltoplam.Text);
            decimal kart = geneltoplam - nakit;
            f.LblNakit.Text = nakit.ToString("C2");
            f.LblKart.Text = kart.ToString("C2");
            f.SatisYap("Kart-Nakit");
            this.Hide();
        }
        private void TxtNakit_KeyDown(object sender, KeyEventArgs e)
        {
            if (TxtNakit.Text!="")
            {
                if (e.KeyCode==Keys.Enter)
                {
                    Hesapla();
                }
            }
        }
        private void bNx_Click(Object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = TxtNakit.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    TxtNakit.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (TxtNakit.Text.Length > 0)
                {
                    TxtNakit.Text = TxtNakit.Text.Substring(0, TxtNakit.Text.Length - 1);
                }
            }
            else
            {
                TxtNakit.Text += b.Text;
            }
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if (TxtNakit.Text!="")
            {

            Hesapla();
            }
        }

        private void TxtNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)==false && e.KeyChar!=(char)08)
            {
                e.Handled = true;
            }
        }
    }
}
