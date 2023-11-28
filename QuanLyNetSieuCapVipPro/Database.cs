using System;
using System.Collections.Generic;
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
            string sql = "CREATE TABLE IF NOT EXISTS \"MAYTINH\" (" +
                         "\"MaMay\" TEXT," +
                         "\"CPU\" TEXT," +
                         "\"GPU\" TEXT," +
                         "\"RAM\" TEXT," +
                         "\"DISK\" TEXT," +
                         "CONSTRAINT \"MT_MaMay_PK\" PRIMARY KEY(\"MaMay\")" +
                         ")";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"ADMIN\" (" +
                  "\"MaAdmin\" TEXT," +
                  "\"TenAdmin\" TEXT NOT NULL," +
                  "\"SDT\" TEXT," +
                  "\"DiaChi\" TEXT," +
                  "CONSTRAINT \"A_MaAdmin_PK\" PRIMARY KEY(\"MaAdmin\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"NGUOICHOI\" (" +
                  "\"MaNguoiChoi\" TEXT," +
                  "\"TenNguoiDung\" TEXT NOT NULL," +
                  "\"SoGioChoiConLai\" TEXT," +
                  "\"SoTienNo\" NUMERIC," +
                  "\"NgayTaoTaiKhoan\" TEXT," +
                  "\"NguoiTaoTaiKhoan\" TEXT," +
                  "\"NguoiNapTien\" TEXT," +
                  "CONSTRAINT \"NC_NguoiNapTien_FK\" FOREIGN KEY(\"NguoiNapTien\") REFERENCES \"ADMIN\"(\"MaAdmin\")," +
                  "CONSTRAINT \"NC_NguoiTaoTaiKhoan_FK\" FOREIGN KEY(\"NguoiTaoTaiKhoan\") REFERENCES \"ADMIN\"(\"MaAdmin\")," +
                  "CONSTRAINT \"NC_MaNguoiChoi_PK\" PRIMARY KEY(\"MaNguoiChoi\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DICHVU\" (" +
                  "\"MaDichVu\" TEXT," +
                  "\"TenDichVu\" TEXT NOT NULL," +
                  "\"Gia\" NUMERIC," +
                  "CONSTRAINT \"DV_MaDichVu_PK\" PRIMARY KEY(\"MaDichVu\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"TAIKHOAN\" (" +
                  "\"MaTaiKhoan\" TEXT NOT NULL," +
                  "\"MatKhau\" TEXT NOT NULL," +
                  "CONSTRAINT \"TK_MaTaiKhoan_PK\" PRIMARY KEY(\"MaTaiKhoan\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DANGNHAP_ADMIN\" (" +
                  "\"MaPhienDangNhap\" TEXT," +
                  "\"MaAdmin\" TEXT NOT NULL," +
                  "\"MaMay\" TEXT NOT NULL," +
                  "\"ThoiGianDangNhap\" TEXT," +
                  "\"ThoiGianDangXuat\" TEXT," +
                  "CONSTRAINT \"DNA_MaMay_FK\" FOREIGN KEY(\"MaMay\") REFERENCES \"MAYTINH\"(\"MaMay\")," +
                  "CONSTRAINT \"DNA_MaAdmin_FK\" FOREIGN KEY(\"MaAdmin\") REFERENCES \"ADMIN\"(\"MaAdmin\")," +
                  "CONSTRAINT \"DNA_MaPhienDangNhap_MaAdmin_MaMay_PK\" PRIMARY KEY(\"MaPhienDangNhap\",\"MaAdmin\",\"MaMay\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DANGNHAP_USER\" (" +
                  "\"MaMay\" TEXT NOT NULL," +
                  "\"MaNguoiChoi\" TEXT NOT NULL," +
                  "\"ThoiGianDangNhap\" TEXT," +
                  "\"ThoiGianLogOut\" TEXT," +
                  "\"MaPhienDangNhap\" TEXT," +
                  "CONSTRAINT \"DNU_MaNguoiChoi_FK\" FOREIGN KEY(\"MaNguoiChoi\") REFERENCES \"NGUOICHOI\"(\"MaNguoiChoi\")," +
                  "CONSTRAINT \"DNU_MaMay_FK\" FOREIGN KEY(\"MaMay\") REFERENCES \"MAYTINH\"(\"MaMay\")," +
                  "CONSTRAINT \"DN_MaMay_MaNguoiChoi_ThoiGianDangNhap_PK\" PRIMARY KEY(\"MaMay\",\"MaNguoiChoi\",\"MaPhienDangNhap\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DONHANG_DICHVU\" (" +
                  "\"MaDonHang\" TEXT," +
                  "\"MaDichVu\" TEXT NOT NULL," +
                  "\"MaNguoiChoi\" TEXT NOT NULL," +
                  "\"ThoiGianDatHang\" TEXT," +
                  "CONSTRAINT \"DHDV_MaDonHang_MaDichVu_MaNguoiChoi_PK\" PRIMARY KEY(\"MaDonHang\",\"MaDichVu\",\"MaNguoiChoi\")," +
                  "CONSTRAINT \"DHDV_MaDichVu_FK\" FOREIGN KEY(\"MaDichVu\") REFERENCES \"DICHVU\"(\"MaDichVu\")," +
                  "CONSTRAINT \"DHDV_MaNguoiChoi_FK\" FOREIGN KEY(\"MaNguoiChoi\") REFERENCES \"NGUOICHOI\"(\"MaNguoiChoi\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void insertDataIntoTaiKhoan(string UserAccount, string Password)
        {
            SQLiteConnection conn = new SQLiteConnection(createDBSQL);
            conn.Open();
            string sql = "INSERT INTO TAIKHOAN(MaTaiKhoan, MatKhau)" +
                         "VALUES(@MaTaiKhoan, @MatKhau)";
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
            string sql = "INSERT INTO ADMIN(MaAdmin, TenAdmin, SDT, DiaChi)" +
                         "VALUES(@MaAdmin, @TenAdmin, @SDT, @DiaChi)";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaAdmin", UserAccount);
            cmd.Parameters.AddWithValue("@TenAdmin", TenAdmin);
            cmd.Parameters.AddWithValue("@SDT", SDT);
            cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public string getUserPassword(string UserAccount)
        {
            SQLiteConnection conn = new SQLiteConnection(createDBSQL);
            conn.Open();
            string sql = "SELECT MatKhau " +
                         "FROM TAIKHOAN " +
                         "WHERE TAIKHOAN.MaTaiKhoan = @UserAccount"; // Corrected parameter syntax
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

    }
}
