namespace QuanLyNetSieuCapVipPro
{
    class BackupRestoreDB
    {
        private Database _db = new Database();
        public void BackupDB()
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
                    _db.Backup(pickDataBaseFrom, "QuanLyNet123.db", backupDatabaseTo);
                    MessageBox.Show("Backup thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void RestoreDB()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string restoreDatabaseFrom = fileDialog.FileName;
                var restoreDatabaseTo = Environment.CurrentDirectory + "\\" + "QuanLyNet123.db";
                _db.Restore(restoreDatabaseFrom, restoreDatabaseTo);
                MessageBox.Show("Restore thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
