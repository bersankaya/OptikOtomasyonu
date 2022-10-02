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
    public partial class FrmUrunGiris : Form
    {
        public FrmUrunGiris()
        {
            InitializeComponent();
        }
        OptikOtomasyonuEntities db = new OptikOtomasyonuEntities();
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = txtBarkod.Text.Trim();
                if (db.TBLURUN.Any(a => a.Barkod == barkod))
                {
                    var urun = db.TBLURUN.Where(a => a.Barkod == barkod).SingleOrDefault();
                    TxtUrunAd.Text = urun.UrunAd;
                    TxtAciklama.Text = urun.Aciklama;
                    CmbUrunGrub.Text = urun.UrunGrup;
                    TxtAlisFiyati.Text = urun.AlisFiyat.ToString();
                    txtsatisfiyati.Text = urun.SatisFiyat.ToString();
                    TxtMiktar.Text = urun.Miktar.ToString();
                    TxtKdvOrani.Text = urun.KdvOrani.ToString();
                    if (urun.Birim=="Kg")
                    {
                        churuntipi.Checked = true;
                    }
                    else
                    {
                        churuntipi.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Kayıtlı Değildir,Kaydedebilirsiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBarkod.Text != "" && TxtUrunAd.Text != "" && CmbUrunGrub.Text != "" && TxtAlisFiyati.Text != "" && txtsatisfiyati.Text != "" && TxtKdvOrani.Text != "" && TxtMiktar.Text != "")
            {
                if (db.TBLURUN.Any(a => a.Barkod == txtBarkod.Text))
                {
                    var guncelle = db.TBLURUN.Where(a => a.Barkod == txtBarkod.Text).SingleOrDefault();
                    guncelle.UrunAd = TxtUrunAd.Text;
                    guncelle.Aciklama = TxtAciklama.Text;
                    guncelle.UrunGrup = CmbUrunGrub.Text;
                    guncelle.AlisFiyat = Convert.ToDecimal(TxtAlisFiyati.Text);
                    guncelle.SatisFiyat = Convert.ToDecimal(txtsatisfiyati.Text);
                    guncelle.KdvOrani = Convert.ToInt32(TxtKdvOrani.Text);
                    guncelle.KdvTutari = Math.Round(islemler.decimalyap(txtsatisfiyati.Text) * Convert.ToInt32(TxtKdvOrani.Text) / 100, 2);
                    guncelle.Miktar += Convert.ToDecimal(TxtMiktar.Text);
                    if (churuntipi.Checked)
                    {
                        guncelle.Birim = "Kg";

                    }
                    else
                    {
                        guncelle.Birim = "Adet";
                    }
                    guncelle.Tarih = DateTime.Now;
                    guncelle.Kullanici = Lblkullanici.Text;
                    db.SaveChanges();

                    temizle();
                    gridUrunGirisi.DataSource = db.TBLURUN.OrderByDescending(a => a.UrunId).Take(10).ToList();
                    gridUrunGirisi.DataSource = db.TBLURUN.ToList();
                    islemler.GridDuzenle(gridUrunGirisi);

                }
                else
                {
                    TBLURUN urun = new TBLURUN();
                    urun.Barkod = txtBarkod.Text;
                    urun.UrunAd = TxtUrunAd.Text;
                    urun.Aciklama = TxtAciklama.Text;
                    urun.UrunGrup = CmbUrunGrub.Text;
                    urun.AlisFiyat = Convert.ToDecimal(TxtAlisFiyati.Text);
                    urun.SatisFiyat = Convert.ToDecimal(txtsatisfiyati.Text);
                    urun.KdvOrani = Convert.ToInt32(TxtKdvOrani.Text);
                    urun.KdvTutari = Math.Round(islemler.decimalyap(txtsatisfiyati.Text) * Convert.ToInt32(TxtKdvOrani.Text) / 100, 2);
                    urun.Miktar = Convert.ToDecimal(TxtMiktar.Text);
                    if (churuntipi.Checked)
                    {
                        urun.Birim = "Kg";

                    }
                    else
                    {
                        urun.Birim = "Adet";
                    }
                    urun.Tarih = DateTime.Now;
                    urun.Kullanici = Lblkullanici.Text;
                    db.TBLURUN.Add(urun);
                    db.SaveChanges();
                    if (txtBarkod.Text.Length == 8)
                    {
                        var ozelbarkod = db.TBLBARKOD.First();
                        ozelbarkod.BarkodNo += 1;
                        db.SaveChanges();
                    }
                    gridUrunGirisi.DataSource = db.TBLURUN.OrderByDescending(a => a.UrunId).Take(20).ToList();
                }
                islemler.StokHareket(txtBarkod.Text, TxtUrunAd.Text, "Adet", Convert.ToDecimal(TxtMiktar.Text), CmbUrunGrub.Text, Lblkullanici.Text);
                temizle();
            }
            else
            {
                MessageBox.Show("Bilgi Girişlerini Kontrol Ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarkod.Focus();
            }

        }

        private void TxtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (TxtUrunAra.Text.Length > 1)
            {
                string urunad = TxtUrunAra.Text;
                gridUrunGirisi.DataSource = db.TBLURUN.Where(a => a.UrunAd.Contains(urunad)).ToList();
                islemler.GridDuzenle(gridUrunGirisi);
            }
        }

        private void FrmUrunGiris_Load(object sender, EventArgs e)
        {
            TxtUrunSayisi.Text = db.TBLURUN.Count().ToString();
            gridUrunGirisi.DataSource = db.TBLURUN.OrderByDescending(a => a.UrunId).Take(20).ToList();
            grupdoldur();
            islemler.GridDuzenle(gridUrunGirisi);
        }
        void temizle()
        {
            txtBarkod.Clear();
            TxtUrunAd.Clear();
            TxtAciklama.Clear();
            TxtAlisFiyati.Text = "0";
            txtsatisfiyati.Text = "0";
            TxtMiktar.Text = "0";
            TxtKdvOrani.Text = "8";
            txtBarkod.Focus();
            churuntipi.Checked = false;
        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnUrunGrubuEkle_Click(object sender, EventArgs e)
        {
            frmUrunGrubuEkle fr = new frmUrunGrubuEkle();
            fr.ShowDialog();
        }
        public void grupdoldur()
        {
            CmbUrunGrub.DisplayMember = "UrunGrupAd";
            CmbUrunGrub.ValueMember = "id";
            CmbUrunGrub.DataSource = db.TBLURUNGRUP.OrderBy(a => a.UrunGrupAd).ToList();

        }

        private void BtnBarkodOlustur_Click(object sender, EventArgs e)
        {
            var barkodno = db.TBLBARKOD.First();
            int karakter = barkodno.BarkodNo.ToString().Length;
            string sifirlar = string.Empty;
            for (int i = 0; i < 8 - karakter; i++)
            {
                sifirlar = sifirlar + "0";

            }
            string olusanbarkod = sifirlar + barkodno.BarkodNo.ToString();
            txtBarkod.Text = olusanbarkod;
            TxtUrunAd.Focus();
        }

        private void txtsatisfiyati_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }

        private void TxtAlisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridUrunGirisi.Rows.Count > 0)
            {
                int urunid = Convert.ToInt32(gridUrunGirisi.CurrentRow.Cells["UrunId"].Value.ToString());
                string UrunAd = gridUrunGirisi.CurrentRow.Cells["UrunAd"].Value.ToString();
                string barkod = gridUrunGirisi.CurrentRow.Cells["Barkod"].Value.ToString();
                DialogResult onay = MessageBox.Show(UrunAd + " Ürünü Silmek İstiyormusunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (onay == DialogResult.Yes)
                {
                    var urun = db.TBLURUN.Find(urunid);
                    db.TBLURUN.Remove(urun);
                    db.SaveChanges();
                    var hizliurun = db.TBLHIZLIURUN.Where(x => x.Barkod == barkod).SingleOrDefault();
                    if (db.TBLHIZLIURUN.Any(x => x.Barkod == barkod))
                    {

                        hizliurun.Barkod = "-";
                        hizliurun.UrunAd = "-";
                        hizliurun.fiyat = 0;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Ürün Listeden Silinmiştir");
                    gridUrunGirisi.DataSource = db.TBLURUN.OrderByDescending(a => a.UrunId).Take(20).ToList();
                    islemler.GridDuzenle(gridUrunGirisi);
                    txtBarkod.Focus();

                }
            }

        }

        private void churuntipi_CheckedChanged(object sender, EventArgs e)
        {
            if (churuntipi.Checked)
            {
                churuntipi.Text = "Gramajlı Ürün İşlemi";
                BtnBarkodOlustur.Enabled = false;
            }
            else
            {
                churuntipi.Text = "Barkodlu Ürün İşlemi";
                BtnBarkodOlustur.Enabled = true;
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridUrunGirisi.Rows.Count>0)
            {
                txtBarkod.Text = gridUrunGirisi.CurrentRow.Cells["Barkod"].Value.ToString();
                TxtUrunAd.Text = gridUrunGirisi.CurrentRow.Cells["UrunAd"].Value.ToString();
                TxtAciklama.Text = gridUrunGirisi.CurrentRow.Cells["Aciklama"].Value.ToString();
                CmbUrunGrub.Text = gridUrunGirisi.CurrentRow.Cells["UrunGrup"].Value.ToString();
                TxtAlisFiyati.Text = gridUrunGirisi.CurrentRow.Cells["AlisFiyat"].Value.ToString();
               txtsatisfiyati.Text= gridUrunGirisi.CurrentRow.Cells["SatisFiyat"].Value.ToString();
                TxtKdvOrani.Text = gridUrunGirisi.CurrentRow.Cells["KdvOrani"].Value.ToString();
                TxtMiktar.Text = gridUrunGirisi.CurrentRow.Cells["Miktar"].Value.ToString();
                string birim = gridUrunGirisi.CurrentRow.Cells["Birim"].Value.ToString();
                if (birim=="Kg")
                {
                    churuntipi.Checked = true;

                }
                else
                {
                    churuntipi.Checked = false;
                }
            }
        }
    }
}
