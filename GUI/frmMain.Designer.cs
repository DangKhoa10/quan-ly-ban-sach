
namespace QuanLyMuaBanSach.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSachTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSachCN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSachCNS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSachCNTG = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSachCNLS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSachCNNXB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSachDS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSachTKSMN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSachTKSDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSachTKSTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDTKDT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHDTKCNS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKHTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKHCN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKHXTT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKHTKKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVienTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVienCN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVienLapPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVienDSPN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVienQLPD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVienQLNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSach,
            this.mnuHD,
            this.mnuKH,
            this.mnuNhanVien,
            this.mnuHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSach
            // 
            this.mnuSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSachTK,
            this.mnuSachCN,
            this.mnuSachDS,
            this.mnuSachTKSMN,
            this.mnuSachTKSDB,
            this.mnuSachTKSTK});
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Size = new System.Drawing.Size(44, 20);
            this.mnuSach.Text = "Sách";
            // 
            // mnuSachTK
            // 
            this.mnuSachTK.Image = global::QuanLyMuaBanSach.Properties.Resources.icons8_search_64;
            this.mnuSachTK.Name = "mnuSachTK";
            this.mnuSachTK.Size = new System.Drawing.Size(199, 22);
            this.mnuSachTK.Text = "Tìm Kiếm";
            this.mnuSachTK.Click += new System.EventHandler(this.mnuSachTK_Click);
            // 
            // mnuSachCN
            // 
            this.mnuSachCN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSachCNS,
            this.mnuSachCNTG,
            this.mnuSachCNLS,
            this.mnuSachCNNXB});
            this.mnuSachCN.Image = global::QuanLyMuaBanSach.Properties.Resources.pencil_icon;
            this.mnuSachCN.Name = "mnuSachCN";
            this.mnuSachCN.Size = new System.Drawing.Size(199, 22);
            this.mnuSachCN.Text = "Cập Nhật";
            // 
            // mnuSachCNS
            // 
            this.mnuSachCNS.Image = ((System.Drawing.Image)(resources.GetObject("mnuSachCNS.Image")));
            this.mnuSachCNS.Name = "mnuSachCNS";
            this.mnuSachCNS.Size = new System.Drawing.Size(199, 22);
            this.mnuSachCNS.Text = "Cập Nhật Sách";
            this.mnuSachCNS.Click += new System.EventHandler(this.mnuSachCNS_Click);
            // 
            // mnuSachCNTG
            // 
            this.mnuSachCNTG.Image = ((System.Drawing.Image)(resources.GetObject("mnuSachCNTG.Image")));
            this.mnuSachCNTG.Name = "mnuSachCNTG";
            this.mnuSachCNTG.Size = new System.Drawing.Size(199, 22);
            this.mnuSachCNTG.Text = "Cập Nhật Tác Giả";
            this.mnuSachCNTG.Click += new System.EventHandler(this.mnuSachCNTG_Click);
            // 
            // mnuSachCNLS
            // 
            this.mnuSachCNLS.Image = ((System.Drawing.Image)(resources.GetObject("mnuSachCNLS.Image")));
            this.mnuSachCNLS.Name = "mnuSachCNLS";
            this.mnuSachCNLS.Size = new System.Drawing.Size(199, 22);
            this.mnuSachCNLS.Text = "Cập Nhật Loại Sách";
            this.mnuSachCNLS.Click += new System.EventHandler(this.mnuSachCNLS_Click);
            // 
            // mnuSachCNNXB
            // 
            this.mnuSachCNNXB.Image = ((System.Drawing.Image)(resources.GetObject("mnuSachCNNXB.Image")));
            this.mnuSachCNNXB.Name = "mnuSachCNNXB";
            this.mnuSachCNNXB.Size = new System.Drawing.Size(199, 22);
            this.mnuSachCNNXB.Text = "Cập Nhật Nhà Xuất Bản";
            this.mnuSachCNNXB.Click += new System.EventHandler(this.mnuSachCNNXB_Click);
            // 
            // mnuSachDS
            // 
            this.mnuSachDS.Image = global::QuanLyMuaBanSach.Properties.Resources.icons8_cart_64;
            this.mnuSachDS.Name = "mnuSachDS";
            this.mnuSachDS.Size = new System.Drawing.Size(199, 22);
            this.mnuSachDS.Text = "Đặt Sách";
            this.mnuSachDS.Click += new System.EventHandler(this.mnuSachDS_Click);
            // 
            // mnuSachTKSMN
            // 
            this.mnuSachTKSMN.Image = global::QuanLyMuaBanSach.Properties.Resources.note;
            this.mnuSachTKSMN.Name = "mnuSachTKSMN";
            this.mnuSachTKSMN.Size = new System.Drawing.Size(199, 22);
            this.mnuSachTKSMN.Text = "Thống Kê Sách Nhập";
            this.mnuSachTKSMN.Click += new System.EventHandler(this.mnuSachTKSMN_Click);
            // 
            // mnuSachTKSDB
            // 
            this.mnuSachTKSDB.Image = global::QuanLyMuaBanSach.Properties.Resources.note;
            this.mnuSachTKSDB.Name = "mnuSachTKSDB";
            this.mnuSachTKSDB.Size = new System.Drawing.Size(199, 22);
            this.mnuSachTKSDB.Text = "Thống Kê Sách Đã Bán";
            this.mnuSachTKSDB.Click += new System.EventHandler(this.mnuSachTKSDB_Click);
            // 
            // mnuSachTKSTK
            // 
            this.mnuSachTKSTK.Image = global::QuanLyMuaBanSach.Properties.Resources.note;
            this.mnuSachTKSTK.Name = "mnuSachTKSTK";
            this.mnuSachTKSTK.Size = new System.Drawing.Size(199, 22);
            this.mnuSachTKSTK.Text = "Thống Kê Sách Tồn Kho";
            this.mnuSachTKSTK.Click += new System.EventHandler(this.mnuSachTKSTK_Click);
            // 
            // mnuHD
            // 
            this.mnuHD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHDTK,
            this.mnuHDLHD,
            this.mnuHDTKDT,
            this.mnuHDTKCNS});
            this.mnuHD.Name = "mnuHD";
            this.mnuHD.Size = new System.Drawing.Size(66, 20);
            this.mnuHD.Text = "Hóa Đơn";
            // 
            // mnuHDTK
            // 
            this.mnuHDTK.Image = global::QuanLyMuaBanSach.Properties.Resources.icons8_search_64;
            this.mnuHDTK.Name = "mnuHDTK";
            this.mnuHDTK.Size = new System.Drawing.Size(205, 22);
            this.mnuHDTK.Text = "Tìm Kiếm";
            this.mnuHDTK.Click += new System.EventHandler(this.mnuHDTK_Click);
            // 
            // mnuHDLHD
            // 
            this.mnuHDLHD.Image = global::QuanLyMuaBanSach.Properties.Resources.icons8_bill_64;
            this.mnuHDLHD.Name = "mnuHDLHD";
            this.mnuHDLHD.Size = new System.Drawing.Size(205, 22);
            this.mnuHDLHD.Text = "Lập Hóa Đơn";
            this.mnuHDLHD.Click += new System.EventHandler(this.mnuHDLHD_Click);
            // 
            // mnuHDTKDT
            // 
            this.mnuHDTKDT.Image = global::QuanLyMuaBanSach.Properties.Resources.note;
            this.mnuHDTKDT.Name = "mnuHDTKDT";
            this.mnuHDTKDT.Size = new System.Drawing.Size(205, 22);
            this.mnuHDTKDT.Text = "Thống Kê Doanh Thu";
            this.mnuHDTKDT.Click += new System.EventHandler(this.mnuHDTKDT_Click);
            // 
            // mnuHDTKCNS
            // 
            this.mnuHDTKCNS.Image = global::QuanLyMuaBanSach.Properties.Resources.note;
            this.mnuHDTKCNS.Name = "mnuHDTKCNS";
            this.mnuHDTKCNS.Size = new System.Drawing.Size(205, 22);
            this.mnuHDTKCNS.Text = "Thống Kê Chi Nhập Sách";
            this.mnuHDTKCNS.Click += new System.EventHandler(this.mnuHDTKCNS_Click);
            // 
            // mnuKH
            // 
            this.mnuKH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKHTK,
            this.mnuKHCN,
            this.mnuKHXTT,
            this.mnuKHTKKH});
            this.mnuKH.Name = "mnuKH";
            this.mnuKH.Size = new System.Drawing.Size(84, 20);
            this.mnuKH.Text = "Khách Hàng";
            // 
            // mnuKHTK
            // 
            this.mnuKHTK.Image = global::QuanLyMuaBanSach.Properties.Resources.icons8_search_64;
            this.mnuKHTK.Name = "mnuKHTK";
            this.mnuKHTK.Size = new System.Drawing.Size(192, 22);
            this.mnuKHTK.Text = "Tìm Kiếm";
            this.mnuKHTK.Click += new System.EventHandler(this.mnuKHTK_Click);
            // 
            // mnuKHCN
            // 
            this.mnuKHCN.Image = global::QuanLyMuaBanSach.Properties.Resources.pencil_icon;
            this.mnuKHCN.Name = "mnuKHCN";
            this.mnuKHCN.Size = new System.Drawing.Size(192, 22);
            this.mnuKHCN.Text = "Cập Nhật";
            this.mnuKHCN.Click += new System.EventHandler(this.mnuKHCN_Click);
            // 
            // mnuKHXTT
            // 
            this.mnuKHXTT.Image = global::QuanLyMuaBanSach.Properties.Resources.user;
            this.mnuKHXTT.Name = "mnuKHXTT";
            this.mnuKHXTT.Size = new System.Drawing.Size(192, 22);
            this.mnuKHXTT.Text = "Xem Thông Tin";
            this.mnuKHXTT.Click += new System.EventHandler(this.mnuKHXTT_Click);
            // 
            // mnuKHTKKH
            // 
            this.mnuKHTKKH.Image = global::QuanLyMuaBanSach.Properties.Resources.note;
            this.mnuKHTKKH.Name = "mnuKHTKKH";
            this.mnuKHTKKH.Size = new System.Drawing.Size(192, 22);
            this.mnuKHTKKH.Text = "Thống Kê Khách Hàng";
            this.mnuKHTKKH.Click += new System.EventHandler(this.mnuKHTKKH_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVienTimKiem,
            this.mnuNhanVienCN,
            this.mnuNhanVienLapPhieuNhap,
            this.mnuNhanVienDSPN,
            this.mnuNhanVienQLPD,
            this.mnuNhanVienQLNCC});
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(74, 20);
            this.mnuNhanVien.Text = "Nhân Viên";
            // 
            // mnuNhanVienTimKiem
            // 
            this.mnuNhanVienTimKiem.Image = global::QuanLyMuaBanSach.Properties.Resources.icons8_search_64;
            this.mnuNhanVienTimKiem.Name = "mnuNhanVienTimKiem";
            this.mnuNhanVienTimKiem.Size = new System.Drawing.Size(198, 22);
            this.mnuNhanVienTimKiem.Text = "Tìm Kiếm";
            this.mnuNhanVienTimKiem.Click += new System.EventHandler(this.mnuNhanVienTimKiem_Click);
            // 
            // mnuNhanVienCN
            // 
            this.mnuNhanVienCN.Image = global::QuanLyMuaBanSach.Properties.Resources.pencil_icon;
            this.mnuNhanVienCN.Name = "mnuNhanVienCN";
            this.mnuNhanVienCN.Size = new System.Drawing.Size(198, 22);
            this.mnuNhanVienCN.Text = "Cập Nhật";
            this.mnuNhanVienCN.Click += new System.EventHandler(this.mnuNhanVienCN_Click);
            // 
            // mnuNhanVienLapPhieuNhap
            // 
            this.mnuNhanVienLapPhieuNhap.Image = global::QuanLyMuaBanSach.Properties.Resources.icons8_bill_64;
            this.mnuNhanVienLapPhieuNhap.Name = "mnuNhanVienLapPhieuNhap";
            this.mnuNhanVienLapPhieuNhap.Size = new System.Drawing.Size(198, 22);
            this.mnuNhanVienLapPhieuNhap.Text = "Lập Phiếu Nhập";
            this.mnuNhanVienLapPhieuNhap.Click += new System.EventHandler(this.mnuPNSLPN_Click);
            // 
            // mnuNhanVienDSPN
            // 
            this.mnuNhanVienDSPN.Image = global::QuanLyMuaBanSach.Properties.Resources.icons8_list_64;
            this.mnuNhanVienDSPN.Name = "mnuNhanVienDSPN";
            this.mnuNhanVienDSPN.Size = new System.Drawing.Size(198, 22);
            this.mnuNhanVienDSPN.Text = "Danh Sách Phiếu Nhập";
            this.mnuNhanVienDSPN.Click += new System.EventHandler(this.mnuPNSDSPN_Click);
            // 
            // mnuNhanVienQLPD
            // 
            this.mnuNhanVienQLPD.Image = global::QuanLyMuaBanSach.Properties.Resources.icons8_list_64;
            this.mnuNhanVienQLPD.Name = "mnuNhanVienQLPD";
            this.mnuNhanVienQLPD.Size = new System.Drawing.Size(198, 22);
            this.mnuNhanVienQLPD.Text = "Danh Sách Phiếu Đặt";
            this.mnuNhanVienQLPD.Click += new System.EventHandler(this.mnuPDSDSPD_Click);
            // 
            // mnuNhanVienQLNCC
            // 
            this.mnuNhanVienQLNCC.Image = global::QuanLyMuaBanSach.Properties.Resources.pencil_icon;
            this.mnuNhanVienQLNCC.Name = "mnuNhanVienQLNCC";
            this.mnuNhanVienQLNCC.Size = new System.Drawing.Size(198, 22);
            this.mnuNhanVienQLNCC.Text = "Quản Lý Nhà Cung Cấp";
            this.mnuNhanVienQLNCC.Click += new System.EventHandler(this.mnuNhanVienQLNCC_Click);
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThongDangXuat,
            this.mnuHeThongThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(71, 20);
            this.mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuHeThongDangXuat
            // 
            this.mnuHeThongDangXuat.Image = global::QuanLyMuaBanSach.Properties.Resources.logout;
            this.mnuHeThongDangXuat.Name = "mnuHeThongDangXuat";
            this.mnuHeThongDangXuat.Size = new System.Drawing.Size(128, 22);
            this.mnuHeThongDangXuat.Text = "Đăng xuất";
            this.mnuHeThongDangXuat.Click += new System.EventHandler(this.mnuHeThongDangXuat_Click);
            // 
            // mnuHeThongThoat
            // 
            this.mnuHeThongThoat.Image = global::QuanLyMuaBanSach.Properties.Resources.cross;
            this.mnuHeThongThoat.Name = "mnuHeThongThoat";
            this.mnuHeThongThoat.Size = new System.Drawing.Size(128, 22);
            this.mnuHeThongThoat.Text = "Thoát";
            this.mnuHeThongThoat.Click += new System.EventHandler(this.mnuHeThongThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::QuanLyMuaBanSach.Properties.Resources.anhnen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Quản Lý Mua Bán Sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripMenuItem mnuSachTK;
        private System.Windows.Forms.ToolStripMenuItem mnuSachCN;
        private System.Windows.Forms.ToolStripMenuItem mnuSachDS;
        private System.Windows.Forms.ToolStripMenuItem mnuSachTKSMN;
        private System.Windows.Forms.ToolStripMenuItem mnuSachTKSDB;
        private System.Windows.Forms.ToolStripMenuItem mnuHD;
        private System.Windows.Forms.ToolStripMenuItem mnuHDTK;
        private System.Windows.Forms.ToolStripMenuItem mnuHDLHD;
        private System.Windows.Forms.ToolStripMenuItem mnuHDTKDT;
        private System.Windows.Forms.ToolStripMenuItem mnuKH;
        private System.Windows.Forms.ToolStripMenuItem mnuKHTK;
        private System.Windows.Forms.ToolStripMenuItem mnuKHCN;
        private System.Windows.Forms.ToolStripMenuItem mnuKHXTT;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVienLapPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVienDSPN;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVienQLPD;
        private System.Windows.Forms.ToolStripMenuItem mnuSachCNS;
        private System.Windows.Forms.ToolStripMenuItem mnuSachCNTG;
        private System.Windows.Forms.ToolStripMenuItem mnuSachCNLS;
        private System.Windows.Forms.ToolStripMenuItem mnuSachCNNXB;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVienTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVienCN;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVienQLNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuSachTKSTK;
        private System.Windows.Forms.ToolStripMenuItem mnuKHTKKH;
        private System.Windows.Forms.ToolStripMenuItem mnuHDTKCNS;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongThoat;
    }
}