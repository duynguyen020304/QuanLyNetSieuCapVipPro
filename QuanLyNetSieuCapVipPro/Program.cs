namespace QuanLyNetSieuCapVipPro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Database db = new Database();
            db.CreateDatabase();
            frmLogin login = new frmLogin();
            login.Show();
            Application.Run();
        }
    }
}