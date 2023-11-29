using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.Data.SqlClient;

namespace QuanLyNetSieuCapVipPro
{
    class Database
    {
        string createDBSQL = "Data Source=QuanLyNet123.db";

        public void createDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(createDBSQL);
            conn.Open();
            string sql = "CREATE TABLE IF NOT EXISTS \"MAYTINH\" ( " +
                         "\"MaMay\" TEXT, " +
                         "\"CPU\" TEXT, " +
                         "\"GPU\" TEXT, " +
                         "\"RAM\" TEXT, " +
                         "\"DISK\" TEXT, " +
                         "CONSTRAINT \"MT_MaMay_PK\" PRIMARY KEY(\"MaMay\") " +
                         ")";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"ADMIN\" ( " +
                  "\"MaAdmin\" TEXT, " +
                  "\"TenAdmin\" TEXT NOT NULL, " +
                  "\"SDT\" TEXT, " +
                  "\"DiaChi\" TEXT, " +
                  "CONSTRAINT \"A_MaAdmin_PK\" PRIMARY KEY(\"MaAdmin\") " +
                  ") ";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"NGUOICHOI\" ( " +
                  "\"MaNguoiChoi\" TEXT, " +
                  "\"TenNguoiDung\" TEXT NOT NULL, " +
                  "\"SoGioChoiConLai\" INTEGER," +
                  "\"SoTienNo\" NUMERIC, " +
                  "\"NgayTaoTaiKhoan\" TEXT, " +
                  "\"NguoiTaoTaiKhoan\" TEXT, " +
                  "\"NguoiNapTien\" TEXT, " +
                  "\"Email\" TEXT," +
                  "\"DiaChi\" TEXT," +
                  "\"ThanhPho\" TEXT," +
                  "\"QuanHuyen\" TEXT," +
                  "\"CMND\" TEXT," +
                  "CONSTRAINT \"NC_NguoiNapTien_FK\" FOREIGN KEY(\"NguoiNapTien\") REFERENCES \"ADMIN\"(\"MaAdmin\"), " +
                  "CONSTRAINT \"NC_NguoiTaoTaiKhoan_FK\" FOREIGN KEY(\"NguoiTaoTaiKhoan\") REFERENCES \"ADMIN\"(\"MaAdmin\"), " +
                  "CONSTRAINT \"NC_MaNguoiChoi_PK\" PRIMARY KEY(\"MaNguoiChoi\") " +
                  ") ";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DICHVU\" ( " +
                  "\"MaDichVu\" INTEGER, " +
                  "\"TenDichVu\" TEXT NOT NULL, " +
                  "\"Gia\" NUMERIC, " +
                  "\"DonVi\" TEXT, " +
                  "CONSTRAINT \"DV_MaDichVu_PK\" PRIMARY KEY(\"MaDichVu\" AUTOINCREMENT) " +
                  ") ";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"TAIKHOAN_ADMIN\" ( " +
                  "\"MaTaiKhoan\" TEXT NOT NULL, " +
                  "\"MatKhau\" TEXT NOT NULL, " +
                  "CONSTRAINT \"TKADMIN_MaTaiKhoan_PK\" PRIMARY KEY(\"MaTaiKhoan\") " +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"TAIKHOAN_USER\" (" +
                  "\"MaTaiKhoan\" TEXT NOT NULL," +
                  "\"MatKhau\" TEXT NOT NULL," +
                  "CONSTRAINT \"TKUSER_MaTaiKhoan_PK\" PRIMARY KEY(\"MaTaiKhoan\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DANGNHAP_ADMIN\" ( " +
                  "\"MaPhienDangNhap\" TEXT, " +
                  "\"MaAdmin\" TEXT NOT NULL, " +
                  "\"MaMay\" TEXT NOT NULL, " +
                  "\"ThoiGianDangNhap\" TEXT, " +
                  "\"ThoiGianDangXuat\" TEXT, " +
                  "CONSTRAINT \"DNA_MaMay_FK\" FOREIGN KEY(\"MaMay\") REFERENCES \"MAYTINH\"(\"MaMay\"), " +
                  "CONSTRAINT \"DNA_MaAdmin_FK\" FOREIGN KEY(\"MaAdmin\") REFERENCES \"ADMIN\"(\"MaAdmin\"), " +
                  "CONSTRAINT \"DNA_MaPhienDangNhap_MaAdmin_MaMay_PK\" PRIMARY KEY(\"MaPhienDangNhap\",\"MaAdmin\",\"MaMay\") " +
                  ") ";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DANGNHAP_USER\" ( " +
                  "\"MaMay\" TEXT NOT NULL, " +
                  "\"MaNguoiChoi\" TEXT NOT NULL, " +
                  "\"ThoiGianDangNhap\" TEXT, " +
                  "\"ThoiGianLogOut\" TEXT, " +
                  "\"MaPhienDangNhap\" TEXT, " +
                  "CONSTRAINT \"DNU_MaNguoiChoi_FK\" FOREIGN KEY(\"MaNguoiChoi\") REFERENCES \"NGUOICHOI\"(\"MaNguoiChoi\"), " +
                  "CONSTRAINT \"DNU_MaMay_FK\" FOREIGN KEY(\"MaMay\") REFERENCES \"MAYTINH\"(\"MaMay\"), " +
                  "CONSTRAINT \"DN_MaMay_MaNguoiChoi_ThoiGianDangNhap_PK\" PRIMARY KEY(\"MaMay\",\"MaNguoiChoi\",\"MaPhienDangNhap\") " +
                  ") ";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DONHANG_DICHVU\" ( " +
                  "\"MaDonHang\" TEXT, " +
                  "\"MaDichVu\" TEXT NOT NULL, " +
                  "\"MaNguoiChoi\" TEXT NOT NULL, " +
                  "\"ThoiGianDatHang\" TEXT, " +
                  "CONSTRAINT \"DHDV_MaDonHang_MaDichVu_MaNguoiChoi_PK\" PRIMARY KEY(\"MaDonHang\",\"MaDichVu\",\"MaNguoiChoi\"), " +
                  "CONSTRAINT \"DHDV_MaDichVu_FK\" FOREIGN KEY(\"MaDichVu\") REFERENCES \"DICHVU\"(\"MaDichVu\"), " +
                  "CONSTRAINT \"DHDV_MaNguoiChoi_FK\" FOREIGN KEY(\"MaNguoiChoi\") REFERENCES \"NGUOICHOI\"(\"MaNguoiChoi\") " +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "INSERT OR IGNORE INTO TAIKHOAN_ADMIN(MaTaiKhoan, MatKhau) " +
                      "VALUES(\"admin\", \"admin\") ";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void insertDataIntoTaiKhoanAdmin(string UserAccount, string Password)
        {
            SQLiteConnection conn = new SQLiteConnection(createDBSQL);
            conn.Open();
            string sql = "INSERT OR IGNORE INTO TAIKHOAN_ADMIN(MaTaiKhoan, MatKhau) " +
                         "VALUES(@MaTaiKhoan, @MatKhau) ";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaTaiKhoan", UserAccount);
            cmd.Parameters.AddWithValue("@MatKhau", Password);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void insertDataIntoAdmin(string UserAccount, string TenAdmin, string SDT, string DiaChi)
        {
            SQLiteConnection conn = new SQLiteConnection(createDBSQL);
            conn.Open();
            string sql = "INSERT OR IGNORE INTO ADMIN(MaAdmin, TenAdmin, SDT, DiaChi) " +
                         "VALUES(@MaAdmin, @TenAdmin, @SDT, @DiaChi) ";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaAdmin", UserAccount);
            cmd.Parameters.AddWithValue("@TenAdmin", TenAdmin);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public string getAdminPassword(string UserAccount)
        {
            SQLiteConnection conn = new SQLiteConnection(createDBSQL);
            conn.Open();
            string sql = "SELECT MatKhau " +
                         "FROM TAIKHOAN_ADMIN " +
                         "WHERE TAIKHOAN_ADMIN.MaTaiKhoan = @UserAccount "; // Corrected parameter syntax
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@UserAccount", UserAccount);
            var sqReader = cmd.ExecuteReader();
            string result = "";
            if (sqReader.Read()) // Use 'if' to check if there is a row
            {
                result = sqReader.GetString(0);
            }
            sqReader.Close();
            conn.Close();
            return result;
        }

        public string getUserPassword(string MaNguoiChoi)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                conn.Open();
                string sql = "SELECT MatKhau " +
                             "FROM TAIKHOAN_USER " +
                             "WHERE MaTaiKhoan = @UserAccount "; // Corrected parameter syntax
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserAccount", MaNguoiChoi);
                var sqReader = cmd.ExecuteReader();
                string result = "";
                if (sqReader.Read()) // Use 'if' to check if there is a row
                {
                    result = sqReader.GetString(0);
                }
                sqReader.Close();
                conn.Close();
                return result;
            }
        }

