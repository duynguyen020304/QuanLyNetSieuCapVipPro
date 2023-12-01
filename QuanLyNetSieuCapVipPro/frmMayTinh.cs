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
    public partial class frmMayTinh : Form
    {
        private string maMay;
        public frmMayTinh()
        {
            InitializeComponent();
        }

        public frmMayTinh(string maMay)
        {
            InitializeComponent();
            this.maMay = maMay;
        }

        private void lblTinNhan_Click(object sender, EventArgs e)
        {
            frmGuiTinNhan guitinnhan = new frmGuiTinNhan();
            guitinnhan.ShowDialog();
        }
    }
}
