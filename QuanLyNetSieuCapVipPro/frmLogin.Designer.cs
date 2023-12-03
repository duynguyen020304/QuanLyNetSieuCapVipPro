namespace QuanLyNetSieuCapVipPro
{
    partial class frmLogin
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDangNhap = new Button();
            label3 = new Label();
            lblTaoTaiKhoan = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(135, 63);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(449, 33);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(135, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(449, 33);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 66);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 121);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(226, 172);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(197, 35);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(198, 9);
            label3.Name = "label3";
            label3.Size = new Size(244, 37);
            label3.TabIndex = 5;
            label3.Text = "Đăng nhập admin";
            // 
            // lblTaoTaiKhoan
            // 
            lblTaoTaiKhoan.AutoSize = true;
            lblTaoTaiKhoan.ForeColor = Color.Red;
            lblTaoTaiKhoan.Location = new Point(265, 228);
            lblTaoTaiKhoan.Name = "lblTaoTaiKhoan";
            lblTaoTaiKhoan.Size = new Size(122, 25);
            lblTaoTaiKhoan.TabIndex = 6;
            lblTaoTaiKhoan.Text = "tạo tài khoản";
            lblTaoTaiKhoan.Click += lblTaoTaiKhoan_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 267);
            Controls.Add(lblTaoTaiKhoan);
            Controls.Add(label3);
            Controls.Add(btnDangNhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmLogin";
            Text = "frmLogin";
            FormClosing += frmLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnDangNhap;
        private Label label3;
        private Label lblTaoTaiKhoan;
    }
}