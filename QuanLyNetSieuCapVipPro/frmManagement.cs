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
    public partial class frmManagement : Form
    {
        private string userName;
        public static frmManagement instance;
        public string sendUserName;
        public frmManagement()
        {
            InitializeComponent();
            instance = this;
        }

        public frmManagement(string userName)
        {
            this.userName = userName;
            sendUserName = userName;
            InitializeComponent();
            lblHello.Text = "Hello " + userName;
            instance = this;
        }


        private bool nhanTinHieuDangNhap = false;

        private void frmManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadTinHieu(bool tinHieu)
        {
            nhanTinHieuDangNhap = tinHieu;
        }

        private void saoLưuCơSởDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chuyenCaNhanVien_mnst_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(true);
            login.truyenTinHieuDangNhapThanhCong = new frmLogin.truyenChoFrmManagement(loadTinHieu);
            login.ShowDialog();
            if (nhanTinHieuDangNhap)
            {
                this.Close();
            }
        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }

        private void nhomNguoiDung_mnst_Click(object sender, EventArgs e)
        {

        }

        private void themThanhVien_mnst_Click(object sender, EventArgs e)
        {
            frmThemThanhVien themthanhvien = new frmThemThanhVien(3000, userName, true);
            themthanhvien.ShowDialog();
            thanhVien1.loadDgv();
        }

        private void thanhVien_mnst_Click(object sender, EventArgs e)
        {
            thanhVien1.Show();
            thanhVien1.loadDgv();
        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            thanhVien1.Hide();
        }
    }
}
