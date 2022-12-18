using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
              Foreach(1 2 3 4)
                 1= Değişken Türü
                 2= Değişken Adı(Kendimiz isim veriyoruz)
                 3= in
                 4= Dizi Adı
             
             */
            int toplam = 0;
            int[] sayilar = { 56, 80, 32, 45, 9, 86,12,45,78,87 };
            foreach (int say in sayilar)//Sayilar dizisini say değişkenine attık
            {
                listBox1.Items.Add(say);
                toplam = toplam + say;
                if (say%2==0)
                {
                   
                }

            }
            label6.Text = toplam.ToString();
           
        }
    }
}
