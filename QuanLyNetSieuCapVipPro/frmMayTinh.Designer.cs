namespace QuanLyNetSieuCapVipPro
{
    partial class frmMayTinh
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
            panel1 = new Panel();
            txtTongThoiGianConLai = new TextBox();
            txtTongThoiGianSuDung = new TextBox();
            txtTongThoiGian = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pctbTinNhan = new PictureBox();
            pctbDichVu = new PictureBox();
            pctbDangXuat = new PictureBox();
            pictureBox5 = new PictureBox();
            pctbMatKhau = new PictureBox();
            lblTinNhan = new Label();
            lblDichVu = new Label();
            lblDangXuat = new Label();
            lblMatKhau = new Label();
            label8 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbTinNhan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbDangXuat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbMatKhau).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTongThoiGianConLai);
            panel1.Controls.Add(txtTongThoiGianSuDung);
            panel1.Controls.Add(txtTongThoiGian);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 141);
            panel1.TabIndex = 0;
            // 
            // txtTongThoiGianConLai
            // 
            txtTongThoiGianConLai.Location = new Point(188, 103);
            txtTongThoiGianConLai.Name = "txtTongThoiGianConLai";
            txtTongThoiGianConLai.ReadOnly = true;
            txtTongThoiGianConLai.Size = new Size(123, 23);
            txtTongThoiGianConLai.TabIndex = 5;
            // 
            // txtTongThoiGianSuDung
            // 
            txtTongThoiGianSuDung.Location = new Point(188, 57);
            txtTongThoiGianSuDung.Name = "txtTongThoiGianSuDung";
            txtTongThoiGianSuDung.ReadOnly = true;
            txtTongThoiGianSuDung.Size = new Size(123, 23);
            txtTongThoiGianSuDung.TabIndex = 4;
            // 
            // txtTongThoiGian
            // 
            txtTongThoiGian.Location = new Point(188, 11);
            txtTongThoiGian.Name = "txtTongThoiGian";
            txtTongThoiGian.ReadOnly = true;
            txtTongThoiGian.Size = new Size(123, 23);
            txtTongThoiGian.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 102);
            label3.Name = "label3";
            label3.Size = new Size(163, 21);
            label3.TabIndex = 2;
            label3.Text = "Tổng thời gian còn lại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Size = new Size(174, 21);
            label2.TabIndex = 1;
            label2.Text = "Tổng thời gian sử dụng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 14);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "Tổng thời gian:";
            // 
            // pctbTinNhan
            // 
            pctbTinNhan.BackgroundImage = Properties.Resources.comments;
            pctbTinNhan.BackgroundImageLayout = ImageLayout.Stretch;
            pctbTinNhan.Location = new Point(12, 178);
            pctbTinNhan.Name = "pctbTinNhan";
            pctbTinNhan.Size = new Size(80, 74);
            pctbTinNhan.TabIndex = 1;
            pctbTinNhan.TabStop = false;
            pctbTinNhan.Click += lblTinNhan_Click;
            // 
            // pctbDichVu
            // 
            pctbDichVu.BackgroundImage = Properties.Resources.food_drink;
            pctbDichVu.BackgroundImageLayout = ImageLayout.Stretch;
            pctbDichVu.Location = new Point(135, 178);
            pctbDichVu.Name = "pctbDichVu";
            pctbDichVu.Size = new Size(80, 74);
            pctbDichVu.TabIndex = 2;
            pctbDichVu.TabStop = false;
            pctbDichVu.Click += pctbDichVu_Click;
            // 
            // pctbDangXuat
            // 
            pctbDangXuat.BackgroundImage = Properties.Resources.power_on;
            pctbDangXuat.BackgroundImageLayout = ImageLayout.Stretch;
            pctbDangXuat.Location = new Point(257, 178);
            pctbDangXuat.Name = "pctbDangXuat";
            pctbDangXuat.Size = new Size(80, 74);
            pctbDangXuat.TabIndex = 3;
            pctbDangXuat.TabStop = false;
            pctbDangXuat.Click += pctbDangXuat_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources._lock;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(188, 290);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 74);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pctbMatKhau
            // 
            pctbMatKhau.BackgroundImage = Properties.Resources.reset_password;
            pctbMatKhau.BackgroundImageLayout = ImageLayout.Stretch;
            pctbMatKhau.Location = new Point(65, 290);
            pctbMatKhau.Name = "pctbMatKhau";
            pctbMatKhau.Size = new Size(80, 74);
            pctbMatKhau.TabIndex = 4;
            pctbMatKhau.TabStop = false;
            pctbMatKhau.Click += pctbMatKhau_Click;
            // 
            // lblTinNhan
            // 
            lblTinNhan.AutoSize = true;
            lblTinNhan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTinNhan.Location = new Point(14, 255);
            lblTinNhan.Name = "lblTinNhan";
            lblTinNhan.Size = new Size(73, 21);
            lblTinNhan.TabIndex = 7;
            lblTinNhan.Text = "Tin Nhắn";
            lblTinNhan.Click += lblTinNhan_Click;
            // 
            // lblDichVu
            // 
            lblDichVu.AutoSize = true;
            lblDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDichVu.Location = new Point(146, 255);
            lblDichVu.Name = "lblDichVu";
            lblDichVu.Size = new Size(62, 21);
            lblDichVu.TabIndex = 8;
            lblDichVu.Text = "Dịch vụ";
            lblDichVu.Click += pctbDichVu_Click;
            // 
            // lblDangXuat
            // 
            lblDangXuat.AutoSize = true;
            lblDangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDangXuat.Location = new Point(257, 255);
            lblDangXuat.Name = "lblDangXuat";
            lblDangXuat.Size = new Size(80, 21);
            lblDangXuat.TabIndex = 9;
            lblDangXuat.Text = "Đăng xuất";
            lblDangXuat.Click += pctbDangXuat_Click;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatKhau.Location = new Point(67, 367);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(75, 21);
            lblMatKhau.TabIndex = 10;
            lblMatKhau.Text = "Mật khẩu";
            lblMatKhau.Click += pctbMatKhau_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(189, 367);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 11;
            label8.Text = "Khoá máy";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // frmMayTinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 205);
            ClientSize = new Size(349, 412);
            Controls.Add(label8);
            Controls.Add(lblMatKhau);
            Controls.Add(lblDangXuat);
            Controls.Add(lblDichVu);
            Controls.Add(lblTinNhan);
            Controls.Add(pictureBox5);
            Controls.Add(pctbMatKhau);
            Controls.Add(pctbDangXuat);
            Controls.Add(pctbDichVu);
            Controls.Add(pctbTinNhan);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMayTinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMayTinh";
            Load += frmMayTinh_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbTinNhan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbDangXuat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbMatKhau).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTongThoiGianConLai;
        private TextBox txtTongThoiGianSuDung;
        private TextBox txtTongThoiGian;
        private PictureBox pctbTinNhan;
        private PictureBox pctbDichVu;
        private PictureBox pctbDangXuat;
        private PictureBox pictureBox5;
        private PictureBox pctbMatKhau;
        private Label lblTinNhan;
        private Label lblDichVu;
        private Label lblDangXuat;
        private Label lblMatKhau;
        private Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}