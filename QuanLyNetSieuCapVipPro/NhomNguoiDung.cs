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
            int numberOfEmptyRowsToAdd = 20 - dataGridView1.Rows.Count;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = db.getAllItemsFROMNHOMNGUOIDUNG().Tables[0];
            for (int i = 0; i < numberOfEmptyRowsToAdd; i++)
            {
                dataGridView1.Rows.Add(); // Thêm một hàng mới không có dữ liệu
            }
        }

    }
}
