using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNetSieuCapVipPro
{
    class MayTram
    {
        private Database db = new Database();
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

        public bool tatMayTinhTuyChon(string userTatMayTinh, List<frmMayTinh> listFrmMayTinhBat)
        {
            bool isShutdownSuccess = false;
            foreach (frmMayTinh item in listFrmMayTinhBat)
            {
                if (item.Text == userTatMayTinh)
                {
                    item.shutDown();
                    isShutdownSuccess = true;
                    break;
                }
            }
            if (isShutdownSuccess && db.modifiedComputerStateInMAYTINH(userTatMayTinh, "off"))
            {
                return true;
            }
            return false;
        }
    }
}
