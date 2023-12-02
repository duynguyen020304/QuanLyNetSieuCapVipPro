namespace QuanLyNetSieuCapVipPro
{
    partial class frmBackupRestoreDB
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
            textBox1 = new TextBox();
            btnBackupDB = new Button();
            btnRestoreDB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 25);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 0;
            label1.Text = "Đường dẫn sao lưu CSDL";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 1;
            // 
            // btnBackupDB
            // 
            btnBackupDB.Location = new Point(68, 63);
            btnBackupDB.Name = "btnBackupDB";
            btnBackupDB.Size = new Size(108, 36);
            btnBackupDB.TabIndex = 2;
            btnBackupDB.Text = "Sao lưu CSDL";
            btnBackupDB.UseVisualStyleBackColor = true;
            btnBackupDB.Click += btnBackupDB_Click;
            // 
            // btnRestoreDB
            // 
            btnRestoreDB.Location = new Point(261, 63);
            btnRestoreDB.Name = "btnRestoreDB";
            btnRestoreDB.Size = new Size(114, 36);
            btnRestoreDB.TabIndex = 3;
            btnRestoreDB.Text = "Phục hồi CSDL";
            btnRestoreDB.UseVisualStyleBackColor = true;
            btnRestoreDB.Click += btnRestoreDB_Click;
            // 
            // frmBackupRestoreDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 111);
            Controls.Add(btnRestoreDB);
            Controls.Add(btnBackupDB);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBackupRestoreDB";
            Text = "frmBackupRestoreDB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnBackupDB;
        private Button btnRestoreDB;
    }
}