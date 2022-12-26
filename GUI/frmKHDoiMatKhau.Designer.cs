
namespace QuanLyMuaBanSach.GUI
{
    partial class frmKHDoiMatKhau
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHienXNMK = new System.Windows.Forms.Button();
            this.btnHienMKMoi = new System.Windows.Forms.Button();
            this.btnHienMKCu = new System.Windows.Forms.Button();
            this.lblXacNhanMK = new System.Windows.Forms.Label();
            this.lblMKMoi = new System.Windows.Forms.Label();
            this.lblDoiMatKhau = new System.Windows.Forms.Label();
            this.lblMKCu = new System.Windows.Forms.Label();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Aqua;
            this.btnLuu.Location = new System.Drawing.Point(461, 292);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 49);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHienXNMK
            // 
            this.btnHienXNMK.BackColor = System.Drawing.Color.Aqua;
            this.btnHienXNMK.Location = new System.Drawing.Point(471, 234);
            this.btnHienXNMK.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienXNMK.Name = "btnHienXNMK";
            this.btnHienXNMK.Size = new System.Drawing.Size(99, 28);
            this.btnHienXNMK.TabIndex = 21;
            this.btnHienXNMK.Text = "Hiện";
            this.btnHienXNMK.UseVisualStyleBackColor = false;
            this.btnHienXNMK.Click += new System.EventHandler(this.btnHienXNMK_Click);
            // 
            // btnHienMKMoi
            // 
            this.btnHienMKMoi.BackColor = System.Drawing.Color.Aqua;
            this.btnHienMKMoi.Location = new System.Drawing.Point(471, 174);
            this.btnHienMKMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienMKMoi.Name = "btnHienMKMoi";
            this.btnHienMKMoi.Size = new System.Drawing.Size(99, 28);
            this.btnHienMKMoi.TabIndex = 22;
            this.btnHienMKMoi.Text = "Hiện";
            this.btnHienMKMoi.UseVisualStyleBackColor = false;
            this.btnHienMKMoi.Click += new System.EventHandler(this.btnHienMKMoi_Click);
            // 
            // btnHienMKCu
            // 
            this.btnHienMKCu.BackColor = System.Drawing.Color.Aqua;
            this.btnHienMKCu.Location = new System.Drawing.Point(471, 118);
            this.btnHienMKCu.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienMKCu.Name = "btnHienMKCu";
            this.btnHienMKCu.Size = new System.Drawing.Size(99, 28);
            this.btnHienMKCu.TabIndex = 23;
            this.btnHienMKCu.Text = "Hiện";
            this.btnHienMKCu.UseVisualStyleBackColor = false;
            this.btnHienMKCu.Click += new System.EventHandler(this.btnHienMKCu_Click);
            // 
            // lblXacNhanMK
            // 
            this.lblXacNhanMK.AutoSize = true;
            this.lblXacNhanMK.Location = new System.Drawing.Point(28, 238);
            this.lblXacNhanMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXacNhanMK.Name = "lblXacNhanMK";
            this.lblXacNhanMK.Size = new System.Drawing.Size(126, 18);
            this.lblXacNhanMK.TabIndex = 14;
            this.lblXacNhanMK.Text = "Nhập lại mật khẩu";
            // 
            // lblMKMoi
            // 
            this.lblMKMoi.AutoSize = true;
            this.lblMKMoi.Location = new System.Drawing.Point(28, 179);
            this.lblMKMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMKMoi.Name = "lblMKMoi";
            this.lblMKMoi.Size = new System.Drawing.Size(137, 18);
            this.lblMKMoi.TabIndex = 15;
            this.lblMKMoi.Text = "Nhập mật khẩu mới";
            // 
            // lblDoiMatKhau
            // 
            this.lblDoiMatKhau.BackColor = System.Drawing.Color.Aqua;
            this.lblDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.lblDoiMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoiMatKhau.Name = "lblDoiMatKhau";
            this.lblDoiMatKhau.Size = new System.Drawing.Size(596, 48);
            this.lblDoiMatKhau.TabIndex = 17;
            this.lblDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.lblDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMKCu
            // 
            this.lblMKCu.AutoSize = true;
            this.lblMKCu.Location = new System.Drawing.Point(28, 122);
            this.lblMKCu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMKCu.Name = "lblMKCu";
            this.lblMKCu.Size = new System.Drawing.Size(128, 18);
            this.lblMKCu.TabIndex = 16;
            this.lblMKCu.Text = "Nhập mật khẩu cũ";
            // 
            // txtMKCu
            // 
            this.txtMKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCu.Location = new System.Drawing.Point(173, 119);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(282, 26);
            this.txtMKCu.TabIndex = 18;
            this.txtMKCu.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMK.Location = new System.Drawing.Point(173, 235);
            this.txtXacNhanMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(282, 26);
            this.txtXacNhanMK.TabIndex = 19;
            this.txtXacNhanMK.UseSystemPasswordChar = true;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMoi.Location = new System.Drawing.Point(173, 175);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(282, 26);
            this.txtMKMoi.TabIndex = 20;
            this.txtMKMoi.UseSystemPasswordChar = true;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Aqua;
            this.btnHuy.Location = new System.Drawing.Point(346, 292);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 49);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmKHDoiMatKhau
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(596, 359);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHienXNMK);
            this.Controls.Add(this.btnHienMKMoi);
            this.Controls.Add(this.btnHienMKCu);
            this.Controls.Add(this.lblXacNhanMK);
            this.Controls.Add(this.lblMKMoi);
            this.Controls.Add(this.lblDoiMatKhau);
            this.Controls.Add(this.lblMKCu);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.txtXacNhanMK);
            this.Controls.Add(this.txtMKMoi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKHDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKHDoiMatKhau_FormClosing);
            this.Load += new System.EventHandler(this.frmKHDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHienXNMK;
        private System.Windows.Forms.Button btnHienMKMoi;
        private System.Windows.Forms.Button btnHienMKCu;
        private System.Windows.Forms.Label lblXacNhanMK;
        private System.Windows.Forms.Label lblMKMoi;
        private System.Windows.Forms.Label lblDoiMatKhau;
        private System.Windows.Forms.Label lblMKCu;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Button btnHuy;
    }
}