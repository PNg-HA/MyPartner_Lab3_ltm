namespace Lab3
{
    partial class ex3_Dashboard
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
            btn_ser = new Button();
            btn_clt = new Button();
            SuspendLayout();
            // 
            // btn_ser
            // 
            btn_ser.Location = new Point(87, 112);
            btn_ser.Name = "btn_ser";
            btn_ser.Size = new Size(169, 92);
            btn_ser.TabIndex = 0;
            btn_ser.Text = "Server";
            btn_ser.UseVisualStyleBackColor = true;
            btn_ser.Click += btn_ser_Click;
            // 
            // btn_clt
            // 
            btn_clt.Location = new Point(495, 112);
            btn_clt.Name = "btn_clt";
            btn_clt.Size = new Size(169, 92);
            btn_clt.TabIndex = 1;
            btn_clt.Text = "Client";
            btn_clt.UseVisualStyleBackColor = true;
            btn_clt.Click += btn_clt_Click;
            // 
            // ex3_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_clt);
            Controls.Add(btn_ser);
            Name = "ex3_Dashboard";
            Text = "ex3_Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ser;
        private Button btn_clt;
    }
}