        public bool insertDataNguoiChoi(string maNguoiChoi, string tenNguoiDung, Int64 soGioiChoiConLai, Decimal soTienNo, DateTime ngayTaoTaiKhoan, string nguoiTaoTaiKhoan, string nguoiNapTien, string email, string diaChi, string thanhPho, string quanHuyen, string CMND)
        {
            int i = 0;
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                conn.Open();
                string sql =
                    "INSERT OR IGNORE INTO NGUOICHOI(MaNguoiChoi, TenNguoiDung, SoGioChoiConLai, SoTienNo, NgayTaoTaiKhoan, NguoiTaoTaiKhoan, NguoiNapTien, Email, DiaChi, ThanhPho, QuanHuyen, CMND) " +
                    "VALUES(@MaNguoiChoi, @TenNguoiDung, @SoGioChoiConLai, @SoTienNo, @NgayTaoTaiKhoan, @NguoiTaoTaiKhoan, @NguoiNapTien, @Email, @DiaChi, @ThanhPho, @QuanHuyen, @CMND)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", maNguoiChoi);
                cmd.Parameters.AddWithValue("@TenNguoiDung", tenNguoiDung);
                cmd.Parameters.AddWithValue("@SoGioChoiConLai", soGioiChoiConLai);
                cmd.Parameters.AddWithValue("@SoTienNo", soTienNo);
                cmd.Parameters.AddWithValue("@NgayTaoTaiKhoan", ngayTaoTaiKhoan);
                cmd.Parameters.AddWithValue("@NguoiTaoTaiKhoan", nguoiTaoTaiKhoan);
                cmd.Parameters.AddWithValue("@NguoiNapTien", nguoiNapTien);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@ThanhPho", thanhPho);
                cmd.Parameters.AddWithValue("@QuanHuyen", quanHuyen);
                cmd.Parameters.AddWithValue("@CMND", CMND);
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }


