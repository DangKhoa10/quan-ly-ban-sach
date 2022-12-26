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
    public partial class frmChiTietHoaDonTimKiem : Form
    {
        public frmChiTietHoaDonTimKiem()
        {
            InitializeComponent();
        }
        public frmChiTietHoaDonTimKiem(string maHoaDon, string ngayLapHD)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.ngayLapHD = ngayLapHD;
        }

        string maHoaDon;
        string ngayLapHD;
        clsKhachHang kh;
        clsCTHoaDon cthd;
        clsHoaDon hd;

        private void frmChiTietHoaDonTimKiem_Load(object sender, EventArgs e)
        {
            txtMaDonDat.Enabled = false;
            dtmNgayDat.Enabled = false;
            cthd = new clsCTHoaDon();
            hd = new clsHoaDon();
            kh = new clsKhachHang();
            dgvDSSP.DataSource = cthd.GetCTHDTheoMa2(this.maHoaDon);
            dgvDSSP.MultiSelect = false;
            DoiTenCot();
            txtMaDonDat.Text = this.maHoaDon;
            dtmNgayDat.Value = DateTime.Parse(this.ngayLapHD);
            lblTongTien.Text = string.Format("{0:#,###}", TinhTien()) + " VNĐ";
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("đồng ý in hoa đơn không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                InHoaDon();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void prdHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string maHD = this.maHoaDon;
            HoaDon hoaDon = hd.GetHoaDonTheoMa(maHD).FirstOrDefault();
            var w = prdHoaDon.DefaultPageSettings.PaperSize.Width;// lấy chiều rông giấy in

            e.Graphics.DrawString(
                "Hiệu Sách HKN".ToUpper(),
                new Font("Courier New", 18, FontStyle.Bold),
                Brushes.Black,
                new Point(50, 20)
                );
            e.Graphics.DrawString(
                this.maHoaDon.ToUpper(),
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

            IEnumerable<dynamic> chiTietHD = cthd.GetCTHDTheoMa2(this.maHoaDon);
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

        private void frmChiTietHoaDonTimKiem_FormClosing(object sender, FormClosingEventArgs e)
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
