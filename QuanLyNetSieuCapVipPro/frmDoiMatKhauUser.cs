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
    public partial class frmDoiMatKhauUser : Form
    {
        private Database _db = new Database();
        private string _userAccountId;
        public frmDoiMatKhauUser()
        {
            InitializeComponent();
        }
        public frmDoiMatKhauUser(string userAccountId)
        {
            InitializeComponent();
            this._userAccountId = userAccountId;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text.Trim().Length == 0 || txtXacNhanMatKhauMoi.Text.Trim().Length == 0 ||
                txtMatKhauCu.Text.Trim().Length == 0)
            {
                return;
            }
            if (txtMatKhauCu.Text.Trim() == _db.GetUserPassword(_userAccountId) && txtMatKhauMoi.Text.Trim() == txtXacNhanMatKhauMoi.Text.Trim() && _db.UpdateUserPassword(_userAccountId, txtXacNhanMatKhauMoi.Text.Trim()))
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
