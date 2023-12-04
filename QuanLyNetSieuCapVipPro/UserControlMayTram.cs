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
    public partial class UserControlMayTram : UserControl
    {
        Database db = new Database();
        public UserControlMayTram()
        {
            InitializeComponent();
        }
        public void loadDgv()
        {
            DataTable dt = db.getAllItemsFromMAYTINH().Tables[0];
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
            dataGridView1.Columns[0].HeaderText = "Mã máy";
            dataGridView1.Columns[1].HeaderText = "Lần khởi động gần nhất";
            dataGridView1.Columns[2].HeaderText = "Trạng thái máy";
        }
    }
}
