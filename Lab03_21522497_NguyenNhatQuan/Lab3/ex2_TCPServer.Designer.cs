namespace Lab3
{
    partial class ex2_TCPServer
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
            tbx_mess = new TextBox();
            SuspendLayout();
            // 
            // btn_listen
            // 
            btn_listen.Location = new Point(319, 36);
            btn_listen.Name = "btn_listen";
            btn_listen.Size = new Size(94, 29);
            btn_listen.TabIndex = 0;
            btn_listen.Text = "Listen";
            btn_listen.UseVisualStyleBackColor = true;
            btn_listen.Click += btn_listen_Click;
            // 
            // tbx_mess
            // 
            tbx_mess.Location = new Point(34, 88);
            tbx_mess.Multiline = true;
            tbx_mess.Name = "tbx_mess";
            tbx_mess.Size = new Size(379, 255);
            tbx_mess.TabIndex = 1;
            // 
            // ex2_TCPServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 376);
            Controls.Add(tbx_mess);
            Controls.Add(btn_listen);
            Name = "ex2_TCPServer";
            Text = "ex2_TCPServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_listen;
        private TextBox tbx_mess;
    }
}