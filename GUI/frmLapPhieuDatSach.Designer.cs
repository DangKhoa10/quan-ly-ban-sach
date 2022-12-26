
namespace QuanLyMuaBanSach.GUI
{
    partial class frmLapPhieuDatSach
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
            this.grbTTDonDat = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtmNgayLapDon = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblNgayLapDon = new System.Windows.Forms.Label();
            this.grbDSSP = new System.Windows.Forms.GroupBox();
            this.lstvGioHang = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatSach = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTextTongTien = new System.Windows.Forms.Label();
            this.grbTTDonDat.SuspendLayout();
            this.grbDSSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTDonDat
            // 
            this.grbTTDonDat.Controls.Add(this.btnTim);
            this.grbTTDonDat.Controls.Add(this.lblDiaChi);
            this.grbTTDonDat.Controls.Add(this.lblSoDienThoai);
            this.grbTTDonDat.Controls.Add(this.lblTenKH);
            this.grbTTDonDat.Controls.Add(this.txtDiaChi);
            this.grbTTDonDat.Controls.Add(this.dtmNgayLapDon);
            this.grbTTDonDat.Controls.Add(this.txtSDT);
            this.grbTTDonDat.Controls.Add(this.txtTenKH);
            this.grbTTDonDat.Controls.Add(this.lblNgayLapDon);
            this.grbTTDonDat.Location = new System.Drawing.Point(13, 49);
            this.grbTTDonDat.Name = "grbTTDonDat";
            this.grbTTDonDat.Size = new System.Drawing.Size(785, 150);
            this.grbTTDonDat.TabIndex = 0;
            this.grbTTDonDat.TabStop = false;
            this.grbTTDonDat.Text = "Thông tin";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Aqua;
            this.btnTim.Location = new System.Drawing.Point(306, 50);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(56, 35);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(410, 86);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(56, 18);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(6, 34);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(94, 18);
            this.lblSoDienThoai.TabIndex = 5;
            this.lblSoDienThoai.Text = "Số điện thoại";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(6, 86);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(113, 18);
            this.lblTenKH.TabIndex = 5;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(413, 107);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(331, 24);
            this.txtDiaChi.TabIndex = 2;
            // 
            // dtmNgayLapDon
            // 
            this.dtmNgayLapDon.Enabled = false;
            this.dtmNgayLapDon.Location = new System.Drawing.Point(413, 53);
            this.dtmNgayLapDon.Name = "dtmNgayLapDon";
            this.dtmNgayLapDon.Size = new System.Drawing.Size(331, 24);
            this.dtmNgayLapDon.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(9, 55);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(291, 24);
            this.txtSDT.TabIndex = 0;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(9, 107);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(324, 24);
            this.txtTenKH.TabIndex = 1;
            // 
            // lblNgayLapDon
            // 
            this.lblNgayLapDon.AutoSize = true;
            this.lblNgayLapDon.Location = new System.Drawing.Point(410, 32);
            this.lblNgayLapDon.Name = "lblNgayLapDon";
            this.lblNgayLapDon.Size = new System.Drawing.Size(94, 18);
            this.lblNgayLapDon.TabIndex = 3;
            this.lblNgayLapDon.Text = "Ngày lập đơn";
            // 
            // grbDSSP
            // 
            this.grbDSSP.Controls.Add(this.lstvGioHang);
            this.grbDSSP.Location = new System.Drawing.Point(12, 205);
            this.grbDSSP.Name = "grbDSSP";
            this.grbDSSP.Size = new System.Drawing.Size(785, 230);
            this.grbDSSP.TabIndex = 17;
            this.grbDSSP.TabStop = false;
            this.grbDSSP.Text = "Danh sách sản phẩm";
            // 
            // lstvGioHang
            // 
            this.lstvGioHang.HideSelection = false;
            this.lstvGioHang.Location = new System.Drawing.Point(24, 23);
            this.lstvGioHang.Name = "lstvGioHang";
            this.lstvGioHang.Size = new System.Drawing.Size(736, 196);
            this.lstvGioHang.TabIndex = 2;
            this.lstvGioHang.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Đơn Đặt Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDatSach
            // 
            this.btnDatSach.BackColor = System.Drawing.Color.Aqua;
            this.btnDatSach.Location = new System.Drawing.Point(562, 497);
            this.btnDatSach.Name = "btnDatSach";
            this.btnDatSach.Size = new System.Drawing.Size(136, 44);
            this.btnDatSach.TabIndex = 21;
            this.btnDatSach.Text = "&Đặt Sách";
            this.btnDatSach.UseVisualStyleBackColor = false;
            this.btnDatSach.Click += new System.EventHandler(this.btnDatSach_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Aqua;
            this.btnHuy.Location = new System.Drawing.Point(704, 497);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 45);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTongTien.Location = new System.Drawing.Point(586, 450);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(212, 33);
            this.lblTongTien.TabIndex = 19;
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextTongTien
            // 
            this.lblTextTongTien.AutoSize = true;
            this.lblTextTongTien.Location = new System.Drawing.Point(506, 465);
            this.lblTextTongTien.Name = "lblTextTongTien";
            this.lblTextTongTien.Size = new System.Drawing.Size(74, 18);
            this.lblTextTongTien.TabIndex = 18;
            this.lblTextTongTien.Text = "Tổng Tiền";
            // 
            // frmLapPhieuDatSach
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(810, 546);
            this.Controls.Add(this.grbTTDonDat);
            this.Controls.Add(this.grbDSSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDatSach);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTextTongTien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLapPhieuDatSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu đặt sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLapPhieuDatSach_FormClosing);
            this.Load += new System.EventHandler(this.frmLapPhieuDatSach_Load);
            this.grbTTDonDat.ResumeLayout(false);
            this.grbTTDonDat.PerformLayout();
            this.grbDSSP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTDonDat;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.DateTimePicker dtmNgayLapDon;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblNgayLapDon;
        private System.Windows.Forms.GroupBox grbDSSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatSach;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTextTongTien;
        private System.Windows.Forms.ListView lstvGioHang;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnTim;
    }
}