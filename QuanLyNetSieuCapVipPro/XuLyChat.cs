using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNetSieuCapVipPro
{
    class XuLyChat
    {
        public bool AdminToMayTinh(string tenAdmin, string userGuiTinNhan, string chat)
        {
            foreach (frmMayTinh item in frmManagement.instance.maytram.lstFrmMayTinhBat)
            {
                if (item.Text == userGuiTinNhan)
                {
                    item._guiTinNhan.syncChat(tenAdmin, chat);
                    return true;
                }
            }
            return false;
        }

        public void MayTinhToAdmin(string maMay, string chat)
        {
            frmManagement.instance.syncChat(maMay, chat);
        }
    }
}
