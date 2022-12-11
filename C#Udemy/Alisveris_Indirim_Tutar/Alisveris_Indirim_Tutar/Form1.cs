using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alisveris_Indirim_Tutar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt32(txtKitapAdet.Text);
            if (kitapadet >= 0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 40) - (kitapadet * 40 * 0.20);
                label2.Text = toplam + " ₺";
            }
            if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 40) - (kitapadet * 40 * 0.40);
                label2.Text = toplam + " ₺";

            }
            if (kitapadet>=41)
            {
                toplam = (kitapadet * 40) - (kitapadet * 40 * 0.50);
                label2.Text = toplam+" ₺";
            }
        }

        // 0-20 arası kitap alana %20 indirim
        // 21-40 aarsı kitap alana %40 indirim
        // 41 ve daha fazla kitap alana +50 indirim
        //kitap= 40₺
    }
}
