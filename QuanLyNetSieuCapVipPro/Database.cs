using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace QuanLyNetSieuCapVipPro
{
    class Database
    {
        private string createDBSQL = "Data Source=QuanLyNet123.db";
        
        public Database()
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

            sql = "CREATE TABLE IF NOT EXISTS \"NGUOICHOI\" (" +
                  "\"MaNguoiChoi\" TEXT," +
                  "\"TenNguoiDung\" TEXT," +
                  "\"SoGioChoiConLai\" TEXT," +
                  "\"SoTienNo\" NUMERIC," +
                  "\"NgayTaoTaiKhoan\" TEXT," +
                  "CONSTRAINT \"NC_MaNguoiChoi_PK\" PRIMARY KEY(\"MaNguoiChoi\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DOAN\" (" +
                  "\"MaDoAn\" TEXT," +
                  "\"TenDoAn\" TEXT NOT NULL," +
                  "\"Gia\"\t NUMERIC," +
                  "CONSTRAINT \"DA_MaDoAn_PK\" PRIMARY KEY(\"MaDoAn\"" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"NUOCUONG\" (" +
                  "\"MaNuocUong\" TEXT," +
                  "\"TenNuocUong\" TEXT NOT NULL," +
                  "\"Gia\" NUMERIC," +
                  "CONSTRAINT \"NU_MaNuocUong_PK\" PRIMARY KEY(\"MaNuocUong\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DONHANG_DOAN\" (" +
                  "\"MaDonHangDoAn\" TEXT," +
                  "\"MaDoAn\" TEXT," +
                  "\"MaNguoiChoi\" TEXT," +
                  "\"ThoiGianDat\" TEXT," +
                  "CONSTRAINT \"DHDA_MaDonHang_MaDoAn_MaNguoiChoi_PK\" PRIMARY KEY(\"MaDonHangDoAn\",\"MaDoAn\",\"MaNguoiChoi\")," +
                  "CONSTRAINT \"DHDA_MaNguoiChoi_FK\" FOREIGN KEY(\"MaNguoiChoi\") REFERENCES \"NGUOICHOI\"(\"MaNguoiChoi\")," +
                  "CONSTRAINT \"DHDA_MaDoAn_FK\" FOREIGN KEY(\"MaDoAn\") REFERENCES \"DOAN\"(\"MaDoAn\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DONHANG_NUOCUONG\" (" +
                  "\"MaDonHangNuocUong\" TEXT," +
                  "\"MaNuocUong\" TEXT," +
                  "\"MaNguoiChoi\" TEXT," +
                  "\"ThoiGianDat\" TEXT," +
                  "CONSTRAINT \"DHNU_MaDonHangNuocUong_MaNuocUong_MaNguoiChoi_PK\" PRIMARY KEY(\"MaDonHangNuocUong\",\"MaNuocUong\",\"MaNguoiChoi\")," +
                  "CONSTRAINT \"DHNU_MaNuocUong_FK\" FOREIGN KEY(\"MaNuocUong\") REFERENCES \"NUOCUONG\"(\"MaNuocUong\")," +
                  "CONSTRAINT \"DHNU_MaNguoiChoi_FK\" FOREIGN KEY(\"MaNguoiChoi\") REFERENCES \"NGUOICHOI\"(\"MaNguoiChoi\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

            sql = "CREATE TABLE IF NOT EXISTS \"DANGNHAP_USER\" (" +
                  "\"MaMay\" TEXT," +
                  "\"MaNguoiChoi\" TEXT NOT NULL," +
                  "\"ThoiGianDangNhap\" TEXT," +
                  "\"MatKhau\"TEXT," +
                  "\"ThoiGianLogOut\" TEXT," +
                  "CONSTRAINT \"DN_MaMay_MaNguoiChoi_ThoiGianDangNhap_PK\" PRIMARY KEY(\"MaMay\",\"MaNguoiChoi\",\"ThoiGianDangNhap\")," +
                  "FOREIGN KEY(\"MaNguoiChoi\") REFERENCES \"NGUOICHOI\"(\"MaNguoiChoi\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
            
            
        }
        public void createTable(SQLiteConnection conn)
        {
            
        }
    }
}