            return i > 0;
        }

        public bool suaDataNguoiChoi(string maNguoiChoi, string tenNguoiDung, Int64 soGioiChoiConLai, Decimal soTienNo,
            DateTime ngayTaoTaiKhoan, string nguoiTaoTaiKhoan, string nguoiNapTien, string email, string diaChi,
            string thanhPho, string quanHuyen, string CMND)
        {
            int i = 0;
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                conn.Open();
                string sql = "UPDATE NGUOICHOI set TenNguoiDung = @TenNguoiDung, " +
                             "SoGioChoiConLai = @SoGioChoiConLai, " +
                             "SoTienNo = @SoTienNo, " +
                             "NgayTaoTaiKhoan = @NgayTaoTaiKhoan, " +
                             "NguoiTaoTaiKhoan = @NguoiTaoTaiKhoan, " +
                             "NguoiNapTien = @NguoiNapTien, " +
                             "Email = @Email, " +
                             "DiaChi = @DiaChi, " +
                             "ThanhPho = @ThanhPho, " +
                             "QuanHuyen = @QuanHuyen, " +
                             "CMND = @CMND Where MaNguoiChoi = @MaNguoiChoi";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", maNguoiChoi);
                cmd.Parameters.AddWithValue("@TenNguoiDung", tenNguoiDung);
                cmd.Parameters.AddWithValue("@SoGioChoiConLai", soGioiChoiConLai);
                cmd.Parameters.AddWithValue("@SoTienNo", soTienNo);
                cmd.Parameters.AddWithValue("@NgayTaoTaiKhoan", ngayTaoTaiKhoan);
                cmd.Parameters.AddWithValue("@NguoiTaoTaiKhoan", nguoiTaoTaiKhoan);
                cmd.Parameters.AddWithValue("@NguoiNapTien", nguoiNapTien);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@ThanhPho", thanhPho);
                cmd.Parameters.AddWithValue("@QuanHuyen", quanHuyen);
                cmd.Parameters.AddWithValue("@CMND", CMND);
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return i > 0;
        }

        public bool insertDataIntoDichVu(string tenDichVu, Decimal gia, string donVi)
        {
            int i = 0;
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                conn.Open();
                string sql = "INSERT OR IGNORE INTO DICHVU(TenDichVu, Gia, DonVi) " +
                             "VALUES(@TenDichVu, @Gia, @DonVi)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDichVu", tenDichVu);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@DonVi", donVi);
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return i > 0;
        }

        public bool insertDataIntoTAIKHOAN_USER(string maNguoiChoi, string password)
        {
            int i = 0;
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                conn.Open();
                string sql = "INSERT OR IGNORE INTO TAIKHOAN_USER(MaTaiKhoan, MatKhau) " +
                             "VALUES(@MaTaiKhoan, @MatKhau) ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaTaiKhoan", maNguoiChoi);
                cmd.Parameters.AddWithValue("@MatKhau", password);
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }

            return i > 0;
        }

        public DataSet GetAllUserDataSetForThanhVien()
        {
            DataSet data = new DataSet();
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                conn.Open();
                string sql = "SELECT MaNguoiChoi as \"Mã Người Chơi\", TenNguoiDung as \"Tên Người Dùng\", SoGioChoiConLai as \"Số Giờ\", SoTienNo as \"Số Nợ\", NgayTaoTaiKhoan as \"Ngày Tạo Tài Khoản\"" +
                             "From NGUOICHOI";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }

        public DataSet getSpecificUserData(string userName)
        {
            DataSet data = new DataSet();
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                conn.Open();
                string sql = "SELECT * " +
                             "From NGUOICHOI " +
                             "WHERE MaNguoiChoi = \"" + userName + "\"";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }

        public void removeUserFromNGUOICHOI(string username)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                conn.Open();
                string sql = "DELETE FROM NGUOICHOI WHERE MaNguoiChoi = @MaNguoiChoi";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", username);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
