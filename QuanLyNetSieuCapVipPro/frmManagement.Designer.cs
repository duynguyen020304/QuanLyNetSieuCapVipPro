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
            chucNang_mnst = new ToolStripMenuItem();
            mayTram_mnst = new ToolStripMenuItem();
            thanhVien_mnst = new ToolStripMenuItem();
            dichVu_mnst = new ToolStripMenuItem();
            themThanhVien_mnst = new ToolStripMenuItem();
            themDichVu_mnst = new ToolStripMenuItem();
            nhomNguoiDung_mnst = new ToolStripMenuItem();
            themNhomNguoiDung_mnst = new ToolStripMenuItem();
            nhậtKýGiaoDịchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            chuyenCaNhanVien_mnst = new ToolStripMenuItem();
            thoat_mnst = new ToolStripMenuItem();
            heThong_mnst = new ToolStripMenuItem();
            khoiDongMayTram_mnst = new ToolStripMenuItem();
            cboMayTram_mnst = new ToolStripComboBox();
            shutDown_mnst = new ToolStripMenuItem();
            cboShutDownMayTram_mnst = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            quảnLýCơSởDữLiêuToolStripMenuItem = new ToolStripMenuItem();
            backupCSDL_mnst = new ToolStripMenuItem();
            khoiPhucCSDL_mnst = new ToolStripMenuItem();
            themTaiKhoanQuanly_mnst = new ToolStripMenuItem();
            banCard_mnst = new ToolStripMenuItem();
            cardGameToolStripMenuItem = new ToolStripMenuItem();
            garenaToolStripMenuItem = new ToolStripMenuItem();
            vinagameToolStripMenuItem = new ToolStripMenuItem();
            cardĐiệnThoạiToolStripMenuItem = new ToolStripMenuItem();
            viettelToolStripMenuItem = new ToolStripMenuItem();
            mobifoneToolStripMenuItem = new ToolStripMenuItem();
            vietnamobileToolStripMenuItem = new ToolStripMenuItem();
            giupDo_mnst = new ToolStripMenuItem();
            lblHello = new Label();
            thanhVien1 = new ThanhVien();
            dichVu1 = new DichVu();
            nhomNguoiDung1 = new NhomNguoiDung();
            rtxtShowChat = new RichTextBox();
            pnlChat = new Panel();
            cboChonNguoiChat = new ComboBox();
            txtChat = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            pctbChat = new PictureBox();
            userControlMayTram1 = new UserControlMayTram();
            userControlGiaoDich1 = new UserControlGiaoDich();
            menuStrip1.SuspendLayout();
            pnlChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctbChat).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { chucNang_mnst, heThong_mnst, banCard_mnst, giupDo_mnst });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1080, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chucNang_mnst
            // 
            chucNang_mnst.DropDownItems.AddRange(new ToolStripItem[] { mayTram_mnst, thanhVien_mnst, dichVu_mnst, themThanhVien_mnst, themDichVu_mnst, nhomNguoiDung_mnst, themNhomNguoiDung_mnst, nhậtKýGiaoDịchToolStripMenuItem, toolStripSeparator1, chuyenCaNhanVien_mnst, thoat_mnst });
            chucNang_mnst.Name = "chucNang_mnst";
            chucNang_mnst.Size = new Size(77, 20);
            chucNang_mnst.Text = "Chức năng";
            // 
            // mayTram_mnst
            // 
            mayTram_mnst.Image = Properties.Resources.computer;
            mayTram_mnst.Name = "mayTram_mnst";
            mayTram_mnst.Size = new Size(204, 22);
            mayTram_mnst.Text = "Máy trạm";
            mayTram_mnst.Click += mayTram_mnst_Click;
            // 
            // thanhVien_mnst
            // 
            thanhVien_mnst.Image = Properties.Resources.member_card;
            thanhVien_mnst.Name = "thanhVien_mnst";
            thanhVien_mnst.Size = new Size(204, 22);
            thanhVien_mnst.Text = "Thành viên";
            thanhVien_mnst.Click += thanhVien_mnst_Click;
            // 
            // dichVu_mnst
            // 
            dichVu_mnst.Image = Properties.Resources.food_tray;
            dichVu_mnst.Name = "dichVu_mnst";
            dichVu_mnst.Size = new Size(204, 22);
            dichVu_mnst.Text = "Dịch vụ";
            dichVu_mnst.Click += dichVu_mnst_Click;
            // 
            // themThanhVien_mnst
            // 
            themThanhVien_mnst.Image = Properties.Resources.add_user;
            themThanhVien_mnst.Name = "themThanhVien_mnst";
            themThanhVien_mnst.Size = new Size(204, 22);
            themThanhVien_mnst.Text = "Thêm thành viên";
            themThanhVien_mnst.Click += themThanhVien_mnst_Click;
            // 
            // themDichVu_mnst
            // 
            themDichVu_mnst.Image = Properties.Resources.add;
            themDichVu_mnst.Name = "themDichVu_mnst";
            themDichVu_mnst.Size = new Size(204, 22);
            themDichVu_mnst.Text = "Thêm dịch vụ";
            themDichVu_mnst.Click += themDichVu_mnst_Click;
            // 
            // nhomNguoiDung_mnst
            // 
            nhomNguoiDung_mnst.Image = Properties.Resources.group;
            nhomNguoiDung_mnst.Name = "nhomNguoiDung_mnst";
            nhomNguoiDung_mnst.Size = new Size(204, 22);
            nhomNguoiDung_mnst.Text = "Nhóm người dùng";
            nhomNguoiDung_mnst.Click += nhomNguoiDung_mnst_Click;
            // 
            // themNhomNguoiDung_mnst
            // 
            themNhomNguoiDung_mnst.Image = Properties.Resources.add_group;
            themNhomNguoiDung_mnst.Name = "themNhomNguoiDung_mnst";
            themNhomNguoiDung_mnst.Size = new Size(204, 22);
            themNhomNguoiDung_mnst.Text = "Thêm nhóm người dùng";
            themNhomNguoiDung_mnst.Click += themNhomNguoiDung_mnst_Click;
            // 
            // nhậtKýGiaoDịchToolStripMenuItem
            // 
            nhậtKýGiaoDịchToolStripMenuItem.Image = Properties.Resources.file;
            nhậtKýGiaoDịchToolStripMenuItem.Name = "nhậtKýGiaoDịchToolStripMenuItem";
            nhậtKýGiaoDịchToolStripMenuItem.Size = new Size(204, 22);
            nhậtKýGiaoDịchToolStripMenuItem.Text = "Nhật ký giao dịch";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(201, 6);
            // 
            // chuyenCaNhanVien_mnst
            // 
            chuyenCaNhanVien_mnst.Image = Properties.Resources.swap;
            chuyenCaNhanVien_mnst.Name = "chuyenCaNhanVien_mnst";
            chuyenCaNhanVien_mnst.Size = new Size(204, 22);
            chuyenCaNhanVien_mnst.Text = "Chuyển ca nhân viên";
            chuyenCaNhanVien_mnst.Click += chuyenCaNhanVien_mnst_Click;
            // 
            // thoat_mnst
            // 
            thoat_mnst.Image = Properties.Resources.reject;
            thoat_mnst.Name = "thoat_mnst";
            thoat_mnst.Size = new Size(204, 22);
            thoat_mnst.Text = "Thoát";
            thoat_mnst.Click += thoat_mnst_Click;
            // 
            // heThong_mnst
            // 
            heThong_mnst.DropDownItems.AddRange(new ToolStripItem[] { khoiDongMayTram_mnst, shutDown_mnst, toolStripSeparator2, quảnLýCơSởDữLiêuToolStripMenuItem, themTaiKhoanQuanly_mnst });
            heThong_mnst.Name = "heThong_mnst";
            heThong_mnst.Size = new Size(69, 20);
            heThong_mnst.Text = "Hệ thống";
            // 
            // khoiDongMayTram_mnst
            // 
            khoiDongMayTram_mnst.DropDownItems.AddRange(new ToolStripItem[] { cboMayTram_mnst });
            khoiDongMayTram_mnst.Image = Properties.Resources.play;
            khoiDongMayTram_mnst.Name = "khoiDongMayTram_mnst";
            khoiDongMayTram_mnst.Size = new Size(198, 22);
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
            shutDown_mnst.Image = Properties.Resources._switch;
            shutDown_mnst.Name = "shutDown_mnst";
            shutDown_mnst.Size = new Size(198, 22);
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
            toolStripSeparator2.Size = new Size(195, 6);
            // 
            // quảnLýCơSởDữLiêuToolStripMenuItem
            // 
            quảnLýCơSởDữLiêuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backupCSDL_mnst, khoiPhucCSDL_mnst });
            quảnLýCơSởDữLiêuToolStripMenuItem.Image = Properties.Resources.database_storage;
            quảnLýCơSởDữLiêuToolStripMenuItem.Name = "quảnLýCơSởDữLiêuToolStripMenuItem";
            quảnLýCơSởDữLiêuToolStripMenuItem.Size = new Size(198, 22);
            quảnLýCơSởDữLiêuToolStripMenuItem.Text = "Quản lý cơ sở dữ liêu";
            // 
            // backupCSDL_mnst
            // 
            backupCSDL_mnst.Image = Properties.Resources.diskette;
            backupCSDL_mnst.Name = "backupCSDL_mnst";
            backupCSDL_mnst.Size = new Size(159, 22);
            backupCSDL_mnst.Text = "Sao lưu CSDL";
            backupCSDL_mnst.Click += backupCSDL_mnst_Click;
            // 
            // khoiPhucCSDL_mnst
            // 
            khoiPhucCSDL_mnst.Image = Properties.Resources.rotate;
            khoiPhucCSDL_mnst.Name = "khoiPhucCSDL_mnst";
            khoiPhucCSDL_mnst.Size = new Size(159, 22);
            khoiPhucCSDL_mnst.Text = "Khôi phục CSDL";
            khoiPhucCSDL_mnst.Click += khoiPhucCSDL_mnst_Click;
            // 
            // themTaiKhoanQuanly_mnst
            // 
            themTaiKhoanQuanly_mnst.Image = Properties.Resources.add_friend;
            themTaiKhoanQuanly_mnst.Name = "themTaiKhoanQuanly_mnst";
            themTaiKhoanQuanly_mnst.Size = new Size(198, 22);
            themTaiKhoanQuanly_mnst.Text = "Thêm tài khoản quản lý";
            themTaiKhoanQuanly_mnst.Click += themTaiKhoanQuanly_mnst_Click;
            // 
            // banCard_mnst
            // 
            banCard_mnst.DropDownItems.AddRange(new ToolStripItem[] { cardGameToolStripMenuItem, cardĐiệnThoạiToolStripMenuItem });
            banCard_mnst.Name = "banCard_mnst";
            banCard_mnst.Size = new Size(65, 20);
            banCard_mnst.Text = "Bán card";
            // 
            // cardGameToolStripMenuItem
            // 
            cardGameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { garenaToolStripMenuItem, vinagameToolStripMenuItem });
            cardGameToolStripMenuItem.Name = "cardGameToolStripMenuItem";
            cardGameToolStripMenuItem.Size = new Size(155, 22);
            cardGameToolStripMenuItem.Text = "Card game";
            // 
            // garenaToolStripMenuItem
            // 
            garenaToolStripMenuItem.Name = "garenaToolStripMenuItem";
            garenaToolStripMenuItem.Size = new Size(127, 22);
            garenaToolStripMenuItem.Text = "Garena";
            // 
            // vinagameToolStripMenuItem
            // 
            vinagameToolStripMenuItem.Name = "vinagameToolStripMenuItem";
            vinagameToolStripMenuItem.Size = new Size(127, 22);
            vinagameToolStripMenuItem.Text = "Vinagame";
            // 
            // cardĐiệnThoạiToolStripMenuItem
            // 
            cardĐiệnThoạiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viettelToolStripMenuItem, mobifoneToolStripMenuItem, vietnamobileToolStripMenuItem });
            cardĐiệnThoạiToolStripMenuItem.Name = "cardĐiệnThoạiToolStripMenuItem";
            cardĐiệnThoạiToolStripMenuItem.Size = new Size(155, 22);
            cardĐiệnThoạiToolStripMenuItem.Text = "Card điện thoại";
            // 
            // viettelToolStripMenuItem
            // 
            viettelToolStripMenuItem.Name = "viettelToolStripMenuItem";
            viettelToolStripMenuItem.Size = new Size(144, 22);
            viettelToolStripMenuItem.Text = "Viettel";
            // 
            // mobifoneToolStripMenuItem
            // 
            mobifoneToolStripMenuItem.Name = "mobifoneToolStripMenuItem";
            mobifoneToolStripMenuItem.Size = new Size(144, 22);
            mobifoneToolStripMenuItem.Text = "Mobifone";
            // 
            // vietnamobileToolStripMenuItem
            // 
            vietnamobileToolStripMenuItem.Name = "vietnamobileToolStripMenuItem";
            vietnamobileToolStripMenuItem.Size = new Size(144, 22);
            vietnamobileToolStripMenuItem.Text = "Vietnamobile";
            // 
            // giupDo_mnst
            // 
            giupDo_mnst.Name = "giupDo_mnst";
            giupDo_mnst.Size = new Size(61, 20);
            giupDo_mnst.Text = "Giúp đỡ";
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
            dichVu1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            // rtxtShowChat
            // 
            rtxtShowChat.BorderStyle = BorderStyle.FixedSingle;
            rtxtShowChat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rtxtShowChat.ForeColor = Color.DarkBlue;
            rtxtShowChat.Location = new Point(0, 0);
            rtxtShowChat.Margin = new Padding(0);
            rtxtShowChat.Name = "rtxtShowChat";
            rtxtShowChat.ReadOnly = true;
            rtxtShowChat.Size = new Size(287, 129);
            rtxtShowChat.TabIndex = 6;
            rtxtShowChat.Text = "";
            // 
            // pnlChat
            // 
            pnlChat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlChat.Controls.Add(cboChonNguoiChat);
            pnlChat.Controls.Add(txtChat);
            pnlChat.Controls.Add(rtxtShowChat);
            pnlChat.Location = new Point(737, 477);
            pnlChat.Margin = new Padding(0);
            pnlChat.Name = "pnlChat";
            pnlChat.Size = new Size(287, 159);
            pnlChat.TabIndex = 7;
            // 
            // cboChonNguoiChat
            // 
            cboChonNguoiChat.Anchor = AnchorStyles.Bottom;
            cboChonNguoiChat.FormattingEnabled = true;
            cboChonNguoiChat.Location = new Point(199, 134);
            cboChonNguoiChat.Margin = new Padding(0);
            cboChonNguoiChat.Name = "cboChonNguoiChat";
            cboChonNguoiChat.Size = new Size(88, 23);
            cboChonNguoiChat.TabIndex = 8;
            // 
            // txtChat
            // 
            txtChat.Anchor = AnchorStyles.Bottom;
            txtChat.BackColor = SystemColors.HotTrack;
            txtChat.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtChat.ForeColor = Color.Yellow;
            txtChat.Location = new Point(0, 131);
            txtChat.Margin = new Padding(0);
            txtChat.Name = "txtChat";
            txtChat.Size = new Size(199, 27);
            txtChat.TabIndex = 7;
            txtChat.KeyDown += txtChat_KeyDown;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pctbChat
            // 
            pctbChat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pctbChat.BackgroundImage = Properties.Resources.chat__1_;
            pctbChat.BackgroundImageLayout = ImageLayout.Stretch;
            pctbChat.Location = new Point(1030, 587);
            pctbChat.Name = "pctbChat";
            pctbChat.Size = new Size(50, 50);
            pctbChat.TabIndex = 8;
            pctbChat.TabStop = false;
            pctbChat.Click += pctbChat_Click;
            // 
            // userControlMayTram1
            // 
            userControlMayTram1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userControlMayTram1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userControlMayTram1.Location = new Point(1, 66);
            userControlMayTram1.Margin = new Padding(3, 4, 3, 4);
            userControlMayTram1.Name = "userControlMayTram1";
            userControlMayTram1.Size = new Size(1080, 310);
            userControlMayTram1.TabIndex = 9;
            // 
            // userControlGiaoDich1
            // 
            userControlGiaoDich1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userControlGiaoDich1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userControlGiaoDich1.Location = new Point(0, 395);
            userControlGiaoDich1.Margin = new Padding(3, 4, 3, 4);
            userControlGiaoDich1.Name = "userControlGiaoDich1";
            userControlGiaoDich1.Size = new Size(1024, 242);
            userControlGiaoDich1.TabIndex = 10;
            // 
            // frmManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 232, 217);
            ClientSize = new Size(1080, 636);
            Controls.Add(userControlGiaoDich1);
            Controls.Add(userControlMayTram1);
            Controls.Add(pctbChat);
            Controls.Add(pnlChat);
            Controls.Add(nhomNguoiDung1);
            Controls.Add(dichVu1);
            Controls.Add(thanhVien1);
            Controls.Add(lblHello);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "frmManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Net Siêu Cấp Vip Pro";
            FormClosing += frmManagement_FormClosing;
            Load += frmManagement_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlChat.ResumeLayout(false);
            pnlChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctbChat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chucNang_mnst;
        private ToolStripMenuItem mayTram_mnst;
        private ToolStripMenuItem thanhVien_mnst;
        private ToolStripMenuItem nhậtKýGiaoDịchToolStripMenuItem;
        private ToolStripMenuItem heThong_mnst;
        private ToolStripMenuItem giupDo_mnst;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem chuyenCaNhanVien_mnst;
        private ToolStripMenuItem thoat_mnst;
        private ToolStripMenuItem khoiDongMayTram_mnst;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem quảnLýCơSởDữLiêuToolStripMenuItem;
        private ToolStripMenuItem backupCSDL_mnst;
        private ToolStripMenuItem themTaiKhoanQuanly_mnst;
        private Label lblHello;
        private ToolStripMenuItem nhomNguoiDung_mnst;
        private ToolStripMenuItem themThanhVien_mnst;
        private ThanhVien thanhVien1;
        private ToolStripMenuItem themDichVu_mnst;
        private ToolStripMenuItem dichVu_mnst;
        private DichVu dichVu1;
        private NhomNguoiDung nhomNguoiDung1;
        private RichTextBox rtxtShowChat;
        private Panel pnlChat;
        private TextBox txtChat;
        private ToolStripComboBox cboMayTram_mnst;
        private ComboBox cboChonNguoiChat;
        private ToolStripMenuItem shutDown_mnst;
        private ToolStripComboBox cboShutDownMayTram_mnst;
        private ToolStripMenuItem khoiPhucCSDL_mnst;
        private ErrorProvider errorProvider1;
        private PictureBox pctbChat;
        private UserControlMayTram userControlMayTram1;
        private ToolStripMenuItem themNhomNguoiDung_mnst;
        private UserControlGiaoDich userControlGiaoDich1;
        private ToolStripMenuItem banCard_mnst;
        private ToolStripMenuItem cardGameToolStripMenuItem;
        private ToolStripMenuItem garenaToolStripMenuItem;
        private ToolStripMenuItem vinagameToolStripMenuItem;
        private ToolStripMenuItem cardĐiệnThoạiToolStripMenuItem;
        private ToolStripMenuItem viettelToolStripMenuItem;
        private ToolStripMenuItem mobifoneToolStripMenuItem;
        private ToolStripMenuItem vietnamobileToolStripMenuItem;
    }
}