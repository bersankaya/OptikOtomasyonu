using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptikOtomasyonu
{
    static class islemler
    {
        public static decimal decimalyap(string deger)
        {
            decimal sonuc;
            decimal.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentUICulture.NumberFormat, out sonuc);
            return Math.Round(sonuc, 2);
        }
        public static void StokAzalt(string barkod, decimal miktar)
        {
            if (barkod != "1111111111116")
            {
                using (var db = new OptikOtomasyonuEntities())
                {
                    var urunbilgi = db.TBLURUN.SingleOrDefault(X => X.Barkod == barkod);
                    urunbilgi.Miktar = urunbilgi.Miktar - miktar;
                    db.SaveChanges();
                }
            }
        }
        public static void StokArttir(string barkod, decimal miktar)
        {
            if (barkod != "1111111111116")
            {
                using (var db = new OptikOtomasyonuEntities())
                {
                    var urunbilgi = db.TBLURUN.SingleOrDefault(X => X.Barkod == barkod);
                    urunbilgi.Miktar = urunbilgi.Miktar + miktar;
                    db.SaveChanges();
                }
            }
        }
        public static void GridDuzenle(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {
                        case "id":
                            dgv.Columns[i].HeaderText = "Numara"; break;
                        case "IslemNo":
                            dgv.Columns[i].HeaderText = "İşlem No"; break;
                        case "UrunId":
                            dgv.Columns[i].HeaderText = "Ürün Numarası"; break;
                        case "UrunAd":
                            dgv.Columns[i].HeaderText = "Ürün Adı"; break;
                        case "Aciklama":
                            dgv.Columns[i].HeaderText = "Açıklama"; break;
                        case "UrunGrup":
                            dgv.Columns[i].HeaderText = "Ürün Grubu"; break;
                        case "AlisFiyat":
                            dgv.Columns[i].HeaderText = "Alış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "SatisFiyat":
                            dgv.Columns[i].HeaderText = "Satış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "AlisFiyatToplam":
                            dgv.Columns[i].HeaderText = "Alış Fiyat Toplam";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "KdvOrani":
                            dgv.Columns[i].HeaderText = "KDV Oranı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "Birim":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "Miktar":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "OdemeSekli":
                            dgv.Columns[i].HeaderText = "Ödeme Şekli";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "Kart":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Nakit":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Gelir":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Gider":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Kullanici":
                            dgv.Columns[i].HeaderText = "Kullanıcı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; break;
                        case "KdvTutari":
                            dgv.Columns[i].HeaderText = "KDV Tutarı";
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; break;
                        case "Toplam":
                            dgv.Columns[i].HeaderText = "Toplam";
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; break;
                    }
                }
            }
        }
        public static void StokHareket(string Barkod,string urunad,string birim,decimal miktar,string urungrup,string kullanici)
        {
            using (var db=new OptikOtomasyonuEntities())
            {
                TBLSTOKHAREKET sh = new TBLSTOKHAREKET();
                sh.Barkod = Barkod;
                sh.UrunAd = urunad;
                sh.Birim = birim;
                sh.Miktar = miktar;
                sh.UrunGrup = urungrup;
                sh.Kullanici = kullanici;
                sh.Tarih = DateTime.Now;
                db.TBLSTOKHAREKET.Add(sh);
                db.SaveChanges();
            }
        }
        public static int Kartkomisyon()
        {
            int sonuc = 0;
            using (var db=new OptikOtomasyonuEntities())
            {
                if (db.TBLSABIT.Any())
                {
                    sonuc =Convert.ToInt16( db.TBLSABIT.First().KartKomisyon);
                }
                else
                {
                    sonuc = 0;

                }
                return sonuc;
            }
        }
        public static void SabitVarsayılan()
        {
            using (var db=new OptikOtomasyonuEntities())
            {
                if (!db.TBLSABIT.Any())
                {
                    TBLSABIT s = new TBLSABIT();
                    s.KartKomisyon = 0;
                    s.Yazici = false;
                    s.AdSoyad = "Admin";
                    s.Adres = "Admin";
                    s.Unvan = "Admin";
                    s.Telefon = "Admin";
                    s.Eposta = "Admin";
                    db.TBLSABIT.Add(s);
                    db.SaveChanges();
                }
            }
        }
    }
}
