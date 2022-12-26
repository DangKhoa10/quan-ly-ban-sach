
namespace QuanLyMuaBanSach.GUI
{
    partial class frmThongKeDoanhThu
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
            this.lblThongKeDoanhThu = new System.Windows.Forms.Label();
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.lblDanhSachHoaDon = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThanhChu = new System.Windows.Forms.Label();
            this.mtbNam = new System.Windows.Forms.MaskedTextBox();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtmDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtmTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.rdoTheoKhoangThoiGian = new System.Windows.Forms.RadioButton();
            this.lblNhapNgay = new System.Windows.Forms.Label();
            this.rdoNgay = new System.Windows.Forms.RadioButton();
            this.dtmOneDay = new System.Windows.Forms.DateTimePicker();
            this.lblNhapThangNam = new System.Windows.Forms.Label();
            this.rdoThang = new System.Windows.Forms.RadioButton();
            this.mtbThangNam = new System.Windows.Forms.MaskedTextBox();
            this.lblNhapNam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNhanVien = new System.Windows.Forms.CheckBox();
            this.lblChonNV = new System.Windows.Forms.Label();
            this.cboTenNhanVien = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongKeDoanhThu
            // 
            this.lblThongKeDoanhThu.BackColor = System.Drawing.Color.Aqua;
            this.lblThongKeDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongKeDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblThongKeDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.lblThongKeDoanhThu.Name = "lblThongKeDoanhThu";
            this.lblThongKeDoanhThu.Size = new System.Drawing.Size(1245, 37);
            this.lblThongKeDoanhThu.TabIndex = 19;
            this.lblThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            this.lblThongKeDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Location = new System.Drawing.Point(114, 213);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.Size = new System.Drawing.Size(1099, 267);
            this.dgvDSHoaDon.TabIndex = 17;
            // 
            // lblDanhSachHoaDon
            // 
            this.lblDanhSachHoaDon.AutoSize = true;
            this.lblDanhSachHoaDon.Location = new System.Drawing.Point(111, 274);
            this.lblDanhSachHoaDon.Name = "lblDanhSachHoaDon";
            this.lblDanhSachHoaDon.Size = new System.Drawing.Size(202, 18);
            this.lblDanhSachHoaDon.TabIndex = 22;
            this.lblDanhSachHoaDon.Text = "Danh Sách Hóa Đơn Đã Xuất";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Aqua;
            this.btnThongKe.Location = new System.Drawing.Point(1057, 149);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(156, 46);
            this.btnThongKe.TabIndex = 21;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(1057, 593);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 49);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTongTien.Location = new System.Drawing.Point(198, 495);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(576, 33);
            this.lblTongTien.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Thành chữ";
            // 
            // lblThanhChu
            // 
            this.lblThanhChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblThanhChu.Location = new System.Drawing.Point(198, 538);
            this.lblThanhChu.Name = "lblThanhChu";
            this.lblThanhChu.Size = new System.Drawing.Size(576, 31);
            this.lblThanhChu.TabIndex = 27;
            // 
            // mtbNam
            // 
            this.mtbNam.Enabled = false;
            this.mtbNam.Location = new System.Drawing.Point(102, 47);
            this.mtbNam.Mask = "0000";
            this.mtbNam.Name = "mtbNam";
            this.mtbNam.Size = new System.Drawing.Size(39, 24);
            this.mtbNam.TabIndex = 43;
            this.mtbNam.ValidatingType = typeof(System.DateTime);
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(23, 17);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(93, 22);
            this.rdoNam.TabIndex = 48;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Theo năm";
            this.rdoNam.UseVisualStyleBackColor = true;
            this.rdoNam.CheckedChanged += new System.EventHandler(this.rdoNam_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtmDenNgay);
            this.groupBox4.Controls.Add(this.dtmTuNgay);
            this.groupBox4.Controls.Add(this.lblTuNgay);
            this.groupBox4.Controls.Add(this.lblDenNgay);
            this.groupBox4.Controls.Add(this.rdoTheoKhoangThoiGian);
            this.groupBox4.Controls.Add(this.lblNhapNgay);
            this.groupBox4.Controls.Add(this.rdoNgay);
            this.groupBox4.Controls.Add(this.dtmOneDay);
            this.groupBox4.Controls.Add(this.lblNhapThangNam);
            this.groupBox4.Controls.Add(this.rdoThang);
            this.groupBox4.Controls.Add(this.mtbThangNam);
            this.groupBox4.Controls.Add(this.lblNhapNam);
            this.groupBox4.Controls.Add(this.rdoNam);
            this.groupBox4.Controls.Add(this.mtbNam);
            this.groupBox4.Location = new System.Drawing.Point(277, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(936, 79);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            // 
            // dtmDenNgay
            // 
            this.dtmDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtmDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmDenNgay.Location = new System.Drawing.Point(826, 44);
            this.dtmDenNgay.Name = "dtmDenNgay";
            this.dtmDenNgay.Size = new System.Drawing.Size(91, 24);
            this.dtmDenNgay.TabIndex = 57;
            // 
            // dtmTuNgay
            // 
            this.dtmTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtmTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmTuNgay.Location = new System.Drawing.Point(649, 44);
            this.dtmTuNgay.Name = "dtmTuNgay";
            this.dtmTuNgay.Size = new System.Drawing.Size(92, 24);
            this.dtmTuNgay.TabIndex = 56;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(580, 49);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(63, 18);
            this.lblTuNgay.TabIndex = 59;
            this.lblTuNgay.Text = "Từ Ngày";
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(747, 49);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(73, 18);
            this.lblDenNgay.TabIndex = 58;
            this.lblDenNgay.Text = "Đến Ngày";
            // 
            // rdoTheoKhoangThoiGian
            // 
            this.rdoTheoKhoangThoiGian.AutoSize = true;
            this.rdoTheoKhoangThoiGian.Location = new System.Drawing.Point(583, 16);
            this.rdoTheoKhoangThoiGian.Name = "rdoTheoKhoangThoiGian";
            this.rdoTheoKhoangThoiGian.Size = new System.Drawing.Size(235, 22);
            this.rdoTheoKhoangThoiGian.TabIndex = 60;
            this.rdoTheoKhoangThoiGian.TabStop = true;
            this.rdoTheoKhoangThoiGian.Text = "Theo khoảng thời gian nhất định";
            this.rdoTheoKhoangThoiGian.UseVisualStyleBackColor = true;
            this.rdoTheoKhoangThoiGian.CheckedChanged += new System.EventHandler(this.rdoTheoKhoangThoiGian_CheckedChanged);
            // 
            // lblNhapNgay
            // 
            this.lblNhapNgay.AutoSize = true;
            this.lblNhapNgay.Location = new System.Drawing.Point(366, 49);
            this.lblNhapNgay.Name = "lblNhapNgay";
            this.lblNhapNgay.Size = new System.Drawing.Size(79, 18);
            this.lblNhapNgay.TabIndex = 55;
            this.lblNhapNgay.Text = "Chọn ngày";
            // 
            // rdoNgay
            // 
            this.rdoNgay.AutoSize = true;
            this.rdoNgay.Location = new System.Drawing.Point(369, 17);
            this.rdoNgay.Name = "rdoNgay";
            this.rdoNgay.Size = new System.Drawing.Size(95, 22);
            this.rdoNgay.TabIndex = 54;
            this.rdoNgay.TabStop = true;
            this.rdoNgay.Text = "Theo ngày";
            this.rdoNgay.UseVisualStyleBackColor = true;
            this.rdoNgay.CheckedChanged += new System.EventHandler(this.rdoNgay_CheckedChanged);
            // 
            // dtmOneDay
            // 
            this.dtmOneDay.CustomFormat = "dd/MM/yyyy";
            this.dtmOneDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmOneDay.Location = new System.Drawing.Point(461, 44);
            this.dtmOneDay.Name = "dtmOneDay";
            this.dtmOneDay.Size = new System.Drawing.Size(94, 24);
            this.dtmOneDay.TabIndex = 53;
            // 
            // lblNhapThangNam
            // 
            this.lblNhapThangNam.AutoSize = true;
            this.lblNhapThangNam.Location = new System.Drawing.Point(160, 50);
            this.lblNhapThangNam.Name = "lblNhapThangNam";
            this.lblNhapThangNam.Size = new System.Drawing.Size(116, 18);
            this.lblNhapThangNam.TabIndex = 52;
            this.lblNhapThangNam.Text = "Nhập tháng năm";
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.Location = new System.Drawing.Point(163, 17);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Size = new System.Drawing.Size(100, 22);
            this.rdoThang.TabIndex = 51;
            this.rdoThang.TabStop = true;
            this.rdoThang.Text = "Theo tháng";
            this.rdoThang.UseVisualStyleBackColor = true;
            this.rdoThang.CheckedChanged += new System.EventHandler(this.rdoThang_CheckedChanged);
            // 
            // mtbThangNam
            // 
            this.mtbThangNam.Location = new System.Drawing.Point(282, 47);
            this.mtbThangNam.Mask = "00/0000";
            this.mtbThangNam.Name = "mtbThangNam";
            this.mtbThangNam.Size = new System.Drawing.Size(61, 24);
            this.mtbThangNam.TabIndex = 50;
            this.mtbThangNam.ValidatingType = typeof(System.DateTime);
            // 
            // lblNhapNam
            // 
            this.lblNhapNam.AutoSize = true;
            this.lblNhapNam.Enabled = false;
            this.lblNhapNam.Location = new System.Drawing.Point(20, 50);
            this.lblNhapNam.Name = "lblNhapNam";
            this.lblNhapNam.Size = new System.Drawing.Size(76, 18);
            this.lblNhapNam.TabIndex = 49;
            this.lblNhapNam.Text = "Nhập năm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNhanVien);
            this.groupBox1.Controls.Add(this.lblChonNV);
            this.groupBox1.Controls.Add(this.cboTenNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(546, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 79);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // chkNhanVien
            // 
            this.chkNhanVien.AutoSize = true;
            this.chkNhanVien.Location = new System.Drawing.Point(129, 13);
            this.chkNhanVien.Name = "chkNhanVien";
            this.chkNhanVien.Size = new System.Drawing.Size(194, 22);
            this.chkNhanVien.TabIndex = 47;
            this.chkNhanVien.Text = "Doanh thu theo nhân viên";
            this.chkNhanVien.UseVisualStyleBackColor = true;
            this.chkNhanVien.CheckedChanged += new System.EventHandler(this.chkNhanVien_CheckedChanged);
            // 
            // lblChonNV
            // 
            this.lblChonNV.AutoSize = true;
            this.lblChonNV.Enabled = false;
            this.lblChonNV.Location = new System.Drawing.Point(13, 44);
            this.lblChonNV.Name = "lblChonNV";
            this.lblChonNV.Size = new System.Drawing.Size(110, 18);
            this.lblChonNV.TabIndex = 46;
            this.lblChonNV.Text = "Chọn nhân viên";
            // 
            // cboTenNhanVien
            // 
            this.cboTenNhanVien.Enabled = false;
            this.cboTenNhanVien.FormattingEnabled = true;
            this.cboTenNhanVien.Location = new System.Drawing.Point(129, 41);
            this.cboTenNhanVien.Name = "cboTenNhanVien";
            this.cboTenNhanVien.Size = new System.Drawing.Size(364, 26);
            this.cboTenNhanVien.TabIndex = 45;
            this.cboTenNhanVien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTenNhanVien_KeyPress);
            // 
            // frmThongKeDoanhThu
            // 
            this.AcceptButton = this.btnThongKe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1245, 683);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThanhChu);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblThongKeDoanhThu);
            this.Controls.Add(this.dgvDSHoaDon);
            this.Controls.Add(this.lblDanhSachHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongKeDoanhThu";
            this.Text = "Thống kê doanh thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongKeDoanhThu_FormClosing);
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblThongKeDoanhThu;
        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.Label lblDanhSachHoaDon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThanhChu;
        private System.Windows.Forms.MaskedTextBox mtbNam;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblNhapNam;
        private System.Windows.Forms.DateTimePicker dtmDenNgay;
        private System.Windows.Forms.DateTimePicker dtmTuNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.RadioButton rdoTheoKhoangThoiGian;
        private System.Windows.Forms.Label lblNhapNgay;
        private System.Windows.Forms.RadioButton rdoNgay;
        private System.Windows.Forms.DateTimePicker dtmOneDay;
        private System.Windows.Forms.Label lblNhapThangNam;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.MaskedTextBox mtbThangNam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkNhanVien;
        private System.Windows.Forms.Label lblChonNV;
        private System.Windows.Forms.ComboBox cboTenNhanVien;
    }
}