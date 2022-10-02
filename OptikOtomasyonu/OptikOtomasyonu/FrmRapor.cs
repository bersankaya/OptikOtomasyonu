using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptikOtomasyonu
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        public void BtnGoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangic = DateTime.Parse(dtbaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dtbitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);
            using (var db = new OptikOtomasyonuEntities())
            {
                if (listFiltreleme.SelectedIndex == 0)//tümünü getir
                {
                    db.TBLISLEMOZET.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemozet = db.TBLISLEMOZET.Local.ToBindingList();
                    gridRapor.DataSource = islemozet;

                    txtsatisNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString("C2");
                    TxtSatiskart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Kart)).ToString("C2");

                    TxtIadeNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Nakit)).ToString("C2");
                    TxtIadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString("C2");

                    TxtGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    TxtGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Kart)).ToString("C2");

                    TxtGiderNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    TxtGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Kart)).ToString("C2");

                    db.TBLSATIS.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satistablosu = db.TBLSATIS.Local.ToBindingList();
                    decimal kdvtutarsatis = islemler.decimalyap(satistablosu.Where(x => x.iade == false).Sum(x => x.KdvTutari).ToString());
                    decimal kdvtutariiade = islemler.decimalyap(satistablosu.Where(x => x.iade == true).Sum(x => x.KdvTutari).ToString());
                    txtKdvToplam.Text = (kdvtutarsatis - kdvtutariiade).ToString("C2");
                }
                else if (listFiltreleme.SelectedIndex==1)//Satışlar 
                {
                    db.TBLISLEMOZET.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == false && x.Gelir == false && x.Gider == false).Load();
                    var islemozet = db.TBLISLEMOZET.Local.ToBindingList();
                    gridRapor.DataSource = islemozet;
                }
                else if (listFiltreleme.SelectedIndex==2)//iadeler
                {
                    db.TBLISLEMOZET.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == true).Load();
                    gridRapor.DataSource = db.TBLISLEMOZET.Local.ToBindingList();
                }
                else if (listFiltreleme.SelectedIndex==3)//gelirler
                {
                    db.TBLISLEMOZET.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).Load();
                    gridRapor.DataSource = db.TBLISLEMOZET.Local.ToBindingList();
                }
                else if (listFiltreleme.SelectedIndex==4)//Giderler
                {
                    db.TBLISLEMOZET.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).Load();
                    gridRapor.DataSource = db.TBLISLEMOZET.Local.ToBindingList();
                }
            }


            islemler.GridDuzenle(gridRapor);

            Cursor.Current = Cursors.Default;
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            listFiltreleme.SelectedIndex = 0;
            TxtKartKomisyon.Text = islemler.Kartkomisyon().ToString();
            BtnGoster_Click(null, null);

        }

        private void gridRapor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==2 || e.ColumnIndex==6 || e.ColumnIndex==7)
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;
                }
            }
        }

        private void BtnGelirEkle_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.gelirgider = "GELİR";
            fr.Kullanici = LblKullanici.Text;
            fr.ShowDialog();
        }

        private void BtnGiderEkle_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.gelirgider = "GİDER";
            fr.Kullanici = LblKullanici.Text;
            fr.ShowDialog();
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridRapor.Rows.Count>0)
            {
                int islemno = Convert.ToInt32(gridRapor.CurrentRow.Cells["IslemNo"].Value.ToString());
                DateTime tarih =Convert.ToDateTime( gridRapor.CurrentRow.Cells["Tarih"].Value.ToString());
                if (islemno!=0)
                {
                    FrmDetayGoster fr = new FrmDetayGoster();
                    fr.islemno = islemno;
                    fr.Tarih = tarih;
                    fr.ShowDialog();
                }
            }
        }
        private void BtnRaporAl_Click(object sender, EventArgs e)
        {
            Raporlar.Baslik = "GENEL RAPOR";
            Raporlar.SatisKart = TxtSatiskart.Text;
            Raporlar.SatisNakit = txtsatisNakit.Text;
            Raporlar.IadeKart = TxtIadeKart.Text;
            Raporlar.IadeNakit = TxtIadeNakit.Text;
            Raporlar.GelirKart = TxtGelirKart.Text;
            Raporlar.GelirNakit = TxtGelirNakit.Text;
            Raporlar.GiderKart = TxtGiderKart.Text;
            Raporlar.GiderNakit = TxtGiderNakit.Text;
            Raporlar.TarihBaslangic = dtbaslangic.Value.ToShortDateString();
            Raporlar.TarihBitis = dtbitis.Value.ToShortDateString();
            Raporlar.KdvToplam = txtKdvToplam.Text;
            Raporlar.KartKomisyon = TxtKartKomisyon.Text;

            Raporlar.RaporSayfsiRaporu(gridRapor);
        }
    }
}
