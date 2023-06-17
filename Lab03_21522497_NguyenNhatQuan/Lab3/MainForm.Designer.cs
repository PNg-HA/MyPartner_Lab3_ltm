namespace Lab3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_ex1 = new Button();
            btn_ex2 = new Button();
            btn_ex3 = new Button();
            btn_ex4 = new Button();
            SuspendLayout();
            // 
            // btn_ex1
            // 
            btn_ex1.Location = new Point(101, 101);
            btn_ex1.Name = "btn_ex1";
            btn_ex1.Size = new Size(160, 78);
            btn_ex1.TabIndex = 0;
            btn_ex1.Text = "Bai 1";
            btn_ex1.UseVisualStyleBackColor = true;
            btn_ex1.Click += btn_ex1_Click;
            // 
            // btn_ex2
            // 
            btn_ex2.Location = new Point(458, 101);
            btn_ex2.Name = "btn_ex2";
            btn_ex2.Size = new Size(160, 78);
            btn_ex2.TabIndex = 1;
            btn_ex2.Text = "Bai 2";
            btn_ex2.UseVisualStyleBackColor = true;
            btn_ex2.Click += btn_ex2_Click;
            // 
            // btn_ex3
            // 
            btn_ex3.Location = new Point(101, 244);
            btn_ex3.Name = "btn_ex3";
            btn_ex3.Size = new Size(160, 78);
            btn_ex3.TabIndex = 2;
            btn_ex3.Text = "Bai 3";
            btn_ex3.UseVisualStyleBackColor = true;
            btn_ex3.Click += btn_ex3_Click;
            // 
            // btn_ex4
            // 
            btn_ex4.Location = new Point(458, 244);
            btn_ex4.Name = "btn_ex4";
            btn_ex4.Size = new Size(160, 78);
            btn_ex4.TabIndex = 3;
            btn_ex4.Text = "Bai 4";
            btn_ex4.UseVisualStyleBackColor = true;
            btn_ex4.Click += btn_ex4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ex4);
            Controls.Add(btn_ex3);
            Controls.Add(btn_ex2);
            Controls.Add(btn_ex1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ex1;
        private Button btn_ex2;
        private Button btn_ex3;
        private Button btn_ex4;
    }
}