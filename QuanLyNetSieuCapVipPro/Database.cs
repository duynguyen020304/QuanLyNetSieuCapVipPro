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
            string sql = "CREATE TABLE IF NOT EXISTS \"DANGNHAP\" (" +
                         "\"MaMay\" TEXT," +
                         "\"MaNguoiChoi\" TEXT NOT NULL," +
                         "\"ThoiGianDangNhap\" TEXT," +
                         "\"MatKhau\"TEXT," +
                         "\"ThoiGianLogOut\" TEXT," +
                         "CONSTRAINT \"DN_MaMay_MaNguoiChoi_ThoiGianDangNhap_PK\" PRIMARY KEY(\"MaMay\",\"MaNguoiChoi\",\"ThoiGianDangNhap\")," +
                         "FOREIGN KEY(\"MaNguoiChoi\") REFERENCES \"NGUOICHOI\"(\"MaNguoiChoi\")" +
                         ")";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
            sql = "CREATE TABLE \"NGUOICHOI\" (" +
                  "\"MaNguoiChoi\" TEXT," +
                  "\"TenNguoiDung\" TEXT," +
                  "\"SoGioChoiConLai\" TEXT," +
                  "\"SoTienNo\" NUMERIC," +
                  "\"NgayTaoTaiKhoan\" TEXT," +
                  "CONSTRAINT \"NC_MaNguoiChoi_PK\" PRIMARY KEY(\"MaNguoiChoi\")" +
                  ")";
            cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();

        }
        public void createTable(SQLiteConnection conn)
        {
            
        }
    }
}
