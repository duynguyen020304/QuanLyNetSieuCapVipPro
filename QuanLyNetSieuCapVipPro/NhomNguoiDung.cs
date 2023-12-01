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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = db.getAllItemsFROMNHOMNGUOIDUNG().Tables[0];
        }

    }
}
