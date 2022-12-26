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
using QuanLyMuaBanSach.GUI;

namespace QuanLyMuaBanSach.GUI
{
    public partial class frmThanhToanHoaDon : Form
    {
        public frmThanhToanHoaDon()
        {
            InitializeComponent();
        }
        public frmThanhToanHoaDon(ListView dssp)
        {
            InitializeComponent();
            this.dssp = dssp;
        }
        public frmThanhToanHoaDon(ListView dssp, string maKHDangChon, bool dangChonKH)
        {
            InitializeComponent();
            this.dssp = dssp;
            this.maKHDangChon = maKHDangChon;
            this.dangChonKH = dangChonKH;
        }

        ListView dssp;
        clsLogin login;
        clsKhachHang kh;
        clsHoaDon hd;
        clsSach sach;
        clsKhachHang khachHang;
        //clsNhanVien nv;
        clsCTHoaDon cthd;
        string maKH;
        string maHD;
        string maKHCu;
        Random rand;
        string maKHDangChon;
        bool dangChonKH = false;


        private void frmThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            //ctPhieuDat = new clsChiTietPhieuDat();
            login = frmLogin.login;
            //phieuDat = new clsPhieuDatSach();
            kh = new clsKhachHang();
            hd = new clsHoaDon();
            //nv = new clsNhanVien();
            rand = new Random();
            cthd = new clsCTHoaDon();
            sach = new clsSach();
            khachHang = new clsKhachHang();
            TaoTieuDeCot(lstDSSP);
            TaiDSSP(this.dssp);
            TaiThongTin();
            lblTongTien.Text = string.Format("{0:#,###}", TinhTien()) + " VNĐ";
        }

