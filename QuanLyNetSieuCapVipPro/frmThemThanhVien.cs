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
        public frmThemThanhVien(decimal donGia, string nguoiTaoTaiKhoan)
        {
            InitializeComponent();
            this.donGia = donGia;
            this.nguoiTaoKhoan = nguoiTaoTaiKhoan;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemThanhVien them = new ThemThanhVien();
            long soGioChoi = Convert.ToInt64((Convert.ToDecimal(txtNapTien.Text.Trim()) / donGia) * 60);
            them.addThanhVien(txtNguoiSuDung.Text.Trim(), txtHoTen.Text.Trim(), soGioChoi, Convert.ToDecimal(txtSoTienNo.Text.Trim()), dateTimePicker1.Value, nguoiTaoKhoan, nguoiTaoKhoan, txtEmail.Text.Trim(), txtDiaChi.Text.Trim(), txtThanhPho.Text.Trim(), txtQuanHuyen.Text.Trim(), txtCMND.Text.Trim());
        }
    }
}
