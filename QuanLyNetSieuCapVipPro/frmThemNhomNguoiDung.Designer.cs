namespace QuanLyNetSieuCapVipPro
{
    partial class frmThemNhomNguoiDung
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
            txtMaNhom = new TextBox();
            label4 = new Label();
            btnSua = new Button();
            btnThoat = new Button();
            btnDongY = new Button();
            txtGia = new TextBox();
            label2 = new Label();
            txtTenNhom = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtMaNhom
            // 
            txtMaNhom.Location = new Point(173, 28);
            txtMaNhom.Name = "txtMaNhom";
            txtMaNhom.Size = new Size(370, 33);
            txtMaNhom.TabIndex = 10;
            txtMaNhom.Leave += txtMaNhom_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 31);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 20;
            label4.Text = "Mã nhóm";
            // 
            // btnSua
            // 
            btnSua.Enabled = false;
            btnSua.Location = new Point(236, 200);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 40);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Visible = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(340, 200);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 40);
            btnThoat.TabIndex = 19;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDongY
            // 
            btnDongY.Enabled = false;
            btnDongY.Location = new Point(236, 200);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(98, 40);
            btnDongY.TabIndex = 18;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Visible = false;
            btnDongY.Click += btnDongY_Click;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(173, 144);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(370, 33);
            txtGia.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 147);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 14;
            label2.Text = "Giá (đồng):";
            // 
            // txtTenNhom
            // 
            txtTenNhom.Location = new Point(173, 83);
            txtTenNhom.Name = "txtTenNhom";
            txtTenNhom.Size = new Size(370, 33);
            txtTenNhom.TabIndex = 12;
            txtTenNhom.Leave += txtTenNhom_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 89);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 11;
            label1.Text = "Tên";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmThemNhomNguoiDung
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(249, 232, 217);
            ClientSize = new Size(599, 256);
            Controls.Add(txtMaNhom);
            Controls.Add(label4);
            Controls.Add(btnSua);
            Controls.Add(btnThoat);
            Controls.Add(btnDongY);
            Controls.Add(txtGia);
            Controls.Add(label2);
            Controls.Add(txtTenNhom);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmThemNhomNguoiDung";
            Text = "frmThemNhomNguoiDung";
            Load += frmThemNhomNguoiDung_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaNhom;
        private Label label4;
        private Button btnSua;
        private Button btnThoat;
        private Button btnDongY;
        private TextBox txtGia;
        private Label label2;
        private TextBox txtTenNhom;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}