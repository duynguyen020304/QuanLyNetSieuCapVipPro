using System.Data;

namespace QuanLyNetSieuCapVipPro
{
    public partial class frmDatDichVu : Form
    {
        private Database db = new Database();
        private string userAccountId = "";
        private string computerId = "";
        private long unit = 0;
        public frmDatDichVu()
        {
            InitializeComponent();
        }

        public frmDatDichVu(string userAccountId, string computerId)
        {
            InitializeComponent();
            this.userAccountId = userAccountId;
            this.computerId = computerId;
        }

        private void frmDatDichVu_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            DataTable dt = db.GetAllItemsFromDICHVU_1().Tables[0];
            cboTenDichVu.DataSource = dt;
            cboTenDichVu.DisplayMember = "TenDichVu";
            cboTenDichVu.ValueMember = "MaDichVu";
        }

        private void btnYeuCau_Click(object sender, EventArgs e)
        {
            if (cboTenDichVu.SelectedItem == null)
            {
                return;
            }

            if (txtSoLuong.Text.Trim().Length == 0)
            {
                return;
            }
            string serviceId = "";
            string serviceName = "";
            if (cboTenDichVu.SelectedItem is DataRowView selectedRow)
            {
                serviceId = selectedRow["MaDichVu"].ToString();
                serviceName = selectedRow["TenDichVu"].ToString();
            }
            DateTime now = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second
                );
            string orderContent = computerId + "(" + userAccountId + ")" + " đặt " + Convert.ToInt64(txtSoLuong.Text.Trim()) +
                                    " " + serviceName;
            if (db.InsertDataIntoLICHSUGIAODICH(serviceId, userAccountId, now, orderContent, computerId))
            {
                MessageBox.Show("Yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserControlGiaoDich.instance.loadDgv();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtSoLuong.Text.Trim(), out unit))
            {
                unit = 0;
            }

            unit++;
            txtSoLuong.Text = unit.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtSoLuong.Text.Trim(), out unit))
            {
                unit = 0;
            }
            if (unit > 0)
            {
                unit--;
                txtSoLuong.Text = unit.ToString();
            }
        }
    }
}
