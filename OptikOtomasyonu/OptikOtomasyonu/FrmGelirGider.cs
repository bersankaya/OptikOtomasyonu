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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        public string gelirgider { get; set; }
        public string Kullanici { get; set; }
        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            lblgelirgider.Text = gelirgider + " İŞLEMİ YAPILIYOR";
        }

        private void CmbOdemeturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbOdemeturu.SelectedIndex==0)
            {
                txtnakit.Enabled = true;
                txtkart.Enabled = false; 
            }
            else if (CmbOdemeturu.SelectedIndex==1)
            {
                txtnakit.Enabled = false;
                txtkart.Enabled = true;

            }
           else if (CmbOdemeturu.SelectedIndex==2)
            {
                txtnakit.Enabled = true;
                txtkart.Enabled = true;
            }
            txtnakit.Text = "0";
            txtkart.Text = "0";
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (CmbOdemeturu.Text!="")
            {
                if (txtnakit.Text!="" && txtkart.Text!="")
                {
                    using (var db=new OptikOtomasyonuEntities())
                    {
                        TBLISLEMOZET io = new TBLISLEMOZET();
                        io.IslemNo = 0;
                        io.Iade = false;
                        io.OdemeSekli = CmbOdemeturu.Text;
                        io.Nakit = islemler.decimalyap(txtnakit.Text);
                        io.Kart = islemler.decimalyap(txtkart.Text);
                        if (gelirgider=="GELİR")
                        {
                            io.Gelir = true;
                            io.Gider = false;
                        }
                        else
                        {
                            io.Gelir = false;
                            io.Gider = true; 
                        }
                        io.AlisFiyatToplam = 0;
                        io.Aciklama =gelirgider +" - İşlemi " + txtaciklama.Text;
                        io.Tarih =datetarih.Value;
                        io.Kullanici = Kullanici;
                        db.TBLISLEMOZET.Add(io);
                        db.SaveChanges();
                        MessageBox.Show(gelirgider + " İşlemi Kaydedildi");
                        txtnakit.Text = "0";
                        txtkart.Text = "0";
                        txtaciklama.Clear();
                        CmbOdemeturu.Text = "";
                        FrmRapor fr = (FrmRapor)Application.OpenForms["FrmRapor"];
                        if (fr!=null)
                        {
                            fr.BtnGoster_Click(null, null);
                        }
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ödeme Türünü Belirleyiniz");
            }
        }
    }
}
