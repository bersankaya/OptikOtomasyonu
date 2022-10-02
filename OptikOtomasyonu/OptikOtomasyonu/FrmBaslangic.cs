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
    public partial class FrmBaslangic : Form
    {
        public FrmBaslangic()
        {
            InitializeComponent();
        }

        private void BtnSatisIslemi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmSatis fr = new FrmSatis();
            fr.LblKullanici.Text = LblKullanici.Text;
            fr.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void BtnGenelRapor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmRapor frm = new FrmRapor();
            frm.LblKullanici.Text = LblKullanici.Text;
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmStok frm1 = new FrmStok();
            frm1.LblKullanici.Text = LblKullanici.Text;
            frm1.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void BtnUrunGiris_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmUrunGiris frm2 = new FrmUrunGiris();
            frm2.Lblkullanici.Text = LblKullanici.Text;
            frm2.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnFiyatGuncelle_Click(object sender, EventArgs e)
        {
            FrmFiyatGuncelle frm3 = new FrmFiyatGuncelle();
            frm3.ShowDialog();
        }

        private void BtnAyarlar_Click(object sender, EventArgs e)
        {
            FrmAyarlar fr = new FrmAyarlar();
            fr.ShowDialog();
        }
    }
}
