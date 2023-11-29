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
            label1 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtGia = new TextBox();
            txtDonVi = new TextBox();
            btnDongY = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 26);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(173, 23);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(370, 33);
            txtTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 87);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "Giá (đồng):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 148);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 3;
            label3.Text = "Đơn vị";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(173, 84);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(370, 33);
            txtGia.TabIndex = 4;
            // 
            // txtDonVi
            // 
            txtDonVi.Location = new Point(173, 145);
            txtDonVi.Name = "txtDonVi";
            txtDonVi.Size = new Size(370, 33);
            txtDonVi.TabIndex = 5;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(238, 199);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(98, 40);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(342, 199);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 40);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmThemDichVu
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 251);
            Controls.Add(btnThoat);
            Controls.Add(btnDongY);
            Controls.Add(txtDonVi);
            Controls.Add(txtGia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmThemDichVu";
            Text = "frmThemDichVu";
            FormClosing += frmThemDichVu_FormClosing;
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
    }
}