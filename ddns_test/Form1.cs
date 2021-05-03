using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace ddns_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPHostEntry host;

            host = Dns.GetHostEntry(textBox1.Text);

            textBox2.AppendText("GetHostEntry:" + textBox1.Text + Environment.NewLine);

            textBox2.AppendText(host.AddressList.Length.ToString()+Environment.NewLine);
            foreach (IPAddress ip in host.AddressList)
            {
                textBox2.AppendText(ip.ToString() + " / ");
            } 
        }
    }
}
