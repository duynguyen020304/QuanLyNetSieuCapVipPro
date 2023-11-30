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
    public partial class frmThemThanhVien : Form
    {
        private decimal donGia;
        private string nguoiTaoKhoan;
        private bool isAdd = false;
        private string maNguoiChoi;
        Database db = new Database();
        public frmThemThanhVien(decimal donGia, string nguoiTaoTaiKhoan, bool isAdd)
        {
            InitializeComponent();
            this.donGia = donGia;
            this.nguoiTaoKhoan = nguoiTaoTaiKhoan;
            this.isAdd = isAdd;
        }
        public frmThemThanhVien(decimal donGia, string nguoiTaoTaiKhoan, bool isAdd, string maNguoiChoi)
        {
            InitializeComponent();
            this.donGia = donGia;
            this.nguoiTaoKhoan = nguoiTaoTaiKhoan;
            this.isAdd = isAdd;
            this.maNguoiChoi = maNguoiChoi;
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

        private void txtNguoiSuDung_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider2.SetError(control, "Vui lòng không để trống ô người sử dụng");
            }
            else
            {
                this.errorProvider2.Clear();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider3.SetError(control, "Vui lòng không để trống ô mật khẩu");
            }
            else
            {
                this.errorProvider3.Clear();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim().Length == 0 || txtNguoiSuDung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống ô họ tên và ô người sử dụng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal result;
            if (!decimal.TryParse(txtNapTien.Text.Trim(), out result))
            {
                result = 0;
            }
            long soGioChoi = Convert.ToInt64((result / donGia) * 60);
            if (!decimal.TryParse(txtSoTienNo.Text.Trim(), out result))
            {
                result = 0;
            }

            if (db.insertDataNguoiChoi(txtNguoiSuDung.Text.Trim(), txtHoTen.Text.Trim(), soGioChoi, result,
                    dateTimePicker1.Value, nguoiTaoKhoan, nguoiTaoKhoan, txtEmail.Text.Trim(), txtDiaChi.Text.Trim(), txtThanhPho.Text.Trim(), txtQuanHuyen.Text.Trim(), txtCMND.Text.Trim()) && db.insertDataIntoTAIKHOAN_USER(txtNguoiSuDung.Text.Trim(), txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim().Length == 0 || txtNguoiSuDung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống ô họ tên và ô người sử dụng", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal result;
            if (!decimal.TryParse(txtNapTien.Text.Trim(), out result))
            {
                result = 0;
            }
            long soGioChoi = Convert.ToInt64((result / donGia) * 60);
            if (!decimal.TryParse(txtSoTienNo.Text.Trim(), out result))
            {
                result = 0;
            }
            if (db.suaDataNguoiChoi(txtNguoiSuDung.Text.Trim(), txtHoTen.Text.Trim(), soGioChoi, result,
                    dateTimePicker1.Value, nguoiTaoKhoan, nguoiTaoKhoan, txtEmail.Text.Trim(), txtDiaChi.Text.Trim(), txtThanhPho.Text.Trim(), txtQuanHuyen.Text.Trim(), txtCMND.Text.Trim()))
            {
                MessageBox.Show("Sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void loadDuLieu()
        {
            DataTable dt = db.getSpecificUserData(maNguoiChoi).Tables[0];
            DataRow dr = dt.Rows[0];
            txtNguoiSuDung.Text = dr[0].ToString();
            txtHoTen.Text = dr[1].ToString();
            txtSoGioChoiHienCo.Text = dr[2].ToString();
            txtSoTienNo.Text = dr[3].ToString();
            dateTimePicker1.Value = DateTime.Parse(dr[4].ToString());
            txtEmail.Text = dr[7].ToString();
            txtDiaChi.Text = dr[8].ToString();
            txtThanhPho.Text = dr[9].ToString();
            txtQuanHuyen.Text = dr[10].ToString();
            txtCMND.Text = dr[11].ToString();
            txtMatKhau.Text = db.getUserPassword(maNguoiChoi);
        }

        private void frmThemThanhVien_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                btnThem.Enabled = true;
                btnThem.Visible = true;
            }
            else
            {
                btnSua.Enabled = true;
                btnSua.Visible = true;
                loadDuLieu();
                txtNguoiSuDung.Enabled = false;
            }
        }
    }
}
