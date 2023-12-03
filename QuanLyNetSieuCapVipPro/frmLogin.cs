using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNetSieuCapVipPro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public delegate void truyenChoFrmManagement(bool isSuccess = false);
        public truyenChoFrmManagement truyenTinHieuDangNhapThanhCong;
        private bool isExit = false;
        bool tinHieuChuyenCa = false;

        public frmLogin(bool tinHieu)
        {
            tinHieuChuyenCa = tinHieu;
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isExit)
            {
                DialogResult r = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.No)
                {
                    isExit = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            if (authentication.AuthAdminLogin(txtUserName.Text.Trim(), txtPassword.Text.Trim()))
            {
                FormClosing -= frmLogin_FormClosing;
                if (tinHieuChuyenCa)
                {
                    truyenTinHieuDangNhapThanhCong(true);
                }
                frmManagement management = new frmManagement(txtUserName.Text);
                management.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void lblTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            FormClosing -= frmLogin_FormClosing;
            this.Close();
            frmCreateAccountAdmin createAccountAdmin = new frmCreateAccountAdmin();
            createAccountAdmin.Show();
        }
    }
}
