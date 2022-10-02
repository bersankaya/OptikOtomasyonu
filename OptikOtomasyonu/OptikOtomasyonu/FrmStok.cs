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
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridStok.DataSource = null;
            using (var db=new OptikOtomasyonuEntities())
            {
                if (cmbislemturu.Text!="")
                {
                    string urungrubu = cmburungrubu.Text;
                    if (cmbislemturu.SelectedIndex==0)
                    {
                        if (rdTumu.Checked)
                        {
                            db.TBLURUN.OrderBy(x => x.Miktar).Load();
                            gridStok.DataSource = db.TBLURUN.Local.ToBindingList();
                        }
                        else if (RdUrunGrubunaGore.Checked)
                        {
                            db.TBLURUN.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            gridStok.DataSource = db.TBLURUN.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen  Filtereleme Türü'nü Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    else if (cmbislemturu.SelectedIndex==1)
                    {
                        DateTime baslangic = DateTime.Parse(datebaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(datebitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);
                        if (rdTumu.Checked)
                        {
                            db.TBLSTOKHAREKET.OrderByDescending(x=>x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            gridStok.DataSource = db.TBLSTOKHAREKET.Local.ToBindingList();
                        }
                        else if (RdUrunGrubunaGore.Checked)
                        {
                            db.TBLSTOKHAREKET.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            gridStok.DataSource = db.TBLSTOKHAREKET.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtereleme Türü'nü Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen İşlem Türü'nü Seçiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                islemler.GridDuzenle(gridStok);
            }
        }
        OptikOtomasyonuEntities dbx = new OptikOtomasyonuEntities();
        private void FrmStok_Load(object sender, EventArgs e)
        {
            cmburungrubu.DisplayMember = "UrunGrupAd";
            cmburungrubu.ValueMember = "id";
            cmburungrubu.DataSource = dbx.TBLURUNGRUP.ToList();
        }

        private void TxtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (TxtUrunAra.Text.Length>=2)
            {
                string urunad = TxtUrunAra.Text;
                using (var db=new OptikOtomasyonuEntities())
                {
                    if (cmbislemturu.SelectedIndex==0)
                    {
                        db.TBLURUN.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridStok.DataSource = db.TBLURUN.Local.ToBindingList();
                    }
                    else if (cmbislemturu.SelectedIndex==1)
                    {
                        db.TBLSTOKHAREKET.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridStok.DataSource = db.TBLSTOKHAREKET.Local.ToBindingList();
                    }
                    islemler.GridDuzenle(gridStok);
                }
            }
        }

        private void BtnRaporAl_Click(object sender, EventArgs e)
        {
            if (cmbislemturu.SelectedIndex==0)
            {
                Raporlar.Baslik = cmbislemturu.Text + " Raporu";
                Raporlar.TarihBaslangic = datebaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = datebitis.Value.ToShortDateString();
                Raporlar.StokRaporu(gridStok);
            }
            else if (cmbislemturu.SelectedIndex==1)
            {
                Raporlar.Baslik = cmbislemturu.Text + " Raporu";
                Raporlar.TarihBaslangic = datebaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = datebitis.Value.ToShortDateString();
                Raporlar.StokIzlemeRaporu(gridStok);
            }
            
        }
    }
}
