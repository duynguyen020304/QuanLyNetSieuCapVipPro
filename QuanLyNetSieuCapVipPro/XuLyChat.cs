namespace QuanLyNetSieuCapVipPro
{
    class XuLyChat
    {
        public bool AdminToMayTinh(string tenAdmin, string userGuiTinNhan, string chat)
        {
            foreach (frmMayTinh item in frmManagement.instance.Maytram.lstFrmMayTinhBat)
            {
                if (item.Text == userGuiTinNhan)
                {
                    item._guiTinNhan.SyncChat(tenAdmin, chat);
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
