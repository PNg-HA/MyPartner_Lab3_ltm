using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3
{
    public partial class ex4_TCPClient : Form
    {
        TcpClient client;
        NetworkStream stream;
        byte[] buffer;

        public ex4_TCPClient()
        {
            InitializeComponent();
            buffer = new byte[1024];
            try
            {
                client = new TcpClient();
                client.Connect("127.0.0.1", int.Parse("8080"));
                stream = client.GetStream();
                AddMessageToLog("Connected to server.");
                btn_send.Enabled = true;
            }
            catch (Exception ex)
            {
                AddMessageToLog("Error connecting to server: " + ex.Message);
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                string message = tbx_name.Text + ": " + tbx_mess.Text;
                byte[] bytes = Encoding.ASCII.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
                tbx_mess.Clear();

                byte[] data = new byte[1024];
                int b = stream.Read(data);
                string res = Encoding.ASCII.GetString(data);
                AddMessageToLog(res + Environment.NewLine);

            }
            catch (Exception ex)
            {
                AddMessageToLog("Error sending message: " + ex.Message);
            }
        }

        private void AddMessageToLog(string message)
        {
            if (tbx_mess.InvokeRequired)
            {
                tbx_res.Invoke(new Action<string>(AddMessageToLog), message);
                return;
            }
            tbx_res.AppendText(message + Environment.NewLine);
        }
    }
}
