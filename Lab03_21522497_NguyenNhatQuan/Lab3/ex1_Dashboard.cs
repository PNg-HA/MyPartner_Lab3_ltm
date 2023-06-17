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
    public partial class ex1_Dashboard : Form
    {
        public ex1_Dashboard()
        {
            InitializeComponent();
        }

        static void ShowDialog_Server()
        {
            Form form = new ex1_UDPServer();
            form.ShowDialog();
        }

        static void ShowDialog_Client()
        {
            Form form = new ex1_UDPClient();
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
