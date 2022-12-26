
namespace QuanLyMuaBanSach.GUI
{
    partial class frmDanhSachHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachHoaDon));
            this.lblLocNgayLapHD = new System.Windows.Forms.Label();
            this.dtmNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtmLocNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.btnHienThiToanBo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemCTHD = new System.Windows.Forms.Button();
            this.prdHoaDon = new System.Drawing.Printing.PrintDocument();
            this.ppdHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocNgayLapHD
            // 
            this.lblLocNgayLapHD.AutoSize = true;
            this.lblLocNgayLapHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocNgayLapHD.Location = new System.Drawing.Point(6, 22);
            this.lblLocNgayLapHD.Name = "lblLocNgayLapHD";
            this.lblLocNgayLapHD.Size = new System.Drawing.Size(132, 20);
            this.lblLocNgayLapHD.TabIndex = 0;
            this.lblLocNgayLapHD.Text = "Ngày lập hóa đơn";
            // 
            // dtmNgayLapHD
            // 
            this.dtmNgayLapHD.Location = new System.Drawing.Point(739, 38);
            this.dtmNgayLapHD.Name = "dtmNgayLapHD";
            this.dtmNgayLapHD.Size = new System.Drawing.Size(338, 26);
            this.dtmNgayLapHD.TabIndex = 9;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(739, 82);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(336, 26);
            this.txtTenNhanVien.TabIndex = 8;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(206, 82);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(341, 26);
            this.txtTenKhachHang.TabIndex = 6;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(206, 38);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(341, 26);
            this.txtMaHD.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên nhân viên";
            // 
            // dtmLocNgay
            // 
            this.dtmLocNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmLocNgay.Location = new System.Drawing.Point(145, 19);
            this.dtmLocNgay.Name = "dtmLocNgay";
            this.dtmLocNgay.Size = new System.Drawing.Size(314, 26);
            this.dtmLocNgay.TabIndex = 1;
            this.dtmLocNgay.ValueChanged += new System.EventHandler(this.dtmLocNgay_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtmLocNgay);
            this.groupBox2.Controls.Add(this.lblLocNgayLapHD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(101, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 57);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày lập hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Location = new System.Drawing.Point(71, 41);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(93, 20);
            this.lblMaHoaDon.TabIndex = 0;
            this.lblMaHoaDon.Text = "Mã hóa đơn";
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Location = new System.Drawing.Point(101, 332);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.Size = new System.Drawing.Size(1150, 262);
            this.dgvDSHD.TabIndex = 22;
            this.dgvDSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellClick);
            // 
            // btnHienThiToanBo
            // 
            this.btnHienThiToanBo.BackColor = System.Drawing.Color.Aqua;
            this.btnHienThiToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiToanBo.Location = new System.Drawing.Point(578, 270);
            this.btnHienThiToanBo.Name = "btnHienThiToanBo";
            this.btnHienThiToanBo.Size = new System.Drawing.Size(281, 38);
            this.btnHienThiToanBo.TabIndex = 19;
            this.btnHienThiToanBo.Text = "Hiển thị toàn bộ danh sách";
            this.btnHienThiToanBo.UseVisualStyleBackColor = false;
            this.btnHienThiToanBo.Click += new System.EventHandler(this.btnHienThiToanBo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtmNgayLapHD);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.lblMaNhanVien);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblMaKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMaHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(101, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 176);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(739, 126);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(336, 26);
            this.txtMaNV.TabIndex = 8;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(206, 126);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(341, 26);
            this.txtMaKH.TabIndex = 6;
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Location = new System.Drawing.Point(630, 129);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(109, 20);
            this.lblMaNhanVien.TabIndex = 4;
            this.lblMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(71, 129);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(118, 20);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1370, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh Sách Hóa Đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.BackColor = System.Drawing.Color.Aqua;
            this.btnXemCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemCTHD.Location = new System.Drawing.Point(1003, 274);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(248, 38);
            this.btnXemCTHD.TabIndex = 19;
            this.btnXemCTHD.Text = "Xem Chi Tiết Hóa Đơn";
            this.btnXemCTHD.UseVisualStyleBackColor = false;
            this.btnXemCTHD.Click += new System.EventHandler(this.btnXemCTHD_Click);
            // 
            // ppdHoaDon
            // 
            this.ppdHoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdHoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdHoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdHoaDon.Enabled = true;
            this.ppdHoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdHoaDon.Icon")));
            this.ppdHoaDon.Name = "ppdHoaDon";
            this.ppdHoaDon.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1112, 616);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 45);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDSHD);
            this.Controls.Add(this.btnXemCTHD);
            this.Controls.Add(this.btnHienThiToanBo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDanhSachHoaDon";
            this.Text = "Danh Sách Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhSachHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmDanhSachHoaDon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLocNgayLapHD;
        private System.Windows.Forms.DateTimePicker dtmNgayLapHD;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtmLocNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.Button btnHienThiToanBo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemCTHD;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblMaKH;
        private System.Drawing.Printing.PrintDocument prdHoaDon;
        private System.Windows.Forms.PrintPreviewDialog ppdHoaDon;
        private System.Windows.Forms.Button btnThoat;
    }
}