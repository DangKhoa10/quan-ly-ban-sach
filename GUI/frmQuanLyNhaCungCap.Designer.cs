
namespace QuanLyMuaBanSach.GUI
{
    partial class frmQuanLyNhaCungCap
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
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblTenNhaCC = new System.Windows.Forms.Label();
            this.lblMaNhaCC = new System.Windows.Forms.Label();
            this.grbThongTinNCC = new System.Windows.Forms.GroupBox();
            this.lblQuanLyNhaCungCap = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDSNCC = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbThongTinNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNCC.Location = new System.Drawing.Point(158, 64);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(238, 24);
            this.txtTenNCC.TabIndex = 1;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNCC.Location = new System.Drawing.Point(158, 28);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(238, 24);
            this.txtMaNCC.TabIndex = 1;
            // 
            // lblTenNhaCC
            // 
            this.lblTenNhaCC.AutoSize = true;
            this.lblTenNhaCC.Location = new System.Drawing.Point(20, 67);
            this.lblTenNhaCC.Name = "lblTenNhaCC";
            this.lblTenNhaCC.Size = new System.Drawing.Size(125, 18);
            this.lblTenNhaCC.TabIndex = 0;
            this.lblTenNhaCC.Text = "Tên nhà cung cấp";
            // 
            // lblMaNhaCC
            // 
            this.lblMaNhaCC.AutoSize = true;
            this.lblMaNhaCC.Location = new System.Drawing.Point(20, 31);
            this.lblMaNhaCC.Name = "lblMaNhaCC";
            this.lblMaNhaCC.Size = new System.Drawing.Size(121, 18);
            this.lblMaNhaCC.TabIndex = 0;
            this.lblMaNhaCC.Text = "Mã nhà cung cấp";
            // 
            // grbThongTinNCC
            // 
            this.grbThongTinNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinNCC.Controls.Add(this.txtTenNCC);
            this.grbThongTinNCC.Controls.Add(this.txtMaNCC);
            this.grbThongTinNCC.Controls.Add(this.lblTenNhaCC);
            this.grbThongTinNCC.Controls.Add(this.lblMaNhaCC);
            this.grbThongTinNCC.Location = new System.Drawing.Point(4, 47);
            this.grbThongTinNCC.Name = "grbThongTinNCC";
            this.grbThongTinNCC.Size = new System.Drawing.Size(420, 108);
            this.grbThongTinNCC.TabIndex = 7;
            this.grbThongTinNCC.TabStop = false;
            this.grbThongTinNCC.Text = "Thông tin nhà cung cấp";
            // 
            // lblQuanLyNhaCungCap
            // 
            this.lblQuanLyNhaCungCap.BackColor = System.Drawing.Color.Aqua;
            this.lblQuanLyNhaCungCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuanLyNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhaCungCap.ForeColor = System.Drawing.Color.Red;
            this.lblQuanLyNhaCungCap.Location = new System.Drawing.Point(0, 0);
            this.lblQuanLyNhaCungCap.Name = "lblQuanLyNhaCungCap";
            this.lblQuanLyNhaCungCap.Size = new System.Drawing.Size(687, 37);
            this.lblQuanLyNhaCungCap.TabIndex = 6;
            this.lblQuanLyNhaCungCap.Text = "Quản Lý Nhà Cung Cấp";
            this.lblQuanLyNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Location = new System.Drawing.Point(564, 375);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 39);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDSNCC
            // 
            this.dgvDSNCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSNCC.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNCC.Location = new System.Drawing.Point(4, 171);
            this.dgvDSNCC.Name = "dgvDSNCC";
            this.dgvDSNCC.Size = new System.Drawing.Size(676, 198);
            this.dgvDSNCC.TabIndex = 11;
            this.dgvDSNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNCC_CellClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.Aqua;
            this.btnLuu.Image = global::QuanLyMuaBanSach.Properties.Resources._32;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(564, 105);
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
            this.btnSua.Location = new System.Drawing.Point(564, 54);
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
            this.btnXoa.Location = new System.Drawing.Point(430, 105);
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
            this.btnThem.Location = new System.Drawing.Point(430, 54);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 45);
            this.btnThem.TabIndex = 49;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmQuanLyNhaCungCap
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(687, 418);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDSNCC);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbThongTinNCC);
            this.Controls.Add(this.lblQuanLyNhaCungCap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà cung cấp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyNhaCungCap_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyNhaCungCap_Load);
            this.grbThongTinNCC.ResumeLayout(false);
            this.grbThongTinNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblTenNhaCC;
        private System.Windows.Forms.Label lblMaNhaCC;
        private System.Windows.Forms.GroupBox grbThongTinNCC;
        private System.Windows.Forms.Label lblQuanLyNhaCungCap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDSNCC;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}