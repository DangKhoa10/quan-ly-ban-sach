
namespace QuanLyMuaBanSach.GUI
{
    partial class frmThanhToanHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToanHoaDon));
            this.grbTTDonDat = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.dtmNgayLapDon = new System.Windows.Forms.DateTimePicker();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblNgayLapPhieu = new System.Windows.Forms.Label();
            this.grbDSSP = new System.Windows.Forms.GroupBox();
            this.lstDSSP = new System.Windows.Forms.ListView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTextTongTien = new System.Windows.Forms.Label();
            this.ppdHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.prdHoaDon = new System.Drawing.Printing.PrintDocument();
            this.grbTTDonDat.SuspendLayout();
            this.grbDSSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTDonDat
            // 
            this.grbTTDonDat.Controls.Add(this.btnTim);
            this.grbTTDonDat.Controls.Add(this.txtDiaChi);
            this.grbTTDonDat.Controls.Add(this.lblDiaChi);
            this.grbTTDonDat.Controls.Add(this.lblSoDienThoai);
            this.grbTTDonDat.Controls.Add(this.lblTenKH);
            this.grbTTDonDat.Controls.Add(this.dtmNgayLapDon);
            this.grbTTDonDat.Controls.Add(this.txtSoDienThoai);
            this.grbTTDonDat.Controls.Add(this.txtTenKH);
            this.grbTTDonDat.Controls.Add(this.lblNgayLapPhieu);
            this.grbTTDonDat.Location = new System.Drawing.Point(19, 50);
            this.grbTTDonDat.Name = "grbTTDonDat";
            this.grbTTDonDat.Size = new System.Drawing.Size(793, 138);
            this.grbTTDonDat.TabIndex = 0;
            this.grbTTDonDat.TabStop = false;
            this.grbTTDonDat.Text = "Thông tin";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Aqua;
            this.btnTim.Location = new System.Drawing.Point(335, 23);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(58, 43);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(518, 63);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(266, 68);
            this.txtDiaChi.TabIndex = 2;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(408, 75);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(56, 18);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(10, 37);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(102, 18);
            this.lblSoDienThoai.TabIndex = 5;
            this.lblSoDienThoai.Text = "Số Điện Thoại";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(10, 75);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(113, 18);
            this.lblTenKH.TabIndex = 5;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // dtmNgayLapDon
            // 
            this.dtmNgayLapDon.Enabled = false;
            this.dtmNgayLapDon.Location = new System.Drawing.Point(518, 32);
            this.dtmNgayLapDon.Name = "dtmNgayLapDon";
            this.dtmNgayLapDon.Size = new System.Drawing.Size(266, 24);
            this.dtmNgayLapDon.TabIndex = 4;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(129, 32);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(200, 24);
            this.txtSoDienThoai.TabIndex = 0;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(129, 72);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(264, 24);
            this.txtTenKH.TabIndex = 1;
            // 
            // lblNgayLapPhieu
            // 
            this.lblNgayLapPhieu.AutoSize = true;
            this.lblNgayLapPhieu.Location = new System.Drawing.Point(408, 34);
            this.lblNgayLapPhieu.Name = "lblNgayLapPhieu";
            this.lblNgayLapPhieu.Size = new System.Drawing.Size(106, 18);
            this.lblNgayLapPhieu.TabIndex = 3;
            this.lblNgayLapPhieu.Text = "Ngày lập Phiếu";
            // 
            // grbDSSP
            // 
            this.grbDSSP.Controls.Add(this.lstDSSP);
            this.grbDSSP.Location = new System.Drawing.Point(19, 204);
            this.grbDSSP.Name = "grbDSSP";
            this.grbDSSP.Size = new System.Drawing.Size(793, 242);
            this.grbDSSP.TabIndex = 24;
            this.grbDSSP.TabStop = false;
            this.grbDSSP.Text = "Danh sách sản phẩm";
            // 
            // lstDSSP
            // 
            this.lstDSSP.HideSelection = false;
            this.lstDSSP.Location = new System.Drawing.Point(19, 30);
            this.lstDSSP.Name = "lstDSSP";
            this.lstDSSP.Size = new System.Drawing.Size(755, 196);
            this.lstDSSP.TabIndex = 4;
            this.lstDSSP.UseCompatibleStateImageBehavior = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Aqua;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(824, 37);
            this.lblTieuDe.TabIndex = 23;
            this.lblTieuDe.Text = "Thanh Toán Hóa Đơn";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Aqua;
            this.btnThanhToan.Location = new System.Drawing.Point(537, 512);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(136, 40);
            this.btnThanhToan.TabIndex = 28;
            this.btnThanhToan.Text = "&Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Aqua;
            this.btnHuy.Location = new System.Drawing.Point(679, 512);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 40);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "&Thoát";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTongTien.Location = new System.Drawing.Point(624, 465);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(169, 33);
            this.lblTongTien.TabIndex = 26;
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextTongTien
            // 
            this.lblTextTongTien.AutoSize = true;
            this.lblTextTongTien.Location = new System.Drawing.Point(547, 478);
            this.lblTextTongTien.Name = "lblTextTongTien";
            this.lblTextTongTien.Size = new System.Drawing.Size(74, 18);
            this.lblTextTongTien.TabIndex = 25;
            this.lblTextTongTien.Text = "Tổng Tiền";
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
            // prdHoaDon
            // 
            this.prdHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prdHoaDon_PrintPage);
            // 
            // frmThanhToanHoaDon
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(824, 556);
            this.Controls.Add(this.grbTTDonDat);
            this.Controls.Add(this.grbDSSP);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTextTongTien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThanhToanHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThanhToanHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmThanhToanHoaDon_Load);
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
        private System.Windows.Forms.Label lblNgayLapPhieu;
        private System.Windows.Forms.GroupBox grbDSSP;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTextTongTien;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.ListView lstDSSP;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.PrintPreviewDialog ppdHoaDon;
        private System.Drawing.Printing.PrintDocument prdHoaDon;
    }
}