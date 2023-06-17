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
    public partial class ex3_TCPServer : Form
    {
        TcpListener listener;
        List<Client> clients;

        class Client
        {
            TcpClient tcpClient;
            NetworkStream stream;
            byte[] buffer;
            ex3_TCPServer mainForm;

            public Client(TcpClient tcpClient, ex3_TCPServer mainForm)
            {
                this.tcpClient = tcpClient;
                stream = tcpClient.GetStream();
                buffer = new byte[tcpClient.ReceiveBufferSize];
                this.mainForm = mainForm;
            }

            public void ReceiveMessages()
            {
                while (tcpClient.Connected)
                {
                    int bytesRead = 0;
                    try
                    {
                        bytesRead = stream.Read(buffer, 0, tcpClient.ReceiveBufferSize);
                    }
                    catch
                    {
                        Disconnect();
                    }
                    if (bytesRead == 0)
                    {
                        Disconnect();
                    }
                    else
                    {
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        mainForm.BroadcastMessage(message);
                    }
                }
            }

            public void SendMessage(string message)
            {
                byte[] bytes = Encoding.ASCII.GetBytes(message + "\r\n");
                stream.Write(bytes, 0, bytes.Length);
            }

            public void Disconnect()
            {
                if (tcpClient != null)
                {
                    tcpClient.Close();
                    tcpClient = null;
                }
            }
        }

        public ex3_TCPServer()
        {
            InitializeComponent();
        }

        public void ListenForClients()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = listener.AcceptTcpClient();
                    Client client = new Client(tcpClient, this);
                    clients.Add(client);
                    Thread clientThread = new Thread(new ThreadStart(client.ReceiveMessages));
                    clientThread.Start();
                    tbx_mess.AppendText($"Client connected from {tcpClient.Client.RemoteEndPoint}\n");
                }
                catch (Exception ex)
                {
                    /*tbx_mess.AppendText($"Failed to accept client: {ex.Message}\n");*/
                }
            }
        }

        public void BroadcastMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(BroadcastMessage), message);
                return;
            }
            tbx_mess.AppendText("\r\n" + message);
            foreach (Client client in clients)
            {
                client.SendMessage(message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectAllClients();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            DisconnectAllClients();
        }

        private void DisconnectAllClients()
        {
            foreach (Client client in clients)
            {
                client.Disconnect();
            }

        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            clients = new List<Client>();

            try
            {
                IPAddress ip = IPAddress.Parse(tbx_ip.Text);
                int port = int.Parse(tbx_port.Text);
                listener = new TcpListener(ip, port);
                listener.Start();
                tbx_mess.AppendText($"Server started on {ip}:{port}\n");
                Thread listenThread = new Thread(new ThreadStart(ListenForClients));
                listenThread.Start();
                btn_listen.Enabled = false;
            }
            catch (Exception ex)
            {
                tbx_mess.AppendText($"Failed to start server: {ex.Message}\n");
            }
        }
    }
}