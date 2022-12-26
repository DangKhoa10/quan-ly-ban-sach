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
    public partial class frmNVChiTietPhieuDat : Form
    {
        public frmNVChiTietPhieuDat()
        {
            InitializeComponent();
        }
        public frmNVChiTietPhieuDat(string maPhieuDat, string ngayDatPhieu)
        {
            InitializeComponent();
            this.maPhieuDat = maPhieuDat;
            this.ngayDatPhieu = ngayDatPhieu;


        }

        string maPhieuDat;
        string ngayDatPhieu;
        string maKH;
        string maHD;
        clsHoaDon hd;
        clsLogin login = frmLogin.login;
        clsHonLoan honLoan;
        clsPhieuDatSach phieuDat;
        clsKhachHang kh;
        clsSach sach;
        clsCTHoaDon cthd;
        Random rand;


        private void frmNVChiTietPhieuDat_Load(object sender, EventArgs e)
        {
            rand = new Random();
            this.phieuDat = new clsPhieuDatSach();
            this.kh = new clsKhachHang();
            this.honLoan = new clsHonLoan();
            this.hd = new clsHoaDon();
            this.sach = new clsSach();
            this.cthd = new clsCTHoaDon();
            dgvDSSP.DataSource = honLoan.GetChiTietPhieuDatTheoMaPhieuDat(this.maPhieuDat);
            dgvDSSP.MultiSelect = false;
            DoiTenCot();
            lblTongTien.Text = string.Format("{0:#,###}", TinhTien()) + " VNĐ";
            LayThongTin();
            EnableText();
        }
        void EnableText()
        {
            txtMaPhieuDat.Enabled = false;
            txtSDT.Enabled = false;
            txtTenKhachHang.Enabled = false;
            dtmNgayDat.Enabled = false;
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

                PhieuDatSach phieuDat = this.phieuDat.GetPhieuDatTheoMa(this.maPhieuDat).FirstOrDefault();
                if (phieuDat.TinhTrang == 0)// check xem phiếu ở trạng thái gì
                {
                    if (KiemTraDuSach() == 1) // có đủ sách
                    {
                        DialogResult r;
                        r = MessageBox.Show("Xác nhận đã thanh toán?", "Thông báo",
                            MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {
                            hd.ThemHoaDon(TaoHoaDon());
                            ThemChiTietHoaDon();
                            this.phieuDat.SuaPhieuDat(this.maPhieuDat, 1);
                            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK);
                            InHoaDon();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("không đủ sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Phiếu đặt đã được thanh toán rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

        }
        int KiemTraDuSach()
        {
            foreach (DataGridViewRow row in dgvDSSP.Rows)
            {
                string maSach = row.Cells[0].Value.ToString();
                Sach sach = this.sach.GetSachTheoMa(maSach).FirstOrDefault();
                if ((sach.SoLuongTon - Int32.Parse(row.Cells[2].Value.ToString())) < 0)
                    return 0;
            }
            return 1;
        }

        HoaDon TaoHoaDon()
        {
            HoaDon hd = new HoaDon();
            IEnumerable<HoaDon> dshd = this.hd.GetAllHD();
            string maHD;
            maHD = TaoMaHoaDon();
            this.maHD = maHD;
            hd.MaHD = maHD;
            hd.NgayLapHD = DateTime.Today;
            hd.MaKH = this.maKH;
            TaiKhoan tk = login.getTaiKhoan(login.Username).FirstOrDefault();
            hd.MaNV = tk.MaNV;
            return hd;
        }
        string TaoMaHoaDon()
        {
            string maHD = "";
            IEnumerable<HoaDon> hd = this.hd.GetAllHD();
            string maHDcuoi = hd.Last().MaHD;
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
        int KiemTraTrungMaHD(IEnumerable<HoaDon> dsHoaDon, string maHD) // trung -> 1, khong trung -> -1
        {
            foreach (HoaDon hoaDon in dsHoaDon)
            {
                if (maHD == hoaDon.MaHD)
                    return 1;
            }
            return -1;
        }

        void ThemChiTietHoaDon()
        {
            for (int i = 0; i < dgvDSSP.Rows.Count; i++)
            {
                CTHD chiTietHD = new CTHD();
                chiTietHD.MaHD = this.maHD;
                chiTietHD.MaSach = dgvDSSP.Rows[i].Cells[0].Value.ToString();
                chiTietHD.SoLuong = Int32.Parse(dgvDSSP.Rows[i].Cells[2].Value.ToString());
                chiTietHD.GiaBan = decimal.Parse(dgvDSSP.Rows[i].Cells[3].Value.ToString());
                this.cthd.ThemCTHoaDon(chiTietHD);
                CapNhatSLSach(chiTietHD.MaSach, Int32.Parse(chiTietHD.SoLuong.ToString()));
            }
        }

        void CapNhatSLSach(string maSach, int soLuongMua)
        {
            sach.SuaSoLuong(maSach, soLuongMua);
        }
        // ma, ten, sl, giaban



        void LayThongTin()
        {
            txtMaPhieuDat.Text = this.maPhieuDat;
            dtmNgayDat.Value = DateTime.Parse(this.ngayDatPhieu);
            PhieuDatSach phieuDat = this.phieuDat.GetPhieuDatTheoMa(this.maPhieuDat).FirstOrDefault();
            KhachHang khachHang = this.kh.GetKHTheoMa(phieuDat.MaKH).FirstOrDefault();
            txtTenKhachHang.Text = khachHang.TenKH;
            txtSDT.Text = khachHang.SDT;
            this.maKH = phieuDat.MaKH;
        }
        void DoiTenCot()
        {
            dgvDSSP.Columns[0].HeaderText = "Mã sách";
            dgvDSSP.Columns[0].Width = 130;
            dgvDSSP.Columns[1].HeaderText = "Tên sách";
            dgvDSSP.Columns[1].Width = 320;
            dgvDSSP.Columns[2].HeaderText = "Số lượng";
            dgvDSSP.Columns[2].Width = 130;
            dgvDSSP.Columns[3].HeaderText = "Giá bán";
            dgvDSSP.Columns[3].Width = 270;
        }

        float TinhTien()
        {
            float tong = 0;
            for (int i = 0; i < dgvDSSP.Rows.Count; i++)
            {
                tong += float.Parse(dgvDSSP.Rows[i].Cells[3].Value.ToString()) * float.Parse(dgvDSSP.Rows[i].Cells[2].Value.ToString());

            }
            return tong;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
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

        private void btnXoaPhieuDat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Đã xóa phiếu đặt", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                PhieuDatSach phieuDat = this.phieuDat.GetPhieuDatTheoMa(this.maPhieuDat).FirstOrDefault();
                int kq = this.phieuDat.xoaPhieuDat(phieuDat);
                if (kq == 1)
                {
                    MessageBox.Show("Đã xóa phiếu đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không xóa được phiếu đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmNVChiTietPhieuDat_FormClosing(object sender, FormClosingEventArgs e)
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
