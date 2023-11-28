using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNetSieuCapVipPro
{
    class Authentication
    {
        private Database db = new Database();


        public bool AuthAdminLogin(string username, string password)
        {
            if (db.getAdminPassword(username) == password)
            {
                return true;
            }
            return false;
        }
    }
}
