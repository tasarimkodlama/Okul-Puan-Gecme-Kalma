using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GecmeKalmaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //veriler alınacak
            int basarisizDers;
            double puan;
            basarisizDers = Convert.ToInt32(txtDersSayisi.Text);
            puan=Convert.ToDouble(txtOrtalama.Text);

            pboxCokMutlu.Visible = false;
            pboxMutlu.Visible = false;
            pboxMutsuz.Visible = false;
            pboxNormal.Visible = false;


            if (puan <=100 && puan >= 85 && basarisizDers == 0)
            {
                lblDurum.Text = "Tebrikler Takdir Aldınız...";
                pboxCokMutlu.Visible = true;
            }
            else if (puan>=70 && puan <85 && basarisizDers == 0)
            {
                lblDurum.Text = "Tebrikler Teşekkür Aldınız...";
                pboxMutlu.Visible = true;
            }
            else if (puan>=0 && puan < 70 && basarisizDers == 0)
            {
                lblDurum.Text = "Fena Değil Düz Geçtin...";
                pboxNormal.Visible = true;
            }
            else if ( basarisizDers > 0 && basarisizDers <4 )
            {
                lblDurum.Text = "Zayıfla Geçtin...";
                pboxNormal.Visible = true;
            }
            else if (basarisizDers >= 4)
            {
                lblDurum.Text = "Üzgünüm 4 ve Üzerinde Zayıf ile Kaldın...";
                pboxMutsuz.Visible=true;
            }


        }
    }
}
