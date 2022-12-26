
namespace QuanLyMuaBanSach.GUI
{
    partial class frmThongTinKhachHang
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
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnDoiThongTin = new System.Windows.Forms.Button();
            this.lblThongTinKH = new System.Windows.Forms.Label();
            this.dgvDanhSachDonDaDat = new System.Windows.Forms.DataGridView();
            this.lblDanhSachPhieuDat = new System.Windows.Forms.Label();
            this.btnChiTietPhieuDat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuyDonDat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonDaDat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(753, 85);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(57, 18);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Họ Tên";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(830, 82);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(437, 24);
            this.txtTen.TabIndex = 1;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.Aqua;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(294, 209);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(233, 41);
            this.btnDoiMatKhau.TabIndex = 4;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(98, 85);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(111, 18);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Location = new System.Drawing.Point(230, 82);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(437, 24);
            this.txtTenDangNhap.TabIndex = 0;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(98, 149);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(102, 18);
            this.lblSoDienThoai.TabIndex = 0;
            this.lblSoDienThoai.Text = "Số Điện Thoại";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Enabled = false;
            this.txtSoDienThoai.Location = new System.Drawing.Point(230, 146);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(437, 24);
            this.txtSoDienThoai.TabIndex = 2;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(753, 149);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(56, 18);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(830, 146);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(437, 24);
            this.txtDiaChi.TabIndex = 3;
            // 
            // btnDoiThongTin
            // 
            this.btnDoiThongTin.BackColor = System.Drawing.Color.Aqua;
            this.btnDoiThongTin.Location = new System.Drawing.Point(598, 209);
            this.btnDoiThongTin.Name = "btnDoiThongTin";
            this.btnDoiThongTin.Size = new System.Drawing.Size(233, 41);
            this.btnDoiThongTin.TabIndex = 5;
            this.btnDoiThongTin.Text = "Đổi Thông Tin Cá Nhân";
            this.btnDoiThongTin.UseVisualStyleBackColor = false;
            this.btnDoiThongTin.Click += new System.EventHandler(this.btnDoiThongTin_Click);
            // 
            // lblThongTinKH
            // 
            this.lblThongTinKH.BackColor = System.Drawing.Color.Aqua;
            this.lblThongTinKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTinKH.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinKH.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinKH.Location = new System.Drawing.Point(0, 0);
            this.lblThongTinKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTinKH.Name = "lblThongTinKH";
            this.lblThongTinKH.Size = new System.Drawing.Size(1284, 44);
            this.lblThongTinKH.TabIndex = 3;
            this.lblThongTinKH.Text = "Thông Tin Khách Hàng";
            this.lblThongTinKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDanhSachDonDaDat
            // 
            this.dgvDanhSachDonDaDat.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachDonDaDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDonDaDat.Location = new System.Drawing.Point(101, 305);
            this.dgvDanhSachDonDaDat.Name = "dgvDanhSachDonDaDat";
            this.dgvDanhSachDonDaDat.Size = new System.Drawing.Size(1166, 266);
            this.dgvDanhSachDonDaDat.TabIndex = 6;
            this.dgvDanhSachDonDaDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDonDaDat_CellClick);
            // 
            // lblDanhSachPhieuDat
            // 
            this.lblDanhSachPhieuDat.AutoSize = true;
            this.lblDanhSachPhieuDat.Location = new System.Drawing.Point(98, 275);
            this.lblDanhSachPhieuDat.Name = "lblDanhSachPhieuDat";
            this.lblDanhSachPhieuDat.Size = new System.Drawing.Size(187, 18);
            this.lblDanhSachPhieuDat.TabIndex = 7;
            this.lblDanhSachPhieuDat.Text = "Danh Sách Phiếu Đặt Sách";
            // 
            // btnChiTietPhieuDat
            // 
            this.btnChiTietPhieuDat.BackColor = System.Drawing.Color.Aqua;
            this.btnChiTietPhieuDat.Location = new System.Drawing.Point(1116, 252);
            this.btnChiTietPhieuDat.Name = "btnChiTietPhieuDat";
            this.btnChiTietPhieuDat.Size = new System.Drawing.Size(151, 41);
            this.btnChiTietPhieuDat.TabIndex = 5;
            this.btnChiTietPhieuDat.Text = "Chi Tiết Phiếu Đặt";
            this.btnChiTietPhieuDat.UseVisualStyleBackColor = false;
            this.btnChiTietPhieuDat.Click += new System.EventHandler(this.btnChiTietDonDat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(1142, 600);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 41);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuyDonDat
            // 
            this.btnHuyDonDat.BackColor = System.Drawing.Color.Aqua;
            this.btnHuyDonDat.Location = new System.Drawing.Point(964, 252);
            this.btnHuyDonDat.Name = "btnHuyDonDat";
            this.btnHuyDonDat.Size = new System.Drawing.Size(137, 41);
            this.btnHuyDonDat.TabIndex = 8;
            this.btnHuyDonDat.Text = "Hủy đơn đặt";
            this.btnHuyDonDat.UseVisualStyleBackColor = false;
            this.btnHuyDonDat.Click += new System.EventHandler(this.btnHuyDonDat_Click);
            // 
            // frmThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 671);
            this.Controls.Add(this.btnHuyDonDat);
            this.Controls.Add(this.lblDanhSachPhieuDat);
            this.Controls.Add(this.dgvDanhSachDonDaDat);
            this.Controls.Add(this.lblThongTinKH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChiTietPhieuDat);
            this.Controls.Add(this.btnDoiThongTin);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongTinKhachHang";
            this.Text = "Thông tin khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongTinKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmThongTinKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDonDaDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnDoiThongTin;
        private System.Windows.Forms.Label lblThongTinKH;
        private System.Windows.Forms.DataGridView dgvDanhSachDonDaDat;
        private System.Windows.Forms.Label lblDanhSachPhieuDat;
        private System.Windows.Forms.Button btnChiTietPhieuDat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuyDonDat;
    }
}