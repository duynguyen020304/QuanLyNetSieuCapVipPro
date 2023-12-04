using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNetSieuCapVipPro
{
    public class MayTram
    {
        private Database db = new Database();
        public List<frmMayTinh> lstFrmMayTinhBat = new List<frmMayTinh>();
        public List<string> getmayTinh()
        {
            DataTable dt = db.getAllItemsFromMAYTINH().Tables[0];
            List<string> items = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                items.Add(row["MaMay"].ToString());
            }
            return items;
        }

        public List<string> getMayTinhOnline()
        {
            DataTable dt = db.getAllItemsFromMAYTINH().Tables[0];
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
            if (db.getComputerStateINMAYTINH(maMayTinh) == "on")
            {
                return false;
            }
            frmMayTinh item = new frmMayTinh(maMayTinh);
            lstFrmMayTinhBat.Add(item);
            db.modifiedComputerStateInMAYTINH(maMayTinh, "on");
            item.Show();
            return true;
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
            if (db.modifiedComputerStateInMAYTINH(userTatMayTinh, "off"))
            {
                return true;
            }
            return false;
        }

        public void tatToanBoMayTinh()
        {
            foreach (string item in getMayTinhOnline())
            {
                db.modifiedComputerStateInMAYTINH(item, "off");
            }
        }
    }
}
