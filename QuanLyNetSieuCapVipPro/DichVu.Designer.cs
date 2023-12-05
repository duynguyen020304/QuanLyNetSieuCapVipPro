namespace QuanLyNetSieuCapVipPro
{
    partial class DichVu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            them_mnst = new ToolStripMenuItem();
            xoa_mnst = new ToolStripMenuItem();
            sua_mnst = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(985, 508);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { them_mnst, xoa_mnst, sua_mnst });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(105, 70);
            // 
            // them_mnst
            // 
            them_mnst.Name = "them_mnst";
            them_mnst.Size = new Size(104, 22);
            them_mnst.Text = "Thêm";
            them_mnst.Click += them_mnst_Click;
            // 
            // xoa_mnst
            // 
            xoa_mnst.Name = "xoa_mnst";
            xoa_mnst.Size = new Size(104, 22);
            xoa_mnst.Text = "Xoá";
            xoa_mnst.Click += xoa_mnst_Click;
            // 
            // sua_mnst
            // 
            sua_mnst.Name = "sua_mnst";
            sua_mnst.Size = new Size(104, 22);
            sua_mnst.Text = "Sửa";
            sua_mnst.Click += sua_mnst_Click;
            // 
            // DichVu
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DichVu";
            Size = new Size(985, 508);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xoa_mnst;
        private ToolStripMenuItem sua_mnst;
        private ToolStripMenuItem them_mnst;
    }
}
