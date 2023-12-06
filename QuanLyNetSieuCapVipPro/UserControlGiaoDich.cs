using System.Data;

namespace QuanLyNetSieuCapVipPro
{
    public partial class UserControlGiaoDich : UserControl
    {
        private Database db = new Database();

        public static UserControlGiaoDich instance;
        public UserControlGiaoDich()
        {
            InitializeComponent();
            instance = this;
        }
        public void loadDgv()
        {
            DataTable dt = db.GetAllItemsFromLICHSUGIAODICH().Tables[0];
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            while (dt.Rows.Count < 20)
            {
                dt.Rows.Add(dt.NewRow()); // Tạo một hàng mới và thêm nó vào DataTable
            }
            dataGridView1.DataSource = dt;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.Columns[0].HeaderText = "Mã đơn hàng";
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].HeaderText = "Mã dịch vụ";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].HeaderText = "Người đặt";
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].HeaderText = "Thời gian đặt hàng";
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].HeaderText = "Nội dung đơn hàng";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[5].HeaderText = "Máy đặt";
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
