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
    public partial class FrmHizliUrunButonEkle : Form
    {
        public FrmHizliUrunButonEkle()
        {
            InitializeComponent();
        }
        OptikOtomasyonuEntities db = new OptikOtomasyonuEntities();
        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAra.Text != "")
            {
                string urunad = txtUrunAra.Text;
                var urunler = db.TBLURUN.Where(a => a.UrunAd.Contains(urunad)).ToList();
                gridUrunler.DataSource = urunler;
                islemler.GridDuzenle(gridUrunler);
            }
        }

        private void gridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUrunler.Rows.Count > 0)
            {
                string barkod = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string UrunAd = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                decimal fiyat = Convert.ToDecimal(gridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                int id = Convert.ToInt16(lblbutonıd.Text);
                var guncellenecek = db.TBLHIZLIURUN.Find(id);
                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = UrunAd;
                guncellenecek.fiyat = fiyat;
                db.SaveChanges();
                MessageBox.Show("Ürün Tanımlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmSatis fr = (FrmSatis)Application.OpenForms["FrmSatis"];
                if (fr!=null)
                {
                    Button b = fr.Controls.Find("bH" + id, true).FirstOrDefault() as Button;
                    b.Text = UrunAd + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void chtumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chtumu.Checked)
            {

            gridUrunler.DataSource = db.TBLURUN.ToList();
                gridUrunler.Columns["AlisFiyat"].Visible = false;
                gridUrunler.Columns["SatisFiyat"].Visible = false;
                gridUrunler.Columns["KdvOrani"].Visible = false;
                gridUrunler.Columns["KdvTutari"].Visible = false;
                gridUrunler.Columns["Miktar"].Visible = false;


                islemler.GridDuzenle(gridUrunler);
            }
            else
            {
                gridUrunler.DataSource = null;
            }
        }

        private void FrmHizliUrunButonEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
