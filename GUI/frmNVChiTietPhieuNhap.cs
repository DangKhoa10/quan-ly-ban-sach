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
    public partial class frmNVChiTietPhieuNhap : Form
    {
        public frmNVChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        public frmNVChiTietPhieuNhap(string maPhieuNhap, string ngayLapPhieu)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap;
            this.ngayLapPhieu = ngayLapPhieu;
        }

        clsPhieuNhapSach pn;
        string maPhieuNhap;
        string ngayLapPhieu;
        clsHonLoan honLoan;
        clsCTPhieuNhap ctpn;

        private void frmNVChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            this.honLoan = new clsHonLoan();
            this.pn = new clsPhieuNhapSach();
            this.ctpn = new clsCTPhieuNhap();
            txtMaPhieuDat.Text = this.maPhieuNhap;
            dtmNgayDat.Value = DateTime.Parse(this.ngayLapPhieu);
            dgvDSSP.DataSource = honLoan.GetChiTietPhieuNhapSachTheoMaPhieuNhap(this.maPhieuNhap);
            dgvDSSP.MultiSelect = false;
            DoiTenCot();
            lblTongTien.Text = string.Format("{0:#,###}", TinhTien()) + " VNĐ";
        }

        void DoiTenCot()
        {
            dgvDSSP.Columns[0].HeaderText = "Số lượng";
            dgvDSSP.Columns[0].Width = 160;
            dgvDSSP.Columns[1].HeaderText = "Giá nhập";
            dgvDSSP.Columns[1].Width = 330;
            dgvDSSP.Columns[2].HeaderText = "Mã sách";
            dgvDSSP.Columns[2].Width = 170;
        }

        float TinhTien()
        {
            float tong = 0;
            for (int i = 0; i < dgvDSSP.Rows.Count; i++)
            {
                tong += float.Parse(dgvDSSP.Rows[i].Cells[0].Value.ToString()) * float.Parse(dgvDSSP.Rows[i].Cells[1].Value.ToString());

            }
            return tong;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn in phiếu nhập không?", "Thông báo",
                MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
                InHoaDon();
        }
        private void prdPhieuNhap_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string maPN = this.maPhieuNhap;
            PhieuNhapSach phieuNhap = pn.GetPhieuNhapTheoMa(maPN).FirstOrDefault();

            var w = prdPhieuNhap.DefaultPageSettings.PaperSize.Width;// lấy chiều rông giấy in

            e.Graphics.DrawString(
                "Hiệu Sách HKN".ToUpper(),
                new Font("Courier New", 18, FontStyle.Bold),
                Brushes.Black,
                new Point(50, 20)
                );
            e.Graphics.DrawString(
                maPN.ToUpper(),
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
                String.Format("{0}", this.dtmNgayDat.Value.ToString("dd/MM/yyyy")).ToUpper(),// thêm giờ => String.Format("{0}", this.dtmNgayDat.Value.ToString("dd/MM/yyyy HH:mm")).ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w / 2 + 200, 50)
                );
            //KhachHang khachHang = this.kh.GetKHTheoMa(hoaDon.MaKH).FirstOrDefault();
            //e.Graphics.DrawString(
            //    "Khách Hàng: " + khachHang.TenKH.ToUpper(),
            //    new Font("Courier New", 12, FontStyle.Bold),
            //    Brushes.Black,
            //    new Point(50, 90)
            //    );
            //e.Graphics.DrawString(
            //    "SDT: " + khachHang.SDT,
            //    new Font("Courier New", 12, FontStyle.Bold),
            //    Brushes.Black,
            //    new Point(w / 2 + 200, 90)
            //    );

            // format but ve
            Pen blackPen = new Pen(Color.Black, 1);

            //toa do theo chieu doc
            var y = 105;

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

            IEnumerable<dynamic> chiTietPN = ctpn.GetCTPNTheoMa(this.maPhieuNhap);
            y += 50;
            int i = 1;
            double tongTienHD = 0; ;
            foreach (var item in chiTietPN)
            {
                double sum = (double)(item.GiaNhap * item.SoLuong);
                e.Graphics.DrawString(String.Format("{0}", i).ToUpper(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(50, y));
                e.Graphics.DrawString(item.TenSach, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(150, y));
                e.Graphics.DrawString(String.Format("{0}", item.SoLuong), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
                e.Graphics.DrawString(String.Format("{0:N}", item.GiaNhap), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
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
            e.Graphics.DrawString("Tổng tiền phiếu nhập".ToUpper(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(50, y));
            e.Graphics.DrawString(String.Format("{0:N} VND", tongTienHD), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 150, y));
            y += 50;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);
            //y += 30;
            //e.Graphics.DrawString("Cảm ơn quý khách và hẹn gặp lại".ToUpper(), new Font("Courier New", 18, FontStyle.Bold), Brushes.Black, new Point(170, y));
        }
        private void InHoaDon()
        {
            ppdPhieuNhap.Document = prdPhieuNhap;
            ppdPhieuNhap.ShowDialog();
        }

        private void frmNVChiTietPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
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

        //private void btnThoat_Click(object sender, EventArgs e)
        //{
        //    DialogResult r;
        //    r = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo",
        //        MessageBoxButtons.YesNo);
        //    if (r == DialogResult.Yes)
        //        this.Close();
        //}
    }
}
