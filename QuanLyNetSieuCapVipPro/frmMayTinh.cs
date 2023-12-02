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
        public static frmMayTinh instance;
        public frmGuiTinNhan _guiTinNhan;
        public frmMayTinh()
        {
            InitializeComponent();
        }

        public frmMayTinh(string maMay)
        {
            InitializeComponent();
            this.maMay = maMay;
            this.Text = maMay;
            instance = this;
        }

        public void shutDown()
        {
            this.Close();
        }

        private void lblTinNhan_Click(object sender, EventArgs e)
        {
            frmGuiTinNhan guitinnhan = new frmGuiTinNhan(maMay);
            _guiTinNhan = guitinnhan;
            guitinnhan.Show();
        }
    }
}
