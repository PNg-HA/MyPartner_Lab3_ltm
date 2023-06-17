using System;
using System.Collections.Concurrent;
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
    public partial class ex4_TCPServer : Form
    {
        TcpListener listener;
        List<TcpClient> clients;

        public ex4_TCPServer()
        {
            InitializeComponent();
        }

        private void AcceptClients()
        {
            while (true)
            {
                try
                {
                    TcpClient client = listener.AcceptTcpClient();
                    AddMessageToLog("Client connected.");
                    clients.Add(client);
                    Task.Run(() => HandleClient(client));
                }
                catch (Exception ex)
                {
                    AddMessageToLog("Error accepting client: " + ex.Message);
                }
            }
        }

        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            while (true)
            {
                try
                {
                    int b =stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.ASCII.GetString(buffer, 0, b);
                    AddMessageToLog(message);
                    BroadcastMessage(message);
                }
                catch (Exception ex)
                {
                    AddMessageToLog("Error handling client: " + ex.Message);
                    clients.Remove(client);
                    break;
                }
            }
        }

        private void BroadcastMessage(string message)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(message + "\r\n");
            foreach (TcpClient client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(bytes, 0, bytes.Length);
            }
        }

        private void AddMessageToLog(string message)
        {
            if (tbx_mess.InvokeRequired)
            {
                tbx_mess.Invoke(new Action<string>(AddMessageToLog), message);
                return;
            }
            tbx_mess.AppendText(message + Environment.NewLine);
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            clients = new List<TcpClient>();
            try
            {
                listener = new TcpListener(IPAddress.Any, int.Parse("8080"));
                listener.Start();
                AddMessageToLog("Server started.");
                Task.Run(() => AcceptClients());
                btn_listen.Enabled = false;
            }
            catch (Exception ex)
            {
                AddMessageToLog("Error starting server: " + ex.Message);
            }
        }
    }
}