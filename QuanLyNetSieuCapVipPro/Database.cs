using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyNetSieuCapVipPro
{
    class Database
    {
        private string createDBSQL = "Data Source=QuanLyNet123.db";
        public void createDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS \"MAYTINH\" ( " +
                             "\"MaMay\" TEXT, " +
                             "\"LanKhoiDongGanNhat\" TEXT, " +
                             "\"TrangThaiMay\" TEXT NOT NULL, " +
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

                sql = "CREATE TABLE IF NOT EXISTS 'NHOMNGUOIDUNG' ( " +
                      "\"MaNhomNguoiDung\" TEXT, " +
                      "\"TenNhomNguoiDung\" TEXT NOT NULL, " +
                      "\"GiaNhomNguoiDung\" NUMERIC, " +
                      "CONSTRAINT \"NND_MaNhomNguoiDung_PK\" PRIMARY KEY(\"MaNhomNguoiDung\") " +
                      ")";
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
                      "\"CMND\" TEXT, " +
                      "\"SDT\" TEXT, " +
                      "\"NhomNguoiDung\" TEXT, " +
                      "CONSTRAINT \"NC_NguoiNapTien_FK\" FOREIGN KEY(\"NguoiNapTien\") REFERENCES \"ADMIN\"(\"MaAdmin\"), " +
                      "CONSTRAINT \"NC_NguoiTaoTaiKhoan_FK\" FOREIGN KEY(\"NguoiTaoTaiKhoan\") REFERENCES \"ADMIN\"(\"MaAdmin\"), " +
                      "CONSTRAINT \"NC_MaNguoiChoi_PK\" PRIMARY KEY(\"MaNguoiChoi\"), " +
                      "CONSTRAINT \"NC_NhomNguoiDung_FK\" FOREIGN KEY(\"NhomNguoiDung\") REFERENCES \"NHOMNGUOIDUNG\"(\"MaNhomNguoiDung\") " +
                      ") ";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "CREATE TABLE IF NOT EXISTS \"DICHVU\" ( " +
                      "\"MaDichVu\" TEXT, " +
                      "\"TenDichVu\" TEXT NOT NULL, " +
                      "\"Gia\" NUMERIC, " +
                      "\"DonVi\" TEXT, " +
                      "CONSTRAINT \"DV_MaDichVu_PK\" PRIMARY KEY(\"MaDichVu\") " +
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
                      "\"MaDonHang\" INTEGER, " +
                      "\"MaDichVu\" TEXT NOT NULL, " +
                      "\"MaNguoiChoi\" TEXT NOT NULL, " +
                      "\"ThoiGianDatHang\" TEXT, " +
                      "\"NoiDungDonHang\" TEXT, " +
                      "\"MaMayDatHang\" TEXT NOT NULL," +
                      "CONSTRAINT \"DHDV_MaDichVu_FK\" FOREIGN KEY(\"MaDichVu\") REFERENCES \"DICHVU\"(\"MaDichVu\"), "+
                      "CONSTRAINT \"DHDV_MaNguoiChoi_FK\" FOREIGN KEY(\"MaNguoiChoi\") REFERENCES \"NGUOICHOI\"(\"MaNguoiChoi\"), " +
                      "CONSTRAINT \"DHDV_MaMayDatHang_FK\" FOREIGN KEY(\"MaMayDatHang\") REFERENCES \"MAYTINH\"(\"MaMay\"), " +
                      "CONSTRAINT \"DHDV_MaDonHang_MaDichVu_MaNguoiChoi_PK\" PRIMARY KEY(\"MaDonHang\" AUTOINCREMENT) " +
                      ")";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "INSERT OR IGNORE INTO NHOMNGUOIDUNG(MaNhomNguoiDung, TenNhomNguoiDung, GiaNhomNguoiDung) " +
                      "VALUES(\"hoivien\", \"Hội Viên\", 10000), (\"nhanvien\", \"Nhân Viên\", 7000), (\"vip\", \"VIP\", 8500), (\"vanglai\", \"Vãng Lai\", 11500)";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "INSERT OR IGNORE INTO TAIKHOAN_ADMIN(MaTaiKhoan, MatKhau) " +
                          "VALUES(\"admin\", \"admin\") ";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "INSERT OR IGNORE INTO ADMIN(MaAdmin, TenAdmin) " +
                      "VALUES(\"admin\", \"admin\")";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                sql = "INSERT OR IGNORE INTO MAYTINH(MaMay, TrangThaiMay) VALUES ('MAY001', 'off'), ('MAY002', 'off'), ('MAY003', 'off')";
                cmd = new SQLiteCommand(sql, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }

        public bool backUpDB(string currentFilePath, string currentDBName, string destFilePath)
        {
            try
            {
                var srcFile = Path.Combine(currentFilePath, currentDBName);
                if (File.Exists(destFilePath))
                {
                    File.Delete(destFilePath);
                }
                File.Copy(srcFile, destFilePath);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool restoreDB(string filePath, string destFileName)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                try
                {
                    conn.Close();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    if (File.Exists(destFileName))
                    {
                        File.Delete(destFileName);
                    }
                    File.Move(filePath, destFileName);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            return true;
        }
        public void insertDataIntoTaiKhoanAdmin(string UserAccount, string Password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                conn.Open();
                string sql = "INSERT OR IGNORE INTO TAIKHOAN_ADMIN(MaTaiKhoan, MatKhau) " +
                             "VALUES(@MaTaiKhoan, @MatKhau) ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaTaiKhoan", UserAccount);
                cmd.Parameters.AddWithValue("@MatKhau", Password);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public bool insertDataIntoAdmin(string UserAccount, string TenAdmin, string SDT, string DiaChi)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "INSERT OR IGNORE INTO ADMIN(MaAdmin, TenAdmin, SDT, DiaChi) " +
                             "VALUES(@MaAdmin, @TenAdmin, @SDT, @DiaChi) ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaAdmin", UserAccount);
                cmd.Parameters.AddWithValue("@TenAdmin", TenAdmin);
                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public string getAdminPassword(string UserAccount)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
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

        public bool insertDataNguoiChoi(string maNguoiChoi, string tenNguoiDung, Int64 soGioiChoiConLai, Decimal soTienNo, DateTime ngayTaoTaiKhoan, string nguoiTaoTaiKhoan, string nguoiNapTien, string email, string diaChi, string thanhPho, string quanHuyen, string CMND, string SDT, string loaiNguoiDung)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql =
                    "INSERT OR IGNORE INTO NGUOICHOI(MaNguoiChoi, TenNguoiDung, SoGioChoiConLai, SoTienNo, NgayTaoTaiKhoan, NguoiTaoTaiKhoan, NguoiNapTien, Email, DiaChi, ThanhPho, QuanHuyen, CMND, SDT, NhomNguoiDung) " +
                    "VALUES(@MaNguoiChoi, @TenNguoiDung, @SoGioChoiConLai, @SoTienNo, @NgayTaoTaiKhoan, @NguoiTaoTaiKhoan, @NguoiNapTien, @Email, @DiaChi, @ThanhPho, @QuanHuyen, @CMND, @SDT, @NhomNguoiDung)";
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
                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.Parameters.AddWithValue("@NhomNguoiDung", loaiNguoiDung);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }
        public bool suaDataNguoiChoi(string maNguoiChoi, string tenNguoiDung, Int64 soGioiChoiConLai, Decimal soTienNo,
            DateTime ngayTaoTaiKhoan, string nguoiTaoTaiKhoan, string nguoiNapTien, string email, string diaChi,
            string thanhPho, string quanHuyen, string CMND, string SDT, string loaiNguoiDung)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
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
                             "CMND = @CMND, " +
                             "SDT = @SDT, " +
                             "NhomNguoiDung = @NhomNguoiDung " +
                             "Where MaNguoiChoi = @MaNguoiChoi";
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
                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.Parameters.AddWithValue("@NhomNguoiDung", loaiNguoiDung);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool insertDataIntoDichVu(string maDichVu, string tenDichVu, Decimal gia, string donVi)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "INSERT OR IGNORE INTO DICHVU(MaDichVu, TenDichVu, Gia, DonVi) " +
                             "VALUES(@MaDichVu, @TenDichVu, @Gia, @DonVi)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);
                cmd.Parameters.AddWithValue("@TenDichVu", tenDichVu);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@DonVi", donVi);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool insertDataIntoTAIKHOAN_USER(string maNguoiChoi, string password)
        {
            
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "INSERT OR IGNORE INTO TAIKHOAN_USER(MaTaiKhoan, MatKhau) " +
                             "VALUES(@MaTaiKhoan, @MatKhau) ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaTaiKhoan", maNguoiChoi);
                cmd.Parameters.AddWithValue("@MatKhau", password);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool insertDataIntoNHOMNGUOIDUNG(string maNhomNguoiDung, string tenNhomNguoiDung,
            decimal giaNhomNguoiDung)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "INSERT OR IGNORE INTO NHOMNGUOIDUNG(MaNhomNguoiDung, TenNhomNguoiDung, GiaNhomNguoiDung) " +
                             "VALUES(@MaNhomNguoiDung, @TenNhomNguoiDung, @GiaNhomNguoiDung) ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhomNguoiDung", maNhomNguoiDung);
                cmd.Parameters.AddWithValue("@TenNhomNguoiDung", tenNhomNguoiDung);
                cmd.Parameters.AddWithValue("@GiaNhomNguoiDung", giaNhomNguoiDung);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool modifiedSpecificItemInNHOMNGUOIDUNG(string maNhomNguoiDung, string tenNhomNguoiDung,
            decimal giaNhomNguoiDung)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "UPDATE NHOMNGUOIDUNG set TenNhomNguoiDung = @TenNhomNguoiDung," +
                             "GiaNhomNguoiDung = @GiaNhomNguoiDung where MaNhomNguoiDung = @MaNhomNguoiDung ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenNhomNguoiDung", tenNhomNguoiDung);
                cmd.Parameters.AddWithValue("@GiaNhomNguoiDung", giaNhomNguoiDung);
                cmd.Parameters.AddWithValue("@MaNhomNguoiDung", maNhomNguoiDung);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public DataSet GetAllUserDataSetForThanhVien()
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT MaNguoiChoi as \"Mã Người Chơi\", TenNguoiDung as \"Tên Người Dùng\", SoGioChoiConLai as \"Số Phút Hiện Có\", SoTienNo as \"Số Nợ\", NgayTaoTaiKhoan as \"Ngày Tạo Tài Khoản\"" +
                             "From NGUOICHOI";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public long getSoPhutHienCo(string maNguoiChoi)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                long result = 0;
                conn.Open();
                string sql = "SELECT SoGioChoiConLai FROM NGUOICHOI WHERE MaNguoiChoi = @MaNguoiChoi";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", maNguoiChoi);
                result = Convert.ToInt64(cmd.ExecuteScalar());
                conn.Close();
                return result;
            }
        }

        public DataSet getSpecificUserData(string userName)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT * " +
                             "From NGUOICHOI " +
                             "WHERE MaNguoiChoi = \"" + userName + "\"";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public bool modifiedSpecificElement(string maDichVu, string tenDichVu, Decimal gia, string donVi)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "UPDATE DICHVU set TenDichVu = @TenDichVu," +
                             "Gia = @Gia, " +
                             "DonVi = @DonVi where MaDichVu = @MaDichVu";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDichVu", tenDichVu);
                cmd.Parameters.AddWithValue("@Gia", gia);
                cmd.Parameters.AddWithValue("@DonVi", donVi);
                cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public DataSet getAllItemsFormDICHVU()
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT MaDichVu as \"Mã Dịch Vụ\"," +
                             "TenDichVu as \"Tên Dịch Vụ\"," +
                             "Gia as \"Giá\"," +
                             "DonVi as \"Đơn Vị\"" +
                             "FROM DICHVU ";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public DataSet getAllItemsFromDICHVU_1()
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT *" +
                             "FROM DICHVU ";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public DataSet getSpecificItemFromDICHVU(string maDichVu)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT * " +
                             "FROM DICHVU " +
                             "WHERE MaDichVu = " + "\"" + maDichVu + "\"";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public DataSet getSpecificItemFromNHOMNGUOIDUNG(string maNhomNguoiDung)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT * " +
                             "FROM NHOMNGUOIDUNG " +
                             "WHERE MaNhomNguoiDung = " + "\"" + maNhomNguoiDung + "\"";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public bool removeItemsFromDICHVU(string maDichVu)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "DELETE FROM DICHVU WHERE MaDichVu = @MaDichVu";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool insertDataIntoDONHANG_DICHVU(string maDichVu, string maNguoiChoi, DateTime thoiGianDatHang,
            string noiDungDonHang, string maMay)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql =
                    "INSERT OR IGNORE INTO DONHANG_DICHVU(MaDichVu, MaNguoiChoi, ThoiGianDatHang, NoiDungDonHang, MaMayDatHang) " +
                    "VALUES(@MaDichVu, @MaNguoiChoi, @ThoiGianDatHang, @NoiDungDonHang, @MaMayDatHang)";
                var cmd = new SQLiteCommand(sql, conn);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public DataSet getAllItemsFROMNHOMNGUOIDUNG()
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT * FROM NHOMNGUOIDUNG";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public DataSet getAllItemsFromMAYTINH()
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT * FROM MAYTINH";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public Decimal getGiaTaiKhoan(string maNhomNguoiDung)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                Decimal rs = 0;
                conn.Open();
                string sql = "SELECT GiaNhomNguoiDung FROM NHOMNGUOIDUNG WHERE MaNhomNguoiDung = @MaNhomNguoiDung";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhomNguoiDung", maNhomNguoiDung);
                rs = Convert.ToDecimal(cmd.ExecuteScalar());
                conn.Close();
                return rs;
            }
        }

        public bool updateThoiGianToNGUOICHOI(string maNguoiChoi, long soPhut)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "UPDATE NGUOICHOI set SoGioChoiConLai = @SoGioChoiConLai WHERE MaNguoiChoi = @MaNguoiChoi";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SoGioChoiConLai", soPhut);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", maNguoiChoi);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public string getLoaiTaiKhoan(string maNhomNguoiDung)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                string rs = "";
                conn.Open();
                string sql = "SELECT TenNhomNguoiDung FROM NHOMNGUOIDUNG WHERE MaNhomNguoiDung = @MaNhomNguoiDung";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhomNguoiDung", maNhomNguoiDung);
                rs = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return rs;
            }
        }


        public bool modifiedComputerStateInMAYTINH(string maMay, string trangThai)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "UPDATE MAYTINH set TrangThaiMay = @TrangThaiMay WHERE MaMay = @MaMay";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TrangThaiMay", trangThai);
                cmd.Parameters.AddWithValue("@MaMay", maMay);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public string getComputerStateINMAYTINH(string maMay)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                string rs = "";
                conn.Open();
                string sql = "SELECT TrangThaiMay FROM MAYTINH WHERE MaMay = @MaMay";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMay", maMay);
                rs = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return rs;
            }
        }

        public bool removeUserFromNGUOICHOI(string username)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "DELETE FROM NGUOICHOI WHERE MaNguoiChoi = @MaNguoiChoi";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", username);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool removeNhomFROMNHOMNGUOIDUNG(string maNhomNguoiDung)
        {
            using (SQLiteConnection conn = new SQLiteConnection(createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "DELETE FROM NHOMNGUOIDUNG WHERE MaNhomNguoiDung = @MaNhomNguoiDung";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhomNguoiDung", maNhomNguoiDung);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }
    }
}
