namespace QuanLyNetSieuCapVipPro
{
    partial class frmCreateAccountAdmin
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtTenTaiKhoan = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMatKhau = new TextBox();
            txtNhapLaiMatKhau = new TextBox();
            txtHoVaTen = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            btnTaoTaiKhoan = new Button();
            btnThoat = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnDangNhap = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 32);
            label1.TabIndex = 0;
            label1.Text = "Sign up";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(237, 56);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(410, 33);
            txtTenTaiKhoan.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 56);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 104);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 152);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 5;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 200);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 7;
            label5.Text = "Họ và tên";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 248);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 9;
            label6.Text = "SĐT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(161, 296);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 11;
            label7.Text = "Địa chỉ";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(237, 104);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(410, 33);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.Leave += txtPassword_Leave;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Location = new Point(237, 149);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.PasswordChar = '*';
            txtNhapLaiMatKhau.Size = new Size(410, 33);
            txtNhapLaiMatKhau.TabIndex = 6;
            txtNhapLaiMatKhau.Leave += txtPassword_Leave;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(237, 197);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(410, 33);
            txtHoVaTen.TabIndex = 8;
            txtHoVaTen.KeyPress += txtHoTen_KeyPress;
            txtHoVaTen.Leave += txtHoTen_Leave;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(237, 245);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(410, 33);
            txtSDT.TabIndex = 10;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(237, 293);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(410, 33);
            txtDiaChi.TabIndex = 12;
            // 
            // btnTaoTaiKhoan
            // 
            btnTaoTaiKhoan.Location = new Point(472, 332);
            btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            btnTaoTaiKhoan.Size = new Size(175, 36);
            btnTaoTaiKhoan.TabIndex = 13;
            btnTaoTaiKhoan.Text = "Tạo tài khoản";
            btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            btnTaoTaiKhoan.Click += btnTaoTaiKhoan_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(265, 332);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(77, 36);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(348, 332);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(118, 36);
            btnDangNhap.TabIndex = 15;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // frmCreateAccountAdmin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 380);
            Controls.Add(btnDangNhap);
            Controls.Add(btnThoat);
            Controls.Add(btnTaoTaiKhoan);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtHoVaTen);
            Controls.Add(txtNhapLaiMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmCreateAccountAdmin";
            Text = "frmCreateAccountAdmin";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private TextBox txtTenTaiKhoan;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMatKhau;
        private TextBox txtNhapLaiMatKhau;
        private TextBox txtHoVaTen;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private Button btnTaoTaiKhoan;
        private Button btnThoat;
        private ErrorProvider errorProvider1;
        private Button btnDangNhap;
    }
}