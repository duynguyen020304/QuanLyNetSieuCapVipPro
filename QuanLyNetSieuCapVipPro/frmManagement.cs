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
    public partial class frmManagement : Form
    {
        private Database db = new Database();
        private List<frmMayTinh> listMayTinh = new List<frmMayTinh>();
        private string userName;
        public static frmManagement instance;
        public string sendUserName;

        private bool isShowThanhVien = true;
        private bool isShowDichVu = false;
        private bool isShowNhomNguoiDung = false;
        private bool isShowPnlChat = false;
        public frmManagement()
        {
            InitializeComponent();
            instance = this;
        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            dichVu1.Hide();
            nhomNguoiDung1.Hide();
            pnlChat.Visible = false;
            pnlChat.Enabled = false;
            loadMayTram();
            loadMayTramShutDown();
        }

        public frmManagement(string userName)
        {
            this.userName = userName;
            sendUserName = userName;
            InitializeComponent();
            lblHello.Text = "Hello " + userName;
            instance = this;
        }


        private bool nhanTinHieuDangNhap = false;

        private void frmManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadTinHieu(bool tinHieu)
        {
            nhanTinHieuDangNhap = tinHieu;
        }


        private void chuyenCaNhanVien_mnst_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin(true);
            login.truyenTinHieuDangNhapThanhCong = new frmLogin.truyenChoFrmManagement(loadTinHieu);
            login.ShowDialog();
            if (nhanTinHieuDangNhap)
            {
                this.Close();
            }
        }

        private void themThanhVien_mnst_Click(object sender, EventArgs e)
        {
            frmThemThanhVien themthanhvien = new frmThemThanhVien(3000, userName, true);
            themthanhvien.ShowDialog();
            thanhVien1.loadDgv();
        }

        private void themDichVu_mnst_Click(object sender, EventArgs e)
        {
            frmThemDichVu dichvu = new frmThemDichVu();
            dichvu.ShowDialog();
            dichVu1.loadDgv();
        }

        private void nhomNguoiDung_mnst_Click(object sender, EventArgs e)
        {
            if (isShowDichVu)
            {
                isShowDichVu = false;
                dichVu1.Hide();
            }
            if (isShowThanhVien)
            {
                isShowThanhVien = false;
                thanhVien1.Hide();
            }
            isShowNhomNguoiDung = true;
            nhomNguoiDung1.Show();
            nhomNguoiDung1.loadDgv();
        }

        private void thanhVien_mnst_Click(object sender, EventArgs e)
        {
            if (isShowNhomNguoiDung)
            {
                isShowNhomNguoiDung = false;
                nhomNguoiDung1.Hide();
            }

            if (isShowDichVu)
            {
                isShowDichVu = false;
                dichVu1.Hide();
            }
            isShowThanhVien = true;
            thanhVien1.Show();
            thanhVien1.loadDgv();
        }

        private void dichVu_mnst_Click(object sender, EventArgs e)
        {
            if (isShowThanhVien)
            {
                isShowThanhVien = false;
                thanhVien1.Hide();
            }
            if (isShowNhomNguoiDung)
            {
                isShowNhomNguoiDung = false;
                nhomNguoiDung1.Hide();
            }
            isShowDichVu = true;
            dichVu1.Show();
            dichVu1.loadDgv();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            if (isShowPnlChat)
            {
                isShowPnlChat = false;
                pnlChat.Visible = false;
                pnlChat.Enabled = false;
            }
            else
            {
                isShowPnlChat = true;
                pnlChat.Visible = true;
                pnlChat.Enabled = true;
            }
        }
        public void syncChat(string userID, string userChat)
        {
            rtxtShowChat.Text += userID + ": " + userChat + "\n";
        }

        private void loadMayTram()
        {
            DataTable dt = db.getAllItemsFromMAYTINH().Tables[0];
            List<string> items = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                items.Add(row["MaMay"].ToString());
            }
            if (cboMayTram_mnst.ComboBox != null)
            {
                cboMayTram_mnst.ComboBox.Items.Clear();
                cboMayTram_mnst.ComboBox.Items.Add("Chọn máy");
                cboMayTram_mnst.ComboBox.Items.AddRange(items.ToArray());
                cboMayTram_mnst.SelectedIndex = 0;
            }
        }

        private void loadMayTramShutDown()
        {
            DataTable dt = db.getAllItemsFromMAYTINH().Tables[0];
            List<string> items = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                items.Add(row["MaMay"].ToString());
            }
            if (cboShutDownMayTram_mnst.ComboBox != null)
            {
                cboShutDownMayTram_mnst.ComboBox.Items.Clear();
                cboShutDownMayTram_mnst.ComboBox.Items.Add("Chọn máy");
                cboShutDownMayTram_mnst.ComboBox.Items.AddRange(items.ToArray());
                cboShutDownMayTram_mnst.SelectedIndex = 0;
            }
        }

        private void cboMayTram_mnst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMayTram_mnst.SelectedIndex == 0)
            {
                return;
            }

            if (db.getComputerStateINMAYTINH(cboMayTram_mnst.SelectedItem.ToString()) == "on")
            {
                MessageBox.Show("Máy tính đã được bật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmMayTinh mt = new frmMayTinh(cboMayTram_mnst.SelectedItem.ToString());
            listMayTinh.Add(mt);
            cboChonNguoiChat.Items.Add(mt.Text);
            db.modifiedComputerStateInMAYTINH(cboMayTram_mnst.SelectedItem.ToString(), "on");
            mt.Show();
        }

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtChat.Text.Trim().Length != 0)
            {
                rtxtShowChat.Text += "Bạn: " + txtChat.Text.Trim() + "\n";
                string userGuiTinNhan = cboChonNguoiChat.SelectedItem.ToString();
                foreach (frmMayTinh item in listMayTinh)
                {
                    if (item.Text == userGuiTinNhan)
                    {
                        item._guiTinNhan.syncChat(userName, txtChat.Text.Trim());
                        txtChat.Clear();
                    }
                }
            }
        }

        private void cboShutDownMayTram_mnst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboShutDownMayTram_mnst.SelectedIndex == 0)
            {
                return;
            }
            string userTatMayTinh = cboShutDownMayTram_mnst.SelectedItem.ToString();
            if (db.getComputerStateINMAYTINH(userTatMayTinh) == "off")
            {
                MessageBox.Show("Máy tính đang tắt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (db.modifiedComputerStateInMAYTINH(userTatMayTinh, "off"))
                {
                    MessageBox.Show("Tắt máy tính thành công", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void backupCSDL_mnst_Click(object sender, EventArgs e)
        {
            frmBackupRestoreDB backupRestoreDb = new frmBackupRestoreDB();
            backupRestoreDb.Show();
        }
    }
}
