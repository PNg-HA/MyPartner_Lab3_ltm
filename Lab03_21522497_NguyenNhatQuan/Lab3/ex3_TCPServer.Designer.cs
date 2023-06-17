namespace Lab3
{
    partial class ex3_TCPServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_listen = new Button();
            tbx_ip = new TextBox();
            tbx_port = new TextBox();
            tbx_mess = new TextBox();
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(429, 111);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(94, 29);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // tbx_ip
            // 
            tbx_ip.Location = new Point(50, 113);
            tbx_ip.Name = "tbx_ip";
            tbx_ip.Size = new Size(125, 27);
            tbx_ip.TabIndex = 1;
            // 
            // tbx_port
            // 
            tbx_port.Location = new Point(339, 113);
            tbx_port.Name = "tbx_port";
            tbx_port.Size = new Size(65, 27);
            tbx_port.TabIndex = 2;
            // 
            // tbx_mess
            // 
            tbx_mess.Location = new Point(50, 157);
            tbx_mess.Multiline = true;
            tbx_mess.Name = "tbx_mess";
            tbx_mess.Size = new Size(473, 241);
            tbx_mess.TabIndex = 3;
            // 
            // ex3_TCPServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 427);
            Controls.Add(tbx_mess);
            Controls.Add(tbx_port);
            Controls.Add(tbx_ip);
            Controls.Add(btn_listen);
            Name = "ex3_TCPServer";
            Text = "ex3_TCPServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_listen;
        private TextBox tbx_ip;
        private TextBox tbx_port;
        private TextBox tbx_mess;
    }
}