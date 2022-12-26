
namespace QuanLyMuaBanSach.GUI
{
    partial class frmTimKiemHoaDon
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnAllHD = new System.Windows.Forms.Button();
            this.grbLocHoaDon = new System.Windows.Forms.GroupBox();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.dtmLocTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.btnChiTietHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbLocHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Aqua;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1365, 44);
            this.lblTieuDe.TabIndex = 4;
            this.lblTieuDe.Text = "Tìm Kiếm Hóa Đơn";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.lblMaHD);
            this.groupBox1.Controls.Add(this.lblTenKH);
            this.groupBox1.Controls.Add(this.lblTenNV);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(99, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.AutoSize = true;
            this.txtMaNhanVien.Location = new System.Drawing.Point(3, 79);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(100, 18);
            this.txtMaNhanVien.TabIndex = 5;
            this.txtMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(795, 34);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(93, 18);
            this.lblMaHD.TabIndex = 5;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(383, 34);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(118, 18);
            this.lblTenKH.TabIndex = 5;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(3, 37);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(104, 18);
            this.lblTenNV.TabIndex = 5;
            this.lblTenNV.Text = "Tên Nhân Viên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(502, 73);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(274, 24);
            this.txtMaKH.TabIndex = 4;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(894, 31);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(274, 24);
            this.txtMaHD.TabIndex = 4;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(502, 31);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(274, 24);
            this.txtTenKH.TabIndex = 4;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(107, 76);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(274, 24);
            this.txtMaNV.TabIndex = 4;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(107, 34);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(274, 24);
            this.txtTenNV.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Aqua;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1014, 58);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(154, 55);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(1113, 568);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(162, 43);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnAllHD
            // 
            this.btnAllHD.BackColor = System.Drawing.Color.Aqua;
            this.btnAllHD.Location = new System.Drawing.Point(105, 200);
            this.btnAllHD.Name = "btnAllHD";
            this.btnAllHD.Size = new System.Drawing.Size(259, 43);
            this.btnAllHD.TabIndex = 11;
            this.btnAllHD.Text = "Hiển Thị Toàn Bộ Hóa Đơn";
            this.btnAllHD.UseVisualStyleBackColor = false;
            this.btnAllHD.Click += new System.EventHandler(this.btnAllHD_Click);
            // 
            // grbLocHoaDon
            // 
            this.grbLocHoaDon.Controls.Add(this.lblNgayLapHD);
            this.grbLocHoaDon.Controls.Add(this.dtmLocTheoNgay);
            this.grbLocHoaDon.Location = new System.Drawing.Point(370, 188);
            this.grbLocHoaDon.Name = "grbLocHoaDon";
            this.grbLocHoaDon.Size = new System.Drawing.Size(555, 59);
            this.grbLocHoaDon.TabIndex = 10;
            this.grbLocHoaDon.TabStop = false;
            this.grbLocHoaDon.Text = "Lọc hóa đơn";
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Location = new System.Drawing.Point(47, 24);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNgayLapHD.Size = new System.Drawing.Size(160, 18);
            this.lblNgayLapHD.TabIndex = 1;
            this.lblNgayLapHD.Text = "Chọn ngày lập hóa đơn";
            // 
            // dtmLocTheoNgay
            // 
            this.dtmLocTheoNgay.Location = new System.Drawing.Point(213, 21);
            this.dtmLocTheoNgay.Name = "dtmLocTheoNgay";
            this.dtmLocTheoNgay.Size = new System.Drawing.Size(322, 24);
            this.dtmLocTheoNgay.TabIndex = 0;
            this.dtmLocTheoNgay.ValueChanged += new System.EventHandler(this.dtmLocTheoNgay_ValueChanged);
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Location = new System.Drawing.Point(99, 253);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.Size = new System.Drawing.Size(1176, 309);
            this.dgvDSHD.TabIndex = 9;
            this.dgvDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellClick);
            // 
            // btnChiTietHoaDon
            // 
            this.btnChiTietHoaDon.BackColor = System.Drawing.Color.Aqua;
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(1016, 200);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(259, 43);
            this.btnChiTietHoaDon.TabIndex = 11;
            this.btnChiTietHoaDon.Text = "Xem chi tiết hóa đơn";
            this.btnChiTietHoaDon.UseVisualStyleBackColor = false;
            this.btnChiTietHoaDon.Click += new System.EventHandler(this.btnChiTietHoaDon_Click);
            // 
            // frmTimKiemHoaDon
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1365, 623);
            this.Controls.Add(this.btnChiTietHoaDon);
            this.Controls.Add(this.btnAllHD);
            this.Controls.Add(this.grbLocHoaDon);
            this.Controls.Add(this.dgvDSHD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKiemHoaDon";
            this.Text = "Tìm Kiếm Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbLocHoaDon.ResumeLayout(false);
            this.grbLocHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnAllHD;
        private System.Windows.Forms.GroupBox grbLocHoaDon;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.DateTimePicker dtmLocTheoNgay;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtMaNhanVien;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btnChiTietHoaDon;
    }
}