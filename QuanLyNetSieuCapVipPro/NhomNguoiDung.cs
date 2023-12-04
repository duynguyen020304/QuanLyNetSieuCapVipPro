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
    public partial class NhomNguoiDung : UserControl
    {
        Database db = new Database();
        public NhomNguoiDung()
        {
            InitializeComponent();
            //loadDgv();
        }
        public void loadDgv()
        {
            DataTable dt = db.getAllItemsFROMNHOMNGUOIDUNG().Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            while (dt.Rows.Count < 20)
            {
                dt.Rows.Add(dt.NewRow()); // Tạo một hàng mới và thêm nó vào DataTable
            }
            dataGridView1.DataSource = dt;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

    }
}
