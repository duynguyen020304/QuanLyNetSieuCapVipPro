using System.Data;

namespace QuanLyNetSieuCapVipPro
{
    public class MayTram
    {
        private Database db = new Database();
        public List<frmMayTinh> lstFrmMayTinhBat = new List<frmMayTinh>();
        public List<string> getmayTinh()
        {
            DataTable dt = db.GetAllItemsFromMAYTINH().Tables[0];
            List<string> items = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                items.Add(row["MaMay"].ToString());
            }
            return items;
        }

        public List<string> getMayTinhOnline()
        {
            DataTable dt = db.GetAllItemsFromMAYTINH().Tables[0];
            List<string> items = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                if (row["TrangThaiMay"].ToString() != "off")
                {
                    items.Add(row["MaMay"].ToString());
                }
            }
            return items;
        }

        public bool khoiDongMayTinhTuyChon(string maMayTinh)
        {
            if (db.GetComputerStateINMAYTINH(maMayTinh) == "on")
            {
                return false;
            }

            try
            {
                frmMayTinh item = new frmMayTinh(maMayTinh);
                lstFrmMayTinhBat.Add(item);
                DateTime now = new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day,
                    DateTime.Now.Hour,
                    DateTime.Now.Minute,
                    DateTime.Now.Second
                );
                db.UpdateItemInMAYTINH(maMayTinh, now, "on");
                item.Show();
                return true;
            }
            catch (Exception e)
            {
                return true;
            }
        }

        public bool tatMayTinhTuyChon(string userTatMayTinh)
        {
            foreach (frmMayTinh item in lstFrmMayTinhBat)
            {
                if (item.Text == userTatMayTinh)
                {
                    item.shutDown();
                    break;
                }
            }
            if (db.UpdateComputerStateInMAYTINH(userTatMayTinh, "off"))
            {
                return true;
            }
            return false;
        }

        public void tatToanBoMayTinh()
        {
            foreach (string item in getMayTinhOnline())
            {
                db.UpdateComputerStateInMAYTINH(item, "off");
            }
        }
    }
}
