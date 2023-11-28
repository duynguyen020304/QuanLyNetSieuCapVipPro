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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool isExit = false;
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
            if (authentication.Auth(txtUserName.Text.Trim(), txtPassword.Text.Trim()))
            {
                FormClosing -= frmLogin_FormClosing;
                this.Close();
                frmManagement management = new frmManagement();
                management.Show();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
