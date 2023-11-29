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

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChinhSuaThanhVien them = new ChinhSuaThanhVien();
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

            if (them.addThanhVien(txtNguoiSuDung.Text.Trim(), txtHoTen.Text.Trim(), soGioChoi, result,
                    dateTimePicker1.Value, nguoiTaoKhoan, nguoiTaoKhoan, txtEmail.Text.Trim(), txtDiaChi.Text.Trim(), txtThanhPho.Text.Trim(), txtQuanHuyen.Text.Trim(), txtCMND.Text.Trim()))
            {
                MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ChinhSuaThanhVien sua = new ChinhSuaThanhVien();
            DataTable dt = sua.LayDataSetThanhVien(maNguoiChoi).Tables[0];
            DataRow dr = dt.Rows[0];
            txtNguoiSuDung.Text = dr[0].ToString();
            txtHoTen.Text = dr[1].ToString();
            txtSoTienNo.Text = dr[3].ToString();
            dateTimePicker1.Value = DateTime.Parse(dr[4].ToString());
            txtEmail.Text = dr[6].ToString();
            txtDiaChi.Text = dr[7].ToString();
            txtThanhPho.Text = dr[8].ToString();
            txtQuanHuyen.Text = dr[9].ToString();
            long soGioChoi = Convert.ToInt64(dr[2].ToString());
            decimal soTienNo = Convert.ToInt64(dr[3].ToString());
            if (sua.suaThongTinThanhVien(txtNguoiSuDung.Text.Trim(), txtHoTen.Text.Trim(), soGioChoi, soTienNo,
                    dateTimePicker1.Value, nguoiTaoKhoan, nguoiTaoKhoan, txtEmail.Text.Trim(), txtDiaChi.Text.Trim(), txtThanhPho.Text.Trim(), txtQuanHuyen.Text.Trim(), txtCMND.Text.Trim()))
            {
                MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
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
            }
        }
    }
}
