using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPIPDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTCPServer server;

        public int Server_DataRecieved { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

            server = new SimpleTCPServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataRecieved += Server_DataRecieved;


        }
        private void sServer_DataRecieved(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("You Said: {0}", e.MessageString));
            });

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtStatus.Text += "Server Starting";
            System.Net.IPAddress ip = new System.Net.IPAddress(long.Parse(txtHost.Text));
            server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}
