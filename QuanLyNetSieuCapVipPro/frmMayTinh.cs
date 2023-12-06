namespace QuanLyNetSieuCapVipPro
{
    public partial class frmMayTinh : Form
    {
        private string maMay;
        public static frmMayTinh instance;
        public frmGuiTinNhan _guiTinNhan;
        public bool isLoginSucess = false;
        public string _userDangNhap = "";
        private Database db = new Database();
        private frmGuiTinNhan tinhan = new frmGuiTinNhan();
        private bool isTinNhanShow = false;

        public frmMayTinh()
        {
            InitializeComponent();

        }

        private void frmMayTinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.UpdateStateNguoiChoi(_userDangNhap, "off");
            db.UpdateComputerStateInMAYTINH(maMay, "off");
            frmManagement.instance.loadMayTramShutDown();
        }

        public frmMayTinh(string maMay)
        {
            InitializeComponent();
            instance = this;
            this.maMay = maMay;
            this.Text = maMay;
            while (!isLoginSucess)
            {
                frmLogin login = new frmLogin("user");
                login.ShowDialog();
                if (db.GetStateNguoiChoi(_userDangNhap) == "on")
                {
                    MessageBox.Show("Tài khoản đang được đăng nhập trên một máy tính khác, vui lòng thử lại", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isLoginSucess = false;
                    continue;
                }
                if (db.GetplayTimeLeft(_userDangNhap) == 0)
                {
                    MessageBox.Show("Bạn không có đủ thời gian dịch vụ, hãy liên hệ nhân viên để nạp thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isLoginSucess = false;
                    continue;
                }
            }
            timer1.Enabled = true;
            db.UpdateStateNguoiChoi(_userDangNhap, "on");
        }

        public void shutDown()
        {
            db.UpdateStateNguoiChoi(_userDangNhap, "off");
            this.Close();
        }

        private void lblTinNhan_Click(object sender, EventArgs e)
        {
            if (isTinNhanShow)
            {
                tinhan.Hide();
            }
            else
            {
                tinhan.Show();
            }
        }

        private void pctbDichVu_Click(object sender, EventArgs e)
        {
            frmDatDichVu datDichVu = new frmDatDichVu(_userDangNhap, maMay);
            datDichVu.Show();
        }
        private void frmMayTinh_Load(object sender, EventArgs e)
        {
            long tongThoiGianSuDung = db.GetplayTimeLeft(_userDangNhap);
            tongThoiGianSuDungConLai_tick = tongThoiGianSuDung;
            long soGio = tongThoiGianSuDung / 60;
            long soPhut = tongThoiGianSuDung % 60;
            txtTongThoiGian.Text = soGio.ToString() + ":" + soPhut.ToString();
            txtTongThoiGianSuDung.Text = "0:0";
            txtTongThoiGianConLai.Text = tongThoiGianSuDung.ToString();
            frmGuiTinNhan guitinnhan = new frmGuiTinNhan(maMay);
            _guiTinNhan = guitinnhan;
            tinhan = guitinnhan;
        }

        private long tongThoiGianSuDungConLai_tick = 0;
        private long soPhut_tick = 0;
        private long soGio_tick = 0;
        private long soGiay_tick = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            soGiay_tick++;
            if (soGiay_tick == 60)
            {
                soGiay_tick = 0;
                soPhut_tick++;
                txtTongThoiGianSuDung.Text = soGio_tick.ToString() + ":" + soPhut_tick.ToString();
                tongThoiGianSuDungConLai_tick--;
                txtTongThoiGianConLai.Text = tongThoiGianSuDungConLai_tick.ToString();
            }

            if (soPhut_tick == 60)
            {
                soPhut_tick = 0;
                soGio_tick++;
                txtTongThoiGianSuDung.Text = soGio_tick.ToString() + ":" + soPhut_tick.ToString();
            }
        }

        private void pctbDangXuat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            isLoginSucess = false;
            db.UpdatePlayTimeLeftToNGUOICHOI(_userDangNhap, tongThoiGianSuDungConLai_tick);
            while (!isLoginSucess)
            {
                frmLogin login = new frmLogin("user");
                login.ShowDialog();
                if (db.GetplayTimeLeft(_userDangNhap) == 0)
                {
                    MessageBox.Show("Bạn không có đủ thời gian dịch vụ, hãy liên hệ nhân viên để nạp thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isLoginSucess = false;
                    continue;
                }
            }
            frmMayTinh_Load(sender, e);
        }

        private void pctbMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhauUser doiMatKhauUser = new frmDoiMatKhauUser(_userDangNhap);
            doiMatKhauUser.Show();
        }
    }
}
