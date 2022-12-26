
namespace QuanLyMuaBanSach.GUI
{
    partial class frmCapNhatLoaiSach
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
            this.dgvDSLoaiSach = new System.Windows.Forms.DataGridView();
            this.grbThongTinNCC = new System.Windows.Forms.GroupBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.lblTenLS = new System.Windows.Forms.Label();
            this.lblMaLS = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiSach)).BeginInit();
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
            this.lblTieuDe.Size = new System.Drawing.Size(694, 38);
            this.lblTieuDe.TabIndex = 38;
            this.lblTieuDe.Text = "Cập Nhật Loại Sách";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDSLoaiSach
            // 
            this.dgvDSLoaiSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSLoaiSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoaiSach.Location = new System.Drawing.Point(12, 164);
            this.dgvDSLoaiSach.Name = "dgvDSLoaiSach";
            this.dgvDSLoaiSach.Size = new System.Drawing.Size(671, 198);
            this.dgvDSLoaiSach.TabIndex = 41;
            this.dgvDSLoaiSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLoaiSach_CellClick);
            // 
            // grbThongTinNCC
            // 
            this.grbThongTinNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinNCC.Controls.Add(this.txtTenLoai);
            this.grbThongTinNCC.Controls.Add(this.txtMaLoai);
            this.grbThongTinNCC.Controls.Add(this.lblTenLS);
            this.grbThongTinNCC.Controls.Add(this.lblMaLS);
            this.grbThongTinNCC.Location = new System.Drawing.Point(12, 50);
            this.grbThongTinNCC.Name = "grbThongTinNCC";
            this.grbThongTinNCC.Size = new System.Drawing.Size(412, 108);
            this.grbThongTinNCC.TabIndex = 40;
            this.grbThongTinNCC.TabStop = false;
            this.grbThongTinNCC.Text = "Thông tin loại sách";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLoai.Location = new System.Drawing.Point(126, 64);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(270, 24);
            this.txtTenLoai.TabIndex = 1;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLoai.Location = new System.Drawing.Point(126, 28);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(270, 24);
            this.txtMaLoai.TabIndex = 1;
            // 
            // lblTenLS
            // 
            this.lblTenLS.AutoSize = true;
            this.lblTenLS.Location = new System.Drawing.Point(20, 67);
            this.lblTenLS.Name = "lblTenLS";
            this.lblTenLS.Size = new System.Drawing.Size(96, 18);
            this.lblTenLS.TabIndex = 0;
            this.lblTenLS.Text = "Tên loại sách";
            // 
            // lblMaLS
            // 
            this.lblMaLS.AutoSize = true;
            this.lblMaLS.Location = new System.Drawing.Point(20, 31);
            this.lblMaLS.Name = "lblMaLS";
            this.lblMaLS.Size = new System.Drawing.Size(92, 18);
            this.lblMaLS.TabIndex = 0;
            this.lblMaLS.Text = "Mã loại sách";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.Aqua;
            this.btnLuu.Image = global::QuanLyMuaBanSach.Properties.Resources._32;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(567, 108);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 44);
            this.btnLuu.TabIndex = 42;
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
            this.btnSua.Location = new System.Drawing.Point(567, 57);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 44);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(567, 368);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 39);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Aqua;
            this.btnXoa.Image = global::QuanLyMuaBanSach.Properties.Resources.delete_icon31;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(433, 108);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 44);
            this.btnXoa.TabIndex = 44;
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
            this.btnThem.Location = new System.Drawing.Point(433, 57);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 45);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmCapNhatLoaiSach
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(694, 413);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDSLoaiSach);
            this.Controls.Add(this.grbThongTinNCC);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCapNhatLoaiSach";
            this.Text = "Cập nhật loại sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCapNhatLoaiSach_FormClosing);
            this.Load += new System.EventHandler(this.frmCapNhatLoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiSach)).EndInit();
            this.grbThongTinNCC.ResumeLayout(false);
            this.grbThongTinNCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvDSLoaiSach;
        private System.Windows.Forms.GroupBox grbThongTinNCC;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label lblTenLS;
        private System.Windows.Forms.Label lblMaLS;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}