namespace QuanLyNetSieuCapVipPro
{
    public partial class frmCreateAccountAdmin : Form
    {
        public frmCreateAccountAdmin()
        {
            InitializeComponent();
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(control, "Vui lòng không để trống ô họ tên");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(control, "Vui lòng không để trống ô mật khẩu");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan tk = new TaoTaiKhoan();
            if (txtNhapLaiMatKhau.Text.Trim() == txtMatKhau.Text.Trim())
            {
                tk.TaoTaiKhoanAdmin(txtTenTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim(), txtHoVaTen.Text.Trim(), txtSDT.Text.Trim(), txtDiaChi.Text.Trim());
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng, vui lòng kiểm tra lại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
