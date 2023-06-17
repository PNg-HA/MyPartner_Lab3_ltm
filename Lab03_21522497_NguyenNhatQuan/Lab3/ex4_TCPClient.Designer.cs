namespace Lab3
{
    partial class ex4_TCPClient
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
            tbx_res = new TextBox();
            btn_send = new Button();
            tbx_mess = new TextBox();
            tbx_name = new TextBox();
            lbl_name = new Label();
            SuspendLayout();
            // 
            // tbx_res
            // 
            tbx_res.Location = new Point(58, 49);
            tbx_res.Multiline = true;
            tbx_res.Name = "tbx_res";
            tbx_res.Size = new Size(473, 207);
            tbx_res.TabIndex = 15;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(572, 354);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(94, 29);
            btn_send.TabIndex = 14;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // tbx_mess
            // 
            tbx_mess.Location = new Point(58, 356);
            tbx_mess.Name = "tbx_mess";
            tbx_mess.Size = new Size(473, 27);
            tbx_mess.TabIndex = 12;
            // 
            // tbx_name
            // 
            tbx_name.Location = new Point(128, 300);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new Size(125, 27);
            tbx_name.TabIndex = 16;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(56, 303);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(46, 20);
            lbl_name.TabIndex = 17;
            lbl_name.Text = "name";
            // 
            // ex4_TCPClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 413);
            Controls.Add(lbl_name);
            Controls.Add(tbx_name);
            Controls.Add(tbx_res);
            Controls.Add(btn_send);
            Controls.Add(tbx_mess);
            Name = "ex4_TCPClient";
            Text = "ex4_TCPClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_res;
        private Button btn_send;
        private TextBox tbx_mess;
        private TextBox tbx_name;
        private Label lbl_name;
    }
}