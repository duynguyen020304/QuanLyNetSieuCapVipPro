namespace QuanLyNetSieuCapVipPro
{
    public partial class frmGuiTinNhan : Form
    {
        private string maMay;
        public static frmGuiTinNhan instance;
        public frmGuiTinNhan()
        {
            InitializeComponent();
            instance = this;
        }

        public frmGuiTinNhan(string maMay)
        {
            InitializeComponent();
            this.maMay = maMay;
            instance = this;
        }

        public void syncChat(string userID, string userChat)
        {
            rtxtChat.Text += userID + ": " + userChat + "\n";
        }

        private void txtChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtChat.Text.Trim().Length != 0)
            {
                //frmManagement.instance.syncChat(maMay, txtChat.Text.Trim());
                if (txtChat.Text.Trim().Length == 0)
                {
                    return;
                }
                XuLyChat xuly = new XuLyChat();
                rtxtChat.Text += "Bạn: " + txtChat.Text.Trim() + "\n";
                xuly.MayTinhToAdmin(maMay, txtChat.Text.Trim());
                txtChat.Clear();
            }
        }

        public void clearTinNhan()
        {
            rtxtChat.Clear();
            txtChat.Clear();
        }
    }
}
