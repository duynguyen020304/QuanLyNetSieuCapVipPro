namespace QuanLyNetSieuCapVipPro
{
    public partial class frmManagement : Form
    {
        private Database db = new Database();
        public MayTram Maytram = new MayTram();
        private string adminAccountId;
        public static frmManagement instance;
        public string SendAdminAccountId;

        private bool isShowThanhVien = true;
        private bool isShowDichVu = false;
        private bool isShowNhomNguoiDung = false;
        private bool isShowPnlChat = false;
        private bool isShowUserControlMayTram = false;
        private bool isShowUserControlGiaoDich = true;
        public frmManagement()
        {
            InitializeComponent();
            instance = this;
        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            dichVu1.Hide();
            userControlMayTram1.Hide();
            nhomNguoiDung1.Hide();
            pnlChat.Visible = false;
            pnlChat.Enabled = false;
            loadMayTram();
            loadMayTramShutDown();
            userControlGiaoDich1.loadDgv();
        }

        public frmManagement(string adminAccountId)
        {
            this.adminAccountId = adminAccountId;
            SendAdminAccountId = adminAccountId;
            InitializeComponent();
            lblHello.Text = "Hello " + adminAccountId;
            instance = this;
        }


        private bool nhanTinHieuDangNhap = false;

        private void frmManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!nhanTinHieuDangNhap)
            {
                Application.Exit();
                Maytram.tatToanBoMayTinh();
            }
        }

        private void loadTinHieu(bool tinHieu)
        {
            nhanTinHieuDangNhap = tinHieu;
        }


        private void chuyenCaNhanVien_mnst_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(true);
            login.TransferIsLoginSucess = new frmLogin.TransferToFrmManagement(loadTinHieu);
            login.ShowDialog();
            if (nhanTinHieuDangNhap)
            {
                this.Close();
            }
        }

        public void themThanhVien_mnst_Click(object sender, EventArgs e)
        {
            frmThemThanhVien themthanhvien = new frmThemThanhVien(adminAccountId, true);
            themthanhvien.ShowDialog();
            thanhVien1.loadDgv();
        }

        public void themDichVu_mnst_Click(object sender, EventArgs e)
        {
            frmThemDichVu dichvu = new frmThemDichVu();
            dichvu.ShowDialog();
            dichVu1.LoadDgv();
        }

        private void nhomNguoiDung_mnst_Click(object sender, EventArgs e)
        {
            if (isShowDichVu)
            {
                isShowDichVu = false;
                dichVu1.Hide();
            }
            if (isShowThanhVien)
            {
                isShowThanhVien = false;
                thanhVien1.Hide();
            }
            if (isShowUserControlMayTram)
            {
                isShowUserControlMayTram = false;
                userControlMayTram1.Hide();
            }
            isShowNhomNguoiDung = true;
            nhomNguoiDung1.Show();
            nhomNguoiDung1.loadDgv();
        }

        private void thanhVien_mnst_Click(object sender, EventArgs e)
        {
            if (isShowNhomNguoiDung)
            {
                isShowNhomNguoiDung = false;
                nhomNguoiDung1.Hide();
            }

            if (isShowDichVu)
            {
                isShowDichVu = false;
                dichVu1.Hide();
            }

            if (isShowUserControlMayTram)
            {
                isShowUserControlMayTram = false;
                userControlMayTram1.Hide();
            }
            isShowThanhVien = true;
            thanhVien1.Show();
            thanhVien1.loadDgv();
        }

        private void mayTram_mnst_Click(object sender, EventArgs e)
        {
            if (isShowNhomNguoiDung)
            {
                isShowNhomNguoiDung = false;
                nhomNguoiDung1.Hide();
            }
            if (isShowDichVu)
            {
                isShowDichVu = false;
                dichVu1.Hide();
            }
            if (isShowThanhVien)
            {
                isShowThanhVien = false;
                thanhVien1.Hide();
            }
            isShowUserControlMayTram = true;
            userControlMayTram1.Show();
            userControlMayTram1.loadDgv();
        }

        private void dichVu_mnst_Click(object sender, EventArgs e)
        {
            if (isShowThanhVien)
            {
                isShowThanhVien = false;
                thanhVien1.Hide();
            }
            if (isShowNhomNguoiDung)
            {
                isShowNhomNguoiDung = false;
                nhomNguoiDung1.Hide();
            }
            if (isShowUserControlMayTram)
            {
                isShowUserControlMayTram = false;
                userControlMayTram1.Hide();
            }
            isShowDichVu = true;
            dichVu1.Show();
            dichVu1.LoadDgv();
        }

        private void pctbChat_Click(object sender, EventArgs e)
        {
            if (isShowPnlChat)
            {
                isShowPnlChat = false;
                pnlChat.Visible = false;
                pnlChat.Enabled = false;
                pnlChat.SendToBack();
            }
            else
            {
                isShowPnlChat = true;
                pnlChat.Visible = true;
                pnlChat.Enabled = true;
                pnlChat.BringToFront();
            }
        }
        public void syncChat(string userID, string userChat)
        {
            rtxtShowChat.Text += userID + ": " + userChat + "\n";
        }

        private void loadMayTram()
        {
            List<string> mayTinh = Maytram.getmayTinh();
            if (cboMayTram_mnst.ComboBox != null)
            {
                cboMayTram_mnst.ComboBox.Items.Clear();
                cboMayTram_mnst.ComboBox.Items.Add("Chọn máy");
                cboMayTram_mnst.ComboBox.Items.AddRange(mayTinh.ToArray());
                cboMayTram_mnst.SelectedIndex = 0;
            }
        }

        public void loadMayTramShutDown()
        {
            List<string> mayTinhOnline = Maytram.getMayTinhOnline();
            if (cboShutDownMayTram_mnst.ComboBox != null)
            {
                cboShutDownMayTram_mnst.ComboBox.Items.Clear();
                cboShutDownMayTram_mnst.ComboBox.Items.Add("Chọn máy");
                cboShutDownMayTram_mnst.ComboBox.Items.AddRange(mayTinhOnline.ToArray());
                cboShutDownMayTram_mnst.SelectedIndex = 0;
            }
        }

        private void loadNguoiChat()
        {
            List<string> mayTinhOnline = Maytram.getMayTinhOnline();
            cboChonNguoiChat.Items.Clear();
            cboChonNguoiChat.Items.AddRange(mayTinhOnline.ToArray());
        }

        private void cboMayTram_mnst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMayTram_mnst.SelectedIndex == 0)
            {
                return;
            }
            if (Maytram.khoiDongMayTinhTuyChon(cboMayTram_mnst.SelectedItem.ToString()))
            {
                MessageBox.Show("Khởi động " + cboMayTram_mnst.SelectedItem.ToString() + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadMayTramShutDown();
                loadNguoiChat();
            }
            else
            {
                MessageBox.Show("Máy tính đang hoạt động", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtChat.Text.Trim().Length != 0)
            {
                XuLyChat xuLy = new XuLyChat();
                Control control = (Control)sender;
                //bool isChatSucess = false;

                //foreach (frmMayTinh item in listFrmMayTinhBat)
                //{
                //    if (item.Text == userGuiTinNhan)
                //    {
                //        rtxtShowChat.Text += "Bạn: " + txtChat.Text.Trim() + "\n";
                //        item._guiTinNhan.syncChat(userName, txtChat.Text.Trim());
                //        txtChat.Clear();
                //        isChatSucess = true;
                //    }
                //}

                if (cboChonNguoiChat.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (xuLy.AdminToMayTinh(adminAccountId, cboChonNguoiChat.SelectedItem.ToString(), txtChat.Text.Trim()))
                {
                    this.errorProvider1.Clear();
                    rtxtShowChat.Text += "Bạn: " + txtChat.Text.Trim() + "\n";
                    txtChat.Clear();
                }
                else
                {
                    this.errorProvider1.SetError(control, "Gửi tin nhắn thất bại");
                }
            }
        }

        private void cboShutDownMayTram_mnst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShutDownMayTram_mnst.SelectedIndex == 0)
            {
                return;
            }
            if (Maytram.tatMayTinhTuyChon(cboShutDownMayTram_mnst.SelectedItem.ToString()))
            {
                MessageBox.Show("Tắt máy tính thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                loadMayTramShutDown();
                loadNguoiChat();
            }
            else
            {
                MessageBox.Show("Có lỗi khi tắt máy tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backupCSDL_mnst_Click(object sender, EventArgs e)
        {
            BackupRestoreDB backupRestore = new BackupRestoreDB();
            backupRestore.BackupDB();
        }

        private void reloadAllUserControl()
        {
            thanhVien1.loadDgv();
            dichVu1.LoadDgv();
            userControlGiaoDich1.loadDgv();
            userControlMayTram1.loadDgv();
        }

        private void khoiPhucCSDL_mnst_Click(Object sender, EventArgs e)
        {
            BackupRestoreDB backupRestore = new BackupRestoreDB();
            backupRestore.RestoreDB();
            reloadAllUserControl();
        }

        private void themTaiKhoanQuanly_mnst_Click(object sender, EventArgs e)
        {
            frmCreateAccountAdmin createAccountAdmin = new frmCreateAccountAdmin();
            createAccountAdmin.Show();
        }

        public void themNhomNguoiDung_mnst_Click(object sender, EventArgs e)
        {
            frmThemNhomNguoiDung nhomNguoiDung = new frmThemNhomNguoiDung();
            nhomNguoiDung.ShowDialog();
            nhomNguoiDung1.loadDgv();
        }

        private void thoat_mnst_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhatKyGiaoDich_mnst_Click(object sender, EventArgs e)
        {
            if (isShowUserControlGiaoDich)
            {
                isShowUserControlGiaoDich = false;
                userControlGiaoDich1.Hide();
            }
            else
            {
                isShowUserControlGiaoDich = true;
                userControlGiaoDich1.Show();
            }
        }

        private void giupDo_mnst_Click(object sender, EventArgs e)
        {
            gpt frmGpt = new gpt();
            frmGpt.Show();
        }
    }
}
