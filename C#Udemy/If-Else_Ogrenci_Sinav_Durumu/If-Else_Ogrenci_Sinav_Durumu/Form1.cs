using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Else_Ogrenci_Sinav_Durumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, proje, ort;
            string durum;
            sinav1 = Convert.ToDouble(txt1Sinav.Text);
            sinav2 = Convert.ToDouble(txt2Sinav.Text);
            proje = Convert.ToDouble(txtProje.Text);

            ort = (sinav1 + sinav2 + proje) / 3;
            if (ort < 50)
            {

                durum = "Kaldınız";

            }
            else
            {
                durum = "Geçtiniz";
            }
            txtSonuc.Text = ort.ToString("0.00") + "  " + durum;
        }
    }
}
