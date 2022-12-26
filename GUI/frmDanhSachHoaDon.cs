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
    public partial class frmDanhSachHoaDon : Form
    {
        public frmDanhSachHoaDon()
        {
            InitializeComponent();
        }

        clsHonLoan honLoan;
        clsCTHoaDon cthd;
        clsKhachHang kh;
        clsHoaDon hd;
        string maHD;
        private void frmDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            honLoan = new clsHonLoan();
            cthd = new clsCTHoaDon();
            kh = new clsKhachHang();
            hd = new clsHoaDon();
            dgvDSHD.DataSource = honLoan.GetThongTinHoaDon1();
            dgvDSHD.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy hh:MM:ss";
            dgvDSHD.MultiSelect = false;
            DoiTenCot();
            KhongChoPhepNhap();

        }
        private void btnHienThiToanBo_Click(object sender, EventArgs e)
        {
            dtmLocNgay.Value = DateTime.Today;
            dgvDSHD.DataSource = honLoan.GetThongTinHoaDon1();
        }
        private void dtmLocNgay_ValueChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = honLoan.GetHDTheoNgay1(dtmLocNgay.Value);
        }
        //private void btnAllHD_Click(object sender, EventArgs e)
        //{
        //    dgvDSHD.DataSource = honLoan.GetTKThongTinHoaDon1();
        //    NameColumn();
        //    clearTimKiem();
        //}

        //private void dtmLocTheoNgay_ValueChanged(object sender, EventArgs e)
        //{
        //    dgvDSHD.DataSource = honLoan.GetTKHDTheoNgay(dtmLocTheoNgay.Value);
        //    NameColumn();
        //    clearTimKiem();
        //}

        void KhongChoPhepNhap()
        {
            txtMaHD.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtTenNhanVien.Enabled = false;
            dtmNgayLapHD.Enabled = false;
            txtMaNV.Enabled = false;
            txtMaKH.Enabled = false;
        }
        void DoiTenCot()
        {
            dgvDSHD.Columns[0].HeaderText = "Mã hóa đơn";
            dgvDSHD.Columns[0].Width = 160;
            dgvDSHD.Columns[1].HeaderText = "Ngày lập hóa đơn";
            dgvDSHD.Columns[1].Width = 220;
            dgvDSHD.Columns[2].HeaderText = "Nhân viên lập hóa đơn";
            dgvDSHD.Columns[2].Width = 280;
            dgvDSHD.Columns[3].HeaderText = "mã nhân viên";
            dgvDSHD.Columns[3].Width = 160;
            dgvDSHD.Columns[4].HeaderText = "Tên khách hàng";
            dgvDSHD.Columns[4].Width = 280;
            dgvDSHD.Columns[5].HeaderText = "Mã khách hàng";
            dgvDSHD.Columns[5].Width = 160;
        }

        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSHD.Rows[e.RowIndex];
                txtMaHD.Text= row.Cells[0].Value.ToString();
                dtmNgayLapHD.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                txtTenNhanVien.Text = row.Cells[2].Value.ToString();
                txtMaNV.Text = row.Cells[3].Value.ToString();
                txtTenKhachHang.Text = row.Cells[4].Value.ToString();
                txtMaKH.Text = row.Cells[5].Value.ToString();
            }
            selectAllComumns(dgvDSHD);
        }

        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }

        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            if (dgvDSHD.SelectedRows.Count > 0)
            {
                frmNVChiTietHoaDon frm = new frmNVChiTietHoaDon(dgvDSHD.SelectedRows[0].Cells[0].Value.ToString(), dgvDSHD.SelectedRows[0].Cells[1].Value.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //XoaHetSach();
                    //lstvDanhSachSP.Clear();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn hóa đơn muốn xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void frmDanhSachHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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
        //private void prdHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{

        //    string maHD = dgvDSHD.SelectedRows[0].Cells[0].Value.ToString();
        //    HoaDon hoaDon = hd.GetHoaDonTheoMa(maHD).FirstOrDefault();
        //    var w = prdHoaDon.DefaultPageSettings.PaperSize.Width;// lấy chiều rông giấy in

        //    e.Graphics.DrawString(
        //        "Hiệu Sách HKN".ToUpper(),
        //        new Font("Courier New", 18, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(50, 20)
        //        );
        //    e.Graphics.DrawString(
        //        this.maHD.ToUpper(),
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(w/2 + 200, 20)
        //        );
        //    e.Graphics.DrawString(
        //        "12 Nguyễn Văn Bảo, phường 4, quận Gò Vấp".ToUpper(),
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(50, 50)
        //        );
        //    e.Graphics.DrawString(
        //        String.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")).ToUpper(),
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(w/2 + 200, 50)
        //        );
        //    KhachHang khachHang = this.kh.GetKHTheoMa(hoaDon.MaKH).FirstOrDefault();
        //    e.Graphics.DrawString(
        //        "Khách Hàng: " + khachHang.TenKH.ToUpper(),
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(50, 90)
        //        );
        //    e.Graphics.DrawString(
        //        "SDT: " + khachHang.SDT,
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(w / 2 + 200, 90)
        //        );

        //    // format but ve
        //    Pen blackPen = new Pen(Color.Black, 1);

        //    //toa do theo chieu doc
        //    var y = 125;

        //    //dinh nghia 2 diem ve duong thang
        //    // canh le trai va phai 10
        //    Point p1 = new Point(10, y);
        //    Point p2 = new Point(w - 10, y);

        //    e.Graphics.DrawLine(blackPen, p1, p2);
        //    y += 10;
        //    e.Graphics.DrawString(
        //        "Stt".ToUpper(),
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(50, y)
        //        );
        //    e.Graphics.DrawString(
        //        "Tên sách".ToUpper(),
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(150, y)
        //        );
        //    e.Graphics.DrawString(
        //        "Số lượng".ToUpper(),
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(w/2, y)
        //        );
        //    e.Graphics.DrawString(
        //        "Đơn giá".ToUpper(),
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(w/2 + 100, y)
        //        );
        //    e.Graphics.DrawString(
        //        "Thành tiền".ToUpper(),
        //        new Font("Courier New", 12, FontStyle.Bold),
        //        Brushes.Black,
        //        new Point(w / 2 + 230, y)
        //        );

        //    IEnumerable<dynamic> chiTietHD = cthd.GetCTHDTheoMa2(this.maHD);
        //    y += 50;
        //    int i = 1;
        //    double tongTienHD = 0; ;
        //    foreach (var item in chiTietHD)
        //    {
        //        double sum = (double)(item.GiaBan * item.SoLuong);
        //        e.Graphics.DrawString(String.Format("{0}", i).ToUpper(),new Font("Courier New", 12, FontStyle.Bold),Brushes.Black,new Point(50, y));
        //        e.Graphics.DrawString( item.TenSach,new Font("Courier New", 12, FontStyle.Bold),Brushes.Black,new Point(150, y));
        //        e.Graphics.DrawString(String.Format("{0}", item.SoLuong),new Font("Courier New", 12, FontStyle.Bold),Brushes.Black,new Point(w / 2, y) );
        //        e.Graphics.DrawString(String.Format("{0:N}", item.GiaBan), new Font("Courier New", 12, FontStyle.Bold),Brushes.Black,new Point(w / 2 + 100, y));
        //        e.Graphics.DrawString(String.Format("{0:N}", sum), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 230, y));
        //        tongTienHD += sum;
        //        y += 30;
        //        i++;
        //    }
        //    y += 20;
        //    p1 = new Point(10, y);
        //    p2 = new Point(w - 10, y);
        //    e.Graphics.DrawLine(blackPen, p1, p2);
        //    y += 30;
        //    e.Graphics.DrawString("Tổng tiền phải thanh toán".ToUpper(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(50, y));
        //    e.Graphics.DrawString(String.Format("{0:N} VND", tongTienHD), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 150, y));
        //    y += 50;
        //    p1 = new Point(10, y);
        //    p2 = new Point(w - 10, y);
        //    e.Graphics.DrawLine(blackPen, p1, p2);
        //    y += 30;
        //    e.Graphics.DrawString("Cảm ơn quý khách và hẹn gặp lại".ToUpper(), new Font("Courier New", 18, FontStyle.Bold), Brushes.Black, new Point(170, y));
        //}
        //private void InHoaDon()
        //{
        //    ppdHoaDon.Document = prdHoaDon;
        //    ppdHoaDon.ShowDialog();
        //}
    }
}
