namespace QuanLyNetSieuCapVipPro
{
    class TaoTaiKhoan
    {
        private Database db = new Database();
        public void TaoTaiKhoanAdmin(string UserAccount, string Password, string TenAdmin, string SDT, string DiaChi)
        {
            db.InsertDataIntoTAIKHOANADMIN(UserAccount, Password);
            db.InsertDataIntoADMIN(UserAccount, TenAdmin, SDT, DiaChi);
        }
    }
}
