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
    public partial class frmThemDichVu : Form
    {
        public frmThemDichVu()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(control,"Vui lòng không bỏ trống ô tên");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtGia_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(control, "Vui lòng không bỏ trống ô giá");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
        private void txtDonVi_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(control, "Vui lòng không bỏ trống ô đơn vị");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.insertDataIntoDichVu(txtTen.Text.Trim(), Decimal.Parse(txtGia.Text.Trim()), txtDonVi.Text.Trim()))
            {
                MessageBox.Show("Thêm dịch vụ thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
