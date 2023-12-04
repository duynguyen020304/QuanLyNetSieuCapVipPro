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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            máyTrạmToolStripMenuItem = new ToolStripMenuItem();
            thanhVien_mnst = new ToolStripMenuItem();
            dichVu_mnst = new ToolStripMenuItem();
            themThanhVien_mnst = new ToolStripMenuItem();
            themDichVu_mnst = new ToolStripMenuItem();
            nhomNguoiDung_mnst = new ToolStripMenuItem();
            nhậtKýGiaoDịchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            chuyenCaNhanVien_mnst = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            quảnLýThôngTinKháchVãngLaiToolStripMenuItem = new ToolStripMenuItem();
            khoiDongMayTram_mnst = new ToolStripMenuItem();
            cboMayTram_mnst = new ToolStripComboBox();
            shutDown_mnst = new ToolStripMenuItem();
            cboShutDownMayTram_mnst = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            quảnLýCơSởDữLiêuToolStripMenuItem = new ToolStripMenuItem();
            backupCSDL_mnst = new ToolStripMenuItem();
            khoiPhucCSDL_mnst = new ToolStripMenuItem();
            lịchSaoCSDLToolStripMenuItem = new ToolStripMenuItem();
            thêmTàiKhoảnQuảnLýToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            doanhThuTheoMáyToolStripMenuItem = new ToolStripMenuItem();
            giúpĐỡToolStripMenuItem = new ToolStripMenuItem();
            lblHello = new Label();
            thanhVien1 = new ThanhVien();
            dichVu1 = new DichVu();
            nhomNguoiDung1 = new NhomNguoiDung();
            btnChat = new Button();
            rtxtShowChat = new RichTextBox();
            pnlChat = new Panel();
            cboChonNguoiChat = new ComboBox();
            txtChat = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            pnlChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem, hệThốngToolStripMenuItem, báoCáoToolStripMenuItem, giúpĐỡToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1080, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { máyTrạmToolStripMenuItem, thanhVien_mnst, dichVu_mnst, themThanhVien_mnst, themDichVu_mnst, nhomNguoiDung_mnst, nhậtKýGiaoDịchToolStripMenuItem, toolStripSeparator1, chuyenCaNhanVien_mnst, thoátToolStripMenuItem });
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
            // dichVu_mnst
            // 
            dichVu_mnst.Name = "dichVu_mnst";
            dichVu_mnst.Size = new Size(185, 22);
            dichVu_mnst.Text = "Dịch vụ";
            dichVu_mnst.Click += dichVu_mnst_Click;
            // 
            // themThanhVien_mnst
            // 
            themThanhVien_mnst.Name = "themThanhVien_mnst";
            themThanhVien_mnst.Size = new Size(185, 22);
            themThanhVien_mnst.Text = "Thêm thành viên";
            themThanhVien_mnst.Click += themThanhVien_mnst_Click;
            // 
            // themDichVu_mnst
            // 
            themDichVu_mnst.Name = "themDichVu_mnst";
            themDichVu_mnst.Size = new Size(185, 22);
            themDichVu_mnst.Text = "Thêm dịch vụ";
            themDichVu_mnst.Click += themDichVu_mnst_Click;
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
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýThôngTinKháchVãngLaiToolStripMenuItem, khoiDongMayTram_mnst, shutDown_mnst, toolStripSeparator2, quảnLýCơSởDữLiêuToolStripMenuItem, thêmTàiKhoảnQuảnLýToolStripMenuItem });
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
            // khoiDongMayTram_mnst
            // 
            khoiDongMayTram_mnst.DropDownItems.AddRange(new ToolStripItem[] { cboMayTram_mnst });
            khoiDongMayTram_mnst.Name = "khoiDongMayTram_mnst";
            khoiDongMayTram_mnst.Size = new Size(246, 22);
            khoiDongMayTram_mnst.Text = "Khởi động máy trạm";
            // 
            // cboMayTram_mnst
            // 
            cboMayTram_mnst.Name = "cboMayTram_mnst";
            cboMayTram_mnst.Size = new Size(121, 23);
            cboMayTram_mnst.SelectedIndexChanged += cboMayTram_mnst_SelectedIndexChanged;
            // 
            // shutDown_mnst
            // 
            shutDown_mnst.DropDownItems.AddRange(new ToolStripItem[] { cboShutDownMayTram_mnst });
            shutDown_mnst.Name = "shutDown_mnst";
            shutDown_mnst.Size = new Size(246, 22);
            shutDown_mnst.Text = "Tắt máy trạm";
            // 
            // cboShutDownMayTram_mnst
            // 
            cboShutDownMayTram_mnst.Name = "cboShutDownMayTram_mnst";
            cboShutDownMayTram_mnst.Size = new Size(121, 23);
            cboShutDownMayTram_mnst.SelectedIndexChanged += cboShutDownMayTram_mnst_SelectedIndexChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(243, 6);
            // 
            // quảnLýCơSởDữLiêuToolStripMenuItem
            // 
            quảnLýCơSởDữLiêuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backupCSDL_mnst, khoiPhucCSDL_mnst, lịchSaoCSDLToolStripMenuItem });
            quảnLýCơSởDữLiêuToolStripMenuItem.Name = "quảnLýCơSởDữLiêuToolStripMenuItem";
            quảnLýCơSởDữLiêuToolStripMenuItem.Size = new Size(246, 22);
            quảnLýCơSởDữLiêuToolStripMenuItem.Text = "Quản lý cơ sở dữ liêu";
            // 
            // backupCSDL_mnst
            // 
            backupCSDL_mnst.Name = "backupCSDL_mnst";
            backupCSDL_mnst.Size = new Size(159, 22);
            backupCSDL_mnst.Text = "Sao lưu CSDL";
            backupCSDL_mnst.Click += backupCSDL_mnst_Click;
            // 
            // khoiPhucCSDL_mnst
            // 
            khoiPhucCSDL_mnst.Name = "khoiPhucCSDL_mnst";
            khoiPhucCSDL_mnst.Size = new Size(159, 22);
            khoiPhucCSDL_mnst.Text = "Khôi phục CSDL";
            khoiPhucCSDL_mnst.Click += khoiPhucCSDL_mnst_Click;
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
            lblHello.Size = new Size(1080, 21);
            lblHello.TabIndex = 1;
            lblHello.Text = "Hello .. 123123123";
            lblHello.TextAlign = ContentAlignment.TopRight;
            // 
            // thanhVien1
            // 
            thanhVien1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            thanhVien1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            thanhVien1.Location = new Point(1, 66);
            thanhVien1.Margin = new Padding(3, 4, 3, 4);
            thanhVien1.Name = "thanhVien1";
            thanhVien1.Size = new Size(1079, 310);
            thanhVien1.TabIndex = 2;
            // 
            // dichVu1
            // 
            dichVu1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dichVu1.Location = new Point(1, 66);
            dichVu1.Margin = new Padding(0);
            dichVu1.Name = "dichVu1";
            dichVu1.Size = new Size(1079, 310);
            dichVu1.TabIndex = 3;
            // 
            // nhomNguoiDung1
            // 
            nhomNguoiDung1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nhomNguoiDung1.BackColor = SystemColors.ActiveCaption;
            nhomNguoiDung1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nhomNguoiDung1.Location = new Point(1, 66);
            nhomNguoiDung1.Margin = new Padding(0);
            nhomNguoiDung1.Name = "nhomNguoiDung1";
            nhomNguoiDung1.Size = new Size(1079, 310);
            nhomNguoiDung1.TabIndex = 4;
            // 
            // btnChat
            // 
            btnChat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChat.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnChat.Location = new Point(942, 476);
            btnChat.Name = "btnChat";
            btnChat.Size = new Size(138, 40);
            btnChat.TabIndex = 5;
            btnChat.Text = "Chat";
            btnChat.UseVisualStyleBackColor = true;
            btnChat.Click += btnChat_Click;
            // 
            // rtxtShowChat
            // 
            rtxtShowChat.BorderStyle = BorderStyle.FixedSingle;
            rtxtShowChat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtShowChat.Location = new Point(0, 0);
            rtxtShowChat.Margin = new Padding(0);
            rtxtShowChat.Name = "rtxtShowChat";
            rtxtShowChat.Size = new Size(319, 162);
            rtxtShowChat.TabIndex = 6;
            rtxtShowChat.Text = "";
            // 
            // pnlChat
            // 
            pnlChat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlChat.Controls.Add(cboChonNguoiChat);
            pnlChat.Controls.Add(txtChat);
            pnlChat.Controls.Add(rtxtShowChat);
            pnlChat.Location = new Point(620, 313);
            pnlChat.Margin = new Padding(0);
            pnlChat.Name = "pnlChat";
            pnlChat.Size = new Size(319, 203);
            pnlChat.TabIndex = 7;
            // 
            // cboChonNguoiChat
            // 
            cboChonNguoiChat.Anchor = AnchorStyles.Bottom;
            cboChonNguoiChat.FormattingEnabled = true;
            cboChonNguoiChat.Location = new Point(215, 176);
            cboChonNguoiChat.Margin = new Padding(0);
            cboChonNguoiChat.Name = "cboChonNguoiChat";
            cboChonNguoiChat.Size = new Size(104, 23);
            cboChonNguoiChat.TabIndex = 8;
            // 
            // txtChat
            // 
            txtChat.Anchor = AnchorStyles.Bottom;
            txtChat.BackColor = SystemColors.HotTrack;
            txtChat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtChat.ForeColor = Color.Yellow;
            txtChat.Location = new Point(0, 173);
            txtChat.Margin = new Padding(0);
            txtChat.Name = "txtChat";
            txtChat.Size = new Size(215, 27);
            txtChat.TabIndex = 7;
            txtChat.KeyDown += txtChat_KeyDown;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 235, 232);
            ClientSize = new Size(1080, 517);
            Controls.Add(pnlChat);
            Controls.Add(btnChat);
            Controls.Add(nhomNguoiDung1);
            Controls.Add(dichVu1);
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
            pnlChat.ResumeLayout(false);
            pnlChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ToolStripMenuItem khoiDongMayTram_mnst;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem quảnLýCơSởDữLiêuToolStripMenuItem;
        private ToolStripMenuItem backupCSDL_mnst;
        private ToolStripMenuItem lịchSaoCSDLToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem doanhThuTheoMáyToolStripMenuItem;
        private ToolStripMenuItem thêmTàiKhoảnQuảnLýToolStripMenuItem;
        private Label lblHello;
        private ToolStripMenuItem nhomNguoiDung_mnst;
        private ToolStripMenuItem themThanhVien_mnst;
        private ThanhVien thanhVien1;
        private ToolStripMenuItem themDichVu_mnst;
        private ToolStripMenuItem dichVu_mnst;
        private DichVu dichVu1;
        private NhomNguoiDung nhomNguoiDung1;
        private Button btnChat;
        private RichTextBox rtxtShowChat;
        private Panel pnlChat;
        private TextBox txtChat;
        private ToolStripComboBox cboMayTram_mnst;
        private ComboBox cboChonNguoiChat;
        private ToolStripMenuItem shutDown_mnst;
        private ToolStripComboBox cboShutDownMayTram_mnst;
        private ToolStripMenuItem khoiPhucCSDL_mnst;
        private ErrorProvider errorProvider1;
    }
}