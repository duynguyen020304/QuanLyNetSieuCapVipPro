namespace QuanLyNetSieuCapVipPro
{
    class TaoTaiKhoan
    {
        private Database db = new Database();
        public void TaoTaiKhoanAdmin(string UserAccount, string Password, string TenAdmin, string SDT, string DiaChi)
        {
            db.insertDataIntoTaiKhoanAdmin(UserAccount, Password);
            db.insertDataIntoAdmin(UserAccount, TenAdmin, SDT, DiaChi);
        }
    }
}
