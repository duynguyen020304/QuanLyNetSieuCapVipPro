namespace QuanLyNetSieuCapVipPro
{
    partial class frmGuiTinNhan
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
            rtxtChat = new RichTextBox();
            txtChat = new TextBox();
            SuspendLayout();
            // 
            // rtxtChat
            // 
            rtxtChat.BackColor = Color.PapayaWhip;
            rtxtChat.Location = new Point(0, -1);
            rtxtChat.Margin = new Padding(0);
            rtxtChat.Name = "rtxtChat";
            rtxtChat.Size = new Size(422, 245);
            rtxtChat.TabIndex = 0;
            rtxtChat.Text = "";
            // 
            // txtChat
            // 
            txtChat.BackColor = SystemColors.HotTrack;
            txtChat.ForeColor = Color.Yellow;
            txtChat.Location = new Point(0, 247);
            txtChat.Name = "txtChat";
            txtChat.Size = new Size(422, 27);
            txtChat.TabIndex = 1;
            txtChat.KeyDown += txtChat_KeyDown;
            // 
            // frmGuiTinNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 278);
            Controls.Add(txtChat);
            Controls.Add(rtxtChat);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGuiTinNhan";
            Text = "frmGuiTinNhan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtxtChat;
        private TextBox txtChat;
    }
}