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
    public partial class frmDatDichVu : Form
    {
        private Database db = new Database();
        private string maNguoiChoi = "";
        private string maMay = "";
        private long soLuong = 0;
        public frmDatDichVu()
        {
            InitializeComponent();
        }

        public frmDatDichVu(string maNguoiChoi, string maMay)
        {
            InitializeComponent();
            this.maNguoiChoi = maNguoiChoi;
            this.maMay = maMay;
        }

        private void frmDatDichVu_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            DataTable dt = db.getAllItemsFromDICHVU_1().Tables[0];
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
            string maDichVu = "";
            string tenDichVu = "";
            if (cboTenDichVu.SelectedItem is DataRowView selectedRow)
            {
                maDichVu = selectedRow["MaDichVu"].ToString();
                tenDichVu = selectedRow["TenDichVu"].ToString();
            }
            DateTime now = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                DateTime.Now.Hour,
                DateTime.Now.Minute,
                DateTime.Now.Second
                );
            string noiDungDonHang = maMay + "(" + maNguoiChoi + ")" + "đặt " + Convert.ToInt64(txtSoLuong.Text.Trim()) +
                                    " " + tenDichVu;
            if (db.insertDataIntoDONHANG_DICHVU(maDichVu, maNguoiChoi, now, noiDungDonHang, maMay))
            {
                MessageBox.Show("Yêu cầu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtSoLuong.Text.Trim(), out soLuong))
            {
                soLuong = 0;
            }
            
            soLuong++;
            txtSoLuong.Text = soLuong.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtSoLuong.Text.Trim(), out soLuong))
            {
                soLuong = 0;
            }
            if (soLuong > 0)
            {
                soLuong--;
                txtSoLuong.Text = soLuong.ToString();
            }
        }
    }
}
