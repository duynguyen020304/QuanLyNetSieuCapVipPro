using System.Data;

namespace QuanLyNetSieuCapVipPro
{
    public partial class ThanhVien : UserControl
    {
        private string adminUserName;
        public ThanhVien()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void loadUserName(string adminUserName)
        {
            this.adminUserName = adminUserName;
        }

        private void ThanhVien_Load(object sender, EventArgs e)
        {
            adminUserName = frmManagement.instance.SendAdminAccountId;
            loadDgv();
        }

        public void loadDgv()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataTable dt = db.GetAllUserDataSetForThanhVien().Tables[0];

            //Thêm các hàng trống trực tiếp vào DataTable
            while (dt.Rows.Count < 20)
            {
                dt.Rows.Add(dt.NewRow()); // Tạo một hàng mới và thêm nó vào DataTable
            }

            dataGridView1.DataSource = dt; // Gán DataTable đã được thêm hàng trống vào làm DataSource
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex == -1) // Kiểm tra xem ô đó có phải là header không
            {
                SolidBrush myBrush = new SolidBrush(Color.FromArgb(199, 220, 167));
                e.Graphics.FillRectangle(myBrush, e.CellBounds); // Sử dụng Brushes để tô màu

                // Vẽ đường viền với thông số mặc định
                Pen gridLinePen = new Pen(this.dataGridView1.GridColor, (float)0.9); // Sử dụng màu và độ dày đường viền mặc định của DataGridView
                e.Graphics.DrawRectangle(gridLinePen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));

                e.PaintContent(e.CellBounds); // Vẽ nội dung của header
                e.Handled = true; // Đánh dấu sự kiện đã được xử lý
            }
        }

        private void xoa_mnst_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            db.RemoveUserFromNGUOICHOI(dataGridView1.Rows[i].Cells[0].Value.ToString());
            db.RemoveItemInTAIKHOAN_USER(dataGridView1.Rows[i].Cells[0].Value.ToString());
            loadDgv();
        }

        private void sua_mnst_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            frmThemThanhVien themThanhVien = new frmThemThanhVien(adminUserName, false, dataGridView1.Rows[i].Cells[0].Value.ToString());
            themThanhVien.ShowDialog();
            loadDgv();
        }

        private void them_mnst_Click(object sender, EventArgs e)
        {
            frmManagement.instance.themThanhVien_mnst_Click(sender, e);
        }
    }
}
