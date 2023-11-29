using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNetSieuCapVipPro
{
    class ThemThanhVien
    {
        public bool addThanhVien(string maNguoiChoi, string tenNguoiDung, Int64 soGioiChoiConLai, Decimal soTienNo,
            DateTime ngayTaoTaiKhoan, string nguoiTaoTaiKhoan, string nguoiNapTien, string email, string diaChi,
            string thanhPho, string quanHuyen, string CMND)
        {
            Database db = new Database();
            return db.insertDataNguoiChoi(maNguoiChoi, tenNguoiDung, soGioiChoiConLai, soTienNo, ngayTaoTaiKhoan, nguoiTaoTaiKhoan, nguoiNapTien, email, diaChi, thanhPho, quanHuyen, CMND);
        }
    }
}
