using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class ex1_UDPClient : Form
    {
        public ex1_UDPClient()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();
            IPAddress ipadd = IPAddress.Parse(tbx_IP.Text);
            int port = Convert.ToInt32(tbx_port.Text);
            IPEndPoint ep = new IPEndPoint(ipadd, port);
            Byte[] buffer = Encoding.ASCII.GetBytes(tbx_message.Text);
            client.Send(buffer, buffer.Length, ep);
        }
    }
}
