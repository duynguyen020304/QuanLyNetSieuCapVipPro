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
    public partial class ThanhVien : UserControl
    {
        public ThanhVien()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void ThanhVien_Load(object sender, EventArgs e)
        {

        }

        public void loadDgv()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = db.GetAllUserDataSet().Tables[0];
        }

        private void xoa_mnst_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            db.removeUserFromNGUOICHOI(dataGridView1.Rows[i].Cells[0].Value.ToString());
            loadDgv();
        }

        private void sua_mnst_Click(object sender, EventArgs e)
        {
            frmThemThanhVien themThanhVien = new frmThemThanhVien(3000, )
        }
    }
}
