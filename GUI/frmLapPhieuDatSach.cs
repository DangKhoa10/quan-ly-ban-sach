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
    public partial class frmLapPhieuDatSach : Form
    {
        public frmLapPhieuDatSach()
        {
            InitializeComponent();
        }
        public frmLapPhieuDatSach(ListView gioHangNgoai)
        {
            InitializeComponent();
            gioHang = gioHangNgoai;
        }

        public frmLapPhieuDatSach(ListView gioHangNgoai, string maPDCu)
        {
            InitializeComponent();
            gioHang = gioHangNgoai;
            this.maPhieuDatCu = maPDCu;
            this.suaPhieuCu = true;
        }
        public frmLapPhieuDatSach(ListView gioHangNgoai, bool chonKhach, string makHDangDat)
        {
            InitializeComponent();
            gioHang = gioHangNgoai;
            this.DangDatKHDuocChon = true;
            this.maKHDangDat = makHDangDat;
        }

        clsLogin login = frmLogin.login;
        ListView gioHang;
        clsNhanVien nhanVien;
        clsKhachHang khachHang;
        clsPhieuDatSach phieuDat;
        clsChiTietPhieuDat ctPhieuDat;
        clsSach sach;
        string maPhieuDat;
        string ma;
        string maPhieuDatCu;
        bool suaPhieuCu;
        int taiKhoan;
        Random rand;
        string maKHDangDat;
        bool DangDatKHDuocChon = false;

        private void frmLapPhieuDatSach_Load(object sender, EventArgs e)
        {
            nhanVien = new clsNhanVien();
            khachHang = new clsKhachHang();
            rand = new Random();
            phieuDat = new clsPhieuDatSach();
            ctPhieuDat = new clsChiTietPhieuDat();
            sach = new clsSach();
            CreateColumn(lstvGioHang);
            loadGioHang(gioHang);
            LayLoaiTaiKhoan();
            lblTongTien.Text = string.Format("{0:#,###}", TinhTien()) + " VNĐ";
            TaiNgayHienTai();

            TaiThongTin();

            dtmNgayLapDon.Format = DateTimePickerFormat.Custom;
            dtmNgayLapDon.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            dtmNgayLapDon.Value = DateTime.Now;
        }
        private void btnDatSach_Click(object sender, EventArgs e)
        {
            if (this.taiKhoan == 0)//nếu là khách hàng nhấn đặt hàng
            {
                DialogResult rs = MessageBox.Show("Bạn có đồng ý đặt không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    TaoPhieuDat();
                    TaoChiTietPhieuDat();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Đã đặt thành công", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    // nhấn không đặt thì không làm gì
                }
            }
            else // nhân viên nhấn đặt hàng
            {
                NhanVienDatHang();
            }
        }
        void NhanVienDatHang()
        {
            if (this.suaPhieuCu != true) // nếu không phải sửa phiếu đặt cũ
            {
                IEnumerable<KhachHang> danhSachKH = khachHang.GetAllKH();
                if (KiemTraTrungSoDT(danhSachKH, txtSDT.Text) == false) // chưa từng mua hàng -> tạo kh mới
                {
                    if (txtTenKH.Text == "")
                    {
                        MessageBox.Show("Hãy nhập tên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (BoDau(txtTenKH.Text).KiemTraTen() == false)
                    {
                        MessageBox.Show("Tên đã nhập sai định dạng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtSDT.Text == "")
                    {
                        MessageBox.Show("Hãy nhập số điện thoại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtSDT.Text.KiemTraSDT() == false)
                    {
                        MessageBox.Show("Số điện thoại đã nhập sai định dạng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txtDiaChi.Text == "")
                    {
                        MessageBox.Show("Hãy nhập địa chỉ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // tạo kh -> tạo hóa đơn -> tạo chi tiết hóa đơn
                        DialogResult hoi = MessageBox.Show("Xác nhận đặt sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (hoi == DialogResult.Yes)
                        {
                            KhachHang khachHang = new KhachHang();
                            khachHang = TaoKhachHang();
                            int rs = this.khachHang.themKH(khachHang);
                            if (rs == 1) // thêm đc khách hàng
                            {
                                TaoPhieuDat(); // tạo và thêm phiếu đặt sách vào db
                                TaoChiTietPhieuDat(); // tạo chi tiết phiếu đặt và thêm vào db
                                MessageBox.Show("Đã tạo phiếu đặt cho khách hàng mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Không đặt hóa đơn được, vì không thêm được khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else//đã từng mua hàng -> chỉ tạo phiếu đặt và CTPhieu dat
                {
                    DialogResult hoi = MessageBox.Show("Xác nhận đặt sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hoi == DialogResult.Yes)
                    {
                        KhachHang kh = this.khachHang.GetKHTheoSDT(txtSDT.Text.ToString()).FirstOrDefault();
                        if (kh != null) // lấy đc khách hàng
                        {
                            this.ma = kh.MaKH;
                            TaoPhieuDat();
                            TaoChiTietPhieuDat();
                            MessageBox.Show("Đã tạo phiếu đặt cho khách hàng cũ: " + kh.TenKH, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không đặt hóa đơn được, vì không thêm được khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else // đang sửa phiếu cũ -> thêm hd mới -> xóa hd cũ
            {

                DialogResult hoi = MessageBox.Show("Xác nhận đặt sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    PhieuDatSach phieuDat = this.phieuDat.GetPhieuDatTheoMa(this.maPhieuDatCu).FirstOrDefault();
                    //KhachHang khachHang = this.khachHang.GetKHTheoMa(phieuDat.MaKH);
                    this.ma = phieuDat.MaKH; // mã kh đang đặt
                    TaoPhieuDat();
                    TaoChiTietPhieuDat();
                    XoaPhieuDatCu();
                    MessageBox.Show("Đã Thanh toán hóa đơn cho khách hàng mới đặt trong ngày:", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        void XoaPhieuDatCu()
        {
            PhieuDatSach pdCu = this.phieuDat.GetPhieuDatTheoMa(this.maPhieuDatCu).FirstOrDefault();
            this.phieuDat.xoaPhieuDat(pdCu);
        }
        void TaiKHCu(string maPD)
        {
            PhieuDatSach pd = this.phieuDat.GetPhieuDatTheoMa(maPD).FirstOrDefault();
            KhachHang kh = khachHang.GetKHTheoMa(pd.MaKH).FirstOrDefault();

            txtDiaChi.Text = kh.DiaChi;
            txtTenKH.Text = kh.TenKH;
            txtSDT.Text = kh.SDT;
        }
        KhachHang TaoKhachHang()
        {
            KhachHang kh = new KhachHang();
            IEnumerable<KhachHang> dskh = this.khachHang.GetAllKH();
            string maKhachHang;
            maKhachHang = TaoMaKhachHang();
            this.ma = maKhachHang;
            kh.MaKH = maKhachHang;
            kh.TenKH = txtTenKH.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SDT = txtSDT.Text;
            return kh;
        }
        string TaoMaKhachHang()
        {
            string maKH = "";
            IEnumerable<KhachHang> kh = khachHang.GetAllKH();
            string maKHLast = kh.Last().MaKH;
            int so = Convert.ToInt32(maKHLast.Substring(2)) + 1;
            if (so < 10)
                maKH = "KH0000" + so.ToString();
            else if (so < 100)
                maKH = "KH000" + so.ToString();
            else if (so < 1000)
                maKH = "KH00" + so.ToString();
            else if (so < 10000)
                maKH = "KH0" + so.ToString();
            else
                maKH = "KH" + so.ToString();
            return maKH;
        }
        void TaiThongTin()
        {
            if (this.taiKhoan == 0) // nếu là khách hàng đăng nhập
            {
                TaiKhoan tk = login.getTaiKhoan(login.Username).FirstOrDefault();
                this.ma = tk.MaKH;
                KhachHang kh = khachHang.GetKHTheoMa(tk.MaKH).FirstOrDefault();
                txtTenKH.Text = kh.TenKH;
                txtDiaChi.Text = kh.DiaChi;
                txtSDT.Text = kh.SDT;
                btnTim.Hide();
            }
            else // nếu là nhân viên đăng nhập
            {
                if (this.DangDatKHDuocChon)
                {
                    this.ma = this.maKHDangDat;
                    KhachHang kh = khachHang.GetKHTheoMa(this.maKHDangDat).FirstOrDefault();
                    txtTenKH.Text = kh.TenKH;
                    txtDiaChi.Text = kh.DiaChi;
                    txtSDT.Text = kh.SDT;
                    btnTim.Hide();
                }
                else
                {
                    if (this.suaPhieuCu == true)
                    {
                        TaiKHCu(this.maPhieuDatCu);
                        txtDiaChi.Enabled = false;
                        txtSDT.Enabled = false;
                        txtTenKH.Enabled = false;
                        dtmNgayLapDon.Enabled = false;
                        btnTim.Hide();
                    }
                    else
                    {
                        txtDiaChi.Enabled = true;
                        txtSDT.Enabled = true;
                        txtTenKH.Enabled = true;
                    }
                }
            }
        }

        void TaoChiTietPhieuDat()
        {
            for(int i = 0; i < lstvGioHang.Items.Count; i++)
            {
                CTPhieuDat chiTietPD = new CTPhieuDat();
                chiTietPD.MaPhieuDat = this.maPhieuDat;
                chiTietPD.MaSach = lstvGioHang.Items[i].SubItems[0].Text;
                chiTietPD.SoLuong= Int32.Parse(lstvGioHang.Items[i].SubItems[3].Text);
                chiTietPD.GiaBan = decimal.Parse(lstvGioHang.Items[i].SubItems[2].Text);
                ctPhieuDat.ThemCTPhieuDat(chiTietPD);
            }
        }
        void TaoPhieuDat()
        {
            PhieuDatSach phieuDat = new PhieuDatSach();
            IEnumerable<PhieuDatSach> dsPhieuDat = this.phieuDat.GetAllPhieuDat();
            string maPhieuDat; 
            maPhieuDat = TaoMaPhieuDat();
            this.maPhieuDat = maPhieuDat;
            phieuDat.MaPhieuDat = maPhieuDat;
            phieuDat.NgayDat = dtmNgayLapDon.Value;
            phieuDat.TinhTrang = 0;
            phieuDat.MaKH = this.ma;
            this.phieuDat.ThemPhieuDat(phieuDat);
        }
        string TaoMaPhieuDat()
        {
            string maPD = "";
            IEnumerable<PhieuDatSach> pd = this.phieuDat.GetAllPhieuDat();
            string maPHCuoi = pd.Last().MaPhieuDat;
            int so = Convert.ToInt32(maPHCuoi.Substring(2)) + 1;
            if (so < 10)
                maPD = "PD0000" + so.ToString();
            else if (so < 100)
                maPD = "PD000" + so.ToString();
            else if (so < 1000)
                maPD = "PD00" + so.ToString();
            else if (so < 10000)
                maPD = "PD0" + so.ToString();
            else
                maPD = "PD" + so.ToString();
            return maPD;
        }
        int KiemTraTrungMaKH(IEnumerable<KhachHang> dsKhachHang, string maKH) // trung -> 1, khong trung -> -1
        {
            foreach (KhachHang khachHang in dsKhachHang)
            {
                if (maKH == khachHang.MaKH)
                    return 1;
            }
            return -1;
        }
        int KiemTraTrungMa(IEnumerable<PhieuDatSach> dsPhieuDat, string maPhieu)
        {
            foreach (PhieuDatSach phieu in dsPhieuDat)
            {
                if (maPhieu == phieu.MaPhieuDat)
                    return 1;
            }
            return -1;
        }

        public string BoDau(string s)// Hàm bỏ dấu để check tên vd: Trung Hoài => Trung Hoai
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }
        private int KiemTraChucVu()
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
        void LayLoaiTaiKhoan()
        {
            if (KiemTraChucVu() != 4)
            {
                this.taiKhoan = 1;
            }
            else
            {
                this.taiKhoan = 0;
            }
        }
        long TinhTien()
        {
            long tong = 0;
            for (int i = 0; i < lstvGioHang.Items.Count; i++)
            {
                tong += long.Parse(lstvGioHang.Items[i].SubItems[4].Text);
                
            }
            return tong;
        }

        void TaiNgayHienTai()
        {
            dtmNgayLapDon.Value = DateTime.Today;
        }

        void CreateColumn(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã Sách", 100);
            lvw.Columns.Add("Tên Sách", 260);
            lvw.Columns.Add("Đơn Giá", 120);
            lvw.Columns.Add("Số Lượng", 150);
            lvw.Columns.Add("Thành Tiền", 120);
        }
        void loadGioHang(ListView gioHang)
        {
            foreach (ListViewItem item in gioHang.Items)
            {
                ListViewItem newItem = CreateListViewItem(item);
                lstvGioHang.Items.Add(newItem);
            }
        }
        ListViewItem CreateListViewItem(ListViewItem item)
        {
            ListViewItem newItem;
            newItem = new ListViewItem(item.SubItems[0].Text);
            newItem.SubItems.Add(item.SubItems[1].Text);
            newItem.SubItems.Add(item.SubItems[2].Text);
            newItem.SubItems.Add(item.SubItems[3].Text);
            newItem.SubItems.Add(item.SubItems[4].Text);
            return newItem;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text.Trim() != "")
            {
                if (txtSDT.Text.KiemTraSDT() == true)
                {
                    IEnumerable<KhachHang> danhSachKH = khachHang.GetAllKH();
                    if (KiemTraTrungSoDT(danhSachKH, txtSDT.Text) == true)
                    {
                        KhachHang kh = this.khachHang.GetKHTheoSDT(txtSDT.Text.ToString()).FirstOrDefault();
                        txtDiaChi.Text = kh.DiaChi;
                        txtTenKH.Text = kh.TenKH;
                    }
                    else
                    {
                        MessageBox.Show("Chưa có khách hàng này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Sai định dạng số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        Boolean KiemTraTrungSoDT(IEnumerable<KhachHang> dsKH, string sdt)
        {
            foreach (KhachHang kh in dsKH)
            {
                if (sdt == kh.SDT.ToString())
                    return true;
            }
            return false;
        }

        private void frmLapPhieuDatSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo",
                MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
