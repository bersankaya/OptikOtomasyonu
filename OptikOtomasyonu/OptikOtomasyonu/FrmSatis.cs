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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
        OptikOtomasyonuEntities db = new OptikOtomasyonuEntities();
        public double gelenIndirim { get; set; }
        private void txtbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = txtbarkod.Text.Trim();
                if (barkod.Length <= 2)
                {
                    txtmiktar.Text = barkod;
                    txtbarkod.Clear();
                    txtbarkod.Focus();
                }
                else
                {
                    if (db.TBLURUN.Any(a => a.Barkod == barkod))
                    {
                        var urun = db.TBLURUN.Where(a => a.Barkod == barkod).FirstOrDefault();
                        urungetirListeye(urun, barkod, Convert.ToDouble(txtmiktar.Text));
                    }
                    else
                    {
                        int onek = Convert.ToInt32(barkod.Substring(0, 2));
                        if (db.TBLTERAZI.Any(a => a.TeraziOnEk == onek))
                        {
                            string teraziurunno = barkod.Substring(2, 5);
                            if (db.TBLURUN.Any(a => a.Barkod == teraziurunno))
                            {
                                var urunterazi = db.TBLURUN.Where(a => a.Barkod == teraziurunno).FirstOrDefault();
                                double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                urungetirListeye(urunterazi, teraziurunno, miktarkg);

                            }
                            else
                            {
                                Console.Beep(900, 1200);
                                MessageBox.Show("Kg Ürün Ekleme Sayfası", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            Console.Beep(900, 1200);
                            FrmUrunGiris fr = new FrmUrunGiris();
                            fr.txtBarkod.Text = barkod;
                            fr.ShowDialog();
                        }
                    }
                }
                gridsatislistesi.ClearSelection();
                geneltoplam();
            }
        }
        private void urungetirListeye(TBLURUN urun, string barkod, double miktar)
        {
            int satirsayisi = gridsatislistesi.Rows.Count;
            bool eklenmismi = false;
            if (satirsayisi > 0)
            {
                for (int i = 0; i < satirsayisi; i++)
                {
                    if (gridsatislistesi.Rows[i].Cells["Barkod"].Value.ToString() == barkod)
                    {
                        gridsatislistesi.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Miktar"].Value);
                        gridsatislistesi.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Fiyat"].Value), 2);
                        eklenmismi = true;
                    }
                }
            }
            if (!eklenmismi)
            {
                gridsatislistesi.Rows.Add();
                gridsatislistesi.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                gridsatislistesi.Rows[satirsayisi].Cells["UrunAdi"].Value = urun.UrunAd;
                gridsatislistesi.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                gridsatislistesi.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;
                gridsatislistesi.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyat;
                gridsatislistesi.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                gridsatislistesi.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * (double)urun.SatisFiyat, 2);
                gridsatislistesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                gridsatislistesi.Rows[satirsayisi].Cells["KdvTutari"].Value = urun.KdvTutari;

            }
        }

        public double FerhatDeniyor()
        {
            double[] diziFiyat = new double[gridsatislistesi.Rows.Count];

            for (int i = 0; i < gridsatislistesi.Rows.Count; i++)
            {
                diziFiyat[i] += Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Toplam"].Value);
            }

            var resultValue = diziFiyat.Sum();
            return resultValue;
        }

        public double geneltoplam()
        {

            double toplam = 0;
            for (int i = 0; i < gridsatislistesi.Rows.Count; i++)
            {
                toplam += Convert.ToDouble(gridsatislistesi.Rows[i].Cells["Toplam"].Value);
                txtgeneltoplam.Text = toplam.ToString("C2");
                txtmiktar.Text = "1";
                txtbarkod.Clear();
                txtbarkod.Focus();

            }
            return toplam;

        }

        private void gridsatislistesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                txtgeneltoplam.Text = "₺0,00";
                gridsatislistesi.Rows.Remove(gridsatislistesi.CurrentRow);
                gridsatislistesi.ClearSelection();
                geneltoplam();
                txtbarkod.Focus();
            }
        }
        private void HizliButonDoldur()
        {
            var HizliUrun = db.TBLHIZLIURUN.ToList();
            foreach (var item in HizliUrun)
            {
                Button bH = this.Controls.Find("bH" + item.id, true).FirstOrDefault() as Button;
                if (bH != null)
                {
                    decimal fiyat = islemler.decimalyap(item.fiyat.ToString());
                    bH.Text = item.UrunAd + "\n" + fiyat.ToString("C2");
                }

            }

        }
        private void hizlibuttonclick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int butonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
            if (b.Text.ToString().StartsWith("-"))
            {
                FrmHizliUrunButonEkle fr = new FrmHizliUrunButonEkle();
                fr.lblbutonıd.Text = butonid.ToString();
                fr.ShowDialog();
            }
            else
            {
                var urunbarkod = db.TBLHIZLIURUN.Where(a => a.id == butonid).Select(a => a.Barkod).FirstOrDefault();
                var urun = db.TBLURUN.Where(a => a.Barkod == urunbarkod).FirstOrDefault();
                urungetirListeye(urun, urunbarkod, Convert.ToDouble(txtmiktar.Text));
                geneltoplam();
            }
        }
        private void FrmSatis_Load(object sender, EventArgs e)
        {
            FrmIndirimliSatis satis = new FrmIndirimliSatis();
            HizliButonDoldur();
            b5.Text = 5.ToString("C2");
            b10.Text = 10.ToString("C2");
            b20.Text = 20.ToString("C2");
            b50.Text = 50.ToString("C2");
            b100.Text = 100.ToString("C2");
            b200.Text = 200.ToString("C2");

            txtgeneltoplam.Text = satis.setGelenDegerFormSatis.ToString();
        }
        private void bh_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button b = (Button)sender;
                if (!b.Text.StartsWith("-"))
                {
                    int butonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
                    ContextMenuStrip s = new ContextMenuStrip();
                    ToolStripMenuItem sil = new ToolStripMenuItem();
                    sil.Text = "Temizle - Buton No:" + butonid.ToString();
                    sil.Click += Sil_Click;
                    s.Items.Add(sil);
                    this.ContextMenuStrip = s;

                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
            var guncelle = db.TBLHIZLIURUN.Find(butonid);
            guncelle.Barkod = "-";
            guncelle.UrunAd = "-";
            guncelle.fiyat = 0;
            db.SaveChanges();
            double fiyat = 0;
            Button b = this.Controls.Find("bH" + butonid, true).FirstOrDefault() as Button;
            b.Text = "-" + "\n" + fiyat.ToString("C2");
        }

        private void bNx_Click(Object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = TxtNumarator.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    TxtNumarator.Text += b.Text;
                }
            }
            else if (b.Text == "<")
            {
                if (TxtNumarator.Text.Length > 0)
                {
                    TxtNumarator.Text = TxtNumarator.Text.Substring(0, TxtNumarator.Text.Length - 1);
                }
            }
            else
            {
                TxtNumarator.Text += b.Text;
            }
        }

        private void BtnAdet_Click(object sender, EventArgs e)
        {
            if (TxtNumarator.Text != "")
            {
                txtmiktar.Text = TxtNumarator.Text;
                TxtNumarator.Clear();
                txtbarkod.Clear();
                txtbarkod.Focus();
            }
        }

        private void BtnOdenen_Click(object sender, EventArgs e)
        {
            if (TxtNumarator.Text != "")
            {
                decimal sonuc = islemler.decimalyap(TxtNumarator.Text) - islemler.decimalyap(txtgeneltoplam.Text);
                txtparaustu.Text = sonuc.ToString("C2");
                txtodenen.Text = islemler.decimalyap(TxtNumarator.Text).ToString("C2");
                TxtNumarator.Clear();
                txtbarkod.Focus();
            }
        }

        private void BtnBarkod_Click(object sender, EventArgs e)
        {
            if (TxtNumarator.Text != "")
            {
                if (db.TBLURUN.Any(a => a.Barkod == TxtNumarator.Text))
                {
                    var urun = db.TBLURUN.Where(a => a.Barkod == TxtNumarator.Text).FirstOrDefault();
                    urungetirListeye(urun, TxtNumarator.Text, Convert.ToDouble(txtmiktar.Text));
                    TxtNumarator.Clear();
                    txtbarkod.Focus();
                }
                else
                {
                    MessageBox.Show("ürün ekleme sayfasını aç");
                }
            }
        }
        private void paraustuhesapla_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            decimal sonuc = islemler.decimalyap(b.Text) - islemler.decimalyap(txtgeneltoplam.Text);
            txtodenen.Text = islemler.decimalyap(b.Text).ToString("C2");
            txtparaustu.Text = sonuc.ToString("C2");

        }

        private void BtnDiğerUrun_Click(object sender, EventArgs e)
        {
            if (TxtNumarator.Text != "")
            {
                int satirsayisi = gridsatislistesi.Rows.Count;
                gridsatislistesi.Rows.Add();
                gridsatislistesi.Rows[satirsayisi].Cells["Barkod"].Value = "1111111111116";
                gridsatislistesi.Rows[satirsayisi].Cells["UrunAdi"].Value = "Barkodsuz Ürün";
                gridsatislistesi.Rows[satirsayisi].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                gridsatislistesi.Rows[satirsayisi].Cells["Birim"].Value = "Adet";
                gridsatislistesi.Rows[satirsayisi].Cells["Miktar"].Value = 1;
                gridsatislistesi.Rows[satirsayisi].Cells["AlisFiyat"].Value = 0;
                gridsatislistesi.Rows[satirsayisi].Cells["Fiyat"].Value = Convert.ToDouble(TxtNumarator.Text);
                gridsatislistesi.Rows[satirsayisi].Cells["KdvTutari"].Value = 0;
                gridsatislistesi.Rows[satirsayisi].Cells["Toplam"].Value = Convert.ToDouble(TxtNumarator.Text);
                TxtNumarator.Text = "";
                txtbarkod.Focus();
                geneltoplam();
            }
        }

        private void btniade_Click(object sender, EventArgs e)
        {
            if (chsatisiadeislemi.Checked)
            {
                chsatisiadeislemi.Checked = false;
                chsatisiadeislemi.Text = "Satış Yapılıyor";
            }
            else
            {
                chsatisiadeislemi.Checked = true;
                chsatisiadeislemi.Text = "İade İşlemi";
            }
        }
        private void temizle()
        {
            txtmiktar.Text = "1";
            txtbarkod.Clear();
            txtodenen.Clear();
            txtparaustu.Clear();
            txtgeneltoplam.Text = 0.ToString("C2");
            chsatisiadeislemi.Checked = false;
            TxtNumarator.Clear();
            gridsatislistesi.Rows.Clear();
            txtbarkod.Clear();
            txtbarkod.Focus();
        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        public void SatisYap(string OdemeSekli)
        {

            int SatirSayisi = gridsatislistesi.Rows.Count;
            bool Satisiade = chsatisiadeislemi.Checked;
            decimal alisfiyattoplam = 0;
            if (SatirSayisi > 0)
            {
                int? islemno = db.TBLISLEM.First().islemno;
                TBLSATIS satis = new TBLSATIS();
                for (int i = 0; i < SatirSayisi; i++)
                {
                    satis.islemno = islemno;
                    satis.UrunAd = gridsatislistesi.Rows[i].Cells["UrunAdi"].Value.ToString();
                    satis.UrunGrup = gridsatislistesi.Rows[i].Cells["UrunGrup"].Value.ToString();
                    satis.Barkod = gridsatislistesi.Rows[i].Cells["Barkod"].Value.ToString();
                    satis.Birim = gridsatislistesi.Rows[i].Cells["Birim"].Value.ToString();
                    satis.AlisFiyat = islemler.decimalyap(gridsatislistesi.Rows[i].Cells["AlisFiyat"].Value.ToString());
                    satis.SatisFiyat = islemler.decimalyap(gridsatislistesi.Rows[i].Cells["Fiyat"].Value.ToString());
                    satis.Miktar = islemler.decimalyap(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.Toplam = islemler.decimalyap(gridsatislistesi.Rows[i].Cells["Toplam"].Value.ToString());
                    satis.KdvTutari = islemler.decimalyap(gridsatislistesi.Rows[i].Cells["KdvTutari"].Value.ToString()) * islemler.decimalyap(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.OdemeSekli = OdemeSekli;
                    satis.iade = Satisiade;
                    satis.Tarih = DateTime.Now;
                    satis.Kullanici = LblKullanici.Text;
                    db.TBLSATIS.Add(satis);
                    db.SaveChanges();
                    if (!Satisiade)
                    {
                        islemler.StokAzalt(gridsatislistesi.Rows[i].Cells["Barkod"].Value.ToString(), islemler.decimalyap(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString()));
                    }
                    else
                    {
                        islemler.StokArttir(gridsatislistesi.Rows[i].Cells["Barkod"].Value.ToString(), islemler.decimalyap(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString()));
                    }
                    alisfiyattoplam += islemler.decimalyap(gridsatislistesi.Rows[i].Cells["AlisFiyat"].Value.ToString()) * islemler.decimalyap(gridsatislistesi.Rows[i].Cells["Miktar"].Value.ToString());

                }
                TBLISLEMOZET io = new TBLISLEMOZET();

                io.Nakit = islemler.decimalyap(TxtNumarator.Text);
                io.Kart = islemler.decimalyap(TxtNumarator.Text);
                io.IslemNo = islemno;
                io.Iade = Satisiade;
                io.AlisFiyatToplam = alisfiyattoplam;
                io.Gelir = false;
                io.Gider = false;
                if (!Satisiade)
                {
                    io.Aciklama = OdemeSekli + " Satış";
                }
                else
                {
                    io.Aciklama = "İade İşlemi (" + OdemeSekli + ")";
                }
                io.OdemeSekli = OdemeSekli;
                io.Kullanici = LblKullanici.Text;
                io.Tarih = DateTime.Now;
                switch (OdemeSekli)
                {
                    case "Nakit":
                        io.Nakit = islemler.decimalyap(txtgeneltoplam.Text);
                        io.Kart = 0; break;
                    case "Kart":
                        io.Nakit = 0;
                        io.Kart = islemler.decimalyap(txtgeneltoplam.Text); break;
                    case "Kart-Nakit":
                        io.Nakit = islemler.decimalyap(LblNakit.Text);
                        io.Kart = islemler.decimalyap(LblKart.Text); break;

                }
                db.TBLISLEMOZET.Add(io);
                db.SaveChanges();
                var islemnoarttir = db.TBLISLEM.First();
                islemnoarttir.islemno += 1;
                db.SaveChanges();
                MessageBox.Show("yazdırma İşlemi Yap");
                temizle();
            }
        }

        private void btnnakit_Click(object sender, EventArgs e)
        {
            SatisYap("Nakit");
        }

        private void btnkart_Click(object sender, EventArgs e)
        {
            SatisYap("Kart");
        }

        private void btnnakitkart_Click(object sender, EventArgs e)
        {
            FrmNakitKart fr = new FrmNakitKart();
            fr.ShowDialog();

        }

        private void txtbarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void txtmiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void FrmSatis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SatisYap("Nakit");
            }
            if (e.KeyCode == Keys.F2)
            {
                SatisYap("Kart");
            }
            if (e.KeyCode == Keys.F3)
            {
                FrmNakitKart fr = new FrmNakitKart();
                fr.ShowDialog();
            }
        }

        private void Btnislembeklet_Click(object sender, EventArgs e)
        {
            if (Btnislembeklet.Text == "İşlem Bekletme")
            {
                bekle();
                Btnislembeklet.BackColor = System.Drawing.Color.OrangeRed;
                Btnislembeklet.Text = "İşlem Bekliyor";
                gridsatislistesi.Rows.Clear();
            }
            else
            {
                beklemedencik();
                Btnislembeklet.BackColor = System.Drawing.Color.DimGray;
                Btnislembeklet.Text = "İşlem Bekletme";
                gridBekle.Rows.Clear();

            }
        }

        private void bekle()
        {
            int satir = gridsatislistesi.Rows.Count;
            int sutun = gridsatislistesi.Columns.Count;
            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    gridBekle.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        gridBekle.Rows[i].Cells[j].Value = gridsatislistesi.Rows[i].Cells[j].Value;
                    }
                }
            }
        }
        private void beklemedencik()
        {
            int satir = gridBekle.Rows.Count;
            int sutun = gridBekle.Columns.Count;
            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    gridsatislistesi.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        gridsatislistesi.Rows[i].Cells[j].Value = gridBekle.Rows[i].Cells[j].Value;
                    }
                }
            }
        }



        private void BtnTemizle_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void chsatisiadeislemi_CheckedChanged(object sender, EventArgs e)
        {
            if (chsatisiadeislemi.Checked)
            {
                chsatisiadeislemi.Text = "İade Yapılıyor";
            }
            else
            {
                chsatisiadeislemi.Text = "Satış Yapılıyor";
            }
        }

        private void BtnIndirimliSatis_Click(object sender, EventArgs e)
        {
            FrmIndirimliSatis fr = new FrmIndirimliSatis();
            fr.gelenDeger = geneltoplam();
            fr.Show();

        }

        private void txtgeneltoplam_TextChanged(object sender, EventArgs e)
        {

        }

        public double verAlevAlsin { get; set; }
      
    }
}
