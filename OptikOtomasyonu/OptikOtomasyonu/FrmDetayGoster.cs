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
    public partial class FrmDetayGoster : Form
    {
        public FrmDetayGoster()
        {
            InitializeComponent();
        }
        public int islemno { get; set; }
        public DateTime Tarih { get; set; }
        private void FrmDetayGoster_Load(object sender, EventArgs e)
        {
            lblislemno.Text = "İslem No: " + islemno.ToString();
            lbltarih.Text = "Tarih Ve Saat: " + Tarih.ToString();
            using (var db=new OptikOtomasyonuEntities())
            {
                gridRapor.DataSource = db.TBLSATIS.Select(x=>new {x.islemno,x.UrunAd,x.UrunGrup,x.Miktar,x.Toplam }).Where(x => x.islemno == islemno).ToList();
                islemler.GridDuzenle(gridRapor);
                    
            }
        }
    }
}
