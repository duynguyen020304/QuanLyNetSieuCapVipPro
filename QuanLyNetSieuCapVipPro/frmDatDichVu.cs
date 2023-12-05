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
        public frmDatDichVu()
        {
            InitializeComponent();
        }

        private void frmDatDichVu_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            DataTable dt = db.getAllItemsFormDICHVU().Tables[0];
            cboTenDichVu.DataSource = dt;
            cboTenDichVu.DisplayMember = "TenDichVu";
            cboTenDichVu.ValueMember = "MaDichVu";
        }

        private void btnYeuCau_Click(object sender, EventArgs e)
        {
            string maDichVu = "";
            if (cboTenDichVu.SelectedItem is DataRowView selectedRow)
            {
                maDichVu = selectedRow["MaDichVu"].ToString();
            }
        }
    }
}
