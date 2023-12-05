namespace QuanLyNetSieuCapVipPro
{
    partial class frmThemDichVu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtGia = new TextBox();
            txtDonVi = new TextBox();
            btnDongY = new Button();
            btnThoat = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnSua = new Button();
            label4 = new Label();
            txtMaDichVu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 104);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(173, 98);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(370, 33);
            txtTen.TabIndex = 1;
            txtTen.Leave += txtTen_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 162);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "Giá (đồng):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 223);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "Đơn vị";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(173, 159);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(370, 33);
            txtGia.TabIndex = 2;
            // 
            // txtDonVi
            // 
            txtDonVi.Location = new Point(173, 220);
            txtDonVi.Name = "txtDonVi";
            txtDonVi.Size = new Size(370, 33);
            txtDonVi.TabIndex = 3;
            // 
            // btnDongY
            // 
            btnDongY.Enabled = false;
            btnDongY.Location = new Point(245, 270);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(98, 40);
            btnDongY.TabIndex = 4;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Visible = false;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(349, 270);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 40);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Location = new Point(245, 270);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 40);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Visible = false;
            btnSua.Click += btnSua_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 46);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 9;
            label4.Text = "Mã dịch vụ";
            // 
            // txtMaDichVu
            // 
            txtMaDichVu.Location = new Point(173, 43);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.Size = new Size(370, 33);
            txtMaDichVu.TabIndex = 0;
            txtMaDichVu.Leave += txtMaDichVu_Leave;
            // 
            // frmThemDichVu
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 232, 217);
            ClientSize = new Size(599, 322);
            Controls.Add(txtMaDichVu);
            Controls.Add(label4);
            Controls.Add(btnSua);
            Controls.Add(btnThoat);
            Controls.Add(btnDongY);
            Controls.Add(txtDonVi);
            Controls.Add(txtGia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "frmThemDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemDichVu";
            Load += frmThemDichVu_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTen;
        private Label label2;
        private Label label3;
        private TextBox txtGia;
        private TextBox txtDonVi;
        private Button btnDongY;
        private Button btnThoat;
        private ErrorProvider errorProvider1;
        private Button btnSua;
        private TextBox txtMaDichVu;
        private Label label4;
    }
}