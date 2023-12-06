using System.Data;
using System.Data.SQLite;

namespace QuanLyNetSieuCapVipPro
{
    class Database
    {
        private string _createDBSQL = "Data Source=QuanLyNet123.db";
        public void CreateDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
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

                sql = "CREATE TABLE IF NOT EXISTS \"LICHSUDANGNHAP_ADMIN\" ( " +
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

                sql = "CREATE TABLE IF NOT EXISTS \"LICHSUDANGNHAP_USER\" ( " +
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

                sql = "CREATE TABLE IF NOT EXISTS \"LICHSUGIAODICH\" ( " +
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

        public bool Backup(string currentFilePath, string currentDBName, string destFilePath)
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

        public bool Restore(string filePath, string destFileName)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
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
        public void InsertDataIntoTAIKHOANADMIN(string adminAccountId, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                conn.Open();
                string sql = "INSERT OR IGNORE INTO TAIKHOAN_ADMIN(MaTaiKhoan, MatKhau) " +
                             "VALUES(@MaTaiKhoan, @MatKhau) ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaTaiKhoan", adminAccountId);
                cmd.Parameters.AddWithValue("@MatKhau", password);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public bool InsertDataIntoADMIN(string adminAccountId, string adminAccountName, string phoneNumber, string address)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "INSERT OR IGNORE INTO ADMIN(MaAdmin, TenAdmin, SDT, DiaChi) " +
                             "VALUES(@MaAdmin, @TenAdmin, @SDT, @DiaChi) ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaAdmin", adminAccountId);
                cmd.Parameters.AddWithValue("@TenAdmin", adminAccountName);
                cmd.Parameters.AddWithValue("@SDT", phoneNumber);
                cmd.Parameters.AddWithValue("@DiaChi", address);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public string GetAdminPassword(string adminAccountId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                conn.Open();
                string sql = "SELECT MatKhau " +
                             "FROM TAIKHOAN_ADMIN " +
                             "WHERE TAIKHOAN_ADMIN.MaTaiKhoan = @UserAccount "; // Corrected parameter syntax
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserAccount", adminAccountId);
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

        public string GetUserPassword(string userAccountId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                conn.Open();
                string sql = "SELECT MatKhau " +
                             "FROM TAIKHOAN_USER " +
                             "WHERE MaTaiKhoan = @UserAccount "; // Corrected parameter syntax
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserAccount", userAccountId);
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

        public bool InsertDataIntoNGUOICHOI(string userAccountId, string userAccountName, Int64 playTimeLeft, Decimal debtAmount, DateTime accountCreationDate, string accountCreator, string customerDeposit, string email, string address, string city, string district, string nationalId, string phoneNumber, string userAccountType)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql =
                    "INSERT OR IGNORE INTO NGUOICHOI(MaNguoiChoi, TenNguoiDung, SoGioChoiConLai, SoTienNo, NgayTaoTaiKhoan, NguoiTaoTaiKhoan, NguoiNapTien, Email, DiaChi, ThanhPho, QuanHuyen, CMND, SDT, NhomNguoiDung) " +
                    "VALUES(@MaNguoiChoi, @TenNguoiDung, @SoGioChoiConLai, @SoTienNo, @NgayTaoTaiKhoan, @NguoiTaoTaiKhoan, @NguoiNapTien, @Email, @DiaChi, @ThanhPho, @QuanHuyen, @CMND, @SDT, @NhomNguoiDung)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", userAccountId);
                cmd.Parameters.AddWithValue("@TenNguoiDung", userAccountName);
                cmd.Parameters.AddWithValue("@SoGioChoiConLai", playTimeLeft);
                cmd.Parameters.AddWithValue("@SoTienNo", debtAmount);
                cmd.Parameters.AddWithValue("@NgayTaoTaiKhoan", accountCreationDate);
                cmd.Parameters.AddWithValue("@NguoiTaoTaiKhoan", accountCreator);
                cmd.Parameters.AddWithValue("@NguoiNapTien", customerDeposit);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@DiaChi", address);
                cmd.Parameters.AddWithValue("@ThanhPho", city);
                cmd.Parameters.AddWithValue("@QuanHuyen", district);
                cmd.Parameters.AddWithValue("@CMND", nationalId);
                cmd.Parameters.AddWithValue("@SDT", phoneNumber);
                cmd.Parameters.AddWithValue("@NhomNguoiDung", userAccountType);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }
        public bool UpdateNguoiChoiTableUserData(string userAccountId, string userAccountName, Int64 playTimeLeft, Decimal debtAmount, DateTime accountCreationDate, string accountCreator, string customerDeposit, string email, string address,
            string city, string district, string nationalId, string phoneNumber, string userAccountType)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
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
                cmd.Parameters.AddWithValue("@MaNguoiChoi", userAccountId);
                cmd.Parameters.AddWithValue("@TenNguoiDung", userAccountName);
                cmd.Parameters.AddWithValue("@SoGioChoiConLai", playTimeLeft);
                cmd.Parameters.AddWithValue("@SoTienNo", debtAmount);
                cmd.Parameters.AddWithValue("@NgayTaoTaiKhoan", accountCreationDate);
                cmd.Parameters.AddWithValue("@NguoiTaoTaiKhoan", accountCreator);
                cmd.Parameters.AddWithValue("@NguoiNapTien", customerDeposit);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@DiaChi", address);
                cmd.Parameters.AddWithValue("@ThanhPho", city);
                cmd.Parameters.AddWithValue("@QuanHuyen", district);
                cmd.Parameters.AddWithValue("@CMND", nationalId);
                cmd.Parameters.AddWithValue("@SDT", phoneNumber);
                cmd.Parameters.AddWithValue("@NhomNguoiDung", userAccountType);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool InsertDataIntoDichVu(string serviceId, string serviceName, Decimal price, string unitName)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "INSERT OR IGNORE INTO DICHVU(MaDichVu, TenDichVu, Gia, DonVi) " +
                             "VALUES(@MaDichVu, @TenDichVu, @Gia, @DonVi)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDichVu", serviceId);
                cmd.Parameters.AddWithValue("@TenDichVu", serviceName);
                cmd.Parameters.AddWithValue("@Gia", price);
                cmd.Parameters.AddWithValue("@DonVi", unitName);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool InsertDataIntoTAIKHOAN_USER(string userId, string password)
        {
            
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "INSERT OR IGNORE INTO TAIKHOAN_USER(MaTaiKhoan, MatKhau) " +
                             "VALUES(@MaTaiKhoan, @MatKhau) ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaTaiKhoan", userId);
                cmd.Parameters.AddWithValue("@MatKhau", password);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool InsertDataIntoNHOMNGUOIDUNG(string userGroupId, string userAccountType,
            decimal userGroupPrice)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "INSERT OR IGNORE INTO NHOMNGUOIDUNG(MaNhomNguoiDung, TenNhomNguoiDung, GiaNhomNguoiDung) " +
                             "VALUES(@MaNhomNguoiDung, @TenNhomNguoiDung, @GiaNhomNguoiDung) ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhomNguoiDung", userGroupId);
                cmd.Parameters.AddWithValue("@TenNhomNguoiDung", userAccountType);
                cmd.Parameters.AddWithValue("@GiaNhomNguoiDung", userGroupPrice);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool UpdateItemInNHOMNGUOIDUNG(string userGroupId, string userAccountType,
            decimal userGroupPrice)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "UPDATE NHOMNGUOIDUNG set TenNhomNguoiDung = @TenNhomNguoiDung," +
                             "GiaNhomNguoiDung = @GiaNhomNguoiDung where MaNhomNguoiDung = @MaNhomNguoiDung ";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenNhomNguoiDung", userAccountType);
                cmd.Parameters.AddWithValue("@GiaNhomNguoiDung", userGroupPrice);
                cmd.Parameters.AddWithValue("@MaNhomNguoiDung", userGroupId);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public DataSet GetAllUserDataSetForThanhVien()
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
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

        public long GetplayTimeLeft(string userAccountId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                long result = 0;
                conn.Open();
                string sql = "SELECT SoGioChoiConLai FROM NGUOICHOI WHERE MaNguoiChoi = @MaNguoiChoi";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", userAccountId);
                result = Convert.ToInt64(cmd.ExecuteScalar());
                conn.Close();
                return result;
            }
        }

        public DataSet GetSpecificUserData(string userAccountId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT * " +
                             "From NGUOICHOI " +
                             "WHERE MaNguoiChoi = \"" + userAccountId + "\"";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public bool updateItemInDICHVU(string serviceId, string serviceName, Decimal price, string unitName)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "UPDATE DICHVU set TenDichVu = @TenDichVu," +
                             "Gia = @Gia, " +
                             "DonVi = @DonVi where MaDichVu = @MaDichVu";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDichVu", serviceName);
                cmd.Parameters.AddWithValue("@Gia", price);
                cmd.Parameters.AddWithValue("@DonVi", unitName);
                cmd.Parameters.AddWithValue("@MaDichVu", serviceId);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public DataSet GetAllItemsFromDICHVU()
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
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

        public DataSet GetAllItemsFromDICHVU_1()
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
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

        public DataSet GetSpecificItemFromDICHVU(string serviceId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT * " +
                             "FROM DICHVU " +
                             "WHERE MaDichVu = " + "\"" + serviceId + "\"";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public DataSet GetSpecificItemFromNHOMNGUOIDUNG(string userGroupId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT * " +
                             "FROM NHOMNGUOIDUNG " +
                             "WHERE MaNhomNguoiDung = " + "\"" + userGroupId + "\"";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public bool RemoveItemFromDICHVU(string serviceId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "DELETE FROM DICHVU WHERE MaDichVu = @MaDichVu";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDichVu", serviceId);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool InsertDataIntoLICHSUGIAODICH(string serviceId, string userAccountName, DateTime orderTime,
            string orderContent, string computerId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql =
                    "INSERT OR IGNORE INTO LICHSUGIAODICH(MaDichVu, MaNguoiChoi, ThoiGianDatHang, NoiDungDonHang, MaMayDatHang) " +
                    "VALUES(@MaDichVu, @MaNguoiChoi, @ThoiGianDatHang, @NoiDungDonHang, @MaMayDatHang)";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDichVu", serviceId);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", userAccountName);
                cmd.Parameters.AddWithValue("@ThoiGianDatHang", orderTime);
                cmd.Parameters.AddWithValue("@NoiDungDonHang", orderContent);
                cmd.Parameters.AddWithValue("@MaMayDatHang", computerId);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public DataSet GetAllItemsFromLICHSUGIAODICH()
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                DataSet data = new DataSet();
                conn.Open();
                string sql = "SELECT * FROM LICHSUGIAODICH";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
        }

        public DataSet GetAllItemsFROMNHOMNGUOIDUNG()
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
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

        public DataSet GetAllItemsFromMAYTINH()
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
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

        public Decimal GetUserGroupPrice(string userGroupId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                Decimal rs = 0;
                conn.Open();
                string sql = "SELECT GiaNhomNguoiDung FROM NHOMNGUOIDUNG WHERE MaNhomNguoiDung = @MaNhomNguoiDung";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhomNguoiDung", userGroupId);
                rs = Convert.ToDecimal(cmd.ExecuteScalar());
                conn.Close();
                return rs;
            }
        }

        public bool UpdatePlayTimeLeftToNGUOICHOI(string userAccountId, long playTimeLeft)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "UPDATE NGUOICHOI set SoGioChoiConLai = @SoGioChoiConLai WHERE MaNguoiChoi = @MaNguoiChoi";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SoGioChoiConLai", playTimeLeft);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", userAccountId);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public string GetUserGroupName(string userGroupId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                string rs = "";
                conn.Open();
                string sql = "SELECT TenNhomNguoiDung FROM NHOMNGUOIDUNG WHERE MaNhomNguoiDung = @MaNhomNguoiDung";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNhomNguoiDung", userGroupId);
                rs = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return rs;
            }
        }


        public bool UpdateComputerStateInMAYTINH(string computerId, string state)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "UPDATE MAYTINH set TrangThaiMay = @TrangThaiMay WHERE MaMay = @MaMay";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TrangThaiMay", state);
                cmd.Parameters.AddWithValue("@MaMay", computerId);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool UpdateItemInMAYTINH(string computerId, DateTime bootTime, string state)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "UPDATE MAYTINH set TrangThaiMay = @TrangThaiMay, LanKhoiDongGanNhat = @LanKhoiDongGanNhat WHERE MaMay = @MaMay";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TrangThaiMay", state);
                cmd.Parameters.AddWithValue("@LanKhoiDongGanNhat", bootTime);
                cmd.Parameters.AddWithValue("@MaMay", computerId);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public string GetComputerStateINMAYTINH(string computerId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                string rs = "";
                conn.Open();
                string sql = "SELECT TrangThaiMay FROM MAYTINH WHERE MaMay = @MaMay";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMay", computerId);
                rs = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return rs;
            }
        }

        public bool RemoveUserFromNGUOICHOI(string userAccountId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
            {
                int i = 0;
                conn.Open();
                string sql = "DELETE FROM NGUOICHOI WHERE MaNguoiChoi = @MaNguoiChoi";
                var cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaNguoiChoi", userAccountId);
                i = cmd.ExecuteNonQuery();
                conn.Close();
                return i > 0;
            }
        }

        public bool RemoveNhomFROMNHOMNGUOIDUNG(string maNhomNguoiDung)
        {
            using (SQLiteConnection conn = new SQLiteConnection(_createDBSQL))
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
