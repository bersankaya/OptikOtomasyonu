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
        public double gelenDeger { get; set; }
        public double setGelenDegerFormSatis { get; set; }



        public double yuzdeAl(int indirimYuzde)
        {
            double total = gelenDeger - gelenDeger * indirimYuzde / 100;
            return total;
        }







        public FrmIndirimliSatis()
        {
            InitializeComponent();
        }


        public void BtnYuzde10_Click(object sender, EventArgs e)
        {
            FrmSatis satis = new FrmSatis();
            double geber = yuzdeAl(10);
            setGelenDegerFormSatis = geber;
            satis.verAlevAlsin = geber;
            //satis.
            
        }

    }
}
