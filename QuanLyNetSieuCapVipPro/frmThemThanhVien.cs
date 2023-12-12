using System.Data;

namespace QuanLyNetSieuCapVipPro
{
    public partial class frmThemThanhVien : Form
    {
        private string nguoiTaoKhoan;
        private bool isAdd = false;
        private string maNguoiChoi;
        Database db = new Database();
        public frmThemThanhVien(string nguoiTaoTaiKhoan, bool isAdd)
        {
            InitializeComponent();
            this.nguoiTaoKhoan = nguoiTaoTaiKhoan;
            this.isAdd = isAdd;
        }
        public frmThemThanhVien(string nguoiTaoTaiKhoan, bool isAdd, string maNguoiChoi)
        {
            InitializeComponent();
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
            txtSoGioChoiHienCo.Enabled = false;
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

            string maNhomNguoiDung = "";
            if (cboLoaiNguoiDung.SelectedItem is DataRowView selectedRow)
            {
                maNhomNguoiDung = selectedRow["MaNhomNguoiDung"].ToString();
            }

            decimal giaTaiKhoan = db.GetUserGroupPrice(maNhomNguoiDung);
            long soGioChoi = Convert.ToInt64((result / giaTaiKhoan) * 60);
            if (!decimal.TryParse(txtSoTienNo.Text.Trim(), out result))
            {
                result = 0;
            }
            DateTime now = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second
            );
            DateTime birthTime = new DateTime(
                dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day,
                dateTimePicker1.Value.Hour,
                dateTimePicker1.Value.Minute,
                dateTimePicker1.Value.Second
            );
            if (db.InsertDataIntoNGUOICHOI(txtNguoiSuDung.Text.Trim(), txtHoTen.Text.Trim(), soGioChoi, result,
                    now, nguoiTaoKhoan, nguoiTaoKhoan, txtEmail.Text.Trim(), txtDiaChi.Text.Trim(), txtThanhPho.Text.Trim(), txtQuanHuyen.Text.Trim(), txtCMND.Text.Trim(), txtSDT.Text.Trim(), maNhomNguoiDung, birthTime) && db.InsertDataIntoTAIKHOAN_USER(txtNguoiSuDung.Text.Trim(), txtMatKhau.Text.Trim()))
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

            long timeLeft;
            if (!long.TryParse(txtSoGioChoiHienCo.Text.Trim(), out timeLeft))
            {
                timeLeft = 0;
            }
            string maNhomNguoiDung = "";
            if (cboLoaiNguoiDung.SelectedItem is DataRowView selectedRow)
            {
                maNhomNguoiDung = selectedRow["MaNhomNguoiDung"].ToString();
            }
            decimal giaTaiKhoan = db.GetUserGroupPrice(maNhomNguoiDung);
            long soGioChoi = Convert.ToInt64((result / giaTaiKhoan) * 60) + timeLeft;
            if (!decimal.TryParse(txtSoTienNo.Text.Trim(), out result))
            {
                result = 0;
            }
            DateTime birthTime = new DateTime(
                dateTimePicker1.Value.Year,
                dateTimePicker1.Value.Month,
                dateTimePicker1.Value.Day,
                dateTimePicker1.Value.Hour,
                dateTimePicker1.Value.Minute,
                dateTimePicker1.Value.Second
            );
            if (db.UpdateNguoiChoiTableUserData(txtNguoiSuDung.Text.Trim(), txtHoTen.Text.Trim(), soGioChoi, result,
                    nguoiTaoKhoan, nguoiTaoKhoan, txtEmail.Text.Trim(), txtDiaChi.Text.Trim(), txtThanhPho.Text.Trim(), txtQuanHuyen.Text.Trim(), txtCMND.Text.Trim(), txtSDT.Text.Trim(), maNhomNguoiDung, birthTime) && db.UpdateUserPassword(txtNguoiSuDung.Text.Trim(), txtMatKhau.Text.Trim()))
            {
                MessageBox.Show("Sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void loadDuLieu()
        {
            DataTable dt = db.GetSpecificUserData(maNguoiChoi).Tables[0];
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
            txtSDT.Text = dr[12].ToString();
            txtMatKhau.Text = db.GetUserPassword(maNguoiChoi);
            dt = db.GetAllItemsFROMNHOMNGUOIDUNG().Tables[0];
            cboLoaiNguoiDung.DataSource = dt;
            cboLoaiNguoiDung.DisplayMember = "TenNhomNguoiDung";
            cboLoaiNguoiDung.ValueMember = "MaNhomNguoiDung";
            string loaiNguoiDung = dr[13].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dr[15].ToString());
            for (int i = 0; i < cboLoaiNguoiDung.Items.Count; i++)
            {
                if (cboLoaiNguoiDung.Items[i] is DataRowView row)
                {
                    string maNhomNguoiDung = row["MaNhomNguoiDung"].ToString();
                    if (maNhomNguoiDung == loaiNguoiDung)
                    {
                        cboLoaiNguoiDung.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void frmThemThanhVien_Load(object sender, EventArgs e)
        {
            DataTable dt;
            dt = db.GetAllItemsFROMNHOMNGUOIDUNG().Tables[0];
            cboLoaiNguoiDung.DataSource = dt;
            cboLoaiNguoiDung.DisplayMember = "TenNhomNguoiDung"; //giá trị hiện ra comboBox
            cboLoaiNguoiDung.ValueMember = "MaNhomNguoiDung"; //giá trị thực khi click vào sẽ trả về
            if (isAdd == true)
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
