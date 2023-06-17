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
    public partial class ex1_UDPServer : Form
    {
        private UdpClient server;
        private Thread thread;

        public ex1_UDPServer()
        {
            InitializeComponent();
        }

        private void StartServer(int port)
        {
            server = new UdpClient(port);
            thread = new Thread(new ThreadStart(ReceiveData));
            thread.Start();
            LogMessage("Server started on port " + port);
        }

        private void ReceiveData()
        {
            while (true)
            {
                try
                {
                    IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] data = server.Receive(ref endpoint);
                    string message = Encoding.ASCII.GetString(data);
                    LogMessage("Received message from " + endpoint.Address.ToString() + ": " + message);
                }
                catch (ThreadAbortException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    LogMessage("Error receiving data: " + ex.Message);
                }
            }
        }

        private void LogMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { LogMessage(message); });
                return;
            }
            tbx_message.AppendText(message + Environment.NewLine);
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(tbx_port.Text);
            if (int.TryParse(tbx_port.Text, out port))
            {
                StartServer(port);
            }
            else
            {
                LogMessage("Invalid port number");
            }
            btn_listen.Enabled = false;
        }
    }
}
