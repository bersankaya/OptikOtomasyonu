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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            TxtAdSoyad.Clear();
            MskTelefon.Clear();
            TxtEPosta.Clear();
            TxtKullaniciAdi.Clear();
            TxtSifre.Clear();
            TxtSifreTekrar.Clear();
            ChSatis.Checked = false;
            ChRapor.Checked = false;
            ChUrunGiris.Checked = false;
            ChStok.Checked = false;
            ChAyarlar.Checked = false;
            ChFiyatGuncelle.Checked = false;
            ChYedekleme.Checked = false;

        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (BtnKaydet.Text == "Kaydet")
            {
                if (TxtAdSoyad.Text != "" && MskTelefon.Text != "" && TxtKullaniciAdi.Text != "" && TxtSifre.Text != "" && TxtSifreTekrar.Text != "")
                {
                    if (TxtSifre.Text == TxtSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db = new OptikOtomasyonuEntities())
                            {
                                if (!db.TBLKULLANICI.Any(x => x.KullaniciAd == TxtKullaniciAdi.Text))
                                {
                                    TBLKULLANICI k = new TBLKULLANICI();
                                    k.AdSoyad = TxtAdSoyad.Text;
                                    k.Telefon = MskTelefon.Text;
                                    k.EPosta = TxtEPosta.Text;
                                    k.KullaniciAd = TxtKullaniciAdi.Text.Trim();
                                    k.Sifre = TxtSifre.Text;
                                    k.Satis = ChSatis.Checked;
                                    k.Rapor = ChRapor.Checked;
                                    k.Stok = ChStok.Checked;
                                    k.UrunGiris = ChUrunGiris.Checked;
                                    k.Ayarlar = ChAyarlar.Checked;
                                    k.FiyatGuncelle = ChFiyatGuncelle.Checked;
                                    k.Yedekleme = ChYedekleme.Checked;
                                    db.TBLKULLANICI.Add(k);
                                    db.SaveChanges();
                                    doldur();
                                    Temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Bu Kullanıcı Sistemde Bulunmaktadır");
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Hata Oluştu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmamaktadır");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Zorunlu Girişleri Yazınız" + "\nAd Soyad \nTelefon \nKullanıcı Adı \nŞifre \nŞifre Tekrar", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (BtnKaydet.Text == "Düzenle/Kaydet")
            {
                if (TxtAdSoyad.Text != "" && MskTelefon.Text != "" && TxtKullaniciAdi.Text != "" && TxtSifre.Text != "" && TxtSifreTekrar.Text != "")
                {
                    if (TxtSifre.Text == TxtSifreTekrar.Text)
                    {
                        int id = Convert.ToInt32(LblKullaniciId.Text);
                        using (var db = new OptikOtomasyonuEntities())
                        {
                            var guncelle = db.TBLKULLANICI.Where(x => x.id == id).FirstOrDefault();
                            guncelle.AdSoyad = TxtAdSoyad.Text;
                            guncelle.Telefon = MskTelefon.Text;
                            guncelle.EPosta = TxtEPosta.Text;
                            guncelle.KullaniciAd = TxtKullaniciAdi.Text.Trim();
                            guncelle.Sifre = TxtSifre.Text;
                            guncelle.Satis = ChSatis.Checked;
                            guncelle.Rapor = ChRapor.Checked;
                            guncelle.Stok = ChStok.Checked;
                            guncelle.UrunGiris = ChUrunGiris.Checked;
                            guncelle.Ayarlar = ChAyarlar.Checked;
                            guncelle.FiyatGuncelle = ChFiyatGuncelle.Checked;
                            guncelle.Yedekleme = ChYedekleme.Checked;
                            db.SaveChanges();
                            MessageBox.Show("Güncelleme Yapılmıştır");
                            BtnKaydet.Text = "Kaydet";
                            Temizle();
                            doldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmamaktadır");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Zorunlu Girişleri Yazınız" + "\nAd Soyad \nTelefon \nKullanıcı Adı \nŞifre \nŞifre Tekrar", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListeKullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(gridListeKullanici.CurrentRow.Cells["id"].Value.ToString());
                LblKullaniciId.Text = id.ToString();
                using (var db = new OptikOtomasyonuEntities())
                {
                    var getir = db.TBLKULLANICI.Where(x => x.id == id).FirstOrDefault();
                    TxtAdSoyad.Text = getir.AdSoyad;
                    MskTelefon.Text = getir.Telefon;
                    TxtEPosta.Text = getir.EPosta;
                    TxtKullaniciAdi.Text = getir.KullaniciAd;
                    TxtSifre.Text = getir.Sifre;
                    TxtSifreTekrar.Text = getir.Sifre;
                    ChSatis.Checked = (bool)getir.Satis;
                    ChRapor.Checked = (bool)getir.Rapor;
                    ChStok.Checked = (bool)getir.Stok;
                    ChUrunGiris.Checked = (bool)getir.UrunGiris;
                    ChFiyatGuncelle.Checked = (bool)getir.FiyatGuncelle;
                    ChAyarlar.Checked = (bool)getir.Ayarlar;
                    ChYedekleme.Checked = (bool)getir.Yedekleme;
                    BtnKaydet.Text = "Düzenle/Kaydet";
                    doldur();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Seçiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            doldur();
            Cursor.Current = Cursors.Default;

        }
        private void doldur()
        {
            using (var db = new OptikOtomasyonuEntities())
            {
                if (db.TBLKULLANICI.Any())
                {
                gridListeKullanici.DataSource = db.TBLKULLANICI.Select(x => new { x.id, x.AdSoyad, x.KullaniciAd, x.Telefon }).ToList();
                }
                islemler.SabitVarsayılan();
                var yazici = db.TBLSABIT.FirstOrDefault();
                chYazmaDurumu.Checked = (bool)yazici.Yazici;

                var sabitler = db.TBLSABIT.FirstOrDefault();
                TxtKartKomisyon.Text = sabitler.KartKomisyon.ToString();

                var TeraziOnEk = db.TBLTERAZI.ToList();
                CmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                CmbTeraziOnEk.ValueMember = "id";
                CmbTeraziOnEk.DataSource = TeraziOnEk;

                TxtIsyeriAdSoyad.Text = sabitler.AdSoyad;
                TxtUnvan.Text = sabitler.Unvan;
                TxtAdres.Text = sabitler.Adres;
                MskIsyeriTelefon.Text = sabitler.Telefon;
                TxtIsyeriEposta.Text = sabitler.Eposta;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListeKullanici.Rows.Count > 0)
            {
                int kullaniciid = Convert.ToInt32(gridListeKullanici.CurrentRow.Cells["id"].Value.ToString());
                string kullaniciad = gridListeKullanici.CurrentRow.Cells["AdSoyad"].Value.ToString();
                DialogResult onay = MessageBox.Show(kullaniciad + " Adlı kullanıcıyı silmek istiyormusunuz?", "Kullanıcı Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    using (var db = new OptikOtomasyonuEntities())
                    {
                        var Kullanici = db.TBLKULLANICI.Find(kullaniciid);
                        db.TBLKULLANICI.Remove(Kullanici);
                        db.SaveChanges();
                        MessageBox.Show("Kullanıcı Silinmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        doldur();
                    }

                }
            }

        }

        private void chYazmaDurumu_CheckedChanged(object sender, EventArgs e)
        {
           
                using (var db=new OptikOtomasyonuEntities())
                {
                    if (chYazmaDurumu.Checked)
                    {
                        islemler.SabitVarsayılan();
                        var ayarla = db.TBLSABIT.FirstOrDefault();
                        ayarla.Yazici = true;
                        db.SaveChanges();
                        chYazmaDurumu.Text = "Yazma Durumu Aktif";
                    }
                    else 
                    {
                        islemler.SabitVarsayılan();
                        var ayarla = db.TBLSABIT.FirstOrDefault();
                        ayarla.Yazici = false;
                        db.SaveChanges();
                        chYazmaDurumu.Text = "Yazma Durumu Pasif";
                    }
                }
           
        }

        private void BtnKartKomisyon_Click(object sender, EventArgs e)
        {
            if (TxtKartKomisyon.Text!="")
            {
                using (var db=new OptikOtomasyonuEntities())
                {
                    var sabit = db.TBLSABIT.FirstOrDefault();
                    sabit.KartKomisyon = Convert.ToInt16(TxtKartKomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart Komisyon Ayarlandı");
                }
            }
            else
            {
                MessageBox.Show("Kart Komisyon Bilgisini Giriniz");
            }
        }

        private void BtnTeraziOnEK_Click(object sender, EventArgs e)
        {
            if (TxtTeraziOnEk.Text!="")
            {
                int OnEk = Convert.ToInt16(TxtTeraziOnEk.Text);
                using (var db=new OptikOtomasyonuEntities())
                {
                    if (db.TBLTERAZI.Any(x=>x.TeraziOnEk==OnEk))
                    {
                        MessageBox.Show(OnEk.ToString()+" Önek Zaten Kayıtlı");
                    }
                    else
                    {
                        TBLTERAZI t = new TBLTERAZI();
                        t.TeraziOnEk = OnEk;
                        db.TBLTERAZI.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler Kaydedilmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        CmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        CmbTeraziOnEk.ValueMember = "id";
                        CmbTeraziOnEk.DataSource = db.TBLTERAZI.ToList();
                        TxtTeraziOnEk.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi Önek Bilgisi Giriniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void BtnTeraziOnEkSil_Click(object sender, EventArgs e)
        {
            if (CmbTeraziOnEk.Text!="")
            {
                int onekid = Convert.ToInt16(CmbTeraziOnEk.SelectedValue);
                DialogResult onay = MessageBox.Show(CmbTeraziOnEk.Text + " Öneki Silmek İstiyormusunuz?","Terazi Önek Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (onay==DialogResult.Yes)
                {
                    using (var db=new OptikOtomasyonuEntities())
                    {
                        var onek = db.TBLTERAZI.Find(onekid);
                        db.TBLTERAZI.Remove(onek);
                        db.SaveChanges();
                        CmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        CmbTeraziOnEk.ValueMember = "id";
                        CmbTeraziOnEk.DataSource = db.TBLTERAZI.ToList();
                        MessageBox.Show("Önek Silinmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Önek Seçiniz");
            }
        }
    }
}
