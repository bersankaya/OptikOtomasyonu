using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptikOtomasyonu.Indirimobject;
namespace OptikOtomasyonu
{

    public partial class FrmIndirimliSatis : Form
    {
        public decimal gelenDeger { get; set; }

        public decimal yuzdeAl(decimal indirimYuzde)
        {
            decimal total = gelenDeger - gelenDeger * indirimYuzde / 100;
            return total;
        }


        public FrmIndirimliSatis()
        {
            InitializeComponent();
        }

        public bool CheckIfFormIsOpen(string formname)
        {
            bool formOpen = Application.OpenForms.Cast<Form>().Any(form => form.Name == formname);
            return formOpen;
        }

        public void BtnYuzde10_Click(object sender, EventArgs e)
        {
            var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "FrmSatis").FirstOrDefault();
            if (CheckIfFormIsOpen("FrmSatis"))
            {
                frm.Close();
                decimal geber = yuzdeAl(10);
                FrmSatis frmSatis = new FrmSatis(geber);
                this.Hide();
                frmSatis.Show();
            }

        }

        private void FrmIndirimliSatis_Load(object sender, EventArgs e)
        {
        }
    }
}
