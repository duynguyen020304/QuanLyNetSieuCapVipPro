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
        private string adminUserName;
        public ThanhVien()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void loadUserName(string adminUserName)
        {
            this.adminUserName = adminUserName;
        }

        private void ThanhVien_Load(object sender, EventArgs e)
        {
            adminUserName = frmManagement.instance.sendUserName;
            loadDgv();
        }

        public void loadDgv()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dt = db.GetAllUserDataSetForThanhVien().Tables[0];

            // Thêm các hàng trống trực tiếp vào DataTable
            while (dt.Rows.Count < 20)
            {
                dt.Rows.Add(dt.NewRow()); // Tạo một hàng mới và thêm nó vào DataTable
            }

            dataGridView1.DataSource = dt; // Gán DataTable đã được thêm hàng trống vào làm DataSource
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void xoa_mnst_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            db.removeUserFromNGUOICHOI(dataGridView1.Rows[i].Cells[0].Value.ToString());
            loadDgv();
        }

        private void sua_mnst_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            frmThemThanhVien themThanhVien = new frmThemThanhVien(3000, adminUserName, false, dataGridView1.Rows[i].Cells[0].Value.ToString());
            themThanhVien.ShowDialog();
            loadDgv();
        }
    }
}
