using System.Data;

namespace QuanLyNetSieuCapVipPro
{
    public partial class frmThemDichVu : Form
    {
        private string maDichVu;
        private bool isAdd = true;
        Database db = new Database();
        public frmThemDichVu()
        {
            InitializeComponent();
        }

        public frmThemDichVu(string maDichVu, bool isAdd)
        {
            InitializeComponent();
            this.maDichVu = maDichVu;
            this.isAdd = isAdd;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadDichVu(string maDichVu)
        {
            DataTable dt = db.getSpecificItemFromDICHVU(maDichVu).Tables[0];
            DataRow dr = dt.Rows[0];
            txtMaDichVu.Text = dr[0].ToString();
            txtTen.Text = dr[1].ToString();
            txtGia.Text = dr[2].ToString();
            txtDonVi.Text = dr[3].ToString();
        }

        private void txtMaDichVu_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(control, "Vui lòng không bỏ trống ô mã dịch vụ");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(control, "Vui lòng không bỏ trống ô tên");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        //private void txtGia_Leave(object sender, EventArgs e)
        //{
        //    Control control = (Control)sender;
        //    if (control.Text.Trim().Length == 0)
        //    {
        //        this.errorProvider1.SetError(control, "Vui lòng không bỏ trống ô giá");
        //    }
        //    else
        //    {
        //        this.errorProvider1.Clear();
        //    }
        //}
        //private void txtDonVi_Leave(object sender, EventArgs e)
        //{
        //    Control control = (Control)sender;
        //    if (control.Text.Trim().Length == 0)
        //    {
        //        this.errorProvider1.SetError(control, "Vui lòng không bỏ trống ô đơn vị");
        //    }
        //    else
        //    {
        //        this.errorProvider1.Clear();
        //    }
        //}

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Length == 0 || txtMaDichVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ, mã dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal gia;
            if (!decimal.TryParse(txtGia.Text.Trim(), out gia))
            {
                gia = 0;
            }
            if (db.insertDataIntoDichVu(txtMaDichVu.Text.Trim(), txtTen.Text.Trim(), gia, txtDonVi.Text.Trim()))
            {
                MessageBox.Show("Thêm dịch vụ thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void frmThemDichVu_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                btnDongY.Enabled = true;
                btnDongY.Visible = true;
            }
            else
            {
                txtMaDichVu.Enabled = false;
                btnSua.Enabled = true;
                btnSua.Visible = true;
                loadDichVu(maDichVu);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            decimal gia;
            if (!decimal.TryParse(txtGia.Text.Trim(), out gia))
            {
                gia = 0;
            }

            if (db.modifiedSpecificElement(maDichVu, txtTen.Text.Trim(), gia, txtDonVi.Text.Trim()))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
