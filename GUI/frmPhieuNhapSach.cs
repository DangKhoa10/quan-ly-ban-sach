using QuanLyMuaBanSach.DAO;
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
    public partial class frmPhieuNhapSach : Form
    {
        public frmPhieuNhapSach()
        {
            InitializeComponent();
        }
        ListView lstvFrmLPN;
        clsPhieuNhapSach pns;
        clsLogin lg;
        clsNhanVien nhanVien;
        clsNhaCungCap nhaCungCap;
        clsCTPhieuNhap ctpn;
        clsSach sach;
        string maPhieuNhap;
        private string maNV;
        private string MaNCC;
        clsPhieuNhapSach pn;
        public frmPhieuNhapSach(ListView lstv, string mancc)
        {
            MaNCC = mancc;
            InitializeComponent();
            lstvFrmLPN = lstv;
        }

        private void frmPhieuNhapSach_Load(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Enabled = false;
            txtNCC.Enabled = false;
            dtmNgayNhap.Enabled = false;
            txtNhanVien.Enabled = false;
            nhaCungCap = new clsNhaCungCap();
            pns = new clsPhieuNhapSach();
            ctpn = new clsCTPhieuNhap();
            sach = new clsSach();
            pn = new clsPhieuNhapSach();
            txtMaPhieuNhap.Text = taoMaPhieu();
            txtNCC.Text = nhaCungCap.GetNCCTheoMa(MaNCC).First().TenNCC;
            CreateColumn(lstvThongTinPhieu);
            loadGioHang(lstvFrmLPN);
            tenNhanVien();
            tongTien();
        }
        void tenNhanVien()
        {
            string ten = frmLogin.login.Username;
            lg = new clsLogin();
            TaiKhoan tk = lg.getTaiKhoan(ten).FirstOrDefault();
            nhanVien = new clsNhanVien();
            maNV = tk.MaNV;
            IEnumerable<NhanVien> nv = nhanVien.GetNVTheoMa(tk.MaNV);
            txtNhanVien.Text = nv.FirstOrDefault().TenNV;
        }
        void tongTien()
        {
            double tt = 0;
            for (int i = 0; i < lstvThongTinPhieu.Items.Count; i++)
            {
                tt += Convert.ToDouble(lstvThongTinPhieu.Items[i].SubItems[4].Text);
            }
            lblTongTien.Text = string.Format("{0:#,###}", tt) + " VNĐ";
        }
        void loadGioHang(ListView gioHang)
        {
            foreach (ListViewItem item in gioHang.Items)
            {
                ListViewItem newItem = CreateListViewItem(item);
                lstvThongTinPhieu.Items.Add(newItem);
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
        void CreateColumn(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã sách", 100);
            lvw.Columns.Add("Tên sách", 300);
            lvw.Columns.Add("Số lượng nhập", 150);
            lvw.Columns.Add("Đơn giá nhập", 200);
            lvw.Columns.Add("Thành tiền", 200);
        }
        string taoMaPhieu()
        {
            string maPhieu = "";
            IEnumerable<PhieuNhapSach> pns2 = pns.GetAllPhieuNhap();
            string maPhieuLast = pns2.Last().MaPhieuNhap;
            int so = Convert.ToInt32(maPhieuLast.Substring(2)) + 1;
            if (so < 10)
                maPhieu = "PN0000" + so.ToString();
            else if (so < 100)
                maPhieu = "PN000" + so.ToString();
            else if (so < 1000)
                maPhieu = "PN00" + so.ToString();
            else if (so < 10000)
                maPhieu = "PN0" + so.ToString();
            else
                maPhieu = "PN" + so.ToString();
            return maPhieu;

        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        PhieuNhapSach TaoPNS()
        {
            PhieuNhapSach pns1 = new PhieuNhapSach();
            pns1.MaPhieuNhap = txtMaPhieuNhap.Text;
            pns1.NgayNhap = dtmNgayNhap.Value;
            pns1.MaNV = maNV;
            pns1.MaNCC = MaNCC;
            this.maPhieuNhap = txtMaPhieuNhap.Text;
            return pns1;
        }
        CTPhieuNhap TaoCTPNS(ListViewItem lvt)
        {

            CTPhieuNhap ctpn1 = new CTPhieuNhap();
            ctpn1.SoLuong = Convert.ToInt32(lvt.SubItems[2].Text);
            ctpn1.GiaNhap = Convert.ToInt32(lvt.SubItems[3].Text);
            ctpn1.MaSach = lvt.SubItems[0].Text;
            ctpn1.MaPhieuNhap = txtMaPhieuNhap.Text;
            return ctpn1;
        }
        Sach TaoSachUpdate(ListViewItem lvt)
        {
            IEnumerable<Sach> s1 = sach.GetSachTheoMa(lvt.SubItems[0].Text);
            Sach s = new Sach();
            s.MaSach = lvt.SubItems[0].Text;
            s.DonGiaNhap = Convert.ToDecimal(lvt.SubItems[3].Text);
            s.SoLuongTon = Convert.ToInt32(lvt.SubItems[2].Text) + s1.First().SoLuongTon;
            return s;
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
                String.Format("{0}", this.dtmNgayNhap.Value.ToString("dd/MM/yyyy")).ToUpper(),// thêm giờ => String.Format("{0}", this.dtmNgayDat.Value.ToString("dd/MM/yyyy HH:mm")).ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(w / 2 + 200, 50)
                );
            e.Graphics.DrawString(
                "Nhà Cung Cấp: " + txtNCC.Text.ToUpper(),
                new Font("Courier New", 12, FontStyle.Bold),
                Brushes.Black,
                new Point(50, 90)
                );
            //e.Graphics.DrawString(
            //    "SDT: " + khachHang.SDT,
            //    new Font("Courier New", 12, FontStyle.Bold),
            //    Brushes.Black,
            //    new Point(w / 2 + 200, 90)
            //    );

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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult xacNhanThanhToan;
            xacNhanThanhToan = MessageBox.Show("Số tiền bạn cần thanh toán: " + lblTongTien.Text, "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (xacNhanThanhToan == DialogResult.Yes)
            {
                PhieuNhapSach pns1 = TaoPNS();
                int check = pns.themPNS(pns1);
                if (check == 0)
                {
                    MessageBox.Show("Trùng mã phiếu nhập");
                }
                else
                {
                    int checkcts = 0;
                    foreach (ListViewItem item in lstvThongTinPhieu.Items)
                    {
                        CTPhieuNhap ctpn1 = TaoCTPNS(item);
                        int checkct = ctpn.themCTPN(ctpn1);
                        if (checkct == 1)
                        {
                            Sach s = TaoSachUpdate(item);
                            bool checkupdate = sach.capNhatSachSauKhiNhap(s);
                            if (checkupdate != true)
                            {
                                MessageBox.Show("Không update được mã sách " + item.SubItems[0].Text);
                            }
                        }
                        if (checkct != 1)
                        {
                            MessageBox.Show("Không thể thêm CTPN sách mã " + item.SubItems[0].Text);
                            checkcts = 1;
                        }
                    }
                    if (checkcts == 0)
                    {
                        MessageBox.Show("Thanh toán thành công");
                        InHoaDon();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }

            }
        }

        private void frmPhieuNhapSach_FormClosing(object sender, FormClosingEventArgs e)
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
