using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNetSieuCapVipPro
{
    class TaoTaiKhoan
    {
        private Database db = new Database();
        public void TaoTaiKhoanAdmin(string UserAccount, string Password, string TenAdmin, string SDT, string DiaChi)
        {
            db.insertDataIntoTaiKhoan(UserAccount, Password);
            db.insertDataIntoAdmin(UserAccount, TenAdmin, SDT, DiaChi);
        }
    }
}
