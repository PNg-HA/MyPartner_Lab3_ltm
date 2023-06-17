namespace Lab3
{
    partial class ex1_UDPServer
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
            tbx_port = new TextBox();
            tbx_message = new TextBox();
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(462, 77);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(94, 29);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // tbx_port
            // 
            tbx_port.Location = new Point(365, 77);
            tbx_port.Name = "tbx_port";
            tbx_port.Size = new Size(81, 27);
            tbx_port.TabIndex = 1;
            // 
            // tbx_message
            // 
            tbx_message.Location = new Point(41, 114);
            tbx_message.Multiline = true;
            tbx_message.Name = "tbx_message";
            tbx_message.Size = new Size(515, 242);
            tbx_message.TabIndex = 2;
            // 
            // ex1_UDPServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 406);
            Controls.Add(tbx_message);
            Controls.Add(tbx_port);
            Controls.Add(btn_listen);
            Name = "ex1_UDPServer";
            Text = "ex2_UDPServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_listen;
        private TextBox tbx_port;
        private TextBox tbx_message;
    }
}