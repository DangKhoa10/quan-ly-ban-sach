using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.GUI
{
    public partial class frmMain : Form
    {
        //private void mnuSachCN_Click(object sender, EventArgs e){}
        public frmMain()
        {
            InitializeComponent();
        }
        clsLogin login;
        bool isDangXuat = false;
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.login = frmLogin.login;
            PhanQuyen();
        }
        private int checkQuyen()
        {
            TaiKhoan tk = new clsTaiKhoan().GetAllTaiKhoan().Where(o => o.Username == login.Username).FirstOrDefault();
            if (tk.MaNV != null)
            {
                NhanVien nv = new clsNhanVien().GetNVTheoMa(tk.MaNV).FirstOrDefault();
                int chucVu = nv.ChucVu;
                return chucVu;
            }
            else
            {
                return 4;
            }
        }
        void PhanQuyen()
        {
            if (checkQuyen()==1)
                PhanQuyenChoQuanLy();
            else if (checkQuyen() == 2)
                PhanQuyenChoNVBanHang();
            else if (checkQuyen() == 3)
                PhanQuyenChoNVThongKe();
            else
                PhanQuyenChoKhachHang();
        }
        void PhanQuyenChoQuanLy()
        {
            mnuKHXTT.Visible = false;
        }
        void PhanQuyenChoNVThongKe()
        {
            // mnuSach
            mnuSachCN.Visible = false;
            mnuSachDS.Visible = false;


            //mnuHoaDon
            mnuHDLHD.Visible = false;


            //mnuKhachHang
            mnuKHCN.Visible = false;
            mnuKHXTT.Visible = false;
            mnuKHTK.Visible = false;

            //mnuNhanVien
            mnuNhanVien.Visible = false;
            //mnuNhanVienTimKiem.Visible = false;
            //mnuNhanVienCN.Visible = false;
            //mnuNhanVienLapPhieuNhap.Visible = false;
            //mnuNhanVienQLNCC.Visible = false;
            //mnuNhanVienQLPD.Visible = false;
        }

        void PhanQuyenChoKhachHang()
        {
            // mnuSach
            mnuSachCN.Visible = false;
            mnuSachTKSDB.Visible = false;
            mnuSachTKSDB.Visible = false;
            mnuSachTKSMN.Visible = false;
            mnuSachTKSTK.Visible = false;

            //mnuHoaDon
            mnuHD.Visible = false;

            //mnuKhachHang
            mnuKHCN.Visible = false;
            mnuKHTKKH.Visible = false;
            mnuKHTK.Visible = false;

            //mnuNhanVien
            mnuNhanVien.Visible = false;


        }
        void PhanQuyenChoNVBanHang()
        {
            // mnuSach
            mnuSachCN.Visible = false;
            mnuSachTKSDB.Visible = false;
            mnuSachTKSMN.Visible = false;
            mnuSachTKSTK.Visible = false;

            //mnuHoaDon
            mnuHDTKDT.Visible = false;
            mnuHDTKCNS.Visible = false;
            //mnuKhachHang
            mnuKHXTT.Visible = false;
            mnuKHTKKH.Visible = false;

            //mnuNhanVien
            mnuNhanVienTimKiem.Visible = false;
            mnuNhanVienCN.Visible = false;
            mnuNhanVienDSPN.Visible = false;
            mnuNhanVienQLNCC.Visible = false;
            mnuNhanVienLapPhieuNhap.Visible = false;
        }
        bool KiemTraTonTaiForm(string str)
        {
            foreach (Form frm in this.MdiChildren)
                if (frm.Name.Equals(str))
                {
                    frm.Activate();
                    return true;
                }
            return false;
        }


        private void mnuSachTK_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmTimKiemSach") == false)
            {
                GUI.frmTimKiemSach frm = new GUI.frmTimKiemSach();
                frm.MdiParent = this;
                frm.Name = "frmTimKiemSach";
                frm.Show();
            }
        }

        private void mnuKHTK_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmTimKiemKhachHang") == false)
            {
                GUI.frmTimKiemKhachHang frm = new GUI.frmTimKiemKhachHang();
                frm.MdiParent = this;
                frm.Name = "frmTimKiemKhachHang";
                frm.Show();
            }
        }

        private void mnuHDTK_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmTimKiemHoaDon") == false)
            {
                GUI.frmTimKiemHoaDon frm = new GUI.frmTimKiemHoaDon();
                frm.MdiParent = this;
                frm.Name = "frmTimKiemHoaDon";
                frm.Show();
            }
        }

        //private void mnuPNSTK_Click(object sender, EventArgs e)
        //{
        //    if (KiemTraTonTaiForm("frmTimKiemPhieuNhapSach") == false)
        //    {
        //        GUI.frmTimKiemPhieuNhapSach frm = new GUI.frmTimKiemPhieuNhapSach();
        //        frm.MdiParent = this;
        //        frm.Name = "frmTimKiemPhieuNhapSach";
        //        frm.Show();
        //    }
        //}

        //private void mnuPDSTK_Click(object sender, EventArgs e)
        //{
        //    if (KiemTraTonTaiForm("frmTimKiemPhieuDatSach") == false)
        //    {
        //        GUI.frmTimKiemPhieuDatSach frm = new GUI.frmTimKiemPhieuDatSach();
        //        frm.MdiParent = this;
        //        frm.Name = "frmTimKiemPhieuDatSach";
        //        frm.Show();
        //    }
        //}

        private void mnuKHCN_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmCapNhatKhachHang") == false)
            {
                GUI.frmCapNhatKhachHang frm = new GUI.frmCapNhatKhachHang();
                frm.MdiParent = this;
                frm.Name = "frmCapNhatKhachHang";
                frm.Show();
            }
        }

        private void mnuKHXTT_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmThongTinKhachHang") == false)
            {
                GUI.frmThongTinKhachHang frm = new GUI.frmThongTinKhachHang();
                frm.MdiParent = this;
                frm.Name = "frmThongTinKhachHang";
                frm.Show();
            }
        }

        private void mnuPNSLPN_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmLapPhieuNhap") == false)
            {
                GUI.frmLapPhieuNhap frm = new GUI.frmLapPhieuNhap();
                frm.MdiParent = this;
                frm.Name = "frmLapPhieuNhap";
                frm.Show();
            }
        }

        private void mnuHDLHD_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmLapHoaDon") == false)
            {
                GUI.frmLapHoaDon frm = new GUI.frmLapHoaDon();
                frm.MdiParent = this;
                frm.Name = "frmLapHoaDon";
                frm.Show();
            }
        }

        private void mnuSachTKSMN_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmThongKeSachMoiNhap") == false)
            {
                GUI.frmThongKeSachMoiNhap frm = new GUI.frmThongKeSachMoiNhap();
                frm.MdiParent = this;
                frm.Name = "frmThongSachMoiNhap";
                frm.Show();
            }
        }

        private void mnuSachTKSDB_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmThongKeSachDaBan") == false)
            {
                GUI.frmThongKeSachDaBan frm = new GUI.frmThongKeSachDaBan();
                frm.MdiParent = this;
                frm.Name = "frmThongKeSachDaBan";
                frm.Show();
            }
        }

        private void mnuHDTKDT_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmThongKeDoanhThu") == false)
            {
                GUI.frmThongKeDoanhThu frm = new GUI.frmThongKeDoanhThu();
                frm.MdiParent = this;
                frm.Name = "frmThongKeDoanhThu";
                frm.Show();
            }
        }
        private void mnuSachDS_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmDatSach") == false)
            {
                GUI.frmDatSach frm = new GUI.frmDatSach();
                frm.MdiParent = this;
                frm.Name = "frmDatSach";
                frm.Show();
            }
        }

        

        private void mnuPNSDSPN_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmDanhSachPhieuNhap") == false)
            {
                GUI.frmDanhSachPhieuNhap frm = new GUI.frmDanhSachPhieuNhap();
                frm.MdiParent = this;
                frm.Name = "frmDanhSachPhieuNhap";
                frm.Show();
            }
        }
        private void mnuPDSDSPD_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmDanhSachPhieuDat") == false)
            {
                GUI.frmDanhSachPhieuDat frm = new GUI.frmDanhSachPhieuDat();
                frm.MdiParent = this;
                frm.Name = "frmDanhSachPhieuDat";
                frm.Show();
            }
        }

 
        private void mnuSachCNTG_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmCapNhatTacGia") == false)
            {
                GUI.frmCapNhatTacGia frm = new GUI.frmCapNhatTacGia();
                frm.MdiParent = this;
                frm.Name = "frmCapNhatTacGia";
                frm.Show();
            }
        }

        private void mnuSachCNS_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmCapNhatSach") == false)
            {
                GUI.frmCapNhatSach frm = new GUI.frmCapNhatSach();
                frm.MdiParent = this;
                frm.Name = "frmCapNhatSach";
                frm.Show();
            }
        }

        private void mnuSachCNLS_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmCapNhatLoaiSach") == false)
            {
                GUI.frmCapNhatLoaiSach frm = new GUI.frmCapNhatLoaiSach();
                frm.MdiParent = this;
                frm.Name = "frmCapNhatLoaiSach";
                frm.Show();
            }
        }

        private void mnuSachCNNXB_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmCapNhatNhaXuatBan") == false)
            {
                GUI.frmCapNhatNhaXuatBan frm = new GUI.frmCapNhatNhaXuatBan();
                frm.MdiParent = this;
                frm.Name = "frmCapNhatNhaXuatBan";
                frm.Show();
            }
        }

        private void mnuNhanVienTimKiem_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmTimKiemNhanVien") == false)
            {
                GUI.frmTimKiemNhanVien frm = new GUI.frmTimKiemNhanVien();
                frm.MdiParent = this;
                frm.Name = "frmTimKiemNhanVien";
                frm.Show();
            }
        }

        private void mnuNhanVienCN_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmCapNhatNhanVien") == false)
            {
                GUI.frmCapNhatNhanVien frm = new GUI.frmCapNhatNhanVien();
                frm.MdiParent = this;
                frm.Name = "frmCapNhatNhanVien";
                frm.Show();
            }
        }

        private void mnuNhanVienQLNCC_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmQuanLyNhaCungCap") == false)
            {
                GUI.frmQuanLyNhaCungCap frm = new GUI.frmQuanLyNhaCungCap();
                frm.MdiParent = this;
                frm.Name = "frmQuanLyNhaCungCap";
                frm.Show();
            }
        }

        private void mnuSachTKSTK_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmThongKeTonKho") == false)
            {
                GUI.frmThongKeTonKho frm = new GUI.frmThongKeTonKho();
                frm.MdiParent = this;
                frm.Name = "frmThongKeTonKho";
                frm.Show();
            }
        }

        private void mnuKHTKKH_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmThongKeKhachHang") == false)
            {
                GUI.frmThongKeKhachHang frm = new GUI.frmThongKeKhachHang();
                frm.MdiParent = this;
                frm.Name = "frmThongKeKhachHang";
                frm.Show();
            }
        }

        private void mnuHDTKCNS_Click(object sender, EventArgs e)
        {
            if (KiemTraTonTaiForm("frmThongKeTienNhapSach") == false)
            {
                GUI.frmThongKeTienNhapSach frm = new GUI.frmThongKeTienNhapSach();
                frm.MdiParent = this;
                frm.Name = "frmThongKeTienNhapSach";
                frm.Show();
            }
        }

        private void mnuHeThongDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo",
                MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                this.isDangXuat = true;
                this.Close();
                frmLogin frm = new frmLogin();
                frm.Show();
            }
           
        }

        private void mnuHeThongThoat_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDangXuat == false)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo",
                    MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    //Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
