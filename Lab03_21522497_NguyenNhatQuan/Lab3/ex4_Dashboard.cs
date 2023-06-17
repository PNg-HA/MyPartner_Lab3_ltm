using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class ex4_Dashboard : Form
    {
        public ex4_Dashboard()
        {
            InitializeComponent();
        }

        static void ShowDialog_Server()
        {
            Form form = new ex4_TCPServer();
            form.ShowDialog();
        }

        static void ShowDialog_Client()
        {
            Form form = new ex4_TCPClient();
            form.ShowDialog();
        }

        private static void btn_ser_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowDialog_Server));
            thread.Start();
        }

        private void btn_clt_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowDialog_Client));
            thread.Start();
        }
    }
}
