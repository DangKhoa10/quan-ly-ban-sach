
namespace QuanLyMuaBanSach.GUI
{
    partial class frmNVChiTietPhieuDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNVChiTietPhieuDat));
            this.grbDSSP = new System.Windows.Forms.GroupBox();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.dtmNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuDat = new System.Windows.Forms.TextBox();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.lblMaPhieuDat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTextTongTien = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.prdHoaDon = new System.Drawing.Printing.PrintDocument();
            this.ppdHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.btnXoaPhieuDat = new System.Windows.Forms.Button();
            this.grbDSSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDSSP
            // 
            this.grbDSSP.Controls.Add(this.dgvDSSP);
            this.grbDSSP.Location = new System.Drawing.Point(10, 206);
            this.grbDSSP.Name = "grbDSSP";
            this.grbDSSP.Size = new System.Drawing.Size(720, 279);
            this.grbDSSP.TabIndex = 40;
            this.grbDSSP.TabStop = false;
            this.grbDSSP.Text = "Danh Sách Các Sản Phẩm";
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Location = new System.Drawing.Point(15, 38);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.Size = new System.Drawing.Size(687, 223);
            this.dgvDSSP.TabIndex = 1;
            // 
            // dtmNgayDat
            // 
            this.dtmNgayDat.Location = new System.Drawing.Point(446, 66);
            this.dtmNgayDat.Name = "dtmNgayDat";
            this.dtmNgayDat.Size = new System.Drawing.Size(266, 24);
            this.dtmNgayDat.TabIndex = 39;
            // 
            // txtMaPhieuDat
            // 
            this.txtMaPhieuDat.Enabled = false;
            this.txtMaPhieuDat.Location = new System.Drawing.Point(147, 68);
            this.txtMaPhieuDat.Name = "txtMaPhieuDat";
            this.txtMaPhieuDat.Size = new System.Drawing.Size(206, 24);
            this.txtMaPhieuDat.TabIndex = 38;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(374, 71);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(66, 18);
            this.lblNgayDat.TabIndex = 36;
            this.lblNgayDat.Text = "Ngày đặt";
            // 
            // lblMaPhieuDat
            // 
            this.lblMaPhieuDat.AutoSize = true;
            this.lblMaPhieuDat.Location = new System.Drawing.Point(29, 71);
            this.lblMaPhieuDat.Name = "lblMaPhieuDat";
            this.lblMaPhieuDat.Size = new System.Drawing.Size(92, 18);
            this.lblMaPhieuDat.TabIndex = 37;
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
            this.label1.Size = new System.Drawing.Size(739, 47);
            this.label1.TabIndex = 35;
            this.label1.Text = "Chi Tiết Phiếu Đặt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTongTien.Location = new System.Drawing.Point(260, 172);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(270, 31);
            this.lblTongTien.TabIndex = 43;
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextTongTien
            // 
            this.lblTextTongTien.AutoSize = true;
            this.lblTextTongTien.Location = new System.Drawing.Point(177, 177);
            this.lblTextTongTien.Name = "lblTextTongTien";
            this.lblTextTongTien.Size = new System.Drawing.Size(69, 18);
            this.lblTextTongTien.TabIndex = 42;
            this.lblTextTongTien.Text = "Tổng tiền";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(593, 491);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 40);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(29, 111);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(113, 18);
            this.lblTenKhachHang.TabIndex = 37;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(373, 111);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(94, 18);
            this.lblSDT.TabIndex = 36;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Location = new System.Drawing.Point(147, 108);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(206, 24);
            this.txtTenKhachHang.TabIndex = 38;
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(473, 105);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(239, 24);
            this.txtSDT.TabIndex = 38;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Aqua;
            this.btnThanhToan.Location = new System.Drawing.Point(468, 491);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(119, 40);
            this.btnThanhToan.TabIndex = 41;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // prdHoaDon
            // 
            this.prdHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prdHoaDon_PrintPage);
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
            // btnXoaPhieuDat
            // 
            this.btnXoaPhieuDat.BackColor = System.Drawing.Color.Aqua;
            this.btnXoaPhieuDat.Location = new System.Drawing.Point(343, 491);
            this.btnXoaPhieuDat.Name = "btnXoaPhieuDat";
            this.btnXoaPhieuDat.Size = new System.Drawing.Size(119, 40);
            this.btnXoaPhieuDat.TabIndex = 44;
            this.btnXoaPhieuDat.Text = "Xóa Phiếu";
            this.btnXoaPhieuDat.UseVisualStyleBackColor = false;
            this.btnXoaPhieuDat.Click += new System.EventHandler(this.btnXoaPhieuDat_Click);
            // 
            // frmNVChiTietPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(739, 543);
            this.Controls.Add(this.btnXoaPhieuDat);
            this.Controls.Add(this.grbDSSP);
            this.Controls.Add(this.dtmNgayDat);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtMaPhieuDat);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblNgayDat);
            this.Controls.Add(this.lblMaPhieuDat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTextTongTien);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNVChiTietPhieuDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu đặt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNVChiTietPhieuDat_FormClosing);
            this.Load += new System.EventHandler(this.frmNVChiTietPhieuDat_Load);
            this.grbDSSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSSP;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.DateTimePicker dtmNgayDat;
        private System.Windows.Forms.TextBox txtMaPhieuDat;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblMaPhieuDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTextTongTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Drawing.Printing.PrintDocument prdHoaDon;
        private System.Windows.Forms.PrintPreviewDialog ppdHoaDon;
        private System.Windows.Forms.Button btnXoaPhieuDat;
    }
}