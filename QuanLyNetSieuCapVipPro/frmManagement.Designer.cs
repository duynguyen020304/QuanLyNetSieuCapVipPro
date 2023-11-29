namespace QuanLyNetSieuCapVipPro
{
    partial class frmManagement
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
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            máyTrạmToolStripMenuItem = new ToolStripMenuItem();
            thanhVien_mnst = new ToolStripMenuItem();
            themThanhVien_mnst = new ToolStripMenuItem();
            nhomNguoiDung_mnst = new ToolStripMenuItem();
            nhậtKýGiaoDịchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            chuyenCaNhanVien_mnst = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýThôngTinKháchVãngLaiToolStripMenuItem = new ToolStripMenuItem();
            khởiĐộngMáyTrạmToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            quảnLýCơSởDữLiêuToolStripMenuItem = new ToolStripMenuItem();
            saoLưuCơSởDữLiệuToolStripMenuItem = new ToolStripMenuItem();
            nhậpCơSởDữLiệuToolStripMenuItem = new ToolStripMenuItem();
            lịchSaoCSDLToolStripMenuItem = new ToolStripMenuItem();
            thêmTàiKhoảnQuảnLýToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            doanhThuTheoMáyToolStripMenuItem = new ToolStripMenuItem();
            giúpĐỡToolStripMenuItem = new ToolStripMenuItem();
            lblHello = new Label();
            thanhVien1 = new ThanhVien();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem, hệThốngToolStripMenuItem, báoCáoToolStripMenuItem, giúpĐỡToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1051, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { máyTrạmToolStripMenuItem, thanhVien_mnst, themThanhVien_mnst, nhomNguoiDung_mnst, nhậtKýGiaoDịchToolStripMenuItem, toolStripSeparator1, chuyenCaNhanVien_mnst, thoátToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(77, 20);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // máyTrạmToolStripMenuItem
            // 
            máyTrạmToolStripMenuItem.Name = "máyTrạmToolStripMenuItem";
            máyTrạmToolStripMenuItem.Size = new Size(185, 22);
            máyTrạmToolStripMenuItem.Text = "Máy trạm";
            // 
            // thanhVien_mnst
            // 
            thanhVien_mnst.Name = "thanhVien_mnst";
            thanhVien_mnst.Size = new Size(185, 22);
            thanhVien_mnst.Text = "Thành viên";
            thanhVien_mnst.Click += thanhVien_mnst_Click;
            // 
            // themThanhVien_mnst
            // 
            themThanhVien_mnst.Name = "themThanhVien_mnst";
            themThanhVien_mnst.Size = new Size(185, 22);
            themThanhVien_mnst.Text = "Thêm thành viên";
            themThanhVien_mnst.Click += themThanhVien_mnst_Click;
            // 
            // nhomNguoiDung_mnst
            // 
            nhomNguoiDung_mnst.Name = "nhomNguoiDung_mnst";
            nhomNguoiDung_mnst.Size = new Size(185, 22);
            nhomNguoiDung_mnst.Text = "Nhóm người dùng";
            nhomNguoiDung_mnst.Click += nhomNguoiDung_mnst_Click;
            // 
            // nhậtKýGiaoDịchToolStripMenuItem
            // 
            nhậtKýGiaoDịchToolStripMenuItem.Name = "nhậtKýGiaoDịchToolStripMenuItem";
            nhậtKýGiaoDịchToolStripMenuItem.Size = new Size(185, 22);
            nhậtKýGiaoDịchToolStripMenuItem.Text = "Nhật ký giao dịch";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(182, 6);
            // 
            // chuyenCaNhanVien_mnst
            // 
            chuyenCaNhanVien_mnst.Name = "chuyenCaNhanVien_mnst";
            chuyenCaNhanVien_mnst.Size = new Size(185, 22);
            chuyenCaNhanVien_mnst.Text = "Chuyển ca nhân viên";
            chuyenCaNhanVien_mnst.Click += chuyenCaNhanVien_mnst_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(185, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýThôngTinKháchVãngLaiToolStripMenuItem, khởiĐộngMáyTrạmToolStripMenuItem, toolStripSeparator2, quảnLýCơSởDữLiêuToolStripMenuItem, thêmTàiKhoảnQuảnLýToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // quảnLýThôngTinKháchVãngLaiToolStripMenuItem
            // 
            quảnLýThôngTinKháchVãngLaiToolStripMenuItem.Name = "quảnLýThôngTinKháchVãngLaiToolStripMenuItem";
            quảnLýThôngTinKháchVãngLaiToolStripMenuItem.Size = new Size(246, 22);
            quảnLýThôngTinKháchVãngLaiToolStripMenuItem.Text = "Quản lý thông tin khách vãng lai";
            // 
            // khởiĐộngMáyTrạmToolStripMenuItem
            // 
            khởiĐộngMáyTrạmToolStripMenuItem.Name = "khởiĐộngMáyTrạmToolStripMenuItem";
            khởiĐộngMáyTrạmToolStripMenuItem.Size = new Size(246, 22);
            khởiĐộngMáyTrạmToolStripMenuItem.Text = "Khởi động máy trạm";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(243, 6);
            // 
            // quảnLýCơSởDữLiêuToolStripMenuItem
            // 
            quảnLýCơSởDữLiêuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saoLưuCơSởDữLiệuToolStripMenuItem, nhậpCơSởDữLiệuToolStripMenuItem, lịchSaoCSDLToolStripMenuItem });
            quảnLýCơSởDữLiêuToolStripMenuItem.Name = "quảnLýCơSởDữLiêuToolStripMenuItem";
            quảnLýCơSởDữLiêuToolStripMenuItem.Size = new Size(246, 22);
            quảnLýCơSởDữLiêuToolStripMenuItem.Text = "Quản lý cơ sở dữ liêu";
            // 
            // saoLưuCơSởDữLiệuToolStripMenuItem
            // 
            saoLưuCơSởDữLiệuToolStripMenuItem.Name = "saoLưuCơSởDữLiệuToolStripMenuItem";
            saoLưuCơSởDữLiệuToolStripMenuItem.Size = new Size(159, 22);
            saoLưuCơSởDữLiệuToolStripMenuItem.Text = "Khôi phục CSDL";
            // 
            // nhậpCơSởDữLiệuToolStripMenuItem
            // 
            nhậpCơSởDữLiệuToolStripMenuItem.Name = "nhậpCơSởDữLiệuToolStripMenuItem";
            nhậpCơSởDữLiệuToolStripMenuItem.Size = new Size(159, 22);
            nhậpCơSởDữLiệuToolStripMenuItem.Text = "Khôi phục CSDL";
            // 
            // lịchSaoCSDLToolStripMenuItem
            // 
            lịchSaoCSDLToolStripMenuItem.Name = "lịchSaoCSDLToolStripMenuItem";
            lịchSaoCSDLToolStripMenuItem.Size = new Size(159, 22);
            lịchSaoCSDLToolStripMenuItem.Text = "Lịch sao CSDL";
            // 
            // thêmTàiKhoảnQuảnLýToolStripMenuItem
            // 
            thêmTàiKhoảnQuảnLýToolStripMenuItem.Name = "thêmTàiKhoảnQuảnLýToolStripMenuItem";
            thêmTàiKhoảnQuảnLýToolStripMenuItem.Size = new Size(246, 22);
            thêmTàiKhoảnQuảnLýToolStripMenuItem.Text = "Thêm tài khoản quản lý";
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doanhThuToolStripMenuItem, doanhThuTheoMáyToolStripMenuItem });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(61, 20);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(183, 22);
            doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // doanhThuTheoMáyToolStripMenuItem
            // 
            doanhThuTheoMáyToolStripMenuItem.Name = "doanhThuTheoMáyToolStripMenuItem";
            doanhThuTheoMáyToolStripMenuItem.Size = new Size(183, 22);
            doanhThuTheoMáyToolStripMenuItem.Text = "Doanh thu theo máy";
            // 
            // giúpĐỡToolStripMenuItem
            // 
            giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            giúpĐỡToolStripMenuItem.Size = new Size(61, 20);
            giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // lblHello
            // 
            lblHello.Dock = DockStyle.Top;
            lblHello.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHello.Location = new Point(0, 24);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(1051, 21);
            lblHello.TabIndex = 1;
            lblHello.Text = "Hello .. 123123123";
            lblHello.TextAlign = ContentAlignment.TopRight;
            // 
            // thanhVien1
            // 
            thanhVien1.Anchor = AnchorStyles.Left;
            thanhVien1.Location = new Point(0, 70);
            thanhVien1.Name = "thanhVien1";
            thanhVien1.Size = new Size(1051, 310);
            thanhVien1.TabIndex = 2;
            // 
            // frmManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 565);
            Controls.Add(thanhVien1);
            Controls.Add(lblHello);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmManagement";
            Text = "Quản Lý Net Siêu Cấp Vip Pro";
            FormClosing += frmManagement_FormClosing;
            Load += frmManagement_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem máyTrạmToolStripMenuItem;
        private ToolStripMenuItem thanhVien_mnst;
        private ToolStripMenuItem nhậtKýGiaoDịchToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem chuyenCaNhanVien_mnst;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem quảnLýThôngTinKháchVãngLaiToolStripMenuItem;
        private ToolStripMenuItem khởiĐộngMáyTrạmToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem quảnLýCơSởDữLiêuToolStripMenuItem;
        private ToolStripMenuItem saoLưuCơSởDữLiệuToolStripMenuItem;
        private ToolStripMenuItem nhậpCơSởDữLiệuToolStripMenuItem;
        private ToolStripMenuItem lịchSaoCSDLToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem doanhThuTheoMáyToolStripMenuItem;
        private ToolStripMenuItem thêmTàiKhoảnQuảnLýToolStripMenuItem;
        private Label lblHello;
        private ToolStripMenuItem nhomNguoiDung_mnst;
        private ToolStripMenuItem themThanhVien_mnst;
        private ThanhVien thanhVien1;
    }
}