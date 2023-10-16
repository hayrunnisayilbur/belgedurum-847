using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belge_durum_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDurumGoster_Click(object sender, EventArgs e)
        {
            double notOrtalama, devamsizlikSayi;
            int zayifSayi;

            notOrtalama = Convert.ToDouble(txtOrtalama.Text);
            devamsizlikSayi = Convert.ToDouble(txtDevamsizlik.Text);
            zayifSayi = Convert.ToInt32(txtZayif.Text);

            if(notOrtalama >= 70 && notOrtalama <85 && devamsizlikSayi <5 && zayifSayi == 0)
            {
                lblDurum.Text = "teşekkür belgesi alacaksınız...";
            }
            else if(notOrtalama >=85 && notOrtalama <=100 && devamsizlikSayi < 5 && zayifSayi == 0)
            {
                lblDurum.Text = "takdir belgesi alacaksınız...";
            }
            else if(devamsizlikSayi > 5)
            {
                lblDurum.Text = "devamsızlığınız fazla";
            }
            else if(zayifSayi != 0)
            {
                lblDurum.Text = "zayıf var";
            }

        }
    }
}
