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
        public frmManagement()
        {
            InitializeComponent();
        }

        public frmManagement(string userName)
        {
            InitializeComponent();
            lblHello.Text = "Hello " + userName;
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
    }
}
