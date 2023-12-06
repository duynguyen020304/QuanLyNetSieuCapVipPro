namespace QuanLyNetSieuCapVipPro
{
    class Authentication
    {
        private Database _db = new Database();
        public bool AuthAdminLogin(string adminAccountId, string password)
        {
            if (_db.GetAdminPassword(adminAccountId) == password)
            {
                return true;
            }
            return false;
        }

        public bool AuthUser(string userAcountId, string password)
        {
            if (_db.GetUserPassword(userAcountId) == password)
            {
                return true;
            }
            return false;
        }
    }
}
