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
        public bool Auth(string username, string password)
        {
            if (db.getUserPassword(username) == password)
            {
                return true;
            }
            return false;
        }
    }
}
