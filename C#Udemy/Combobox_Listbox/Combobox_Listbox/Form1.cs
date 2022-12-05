using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cmbSehir.Items.Add(txtSehir.Text);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtMeslek.Text+" "+txtSehir.Text);
        }
    }
}
