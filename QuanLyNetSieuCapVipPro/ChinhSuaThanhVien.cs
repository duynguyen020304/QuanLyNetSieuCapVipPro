using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNetSieuCapVipPro
{
    class ChinhSuaThanhVien
    {
        Database db = new Database();
        public bool addThanhVien(string maNguoiChoi, string tenNguoiDung, Int64 soGioiChoiConLai, Decimal soTienNo,
            DateTime ngayTaoTaiKhoan, string nguoiTaoTaiKhoan, string nguoiNapTien, string email, string diaChi,
            string thanhPho, string quanHuyen, string CMND)
        {
            return db.insertDataNguoiChoi(maNguoiChoi, tenNguoiDung, soGioiChoiConLai, soTienNo, ngayTaoTaiKhoan, nguoiTaoTaiKhoan, nguoiNapTien, email, diaChi, thanhPho, quanHuyen, CMND);
        }

        public bool suaThongTinThanhVien(string maNguoiChoi, string tenNguoiDung, Int64 soGioiChoiConLai, Decimal soTienNo,
            DateTime ngayTaoTaiKhoan, string nguoiTaoTaiKhoan, string nguoiNapTien, string email, string diaChi,
            string thanhPho, string quanHuyen, string CMND)
        {
            return db.suaDataNguoiChoi(maNguoiChoi, tenNguoiDung, soGioiChoiConLai, soTienNo, ngayTaoTaiKhoan,
                nguoiTaoTaiKhoan, nguoiNapTien, email, diaChi, thanhPho, quanHuyen, CMND);
        }

        public DataSet LayDataSetThanhVien(string userName)
        {
            return db.getSpecificUserData(userName);
        }
    }
}
