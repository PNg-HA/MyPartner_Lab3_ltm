namespace Lab3
{
    partial class ex3_TCPClient
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
            tbx_mess = new TextBox();
            tbx_port = new TextBox();
            tbx_ip = new TextBox();
            btn_connect = new Button();
            btn_send = new Button();
            tbx_res = new TextBox();
            SuspendLayout();
            // 
            // tbx_mess
            // 
            tbx_mess.Location = new Point(50, 382);
            tbx_mess.Name = "tbx_mess";
            tbx_mess.Size = new Size(473, 27);
            tbx_mess.TabIndex = 6;
            // 
            // tbx_port
            // 
            tbx_port.Location = new Point(437, 103);
            tbx_port.Name = "tbx_port";
            tbx_port.Size = new Size(86, 27);
            tbx_port.TabIndex = 5;
            // 
            // tbx_ip
            // 
            tbx_ip.Location = new Point(50, 103);
            tbx_ip.Name = "tbx_ip";
            tbx_ip.Size = new Size(160, 27);
            tbx_ip.TabIndex = 4;
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(544, 308);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(94, 47);
            btn_connect.TabIndex = 7;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(544, 380);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(94, 29);
            btn_send.TabIndex = 8;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // tbx_res
            // 
            tbx_res.Location = new Point(50, 148);
            tbx_res.Multiline = true;
            tbx_res.Name = "tbx_res";
            tbx_res.Size = new Size(473, 207);
            tbx_res.TabIndex = 9;
            // 
            // ex3_TCPClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(tbx_res);
            Controls.Add(btn_send);
            Controls.Add(btn_connect);
            Controls.Add(tbx_mess);
            Controls.Add(tbx_port);
            Controls.Add(tbx_ip);
            Name = "ex3_TCPClient";
            Text = "ex3_TCPClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_mess;
        private TextBox tbx_port;
        private TextBox tbx_ip;
        private Button btn_connect;
        private Button btn_send;
        private TextBox tbx_res;
    }
}