namespace QuanLyNetSieuCapVipPro
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public delegate void TransferToFrmManagement(bool isSuccess = false);
        public TransferToFrmManagement TransferIsLoginSucess;
        bool _isChangeAdminAccount = false;
        private string loginType = "";

        public frmLogin(bool isChangeAdminAccount)
        {
            _isChangeAdminAccount = isChangeAdminAccount;
            InitializeComponent();
        }

        public frmLogin(string loginType)
        {
            InitializeComponent();
            this.loginType = loginType;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            if (loginType == "user")
            {
                if (authentication.AuthUser(txtUserName.Text.Trim(), txtPassword.Text.Trim()) && txtUserName.Text.Trim().Length != 0)
                {
                    frmMayTinh.instance.isLoginSucess = true;
                    frmMayTinh.instance._userDangNhap = txtUserName.Text.Trim();
                    this.Close();
                }
            }
            else
            {
                if (authentication.AuthAdminLogin(txtUserName.Text.Trim(), txtPassword.Text.Trim()) && txtUserName.Text.Trim().Length != 0)
                {
                    if (_isChangeAdminAccount)
                    {
                        TransferIsLoginSucess(true);
                    }
                    frmManagement management = new frmManagement(txtUserName.Text);
                    management.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }

        }

    }
}
