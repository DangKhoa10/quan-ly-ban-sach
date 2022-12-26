
namespace QuanLyMuaBanSach.GUI
{
    partial class frmCapNhatNhaXuatBan
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
            this.dgvDSNXB = new System.Windows.Forms.DataGridView();
            this.grbThongTinNCC = new System.Windows.Forms.GroupBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.lblTenNXB = new System.Windows.Forms.Label();
            this.lblMaNXB = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNXB)).BeginInit();
            this.grbThongTinNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Aqua;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(682, 38);
            this.lblTieuDe.TabIndex = 38;
            this.lblTieuDe.Text = "Cập Nhật Nhà Xuất Bản";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDSNXB
            // 
            this.dgvDSNXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSNXB.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNXB.Location = new System.Drawing.Point(5, 155);
            this.dgvDSNXB.Name = "dgvDSNXB";
            this.dgvDSNXB.Size = new System.Drawing.Size(671, 198);
            this.dgvDSNXB.TabIndex = 41;
            this.dgvDSNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNXB_CellClick);
            // 
            // grbThongTinNCC
            // 
            this.grbThongTinNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinNCC.Controls.Add(this.txtTenNXB);
            this.grbThongTinNCC.Controls.Add(this.txtMaNXB);
            this.grbThongTinNCC.Controls.Add(this.lblTenNXB);
            this.grbThongTinNCC.Controls.Add(this.lblMaNXB);
            this.grbThongTinNCC.Location = new System.Drawing.Point(5, 41);
            this.grbThongTinNCC.Name = "grbThongTinNCC";
            this.grbThongTinNCC.Size = new System.Drawing.Size(412, 108);
            this.grbThongTinNCC.TabIndex = 40;
            this.grbThongTinNCC.TabStop = false;
            this.grbThongTinNCC.Text = "Thông tin nhà xuất bản";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNXB.Location = new System.Drawing.Point(126, 64);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(270, 24);
            this.txtTenNXB.TabIndex = 1;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNXB.Location = new System.Drawing.Point(126, 28);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(270, 24);
            this.txtMaNXB.TabIndex = 1;
            // 
            // lblTenNXB
            // 
            this.lblTenNXB.AutoSize = true;
            this.lblTenNXB.Location = new System.Drawing.Point(7, 67);
            this.lblTenNXB.Name = "lblTenNXB";
            this.lblTenNXB.Size = new System.Drawing.Size(120, 18);
            this.lblTenNXB.TabIndex = 0;
            this.lblTenNXB.Text = "Tên nhà xuất bản";
            // 
            // lblMaNXB
            // 
            this.lblMaNXB.AutoSize = true;
            this.lblMaNXB.Location = new System.Drawing.Point(7, 31);
            this.lblMaNXB.Name = "lblMaNXB";
            this.lblMaNXB.Size = new System.Drawing.Size(116, 18);
            this.lblMaNXB.TabIndex = 0;
            this.lblMaNXB.Text = "Mã nhà xuất bản";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.Aqua;
            this.btnLuu.Image = global::QuanLyMuaBanSach.Properties.Resources._32;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(557, 99);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 44);
            this.btnLuu.TabIndex = 46;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.Aqua;
            this.btnSua.Image = global::QuanLyMuaBanSach.Properties.Resources.edit_icon32;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(557, 48);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 44);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Aqua;
            this.btnXoa.Image = global::QuanLyMuaBanSach.Properties.Resources.delete_icon31;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(423, 99);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 44);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.Aqua;
            this.btnThem.Image = global::QuanLyMuaBanSach.Properties.Resources.add_icon32;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(423, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 45);
            this.btnThem.TabIndex = 49;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(560, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 39);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmCapNhatNhaXuatBan
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(682, 404);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDSNXB);
            this.Controls.Add(this.grbThongTinNCC);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapNhatNhaXuatBan";
            this.Text = "Cập nhật nhà xuất bản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCapNhatNhaXuatBan_FormClosing);
            this.Load += new System.EventHandler(this.frmCapNhatNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNXB)).EndInit();
            this.grbThongTinNCC.ResumeLayout(false);
            this.grbThongTinNCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvDSNXB;
        private System.Windows.Forms.GroupBox grbThongTinNCC;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label lblTenNXB;
        private System.Windows.Forms.Label lblMaNXB;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}