
namespace QuanLyMuaBanSach.GUI
{
    partial class frmChiTietHoaDonTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietHoaDonTimKiem));
            this.grbDSSP = new System.Windows.Forms.GroupBox();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.dtmNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtMaDonDat = new System.Windows.Forms.TextBox();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.lblMaDonDat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTextTongTien = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            this.prdHoaDon = new System.Drawing.Printing.PrintDocument();
            this.ppdHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.grbDSSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDSSP
            // 
            this.grbDSSP.Controls.Add(this.dgvDSSP);
            this.grbDSSP.Location = new System.Drawing.Point(7, 171);
            this.grbDSSP.Name = "grbDSSP";
            this.grbDSSP.Size = new System.Drawing.Size(720, 279);
            this.grbDSSP.TabIndex = 51;
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
            this.dtmNgayDat.Location = new System.Drawing.Point(443, 90);
            this.dtmNgayDat.Name = "dtmNgayDat";
            this.dtmNgayDat.Size = new System.Drawing.Size(266, 24);
            this.dtmNgayDat.TabIndex = 50;
            // 
            // txtMaDonDat
            // 
            this.txtMaDonDat.Enabled = false;
            this.txtMaDonDat.Location = new System.Drawing.Point(144, 92);
            this.txtMaDonDat.Name = "txtMaDonDat";
            this.txtMaDonDat.Size = new System.Drawing.Size(186, 24);
            this.txtMaDonDat.TabIndex = 49;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(356, 95);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(66, 18);
            this.lblNgayDat.TabIndex = 47;
            this.lblNgayDat.Text = "Ngày đặt";
            // 
            // lblMaDonDat
            // 
            this.lblMaDonDat.AutoSize = true;
            this.lblMaDonDat.Location = new System.Drawing.Point(26, 95);
            this.lblMaDonDat.Name = "lblMaDonDat";
            this.lblMaDonDat.Size = new System.Drawing.Size(87, 18);
            this.lblMaDonDat.TabIndex = 48;
            this.lblMaDonDat.Text = "Mã hóa đơn";
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
            this.label1.TabIndex = 46;
            this.label1.Text = "Chi Tiết Hóa Đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTongTien.Location = new System.Drawing.Point(257, 137);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(270, 31);
            this.lblTongTien.TabIndex = 54;
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextTongTien
            // 
            this.lblTextTongTien.AutoSize = true;
            this.lblTextTongTien.Location = new System.Drawing.Point(174, 142);
            this.lblTextTongTien.Name = "lblTextTongTien";
            this.lblTextTongTien.Size = new System.Drawing.Size(69, 18);
            this.lblTextTongTien.TabIndex = 53;
            this.lblTextTongTien.Text = "Tổng tiền";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(590, 456);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 43);
            this.btnThoat.TabIndex = 52;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIN
            // 
            this.btnIN.BackColor = System.Drawing.Color.Aqua;
            this.btnIN.Location = new System.Drawing.Point(472, 456);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(112, 43);
            this.btnIN.TabIndex = 55;
            this.btnIN.Text = "In";
            this.btnIN.UseVisualStyleBackColor = false;
            this.btnIN.Click += new System.EventHandler(this.btnIn_Click);
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
            // frmChiTietHoaDonTimKiem
            // 
            this.AcceptButton = this.btnIN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(739, 513);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.grbDSSP);
            this.Controls.Add(this.dtmNgayDat);
            this.Controls.Add(this.txtMaDonDat);
            this.Controls.Add(this.lblNgayDat);
            this.Controls.Add(this.lblMaDonDat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTextTongTien);
            this.Controls.Add(this.btnThoat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietHoaDonTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChiTietHoaDonTimKiem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChiTietHoaDonTimKiem_FormClosing);
            this.Load += new System.EventHandler(this.frmChiTietHoaDonTimKiem_Load);
            this.grbDSSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSSP;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.DateTimePicker dtmNgayDat;
        private System.Windows.Forms.TextBox txtMaDonDat;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblMaDonDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTextTongTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIN;
        private System.Drawing.Printing.PrintDocument prdHoaDon;
        private System.Windows.Forms.PrintPreviewDialog ppdHoaDon;
    }
}