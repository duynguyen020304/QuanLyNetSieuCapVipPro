using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public frmMayTinh()
        {
            InitializeComponent();

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
            }

            if (db.getSoPhutHienCo(_userDangNhap) == 0)
            {
                MessageBox.Show("Bạn không có đủ thời gian dịch vụ, hãy liên hệ nhân viên để nạp thêm", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            timer1.Enabled = true;
        }

        public void shutDown()
        {
            this.Close();
        }

        private void lblTinNhan_Click(object sender, EventArgs e)
        {
            frmGuiTinNhan guitinnhan = new frmGuiTinNhan(maMay);
            _guiTinNhan = guitinnhan;
            guitinnhan.Show();
        }

        private void pctbDichVu_Click(object sender, EventArgs e)
        {

        }
        private void frmMayTinh_Load(object sender, EventArgs e)
        {
            long tongThoiGianSuDung = db.getSoPhutHienCo(_userDangNhap);
            tongThoiGianSuDung_tick = tongThoiGianSuDung;
            long soGio = tongThoiGianSuDung / 60;
            long soPhut = tongThoiGianSuDung % 60;
            txtTongThoiGian.Text = soGio.ToString() + ":" + soPhut.ToString();
            txtTongThoiGianSuDung.Text = "0:0";
            txtTongThoiGianConLai.Text = tongThoiGianSuDung.ToString();
        }

        private long tongThoiGianSuDung_tick = 0;
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
                tongThoiGianSuDung_tick--;
                txtTongThoiGianConLai.Text = tongThoiGianSuDung_tick.ToString();
            }

            if (soPhut_tick == 60)
            {
                soPhut_tick = 0;
                soGio_tick++;
                txtTongThoiGianSuDung.Text = soGio_tick.ToString() + ":" + soPhut_tick.ToString();
            }
        }
    }
}
