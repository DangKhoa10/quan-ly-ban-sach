﻿
namespace QuanLyMuaBanSach.GUI
{
    partial class frmDatSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatSach = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboLocTacGia = new System.Windows.Forms.ComboBox();
            this.cboLocLoaiSach = new System.Windows.Forms.ComboBox();
            this.cboLocTheoNXB = new System.Windows.Forms.ComboBox();
            this.dgvListSach = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lstvGioHang = new System.Windows.Forms.ListView();
            this.grbThongTinSach = new System.Windows.Forms.GroupBox();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdoTenSach = new System.Windows.Forms.RadioButton();
            this.rdoMaSach = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChonPDCu = new System.Windows.Forms.Button();
            this.btnHuyDatThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSach)).BeginInit();
            this.grbThongTinSach.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1370, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Đặt Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDatSach
            // 
            this.btnDatSach.BackColor = System.Drawing.Color.Aqua;
            this.btnDatSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatSach.Location = new System.Drawing.Point(1078, 627);
            this.btnDatSach.Name = "btnDatSach";
            this.btnDatSach.Size = new System.Drawing.Size(109, 44);
            this.btnDatSach.TabIndex = 15;
            this.btnDatSach.Text = "Đặt Sách";
            this.btnDatSach.UseVisualStyleBackColor = false;
            this.btnDatSach.Click += new System.EventHandler(this.btnDatSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1193, 627);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 44);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboLocTacGia
            // 
            this.cboLocTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTacGia.FormattingEnabled = true;
            this.cboLocTacGia.Location = new System.Drawing.Point(724, 65);
            this.cboLocTacGia.Name = "cboLocTacGia";
            this.cboLocTacGia.Size = new System.Drawing.Size(202, 24);
            this.cboLocTacGia.TabIndex = 40;
            this.cboLocTacGia.Text = "Lọc theo tác giả";
            this.cboLocTacGia.SelectedIndexChanged += new System.EventHandler(this.cboLocTacGia_SelectedIndexChanged);
            // 
            // cboLocLoaiSach
            // 
            this.cboLocLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocLoaiSach.FormattingEnabled = true;
            this.cboLocLoaiSach.Location = new System.Drawing.Point(932, 65);
            this.cboLocLoaiSach.Name = "cboLocLoaiSach";
            this.cboLocLoaiSach.Size = new System.Drawing.Size(205, 24);
            this.cboLocLoaiSach.TabIndex = 41;
            this.cboLocLoaiSach.Text = "Lọc theo loại sách";
            this.cboLocLoaiSach.SelectedIndexChanged += new System.EventHandler(this.cboLocLoaiSach_SelectedIndexChanged);
            // 
            // cboLocTheoNXB
            // 
            this.cboLocTheoNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocTheoNXB.FormattingEnabled = true;
            this.cboLocTheoNXB.Location = new System.Drawing.Point(1143, 65);
            this.cboLocTheoNXB.Name = "cboLocTheoNXB";
            this.cboLocTheoNXB.Size = new System.Drawing.Size(189, 24);
            this.cboLocTheoNXB.TabIndex = 42;
            this.cboLocTheoNXB.Text = "Lọc theo nhà xuất bản";
            this.cboLocTheoNXB.SelectedIndexChanged += new System.EventHandler(this.cboLocTheoNXB_SelectedIndexChanged);
            // 
            // dgvListSach
            // 
            this.dgvListSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvListSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSach.Location = new System.Drawing.Point(463, 102);
            this.dgvListSach.Name = "dgvListSach";
            this.dgvListSach.Size = new System.Drawing.Size(869, 262);
            this.dgvListSach.TabIndex = 43;
            this.dgvListSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSach_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Giỏ hàng";
            // 
            // lstvGioHang
            // 
            this.lstvGioHang.HideSelection = false;
            this.lstvGioHang.Location = new System.Drawing.Point(463, 408);
            this.lstvGioHang.Name = "lstvGioHang";
            this.lstvGioHang.Size = new System.Drawing.Size(869, 207);
            this.lstvGioHang.TabIndex = 45;
            this.lstvGioHang.UseCompatibleStateImageBehavior = false;
            // 
            // grbThongTinSach
            // 
            this.grbThongTinSach.Controls.Add(this.txtNhaXB);
            this.grbThongTinSach.Controls.Add(this.txtSoTrang);
            this.grbThongTinSach.Controls.Add(this.txtTheLoai);
            this.grbThongTinSach.Controls.Add(this.txtTacGia);
            this.grbThongTinSach.Controls.Add(this.txtConLai);
            this.grbThongTinSach.Controls.Add(this.txtGia);
            this.grbThongTinSach.Controls.Add(this.txtTenSach);
            this.grbThongTinSach.Controls.Add(this.txtMaSach);
            this.grbThongTinSach.Controls.Add(this.label17);
            this.grbThongTinSach.Controls.Add(this.label16);
            this.grbThongTinSach.Controls.Add(this.label15);
            this.grbThongTinSach.Controls.Add(this.label14);
            this.grbThongTinSach.Controls.Add(this.label13);
            this.grbThongTinSach.Controls.Add(this.label12);
            this.grbThongTinSach.Controls.Add(this.label11);
            this.grbThongTinSach.Controls.Add(this.label9);
            this.grbThongTinSach.Location = new System.Drawing.Point(29, 56);
            this.grbThongTinSach.Name = "grbThongTinSach";
            this.grbThongTinSach.Size = new System.Drawing.Size(414, 359);
            this.grbThongTinSach.TabIndex = 46;
            this.grbThongTinSach.TabStop = false;
            this.grbThongTinSach.Text = "Thông tin sách";
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Enabled = false;
            this.txtNhaXB.Location = new System.Drawing.Point(119, 312);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(275, 24);
            this.txtNhaXB.TabIndex = 1;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Enabled = false;
            this.txtSoTrang.Location = new System.Drawing.Point(119, 272);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(275, 24);
            this.txtSoTrang.TabIndex = 1;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Enabled = false;
            this.txtTheLoai.Location = new System.Drawing.Point(119, 232);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(275, 24);
            this.txtTheLoai.TabIndex = 1;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Enabled = false;
            this.txtTacGia.Location = new System.Drawing.Point(119, 192);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(275, 24);
            this.txtTacGia.TabIndex = 1;
            // 
            // txtConLai
            // 
            this.txtConLai.Enabled = false;
            this.txtConLai.Location = new System.Drawing.Point(119, 152);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.Size = new System.Drawing.Size(275, 24);
            this.txtConLai.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(119, 112);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(275, 24);
            this.txtGia.TabIndex = 1;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Enabled = false;
            this.txtTenSach.Location = new System.Drawing.Point(119, 72);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(275, 24);
            this.txtTenSach.TabIndex = 1;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(119, 32);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(275, 24);
            this.txtMaSach.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nhà xuất bản";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Số trang";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Thể loại";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tác giả";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Còn hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Đơn giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã sách";
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.txtTimKiem);
            this.grbTimKiem.Controls.Add(this.rdoTenSach);
            this.grbTimKiem.Controls.Add(this.rdoMaSach);
            this.grbTimKiem.Location = new System.Drawing.Point(29, 421);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(414, 109);
            this.grbTimKiem.TabIndex = 0;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Aqua;
            this.btnTimKiem.Location = new System.Drawing.Point(319, 51);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 26);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(48, 52);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(265, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rdoTenSach
            // 
            this.rdoTenSach.AutoSize = true;
            this.rdoTenSach.Location = new System.Drawing.Point(193, 24);
            this.rdoTenSach.Name = "rdoTenSach";
            this.rdoTenSach.Size = new System.Drawing.Size(120, 22);
            this.rdoTenSach.TabIndex = 0;
            this.rdoTenSach.Text = "Theo tên sách";
            this.rdoTenSach.UseVisualStyleBackColor = true;
            this.rdoTenSach.CheckedChanged += new System.EventHandler(this.rdoTenSach_CheckedChanged);
            // 
            // rdoMaSach
            // 
            this.rdoMaSach.AutoSize = true;
            this.rdoMaSach.Location = new System.Drawing.Point(48, 24);
            this.rdoMaSach.Name = "rdoMaSach";
            this.rdoMaSach.Size = new System.Drawing.Size(121, 22);
            this.rdoMaSach.TabIndex = 0;
            this.rdoMaSach.Text = "Theo mã sách";
            this.rdoMaSach.UseVisualStyleBackColor = true;
            this.rdoMaSach.CheckedChanged += new System.EventHandler(this.rdoTenSach_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 548);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 123);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Aqua;
            this.btnXoa.Location = new System.Drawing.Point(265, 61);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Aqua;
            this.btnThem.Location = new System.Drawing.Point(152, 61);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(132, 23);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(262, 24);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLMua_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng mua";
            // 
            // btnChonPDCu
            // 
            this.btnChonPDCu.BackColor = System.Drawing.Color.Aqua;
            this.btnChonPDCu.Location = new System.Drawing.Point(1163, 370);
            this.btnChonPDCu.Name = "btnChonPDCu";
            this.btnChonPDCu.Size = new System.Drawing.Size(169, 33);
            this.btnChonPDCu.TabIndex = 3;
            this.btnChonPDCu.Text = "Phiếu đặt trong ngày";
            this.btnChonPDCu.UseVisualStyleBackColor = false;
            this.btnChonPDCu.Click += new System.EventHandler(this.btnChonPDCu_Click);
            // 
            // btnHuyDatThem
            // 
            this.btnHuyDatThem.BackColor = System.Drawing.Color.Aqua;
            this.btnHuyDatThem.Location = new System.Drawing.Point(1062, 370);
            this.btnHuyDatThem.Name = "btnHuyDatThem";
            this.btnHuyDatThem.Size = new System.Drawing.Size(95, 34);
            this.btnHuyDatThem.TabIndex = 49;
            this.btnHuyDatThem.Text = "Hủy";
            this.btnHuyDatThem.UseVisualStyleBackColor = false;
            this.btnHuyDatThem.Click += new System.EventHandler(this.btnHuyDatThem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(463, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 39;
            this.button1.Text = "Toàn bộ sách";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAllSach_Click);
            // 
            // frmDatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnHuyDatThem);
            this.Controls.Add(this.btnChonPDCu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.grbThongTinSach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstvGioHang);
            this.Controls.Add(this.dgvListSach);
            this.Controls.Add(this.cboLocTheoNXB);
            this.Controls.Add(this.cboLocLoaiSach);
            this.Controls.Add(this.cboLocTacGia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatSach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatSach";
            this.Text = "Đặt sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDatSach_FormClosing);
            this.Load += new System.EventHandler(this.frmDatSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSach)).EndInit();
            this.grbThongTinSach.ResumeLayout(false);
            this.grbThongTinSach.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboLocTacGia;
        private System.Windows.Forms.ComboBox cboLocLoaiSach;
        private System.Windows.Forms.ComboBox cboLocTheoNXB;
        private System.Windows.Forms.DataGridView dgvListSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstvGioHang;
        private System.Windows.Forms.GroupBox grbThongTinSach;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.RadioButton rdoMaSach;
        private System.Windows.Forms.RadioButton rdoTenSach;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChonPDCu;
        private System.Windows.Forms.Button btnHuyDatThem;
        private System.Windows.Forms.Button button1;
    }
}