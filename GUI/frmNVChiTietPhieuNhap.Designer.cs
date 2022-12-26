
namespace QuanLyMuaBanSach.GUI
{
    partial class frmNVChiTietPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNVChiTietPhieuNhap));
            this.grbDSSP = new System.Windows.Forms.GroupBox();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.dtmNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuDat = new System.Windows.Forms.TextBox();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.lblMaPhieuNhap = new System.Windows.Forms.Label();
            this.lblChiTietPhieuNhap = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTextTongTien = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.prdPhieuNhap = new System.Drawing.Printing.PrintDocument();
            this.ppdPhieuNhap = new System.Windows.Forms.PrintPreviewDialog();
            this.grbDSSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDSSP
            // 
            this.grbDSSP.Controls.Add(this.dgvDSSP);
            this.grbDSSP.Location = new System.Drawing.Point(8, 177);
            this.grbDSSP.Name = "grbDSSP";
            this.grbDSSP.Size = new System.Drawing.Size(723, 279);
            this.grbDSSP.TabIndex = 49;
            this.grbDSSP.TabStop = false;
            this.grbDSSP.Text = "Danh Sách Các Sản Phẩm";
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Location = new System.Drawing.Point(15, 37);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.Size = new System.Drawing.Size(687, 223);
            this.dgvDSSP.TabIndex = 1;
            // 
            // dtmNgayDat
            // 
            this.dtmNgayDat.Enabled = false;
            this.dtmNgayDat.Location = new System.Drawing.Point(444, 96);
            this.dtmNgayDat.Name = "dtmNgayDat";
            this.dtmNgayDat.Size = new System.Drawing.Size(266, 24);
            this.dtmNgayDat.TabIndex = 48;
            // 
            // txtMaPhieuDat
            // 
            this.txtMaPhieuDat.Enabled = false;
            this.txtMaPhieuDat.Location = new System.Drawing.Point(145, 98);
            this.txtMaPhieuDat.Name = "txtMaPhieuDat";
            this.txtMaPhieuDat.Size = new System.Drawing.Size(186, 24);
            this.txtMaPhieuDat.TabIndex = 47;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(357, 101);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(66, 18);
            this.lblNgayDat.TabIndex = 45;
            this.lblNgayDat.Text = "Ngày đặt";
            // 
            // lblMaPhieuNhap
            // 
            this.lblMaPhieuNhap.AutoSize = true;
            this.lblMaPhieuNhap.Location = new System.Drawing.Point(27, 101);
            this.lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            this.lblMaPhieuNhap.Size = new System.Drawing.Size(104, 18);
            this.lblMaPhieuNhap.TabIndex = 46;
            this.lblMaPhieuNhap.Text = "Mã phiếu nhập";
            // 
            // lblChiTietPhieuNhap
            // 
            this.lblChiTietPhieuNhap.BackColor = System.Drawing.Color.Aqua;
            this.lblChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChiTietPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietPhieuNhap.ForeColor = System.Drawing.Color.Red;
            this.lblChiTietPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.lblChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChiTietPhieuNhap.Name = "lblChiTietPhieuNhap";
            this.lblChiTietPhieuNhap.Size = new System.Drawing.Size(743, 47);
            this.lblChiTietPhieuNhap.TabIndex = 44;
            this.lblChiTietPhieuNhap.Text = "Chi Tiết Phiếu Nhập";
            this.lblChiTietPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTongTien.Location = new System.Drawing.Point(258, 143);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(270, 31);
            this.lblTongTien.TabIndex = 52;
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextTongTien
            // 
            this.lblTextTongTien.AutoSize = true;
            this.lblTextTongTien.Location = new System.Drawing.Point(175, 148);
            this.lblTextTongTien.Name = "lblTextTongTien";
            this.lblTextTongTien.Size = new System.Drawing.Size(69, 18);
            this.lblTextTongTien.TabIndex = 51;
            this.lblTextTongTien.Text = "Tổng tiền";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(575, 462);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 44);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Aqua;
            this.btnIn.Location = new System.Drawing.Point(434, 462);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(135, 44);
            this.btnIn.TabIndex = 50;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
            this.ppdPhieuNhap.Name = "ppdPhieuNhap";
            this.ppdPhieuNhap.Visible = false;
            // 
            // frmNVChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(743, 510);
            this.Controls.Add(this.grbDSSP);
            this.Controls.Add(this.dtmNgayDat);
            this.Controls.Add(this.txtMaPhieuDat);
            this.Controls.Add(this.lblNgayDat);
            this.Controls.Add(this.lblMaPhieuNhap);
            this.Controls.Add(this.lblChiTietPhieuNhap);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTextTongTien);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNVChiTietPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNVChiTietPhieuNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmNVChiTietPhieuNhap_Load);
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
        private System.Windows.Forms.Label lblMaPhieuNhap;
        private System.Windows.Forms.Label lblChiTietPhieuNhap;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTextTongTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Drawing.Printing.PrintDocument prdPhieuNhap;
        private System.Windows.Forms.PrintPreviewDialog ppdPhieuNhap;
    }
}