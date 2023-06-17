namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void Show_ex1()
        {
            Form form = new ex1_Dashboard();
            form.ShowDialog();
        }

        void Show_ex2()
        {
            Form form = new ex2_TCPServer();
            form.ShowDialog();
        }

        void Show_ex3()
        {
            Form form = new ex3_Dashboard();
            form.ShowDialog();
        }

        void Show_ex4()
        {
            Form form = new ex4_Dashboard();
            form.ShowDialog();
        }

        private void btn_ex1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Show_ex1));
            thread.Start();
        }

        private void btn_ex2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Show_ex2));
            thread.Start();
        }

        private void btn_ex3_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Show_ex3));
            thread.Start();
        }

        private void btn_ex4_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Show_ex4));
            thread.Start();
        }
    }
}