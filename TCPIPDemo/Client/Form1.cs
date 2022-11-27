using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTCPClient client;
        private int client_DataRecieved;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            //BtnConnect'i devre dışı bırakır

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTCPClient();
            client.StringEncoder = Encoding.UTF8;
            //her karaktere bir sayı değeri karşılığı atayan bir standarttır.
            client.DataRecieved += client_DataRecieved;
        }
        private void sServer_DataRecieved(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
               
            });

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetreply(txtMessage.Text, TimeSpan.FromSeconds(3));
        }
    }
}
