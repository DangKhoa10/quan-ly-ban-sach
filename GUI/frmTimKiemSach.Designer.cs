
namespace QuanLyMuaBanSach.GUI
{
    partial class frmTimKiemSach
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTimTG = new System.Windows.Forms.ComboBox();
            this.cboTimLS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTimNXB = new System.Windows.Forms.ComboBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.btnAllSach = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemGH = new System.Windows.Forms.Button();
            this.btnThemGH = new System.Windows.Forms.Button();
            this.lblSoLuongSach = new System.Windows.Forms.Label();
            this.lvwGioHang = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Aqua;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1339, 44);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "Tìm Kiếm Sách";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Location = new System.Drawing.Point(83, 290);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.Size = new System.Drawing.Size(1176, 275);
            this.dgvDSSach.TabIndex = 3;
            this.dgvDSSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSach_CellClick);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(695, 23);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(429, 24);
            this.txtTenSach.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Aqua;
            this.btnTimKiem.Location = new System.Drawing.Point(967, 92);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(157, 49);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTimTG);
            this.groupBox1.Controls.Add(this.cboTimLS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTimNXB);
            this.groupBox1.Controls.Add(this.lblTenSach);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Location = new System.Drawing.Point(83, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cboTimTG
            // 
            this.cboTimTG.FormattingEnabled = true;
            this.cboTimTG.Location = new System.Drawing.Point(120, 60);
            this.cboTimTG.Name = "cboTimTG";
            this.cboTimTG.Size = new System.Drawing.Size(242, 26);
            this.cboTimTG.TabIndex = 4;
            // 
            // cboTimLS
            // 
            this.cboTimLS.FormattingEnabled = true;
            this.cboTimLS.Location = new System.Drawing.Point(451, 60);
            this.cboTimLS.Name = "cboTimLS";
            this.cboTimLS.Size = new System.Drawing.Size(267, 26);
            this.cboTimLS.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhà xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Sách";
            // 
            // cboTimNXB
            // 
            this.cboTimNXB.FormattingEnabled = true;
            this.cboTimNXB.Location = new System.Drawing.Point(875, 60);
            this.cboTimNXB.Name = "cboTimNXB";
            this.cboTimNXB.Size = new System.Drawing.Size(249, 26);
            this.cboTimNXB.TabIndex = 2;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(603, 26);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(71, 18);
            this.lblTenSach.TabIndex = 4;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(120, 23);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(438, 24);
            this.txtMaSach.TabIndex = 1;
            // 
            // btnAllSach
            // 
            this.btnAllSach.BackColor = System.Drawing.Color.Aqua;
            this.btnAllSach.Location = new System.Drawing.Point(83, 231);
            this.btnAllSach.Name = "btnAllSach";
            this.btnAllSach.Size = new System.Drawing.Size(259, 53);
            this.btnAllSach.TabIndex = 6;
            this.btnAllSach.Text = "Hiển Thị Toàn Bộ Sách";
            this.btnAllSach.UseVisualStyleBackColor = false;
            this.btnAllSach.Click += new System.EventHandler(this.btnAllSach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(1103, 571);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 44);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemGH
            // 
            this.btnXemGH.BackColor = System.Drawing.Color.Aqua;
            this.btnXemGH.Location = new System.Drawing.Point(1082, 236);
            this.btnXemGH.Name = "btnXemGH";
            this.btnXemGH.Size = new System.Drawing.Size(177, 43);
            this.btnXemGH.TabIndex = 8;
            this.btnXemGH.Text = "Xem giỏ hàng";
            this.btnXemGH.UseVisualStyleBackColor = false;
            this.btnXemGH.Click += new System.EventHandler(this.btnXemGH_Click);
            // 
            // btnThemGH
            // 
            this.btnThemGH.BackColor = System.Drawing.Color.Aqua;
            this.btnThemGH.Location = new System.Drawing.Point(889, 236);
            this.btnThemGH.Name = "btnThemGH";
            this.btnThemGH.Size = new System.Drawing.Size(177, 43);
            this.btnThemGH.TabIndex = 8;
            this.btnThemGH.Text = "Thêm vào giỏ hàng";
            this.btnThemGH.UseVisualStyleBackColor = false;
            this.btnThemGH.Click += new System.EventHandler(this.btnThemGH_Click);
            // 
            // lblSoLuongSach
            // 
            this.lblSoLuongSach.AutoSize = true;
            this.lblSoLuongSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongSach.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuongSach.Location = new System.Drawing.Point(1235, 231);
            this.lblSoLuongSach.Name = "lblSoLuongSach";
            this.lblSoLuongSach.Size = new System.Drawing.Size(0, 25);
            this.lblSoLuongSach.TabIndex = 9;
            // 
            // lvwGioHang
            // 
            this.lvwGioHang.HideSelection = false;
            this.lvwGioHang.Location = new System.Drawing.Point(15, 290);
            this.lvwGioHang.Name = "lvwGioHang";
            this.lvwGioHang.Size = new System.Drawing.Size(62, 97);
            this.lvwGioHang.TabIndex = 10;
            this.lvwGioHang.UseCompatibleStateImageBehavior = false;
            this.lvwGioHang.Visible = false;
            // 
            // frmTimKiemSach
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1339, 631);
            this.Controls.Add(this.lvwGioHang);
            this.Controls.Add(this.lblSoLuongSach);
            this.Controls.Add(this.btnThemGH);
            this.Controls.Add(this.btnXemGH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnAllSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDSSach);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKiemSach";
            this.Text = "Tìm Kiếm Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemSach_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAllSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.ComboBox cboTimTG;
        private System.Windows.Forms.ComboBox cboTimLS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTimNXB;
        private System.Windows.Forms.Button btnXemGH;
        private System.Windows.Forms.Button btnThemGH;
        private System.Windows.Forms.Label lblSoLuongSach;
        private System.Windows.Forms.ListView lvwGioHang;
    }
}