using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNetSieuCapVipPro
{
    class BackupRestoreDB
    {
        private Database db = new Database();
        public void backupDB()
        {
            string pickDataBaseFrom = Environment.CurrentDirectory;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DateTime currentTime = DateTime.Now;
                    string backupDBName = "backupCSDLNet" + currentTime.Year.ToString() + "_" + currentTime.Month + "_" + currentTime.Day.ToString() + "_" + currentTime.Hour.ToString() + "_" + currentTime.Minute.ToString() + "_" + currentTime.Second.ToString();
                    var backupDatabaseTo = fbd.SelectedPath + "\\" + (Path.GetFileNameWithoutExtension(backupDBName) + ".db");
                    db.backUpDB(pickDataBaseFrom, "QuanLyNet123.db", backupDatabaseTo);
                    MessageBox.Show("Backup thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void restoreDB()
        {
            OpenFileDialog opendiDialog = new OpenFileDialog();
            if (opendiDialog.ShowDialog() == DialogResult.OK)
            {
                string restoreDatabaseFrom = opendiDialog.FileName;
                var restoreDatabaseTo = Environment.CurrentDirectory + "\\" + "QuanLyNet123.db";
                db.restoreDB(restoreDatabaseFrom, restoreDatabaseTo);
                MessageBox.Show("Restore thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
