using System.Data;

namespace QuanLyNetSieuCapVipPro
{
    public partial class UserControlMayTram : UserControl
    {
        Database db = new Database();
        public UserControlMayTram()
        {
            InitializeComponent();
        }
        public void loadDgv()
        {
            DataTable dt = db.GetAllItemsFromMAYTINH().Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            while (dt.Rows.Count < 20)
            {
                dt.Rows.Add(dt.NewRow()); // Tạo một hàng mới và thêm nó vào DataTable
            }
            dataGridView1.DataSource = dt;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.Columns[0].HeaderText = "Mã máy";
            dataGridView1.Columns[1].HeaderText = "Lần khởi động gần nhất";
            dataGridView1.Columns[2].HeaderText = "Trạng thái máy";
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
    }
}
