namespace QuanLyNetSieuCapVipPro
{
    partial class frmDatDichVu
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
            label2 = new Label();
            cboTenDichVu = new ComboBox();
            txtSoLuong = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnYeuCau = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 93);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Số lượng";
            // 
            // cboTenDichVu
            // 
            cboTenDichVu.FormattingEnabled = true;
            cboTenDichVu.Location = new Point(145, 27);
            cboTenDichVu.Name = "cboTenDichVu";
            cboTenDichVu.Size = new Size(155, 33);
            cboTenDichVu.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(145, 90);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(155, 33);
            txtSoLuong.TabIndex = 3;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(306, 90);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(36, 36);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(345, 90);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(36, 36);
            btnMinus.TabIndex = 5;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnYeuCau
            // 
            btnYeuCau.Location = new Point(288, 146);
            btnYeuCau.Name = "btnYeuCau";
            btnYeuCau.Size = new Size(93, 36);
            btnYeuCau.TabIndex = 6;
            btnYeuCau.Text = "Yêu cầu";
            btnYeuCau.UseVisualStyleBackColor = true;
            btnYeuCau.Click += btnYeuCau_Click;
            // 
            // frmDatDichVu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(249, 232, 217);
            ClientSize = new Size(412, 194);
            Controls.Add(btnYeuCau);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtSoLuong);
            Controls.Add(cboTenDichVu);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmDatDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDatDichVu";
            Load += frmDatDichVu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboTenDichVu;
        private TextBox txtSoLuong;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnYeuCau;
    }
}