namespace Lab3
{
    partial class ex1_UDPClient
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
            tbx_IP = new TextBox();
            tbx_port = new TextBox();
            tbx_message = new TextBox();
            btn_send = new Button();
            SuspendLayout();
            // 
            // tbx_IP
            // 
            tbx_IP.Location = new Point(28, 72);
            tbx_IP.Name = "tbx_IP";
            tbx_IP.Size = new Size(151, 27);
            tbx_IP.TabIndex = 0;
            // 
            // tbx_port
            // 
            tbx_port.Location = new Point(241, 72);
            tbx_port.Name = "tbx_port";
            tbx_port.Size = new Size(82, 27);
            tbx_port.TabIndex = 1;
            // 
            // tbx_message
            // 
            tbx_message.Location = new Point(28, 121);
            tbx_message.Multiline = true;
            tbx_message.Name = "tbx_message";
            tbx_message.Size = new Size(451, 229);
            tbx_message.TabIndex = 2;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(374, 53);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(105, 46);
            btn_send.TabIndex = 3;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // ex1_UDPClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 392);
            Controls.Add(btn_send);
            Controls.Add(tbx_message);
            Controls.Add(tbx_port);
            Controls.Add(tbx_IP);
            Name = "ex1_UDPClient";
            Text = "UDP Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_IP;
        private TextBox tbx_port;
        private TextBox tbx_message;
        private Button btn_send;
    }
}