        void TaiThongTin()
        {
            if (this.dangChonKH)
            {
                this.maKH = this.maKHDangChon;
                KhachHang kh = khachHang.GetKHTheoMa(this.maKHDangChon).FirstOrDefault();
                txtTenKH.Text = kh.TenKH;
                txtDiaChi.Text = kh.DiaChi;
                txtSoDienThoai.Text = kh.SDT;
                txtDiaChi.Enabled = false;
                txtSoDienThoai.Enabled = false;
                txtTenKH.Enabled = false;
                dtmNgayLapDon.Enabled = false;
                btnTim.Visible = false;
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            IEnumerable<KhachHang> danhSachKH = kh.GetAllKH();
            if (KiemTraTrungSoDT(danhSachKH, txtSoDienThoai.Text) == false)
            {
                if (txtTenKH.Text == "")
                {
                    MessageBox.Show("Hãy nhập tên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (BoDau(txtTenKH.Text).KiemTraTen() == false)
                {
                    MessageBox.Show("Tên đã nhập sai định dạng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSoDienThoai.Text == "")
                {
                    MessageBox.Show("Hãy nhập số điện thoại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSoDienThoai.Text.KiemTraSDT() == false)
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
                    DialogResult hoi = MessageBox.Show("Xác nhận thanh toán không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (hoi == DialogResult.Yes)
                    {
                        KhachHang khachHang = new KhachHang();
                        khachHang = TaoKhachHang();
                        int rs = this.kh.themKH(khachHang);
                        if (rs == 1) // thêm đc khách hàng
                        {
                            HoaDon hd = TaoHoaDon();
                            this.hd.ThemHoaDon(hd);
                            ThemChiTietHoaDon();
                            MessageBox.Show("Đã Thanh toán hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InHoaDon();
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
            else
            {
                // tạo kh -> tạo hóa đơn -> tạo chi tiết hóa đơn
                DialogResult hoi = MessageBox.Show("Xác nhận thanh toán không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hoi == DialogResult.Yes)
                {
                    KhachHang kh = this.kh.GetKHTheoSDT(txtSoDienThoai.Text.ToString()).FirstOrDefault();
                    //KhachHang khachHang = new KhachHang();
                    //khachHang = TaoKhachHang();
                    //int rs = this.kh.themKH(khachHang);
                    if (kh != null) // thêm đc khách hàng
                    {
                        this.maKHCu = kh.MaKH;
                        HoaDon hd = TaoHoaDonKHCu();
                        this.hd.ThemHoaDon(hd);
                        ThemChiTietHoaDon();
                        MessageBox.Show("Đã Thanh toán hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InHoaDon();
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
        //private void btnXuatHoaDon_Click(object sender, EventArgs e)
        //{
        //    if (dgvDSHD.SelectedRows.Count == 1)
        //    {
        //        this.maHD = dgvDSHD.SelectedRows[0].Cells[0].Value.ToString();
        //        InHoaDon();
        //    }
        //    else
        //    {
        //        MessageBox.Show("chỉ chọn 1 hóa đơn để lập");
        //    }
        //}
        private void prdHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string maHD = this.maHD;
            HoaDon hoaDon = hd.GetHoaDonTheoMa(maHD).FirstOrDefault();

            var w = prdHoaDon.DefaultPageSettings.PaperSize.Width;// lấy chiều rông giấy in

            e.Graphics.DrawString(
                "Hiệu Sách HKN".ToUpper(),
                new Font("Courier New", 18, FontStyle.Bold),
                Brushes.Black,
                new Point(50, 20)
                );
            e.Graphics.DrawString(
                this.maHD.ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w / 2 + 200, 20)
                );
            e.Graphics.DrawString(
                "12 Nguyễn Văn Bảo, phường 4, quận Gò Vấp".ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(50, 50)
                );
            e.Graphics.DrawString(
                String.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")).ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w / 2 + 200, 50)
                );
            KhachHang khachHang = this.kh.GetKHTheoMa(hoaDon.MaKH).FirstOrDefault();
            e.Graphics.DrawString(
                "Khách Hàng: " + khachHang.TenKH.ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(50, 90)
                );
            e.Graphics.DrawString(
                "SDT: " + khachHang.SDT,
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w / 2 + 200, 90)
                );

            // format but ve
            Pen blackPen = new Pen(Color.Black, 1);

            //toa do theo chieu doc
            var y = 125;

            //dinh nghia 2 diem ve duong thang
            // canh le trai va phai 10
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);

            e.Graphics.DrawLine(blackPen, p1, p2);
            y += 10;
            e.Graphics.DrawString(
                "Stt".ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(50, y)
                );
            e.Graphics.DrawString(
                "Tên sách".ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(150, y)
                );
            e.Graphics.DrawString(
                "Số lượng".ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w / 2, y)
                );
            e.Graphics.DrawString(
                "Đơn giá".ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w / 2 + 100, y)
                );
            e.Graphics.DrawString(
                "Thành tiền".ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w / 2 + 230, y)
                );

            IEnumerable<dynamic> chiTietHD = cthd.GetCTHDTheoMa2(this.maHD);
            y += 50;
            int i = 1;
            double tongTienHD = 0; ;
            foreach (var item in chiTietHD)
            {
                double sum = (double)(item.GiaBan * item.SoLuong);
                e.Graphics.DrawString(String.Format("{0}", i).ToUpper(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(50, y));
                e.Graphics.DrawString(item.TenSach, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(150, y));
                e.Graphics.DrawString(String.Format("{0}", item.SoLuong), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
                e.Graphics.DrawString(String.Format("{0:N}", item.GiaBan), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
                e.Graphics.DrawString(String.Format("{0:N}", sum), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 230, y));
                tongTienHD += sum;
                y += 30;
                i++;
            }
            y += 20;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);
            y += 30;
            e.Graphics.DrawString("Tổng hóa đơn".ToUpper(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(50, y));
            e.Graphics.DrawString(String.Format("{0:N} VND", tongTienHD), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 150, y));
            y += 50;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);
            y += 30;
            e.Graphics.DrawString("Cảm ơn quý khách và hẹn gặp lại".ToUpper(), new Font("Courier New", 18, FontStyle.Bold), Brushes.Black, new Point(170, y));
        }
        private void InHoaDon()
        {
            ppdHoaDon.Document = prdHoaDon;
            ppdHoaDon.ShowDialog();
        }
        HoaDon TaoHoaDonKHCu()
        {
            HoaDon hd = new HoaDon();
            IEnumerable<HoaDon> dshd = this.hd.GetAllHD();
            string maHD;
            maHD = TaoMaHoaDon();
            this.maHD = maHD;
            hd.MaHD = maHD;
            hd.NgayLapHD = dtmNgayLapDon.Value;
            hd.MaKH = this.maKHCu;
            TaiKhoan tk = login.getTaiKhoan(login.Username).FirstOrDefault();
            //NhanVien nVien = nv.GetNVTheoMa(tk.MaNV).FirstOrDefault();
            hd.MaNV = tk.MaNV;
            return hd;
        }
        string TaoMaHoaDon()
        {
            string maHD = "";
            IEnumerable<HoaDon> hd = this.hd.GetAllHD();
            string maHDcuoi= hd.Last().MaHD;
            int so = Convert.ToInt32(maHDcuoi.Substring(2)) + 1;
            if (so < 10)
                maHD = "HD0000" + so.ToString();
            else if (so < 100)
                maHD = "HD000" + so.ToString();
            else if (so < 1000)
                maHD = "HD00" + so.ToString();
            else if (so < 10000)
                maHD = "HD0" + so.ToString();
            else
                maHD = "HD" + so.ToString();
            return maHD;
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
        void ThemChiTietHoaDon()
        {
            for (int i = 0; i < lstDSSP.Items.Count; i++)
            {
                CTHD chiTietHD = new CTHD();
                chiTietHD.MaHD = this.maHD;
                chiTietHD.MaSach = lstDSSP.Items[i].SubItems[0].Text;
                chiTietHD.SoLuong = Int32.Parse(lstDSSP.Items[i].SubItems[3].Text);
                chiTietHD.GiaBan = decimal.Parse(lstDSSP.Items[i].SubItems[2].Text);
                this.cthd.ThemCTHoaDon(chiTietHD);
                CapNhatSLSach(chiTietHD.MaSach, Int32.Parse(chiTietHD.SoLuong.ToString()));
                //CapNhatSLSach(chiTietPD.MaSach, int.Parse(chiTietPD.SoLuong.ToString()));
            }
        }
        void CapNhatSLSach(string maSach, int soLuongMua)
        {
            sach.SuaSoLuong(maSach, soLuongMua);
        }

        HoaDon TaoHoaDon()
        {

            HoaDon hd = new HoaDon();
            IEnumerable<HoaDon> dshd = this.hd.GetAllHD();
            string maHD;
            maHD = TaoMaHoaDon();
            this.maHD = maHD;
            hd.MaHD = maHD;
            hd.NgayLapHD = dtmNgayLapDon.Value;
            hd.MaKH = this.maKH;
            TaiKhoan tk = login.getTaiKhoan(login.Username).FirstOrDefault();
            //NhanVien nVien = nv.GetNVTheoMa(tk.MaNV).FirstOrDefault();
            hd.MaNV = tk.MaNV;
            return hd;
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
        int KiemTraTrungMaHD(IEnumerable<HoaDon> dsHoaDon, string maHD) // trung -> 1, khong trung -> -1
        {
            foreach (HoaDon hoaDon in dsHoaDon)
            {
                if (maHD == hoaDon.MaHD)
                    return 1;
            }
            return -1;
        }
        KhachHang TaoKhachHang()
        {
            KhachHang kh = new KhachHang();
            IEnumerable<KhachHang> dskh = this.kh.GetAllKH();
            string maKhachHang;
            maKhachHang = TaoMaKhachHang();
            this.maKH = maKhachHang;
            kh.MaKH = maKhachHang;
            kh.TenKH = txtTenKH.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SDT = txtSoDienThoai.Text;
            return kh;
        }
        string TaoMaKhachHang()
        {
            string maKH = "";
            IEnumerable<KhachHang> kh = this.kh.GetAllKH();
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
        int KiemTraTrungMaKH(IEnumerable<KhachHang> dsKhachHang, string maKH) // trung -> 1, khong trung -> -1
        {
            foreach (KhachHang khachHang in dsKhachHang)
            {
                if (maKH == khachHang.MaKH)
                    return 1;
            }
            return -1;
        }

        //void TaoDonDat()
        //{
        //    PhieuDatSach phieuDat = new PhieuDatSach();
        //    IEnumerable<PhieuDatSach> dsPhieuDat = this.phieuDat.GetAllPhieuDat();
        //    string maPhieuDat;
        //    do
        //    {
        //        maPhieuDat = "PD" + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() +
        //            rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString() + rand.Next(0, 9).ToString();
        //    }
        //    while (KiemTraTrungMa(dsPhieuDat, maPhieuDat) == 1);
        //    this.maPhieuDat = maPhieuDat;
        //    phieuDat.MaPhieuDat = maPhieuDat;
        //    phieuDat.NgayDat = DateTime.Today;
        //    phieuDat.TinhTrang = "Chưa xử lý";
        //    phieuDat.MaKH = this.ma;
        //    this.phieuDat.ThemPhieuDat(phieuDat);
        //}
        private void btnHuy_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        void TaiDSSP(ListView dssp)
        {
            foreach (ListViewItem item in dssp.Items)
            {
                ListViewItem newItem = CreateListViewItem(item);
                lstDSSP.Items.Add(newItem);
            }
        }
        long TinhTien()
        {
            long tong = 0;
            for (int i = 0; i < lstDSSP.Items.Count; i++)
            {
                tong += long.Parse(lstDSSP.Items[i].SubItems[4].Text);
            }
            return tong;
        }
        ListViewItem CreateListViewItem(ListViewItem item)
        {
            ListViewItem newItem;
            newItem = new ListViewItem(item.SubItems[0].Text);
            newItem.SubItems.Add(item.SubItems[1].Text);
            newItem.SubItems.Add(item.SubItems[2].Text);
            newItem.SubItems.Add(item.SubItems[3].Text);
            newItem.SubItems.Add(item.SubItems[4].Text);
            newItem.Tag = item;
            return newItem;
        }
        void TaoTieuDeCot(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã Sách", 140);
            lvw.Columns.Add("Tên Sách", 350);
            lvw.Columns.Add("Đơn Giá", 180);
            lvw.Columns.Add("Số Lượng", 180);
            lvw.Columns.Add("Thành Tiền", 180);
            //ColumnHeaderAutoResizeStyle n = new ColumnHeaderAutoResizeStyle();
            //lvw.AutoResizeColumns(n);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text.Trim() != "")
            {
                if (txtSoDienThoai.Text.KiemTraSDT() == true)
                {
                    IEnumerable<KhachHang> danhSachKH = kh.GetAllKH();
                    if (KiemTraTrungSoDT(danhSachKH, txtSoDienThoai.Text) == true)
                    {
                        KhachHang kh = this.kh.GetKHTheoSDT(txtSoDienThoai.Text.ToString()).FirstOrDefault();
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
                    MessageBox.Show("Nhập sai định dạng số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nhập số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmThanhToanHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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
        //float TinhTien()
        //{
        //    float tong = 0;
        //    for (int i = 0; i < dgvDSSP.RowCount; i++)
        //    {
        //        tong += float.Parse(dgvDSSP.Rows[i].Cells[3].Value.ToString()) * float.Parse(dgvDSSP.Rows[i].Cells[2].Value.ToString());
        //    }
        //    return tong;
        //}
        //void TaiThongTin()
        //{



        //PhieuDatSach phieuDat = this.phieuDat.GetPhieuDatTheoMa(this.maPhieu).FirstOrDefault();
        //KhachHang khachHang = kh.GetKHTheoMa(phieuDat.MaKH).FirstOrDefault();
        //txtSoDienThoai.Text = phieuDat.MaPhieuDat;
        //txtTenKH.Text = khachHang.MaKH;
        //dtmNgayLapDon.Value = DateTime.Parse(phieuDat.NgayDat.ToString());
        //}
        //void ChinhDoRongCotVaTieuDe(DataGridView dgv)
        //{
        //    dgv.Columns[0].HeaderText = "Mã Phiếu Đặt";
        //    dgv.Columns[0].Width = 160;
        //    dgv.Columns[1].HeaderText = "Tên Khách Hàng";
        //    dgv.Columns[1].Width = 260;
        //    dgv.Columns[2].HeaderText = "Đơn Giá";
        //    dgv.Columns[2].Width = 160;
        //    dgv.Columns[3].HeaderText = "Số  Lượng";
        //    dgv.Columns[3].Width = 180;
        //}


        //private void btnHuyDon_Click(object sender, EventArgs e)
        //{
        //    PhieuDatSach phieuDat = this.phieuDat.GetPhieuDatTheoMa(this.maPhieu).FirstOrDefault();

        //    DialogResult xacNhan = MessageBox.Show("Bạn có đồng ý xóa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (xacNhan == DialogResult.Yes)
        //    {
        //        int rs = this.phieuDat.xoaPhieuDat(phieuDat);
        //        if (rs == 1)
        //        {
        //            MessageBox.Show("Đã xóa phiếu đặt hàng", "Thông Báo", MessageBoxButtons.OK);
        //            this.DialogResult = DialogResult.OK;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Không xóa được phiếu đặt", "Thông Báo", MessageBoxButtons.OK);
        //        }
        //    }
        //    else
        //    {

        //    }
        //}


    }
}
