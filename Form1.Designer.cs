namespace Form_Đăng_Ký_Tài_Khoản
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btndangky = new Button();
            label4 = new Label();
            txtTen = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 51);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 0;
            label1.Text = "Đăng  ký";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(199, 182);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(170, 238);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // btndangky
            // 
            btndangky.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndangky.Location = new Point(290, 322);
            btndangky.Name = "btndangky";
            btndangky.Size = new Size(158, 29);
            btndangky.TabIndex = 5;
            btndangky.Text = "Đăng ký";
            btndangky.UseVisualStyleBackColor = true;
            btndangky.Click += btndangky_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(212, 126);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 6;
            label4.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(299, 123);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(236, 27);
            txtTen.TabIndex = 7;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(299, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(299, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(236, 27);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtTen);
            Controls.Add(label4);
            Controls.Add(btndangky);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btndangky;
        private Label label4;
        private TextBox txtTen;
        private TextBox txtEmail;
        private TextBox txtPassword;
    }
}
