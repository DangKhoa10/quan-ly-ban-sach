
namespace QuanLyMuaBanSach.GUI
{
    partial class frmDanhSachPhieuDat
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
            this.btnToanBo = new System.Windows.Forms.Button();
            this.dgvDSPhieuDat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grbLocPhieuDat = new System.Windows.Forms.GroupBox();
            this.lblLocPhieu = new System.Windows.Forms.Label();
            this.dtmLocNgay = new System.Windows.Forms.DateTimePicker();
            this.cboLocTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaPhieuDat = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblMaPhieuDat = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuDat)).BeginInit();
            this.grbLocPhieuDat.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToanBo
            // 
            this.btnToanBo.BackColor = System.Drawing.Color.Aqua;
            this.btnToanBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToanBo.Location = new System.Drawing.Point(851, 260);
            this.btnToanBo.Name = "btnToanBo";
            this.btnToanBo.Size = new System.Drawing.Size(190, 36);
            this.btnToanBo.TabIndex = 13;
            this.btnToanBo.Text = "Hiển thị toàn bộ";
            this.btnToanBo.UseVisualStyleBackColor = false;
            this.btnToanBo.Click += new System.EventHandler(this.btnToanBo_Click);
            // 
            // dgvDSPhieuDat
            // 
            this.dgvDSPhieuDat.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuDat.Location = new System.Drawing.Point(97, 305);
            this.dgvDSPhieuDat.Name = "dgvDSPhieuDat";
            this.dgvDSPhieuDat.Size = new System.Drawing.Size(1161, 280);
            this.dgvDSPhieuDat.TabIndex = 16;
            this.dgvDSPhieuDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieuDat_CellClick_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1284, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Danh Sách Phiếu Đặt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbLocPhieuDat
            // 
            this.grbLocPhieuDat.Controls.Add(this.lblLocPhieu);
            this.grbLocPhieuDat.Controls.Add(this.dtmLocNgay);
            this.grbLocPhieuDat.Controls.Add(this.cboLocTinhTrang);
            this.grbLocPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLocPhieuDat.Location = new System.Drawing.Point(97, 249);
            this.grbLocPhieuDat.Name = "grbLocPhieuDat";
            this.grbLocPhieuDat.Size = new System.Drawing.Size(738, 50);
            this.grbLocPhieuDat.TabIndex = 15;
            this.grbLocPhieuDat.TabStop = false;
            this.grbLocPhieuDat.Text = "Lọc phiếu đặt";
            // 
            // lblLocPhieu
            // 
            this.lblLocPhieu.AutoSize = true;
            this.lblLocPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocPhieu.Location = new System.Drawing.Point(6, 16);
            this.lblLocPhieu.Name = "lblLocPhieu";
            this.lblLocPhieu.Size = new System.Drawing.Size(153, 20);
            this.lblLocPhieu.TabIndex = 5;
            this.lblLocPhieu.Text = "Chọn ngày lập phiếu";
            // 
            // dtmLocNgay
            // 
            this.dtmLocNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmLocNgay.Location = new System.Drawing.Point(174, 16);
            this.dtmLocNgay.Name = "dtmLocNgay";
            this.dtmLocNgay.Size = new System.Drawing.Size(283, 26);
            this.dtmLocNgay.TabIndex = 4;
            this.dtmLocNgay.ValueChanged += new System.EventHandler(this.dtmLocNgay_ValueChanged);
            // 
            // cboLocTinhTrang
            // 
            this.cboLocTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTinhTrang.FormattingEnabled = true;
            this.cboLocTinhTrang.Location = new System.Drawing.Point(477, 16);
            this.cboLocTinhTrang.Name = "cboLocTinhTrang";
            this.cboLocTinhTrang.Size = new System.Drawing.Size(250, 28);
            this.cboLocTinhTrang.TabIndex = 3;
            this.cboLocTinhTrang.Text = "Lọc theo tình trang xử lí";
            this.cboLocTinhTrang.SelectedIndexChanged += new System.EventHandler(this.cboLocTinhTrang_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1119, 597);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 45);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.Aqua;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.Location = new System.Drawing.Point(1056, 260);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(202, 36);
            this.btnXemChiTiet.TabIndex = 17;
            this.btnXemChiTiet.Text = "Xem Chi Tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnTimKiem);
            this.groupBox7.Controls.Add(this.cboTinhTrang);
            this.groupBox7.Controls.Add(this.txtSDT);
            this.groupBox7.Controls.Add(this.txtTenKH);
            this.groupBox7.Controls.Add(this.txtMaKH);
            this.groupBox7.Controls.Add(this.txtMaPhieuDat);
            this.groupBox7.Controls.Add(this.lblSDT);
            this.groupBox7.Controls.Add(this.lblTenKH);
            this.groupBox7.Controls.Add(this.lblMaKH);
            this.groupBox7.Controls.Add(this.lblMaPhieuDat);
            this.groupBox7.Controls.Add(this.lblTinhTrang);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(97, 49);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1161, 173);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tìm phiếu đặt";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Aqua;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(939, 123);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(190, 36);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Đã xử lý",
            "Chưa xử lý"});
            this.cboTinhTrang.Location = new System.Drawing.Point(153, 128);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(387, 28);
            this.cboTinhTrang.TabIndex = 7;
            this.cboTinhTrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTinhTrang_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(742, 82);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(387, 26);
            this.txtSDT.TabIndex = 6;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(742, 34);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(387, 26);
            this.txtTenKH.TabIndex = 6;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(153, 83);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(387, 26);
            this.txtMaKH.TabIndex = 5;
            // 
            // txtMaPhieuDat
            // 
            this.txtMaPhieuDat.Location = new System.Drawing.Point(153, 34);
            this.txtMaPhieuDat.Name = "txtMaPhieuDat";
            this.txtMaPhieuDat.Size = new System.Drawing.Size(387, 26);
            this.txtMaPhieuDat.TabIndex = 4;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(584, 82);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(102, 20);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(584, 34);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(123, 20);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(7, 83);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(118, 20);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // lblMaPhieuDat
            // 
            this.lblMaPhieuDat.AutoSize = true;
            this.lblMaPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhieuDat.Location = new System.Drawing.Point(7, 40);
            this.lblMaPhieuDat.Name = "lblMaPhieuDat";
            this.lblMaPhieuDat.Size = new System.Drawing.Size(101, 20);
            this.lblMaPhieuDat.TabIndex = 0;
            this.lblMaPhieuDat.Text = "Mã phiếu đặt";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.Location = new System.Drawing.Point(7, 131);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(80, 20);
            this.lblTinhTrang.TabIndex = 1;
            this.lblTinhTrang.Text = "Tình trạng";
            // 
            // frmDanhSachPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.grbLocPhieuDat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnToanBo);
            this.Controls.Add(this.dgvDSPhieuDat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDanhSachPhieuDat";
            this.Text = "Danh Sách Phiếu Đặt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhSachPhieuDat_FormClosing);
            this.Load += new System.EventHandler(this.frmDanhSachPhieuDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuDat)).EndInit();
            this.grbLocPhieuDat.ResumeLayout(false);
            this.grbLocPhieuDat.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnToanBo;
        private System.Windows.Forms.DataGridView dgvDSPhieuDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbLocPhieuDat;
        private System.Windows.Forms.Label lblLocPhieu;
        private System.Windows.Forms.DateTimePicker dtmLocNgay;
        private System.Windows.Forms.ComboBox cboLocTinhTrang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaPhieuDat;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblMaPhieuDat;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboTinhTrang;
    }
}