
namespace QuanLyMuaBanSach.GUI
{
    partial class frmKHChiTietPhieuDat
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
            this.grbDSSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDSSP
            // 
            this.grbDSSP.Controls.Add(this.dgvDSSP);
            this.grbDSSP.Location = new System.Drawing.Point(13, 173);
            this.grbDSSP.Name = "grbDSSP";
            this.grbDSSP.Size = new System.Drawing.Size(720, 279);
            this.grbDSSP.TabIndex = 22;
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
            this.dtmNgayDat.Location = new System.Drawing.Point(464, 77);
            this.dtmNgayDat.Name = "dtmNgayDat";
            this.dtmNgayDat.Size = new System.Drawing.Size(251, 24);
            this.dtmNgayDat.TabIndex = 21;
            // 
            // txtMaDonDat
            // 
            this.txtMaDonDat.Enabled = false;
            this.txtMaDonDat.Location = new System.Drawing.Point(127, 79);
            this.txtMaDonDat.Name = "txtMaDonDat";
            this.txtMaDonDat.Size = new System.Drawing.Size(232, 24);
            this.txtMaDonDat.TabIndex = 20;
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(382, 82);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(66, 18);
            this.lblNgayDat.TabIndex = 18;
            this.lblNgayDat.Text = "Ngày đặt";
            // 
            // lblMaDonDat
            // 
            this.lblMaDonDat.AutoSize = true;
            this.lblMaDonDat.Location = new System.Drawing.Point(24, 82);
            this.lblMaDonDat.Name = "lblMaDonDat";
            this.lblMaDonDat.Size = new System.Drawing.Size(82, 18);
            this.lblMaDonDat.TabIndex = 19;
            this.lblMaDonDat.Text = "Mã đơn đặt";
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
            this.label1.Size = new System.Drawing.Size(745, 47);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chi Tiết Đơn Đặt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTongTien.Location = new System.Drawing.Point(259, 138);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(270, 31);
            this.lblTongTien.TabIndex = 25;
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextTongTien
            // 
            this.lblTextTongTien.AutoSize = true;
            this.lblTextTongTien.Location = new System.Drawing.Point(171, 144);
            this.lblTextTongTien.Name = "lblTextTongTien";
            this.lblTextTongTien.Size = new System.Drawing.Size(69, 18);
            this.lblTextTongTien.TabIndex = 24;
            this.lblTextTongTien.Text = "Tổng tiền";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(590, 458);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(141, 40);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmKHChiTietPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(745, 510);
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
            this.Name = "frmKHChiTietPhieuDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đơn đặt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKHChiTietPhieuDat_FormClosing);
            this.Load += new System.EventHandler(this.frmKHChiTietDonDat_Load);
            this.grbDSSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSSP;
        private System.Windows.Forms.DateTimePicker dtmNgayDat;
        private System.Windows.Forms.TextBox txtMaDonDat;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblMaDonDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTextTongTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDSSP;
    }
}