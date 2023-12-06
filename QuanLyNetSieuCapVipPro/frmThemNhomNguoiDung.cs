using System.Data;

namespace QuanLyNetSieuCapVipPro
{
    public partial class frmThemNhomNguoiDung : Form
    {
        private string maNhomNguoiDung;
        private bool isAdd = true;
        private Database db = new Database();
        public frmThemNhomNguoiDung()
        {
            InitializeComponent();
        }

        public frmThemNhomNguoiDung(string maNhomNguoiDung, bool isAdd)
        {
            InitializeComponent();
            this.maNhomNguoiDung = maNhomNguoiDung;
            this.isAdd = isAdd;
        }

        public void loadNhomNguoiDung(string maNhomNguoiDung)
        {
            DataTable dt = db.getSpecificItemFromNHOMNGUOIDUNG(maNhomNguoiDung).Tables[0];
            DataRow dr = dt.Rows[0];
            txtMaNhom.Text = dr[0].ToString();
            txtTenNhom.Text = dr[1].ToString();
            txtGia.Text = dr[2].ToString();
        }

        private void txtMaNhom_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(control, "Vui lòng không bỏ trống ô mã nhóm");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtTenNhom_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(control, "Vui lòng không bỏ trống ô tên nhóm");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            decimal gia;
            if (!decimal.TryParse(txtGia.Text.Trim(), out gia))
            {
                gia = 0;
            }

            if (db.modifiedSpecificItemInNHOMNGUOIDUNG(maNhomNguoiDung, txtTenNhom.Text.Trim(), gia))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemNhomNguoiDung_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                btnDongY.Enabled = true;
                btnDongY.Visible = true;
            }
            else
            {
                txtMaNhom.Enabled = false;
                btnSua.Enabled = true;
                btnSua.Visible = true;
                loadNhomNguoiDung(maNhomNguoiDung);
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtTenNhom.Text.Trim().Length == 0 || txtMaNhom.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên nhóm, mã nhóm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal gia;
            if (!decimal.TryParse(txtGia.Text.Trim(), out gia))
            {
                gia = 0;
            }
            if (db.insertDataIntoNHOMNGUOIDUNG(txtMaNhom.Text.Trim(), txtTenNhom.Text.Trim(), gia))
            {
                MessageBox.Show("Thêm nhóm thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
