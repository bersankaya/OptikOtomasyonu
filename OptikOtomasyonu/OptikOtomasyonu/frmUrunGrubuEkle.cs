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
    public partial class frmUrunGrubuEkle : Form
    {
        public frmUrunGrubuEkle()
        {
            InitializeComponent();
        }
        OptikOtomasyonuEntities db = new OptikOtomasyonuEntities();
        private void frmUrunGrubuEkle_Load(object sender, EventArgs e)
        {
            grupdoldur();
        }
       private void grupdoldur()
        {
            ListUrunGrup.DisplayMember = "UrunGrupAd";
            ListUrunGrup.ValueMember = "id";
            ListUrunGrup.DataSource = db.TBLURUNGRUP.OrderBy(a => a.UrunGrupAd).ToList();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (TxtUrunGrup.Text != "")
            {
                TBLURUNGRUP ug = new TBLURUNGRUP();
                ug.UrunGrupAd = TxtUrunGrup.Text;
                db.TBLURUNGRUP.Add(ug);
                db.SaveChanges();
                grupdoldur();
                TxtUrunGrup.Clear();
                MessageBox.Show("Ürün Grubu Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmUrunGiris fr = (FrmUrunGiris)Application.OpenForms["FrmUrunGiris"];
                if (fr!=null)
                {
                fr.grupdoldur();

                }
                 
            }
            else
            {
                MessageBox.Show("Grup Bilgisi Ekleyiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(ListUrunGrup.SelectedValue.ToString());
            string grupad = ListUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupad +" grubunu silmek istiyormusunuz?","Silme İşlemi",MessageBoxButtons.YesNo);
            if (onay==DialogResult.Yes)
            {
                var grup = db.TBLURUNGRUP.FirstOrDefault(x => x.id == grupid);
                db.TBLURUNGRUP.Remove(grup);
                db.SaveChanges();
                grupdoldur();
                TxtUrunGrup.Focus();
                MessageBox.Show(grupad+" Grubu Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FrmUrunGiris f = (FrmUrunGiris)Application.OpenForms["FrmUrunGiris"];
                f.grupdoldur();
            }
        }
    }
}
