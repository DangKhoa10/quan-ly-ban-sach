
namespace QuanLyMuaBanSach.GUI
{
    partial class frmKhachHangTrongNgay
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
            this.grbDSSP = new System.Windows.Forms.GroupBox();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.txtMaPhieuDat = new System.Windows.Forms.TextBox();
            this.lblMaPhieuDat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblTextTongTien = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.grbDSSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDSSP
            // 
            this.grbDSSP.Controls.Add(this.dgvDSSP);
            this.grbDSSP.Location = new System.Drawing.Point(10, 193);
            this.grbDSSP.Name = "grbDSSP";
            this.grbDSSP.Size = new System.Drawing.Size(720, 263);
            this.grbDSSP.TabIndex = 53;
            this.grbDSSP.TabStop = false;
            this.grbDSSP.Text = "Danh sách phiếu đặt trong ngày";
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Location = new System.Drawing.Point(15, 26);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.Size = new System.Drawing.Size(687, 223);
            this.dgvDSSP.TabIndex = 1;
            this.dgvDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellClick);
            // 
            // txtMaPhieuDat
            // 
            this.txtMaPhieuDat.Enabled = false;
            this.txtMaPhieuDat.Location = new System.Drawing.Point(147, 67);
            this.txtMaPhieuDat.Name = "txtMaPhieuDat";
            this.txtMaPhieuDat.Size = new System.Drawing.Size(206, 24);
            this.txtMaPhieuDat.TabIndex = 49;
            // 
            // lblMaPhieuDat
            // 
            this.lblMaPhieuDat.AutoSize = true;
            this.lblMaPhieuDat.Location = new System.Drawing.Point(29, 70);
            this.lblMaPhieuDat.Name = "lblMaPhieuDat";
            this.lblMaPhieuDat.Size = new System.Drawing.Size(92, 18);
            this.lblMaPhieuDat.TabIndex = 47;
            this.lblMaPhieuDat.Text = "Mã phiếu đặt";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 47);
            this.label1.TabIndex = 44;
            this.label1.Text = "Phiếu đặt gần đây";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTongTien.Location = new System.Drawing.Point(266, 150);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(270, 31);
            this.lblTongTien.TabIndex = 57;
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(473, 64);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(239, 24);
            this.txtSDT.TabIndex = 50;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Location = new System.Drawing.Point(147, 107);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(206, 24);
            this.txtTenKhachHang.TabIndex = 51;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(375, 67);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(94, 18);
            this.lblSDT.TabIndex = 46;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(29, 110);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(113, 18);
            this.lblTenKhachHang.TabIndex = 48;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // lblTextTongTien
            // 
            this.lblTextTongTien.AutoSize = true;
            this.lblTextTongTien.Location = new System.Drawing.Point(191, 163);
            this.lblTextTongTien.Name = "lblTextTongTien";
            this.lblTextTongTien.Size = new System.Drawing.Size(69, 18);
            this.lblTextTongTien.TabIndex = 56;
            this.lblTextTongTien.Text = "Tổng tiền";
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.Aqua;
            this.btnChon.Location = new System.Drawing.Point(468, 462);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(119, 42);
            this.btnChon.TabIndex = 54;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(593, 462);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 42);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(375, 107);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(53, 18);
            this.lblDiaChi.TabIndex = 46;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(473, 104);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(239, 24);
            this.txtDiaChi.TabIndex = 50;
            // 
            // frmKhachHangTrongNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(736, 531);
            this.Controls.Add(this.grbDSSP);
            this.Controls.Add(this.txtMaPhieuDat);
            this.Controls.Add(this.lblMaPhieuDat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblTextTongTien);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhachHangTrongNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Đặt Trong Ngày";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHangTrongNgay_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachHangTrongNgay_Load);
            this.grbDSSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSSP;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.TextBox txtMaPhieuDat;
        private System.Windows.Forms.Label lblMaPhieuDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblTextTongTien;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
    }
}