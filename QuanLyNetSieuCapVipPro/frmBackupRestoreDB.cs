using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNetSieuCapVipPro
{
    public partial class frmBackupRestoreDB : Form
    {
        private Database db = new Database();
        public frmBackupRestoreDB()
        {
            InitializeComponent();
        }

        private void btnBackupDB_Click(object sender, EventArgs e)
        {
            string pickDataBaseFrom = Environment.CurrentDirectory;
            string currentDBName = db.dbName;
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DateTime currentTime = DateTime.Now;
                    string backupDBName = "backupCSDLNet" + currentTime.Year.ToString() + "_" + currentTime.Month + "_" + currentTime.Day.ToString() + "_" +currentTime.Hour.ToString() + "_" + currentTime.Minute.ToString() + "_" + currentTime.Second.ToString();
                    var backupDatabaseTo = fbd.SelectedPath + "\\" + (Path.GetFileNameWithoutExtension(backupDBName) + ".db");
                    db.backUpDB(pickDataBaseFrom, currentDBName, backupDatabaseTo);
                }
            }
        }

        private void btnRestoreDB_Click(object sender, EventArgs e)
        {
        }
    }
}
