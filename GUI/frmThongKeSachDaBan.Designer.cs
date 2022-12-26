
namespace QuanLyMuaBanSach.GUI
{
    partial class frmThongKeSachDaBan
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
            this.lblThongKeSachDaBan = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDSSPDaBan = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
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
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.mtbNam = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.chkChonSach = new System.Windows.Forms.CheckBox();
            this.cboSach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSPDaBan)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongKeSachDaBan
            // 
            this.lblThongKeSachDaBan.BackColor = System.Drawing.Color.Aqua;
            this.lblThongKeSachDaBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongKeSachDaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKeSachDaBan.ForeColor = System.Drawing.Color.Red;
            this.lblThongKeSachDaBan.Location = new System.Drawing.Point(0, 0);
            this.lblThongKeSachDaBan.Name = "lblThongKeSachDaBan";
            this.lblThongKeSachDaBan.Size = new System.Drawing.Size(1284, 37);
            this.lblThongKeSachDaBan.TabIndex = 17;
            this.lblThongKeSachDaBan.Text = "Thống Kê Sách Đã Bán";
            this.lblThongKeSachDaBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(1062, 610);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 54);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDSSPDaBan
            // 
            this.dgvDSSPDaBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSPDaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSPDaBan.Location = new System.Drawing.Point(119, 210);
            this.dgvDSSPDaBan.Name = "dgvDSSPDaBan";
            this.dgvDSSPDaBan.Size = new System.Drawing.Size(1099, 380);
            this.dgvDSSPDaBan.TabIndex = 15;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Aqua;
            this.btnThongKe.Location = new System.Drawing.Point(1062, 151);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(156, 47);
            this.btnThongKe.TabIndex = 42;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
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
            this.groupBox4.Location = new System.Drawing.Point(282, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(936, 79);
            this.groupBox4.TabIndex = 53;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTop);
            this.groupBox1.Controls.Add(this.lblTop);
            this.groupBox1.Controls.Add(this.chkChonSach);
            this.groupBox1.Controls.Add(this.cboSach);
            this.groupBox1.Location = new System.Drawing.Point(584, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 79);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // txtTop
            // 
            this.txtTop.Enabled = false;
            this.txtTop.Location = new System.Drawing.Point(383, 41);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(83, 24);
            this.txtTop.TabIndex = 56;
            this.txtTop.Text = "5";
            this.txtTop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTop_KeyPress);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Enabled = false;
            this.lblTop.Location = new System.Drawing.Point(336, 44);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(34, 18);
            this.lblTop.TabIndex = 55;
            this.lblTop.Text = "Top";
            // 
            // chkChonSach
            // 
            this.chkChonSach.AutoSize = true;
            this.chkChonSach.Location = new System.Drawing.Point(18, 13);
            this.chkChonSach.Name = "chkChonSach";
            this.chkChonSach.Size = new System.Drawing.Size(236, 22);
            this.chkChonSach.TabIndex = 47;
            this.chkChonSach.Text = "Thống kê theo sách bán nhiều ít";
            this.chkChonSach.UseVisualStyleBackColor = true;
            this.chkChonSach.CheckedChanged += new System.EventHandler(this.chkChonSach_CheckedChanged);
            // 
            // cboSach
            // 
            this.cboSach.Enabled = false;
            this.cboSach.FormattingEnabled = true;
            this.cboSach.Location = new System.Drawing.Point(18, 41);
            this.cboSach.Name = "cboSach";
            this.cboSach.Size = new System.Drawing.Size(313, 26);
            this.cboSach.TabIndex = 45;
            this.cboSach.SelectedIndexChanged += new System.EventHandler(this.cboSach_SelectedIndexChanged);
            this.cboSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSach_KeyPress);
            // 
            // frmThongKeSachDaBan
            // 
            this.AcceptButton = this.btnThongKe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1284, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lblThongKeSachDaBan);
            this.Controls.Add(this.dgvDSSPDaBan);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongKeSachDaBan";
            this.Text = "Thống kê sách đã bán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongKeSachDaBan_FormClosing);
            this.Load += new System.EventHandler(this.ThongKeSachDaBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSPDaBan)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblThongKeSachDaBan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDSSPDaBan;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.GroupBox groupBox4;
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
        private System.Windows.Forms.Label lblNhapNam;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.MaskedTextBox mtbNam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkChonSach;
        private System.Windows.Forms.ComboBox cboSach;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label lblTop;
    }
}