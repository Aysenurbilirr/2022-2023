using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 4, 3, 6, 8, 9, 6, 33, 44, 89, 66, 35 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]>10&& sayilar[i]%2==0)
                {
                    listBox1.Items.Add(sayilar[i]);
                }
            }
        }
    }
}
