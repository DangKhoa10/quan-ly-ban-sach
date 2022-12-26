
namespace QuanLyMuaBanSach.GUI
{
    partial class frmPhieuNhapSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhapSach));
            this.dtmNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.lblMaPhieuNhap = new System.Windows.Forms.Label();
            this.lblPhieuNhapSach = new System.Windows.Forms.Label();
            this.btnHuyPhieu = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTenTongTien = new System.Windows.Forms.Label();
            this.grbHanhDong = new System.Windows.Forms.GroupBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNhaXuatBan = new System.Windows.Forms.Label();
            this.lblThongTinPhieuNhap = new System.Windows.Forms.Label();
            this.lstvThongTinPhieu = new System.Windows.Forms.ListView();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.prdPhieuNhap = new System.Drawing.Printing.PrintDocument();
            this.ppdPhieuNhap = new System.Windows.Forms.PrintPreviewDialog();
            this.grbHanhDong.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtmNgayNhap
            // 
            this.dtmNgayNhap.Location = new System.Drawing.Point(549, 100);
            this.dtmNgayNhap.Name = "dtmNgayNhap";
            this.dtmNgayNhap.Size = new System.Drawing.Size(280, 24);
            this.dtmNgayNhap.TabIndex = 33;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(454, 103);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(78, 18);
            this.lblNgayNhap.TabIndex = 31;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(142, 100);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(265, 24);
            this.txtMaPhieuNhap.TabIndex = 30;
            // 
            // lblMaPhieuNhap
            // 
            this.lblMaPhieuNhap.AutoSize = true;
            this.lblMaPhieuNhap.Location = new System.Drawing.Point(22, 103);
            this.lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            this.lblMaPhieuNhap.Size = new System.Drawing.Size(104, 18);
            this.lblMaPhieuNhap.TabIndex = 29;
            this.lblMaPhieuNhap.Text = "Mã phiếu phập";
            // 
            // lblPhieuNhapSach
            // 
            this.lblPhieuNhapSach.BackColor = System.Drawing.Color.Aqua;
            this.lblPhieuNhapSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhieuNhapSach.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuNhapSach.ForeColor = System.Drawing.Color.Red;
            this.lblPhieuNhapSach.Location = new System.Drawing.Point(0, 0);
            this.lblPhieuNhapSach.Name = "lblPhieuNhapSach";
            this.lblPhieuNhapSach.Size = new System.Drawing.Size(863, 41);
            this.lblPhieuNhapSach.TabIndex = 28;
            this.lblPhieuNhapSach.Text = "Phiếu nhập sách";
            this.lblPhieuNhapSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHuyPhieu
            // 
            this.btnHuyPhieu.BackColor = System.Drawing.Color.Aqua;
            this.btnHuyPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhieu.Location = new System.Drawing.Point(15, 25);
            this.btnHuyPhieu.Name = "btnHuyPhieu";
            this.btnHuyPhieu.Size = new System.Drawing.Size(116, 37);
            this.btnHuyPhieu.TabIndex = 0;
            this.btnHuyPhieu.Text = "&Hủy Phiếu";
            this.btnHuyPhieu.UseVisualStyleBackColor = false;
            this.btnHuyPhieu.Click += new System.EventHandler(this.btnHuyPhieu_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Aqua;
            this.btnThanhToan.Location = new System.Drawing.Point(137, 25);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(116, 37);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTongTien.Location = new System.Drawing.Point(660, 434);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(169, 33);
            this.lblTongTien.TabIndex = 41;
            // 
            // lblTenTongTien
            // 
            this.lblTenTongTien.AutoSize = true;
            this.lblTenTongTien.Location = new System.Drawing.Point(579, 447);
            this.lblTenTongTien.Name = "lblTenTongTien";
            this.lblTenTongTien.Size = new System.Drawing.Size(74, 18);
            this.lblTenTongTien.TabIndex = 40;
            this.lblTenTongTien.Text = "Tổng Tiền";
            // 
            // grbHanhDong
            // 
            this.grbHanhDong.Controls.Add(this.btnHuyPhieu);
            this.grbHanhDong.Controls.Add(this.btnThanhToan);
            this.grbHanhDong.Location = new System.Drawing.Point(561, 485);
            this.grbHanhDong.Name = "grbHanhDong";
            this.grbHanhDong.Size = new System.Drawing.Size(268, 84);
            this.grbHanhDong.TabIndex = 39;
            this.grbHanhDong.TabStop = false;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(549, 134);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(280, 24);
            this.txtNhanVien.TabIndex = 38;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(459, 137);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(73, 18);
            this.lblNhanVien.TabIndex = 37;
            this.lblNhanVien.Text = "Nhân viên";
            // 
            // lblNhaXuatBan
            // 
            this.lblNhaXuatBan.AutoSize = true;
            this.lblNhaXuatBan.Location = new System.Drawing.Point(23, 137);
            this.lblNhaXuatBan.Name = "lblNhaXuatBan";
            this.lblNhaXuatBan.Size = new System.Drawing.Size(105, 18);
            this.lblNhaXuatBan.TabIndex = 36;
            this.lblNhaXuatBan.Text = "Nhà Cung Cấp";
            // 
            // lblThongTinPhieuNhap
            // 
            this.lblThongTinPhieuNhap.AutoSize = true;
            this.lblThongTinPhieuNhap.Location = new System.Drawing.Point(23, 178);
            this.lblThongTinPhieuNhap.Name = "lblThongTinPhieuNhap";
            this.lblThongTinPhieuNhap.Size = new System.Drawing.Size(144, 18);
            this.lblThongTinPhieuNhap.TabIndex = 35;
            this.lblThongTinPhieuNhap.Text = "Thông tin phiếu nhập";
            // 
            // lstvThongTinPhieu
            // 
            this.lstvThongTinPhieu.HideSelection = false;
            this.lstvThongTinPhieu.Location = new System.Drawing.Point(27, 201);
            this.lstvThongTinPhieu.Name = "lstvThongTinPhieu";
            this.lstvThongTinPhieu.Size = new System.Drawing.Size(803, 216);
            this.lstvThongTinPhieu.TabIndex = 34;
            this.lstvThongTinPhieu.UseCompatibleStateImageBehavior = false;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(142, 134);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(265, 24);
            this.txtNCC.TabIndex = 32;
            // 
            // prdPhieuNhap
            // 
            this.prdPhieuNhap.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prdPhieuNhap_PrintPage);
            // 
            // ppdPhieuNhap
            // 
            this.ppdPhieuNhap.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdPhieuNhap.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdPhieuNhap.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdPhieuNhap.Enabled = true;
            this.ppdPhieuNhap.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdPhieuNhap.Icon")));
            this.ppdPhieuNhap.Name = "printPreviewDialog1";
            this.ppdPhieuNhap.Visible = false;
            // 
            // frmPhieuNhapSach
            // 
            this.AcceptButton = this.btnThanhToan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(863, 585);
            this.Controls.Add(this.dtmNgayNhap);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.txtMaPhieuNhap);
            this.Controls.Add(this.lblMaPhieuNhap);
            this.Controls.Add(this.lblPhieuNhapSach);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTenTongTien);
            this.Controls.Add(this.grbHanhDong);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblNhaXuatBan);
            this.Controls.Add(this.lblThongTinPhieuNhap);
            this.Controls.Add(this.lstvThongTinPhieu);
            this.Controls.Add(this.txtNCC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuNhapSach_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuNhapSach_Load);
            this.grbHanhDong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtmNgayNhap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label lblMaPhieuNhap;
        private System.Windows.Forms.Label lblPhieuNhapSach;
        private System.Windows.Forms.Button btnHuyPhieu;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTenTongTien;
        private System.Windows.Forms.GroupBox grbHanhDong;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblNhaXuatBan;
        private System.Windows.Forms.Label lblThongTinPhieuNhap;
        private System.Windows.Forms.ListView lstvThongTinPhieu;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Drawing.Printing.PrintDocument prdPhieuNhap;
        private System.Windows.Forms.PrintPreviewDialog ppdPhieuNhap;
    }
}