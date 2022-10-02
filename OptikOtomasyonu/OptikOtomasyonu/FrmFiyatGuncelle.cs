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
    public partial class FrmFiyatGuncelle : Form
    {
        public FrmFiyatGuncelle()
        {
            InitializeComponent();
        }

       
        private void TxtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var db = new OptikOtomasyonuEntities())
                {
                    if (db.TBLURUN.Any(x => x.Barkod == TxtBarkod.Text))
                    {
                        var getir = db.TBLURUN.Where(x => x.Barkod == TxtBarkod.Text).SingleOrDefault();
                        LblBarkod.Text = getir.Barkod;
                        LblUrunAdi.Text = getir.UrunAd;
                        decimal mevcutfiyat = Convert.ToDecimal(getir.SatisFiyat);
                        LblFiyat.Text = mevcutfiyat.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Kayıtlı Değil", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

       

        private void FrmFiyatGuncelle_Load(object sender, EventArgs e)
        {
            TxtBarkod.Focus();
            LblBarkod.Text = "";
            LblUrunAdi.Text = "";
            LblFiyat.Text = "";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtYeniFiyat.Text != "" && LblBarkod.Text != "")
            {
                using (var db = new OptikOtomasyonuEntities())
                {
                    var guncellenecek = db.TBLURUN.Where(x => x.Barkod == LblBarkod.Text).SingleOrDefault();
                    guncellenecek.SatisFiyat = islemler.decimalyap(TxtYeniFiyat.Text);
                    int kdvorani = Convert.ToInt16(guncellenecek.KdvOrani);
                    Math.Round(islemler.decimalyap(TxtYeniFiyat.Text) * kdvorani / 100, 2);
                    db.SaveChanges();
                    MessageBox.Show("Yeni Fiyat Kaydedilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LblBarkod.Text = "";
                    LblUrunAdi.Text = "";
                    LblFiyat.Text = "";
                    TxtYeniFiyat.Clear();
                    TxtBarkod.Clear();
                    TxtBarkod.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ürün okutunuz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtBarkod.Focus();
            }
        }
    }
}
