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
//using QuanLyMuaBanSach.GUI;
//using QuanLyMuaBanSach.Entity;

namespace QuanLyMuaBanSach.GUI
{
    public partial class frmDatSach : Form
    {
        public frmDatSach()
        {
            InitializeComponent();
        }
        public frmDatSach(string maKH)
        {
            InitializeComponent();
            this.maKHDangDatSach = maKH;
            this.dangChonKH = true;
        }
        public frmDatSach(ListView gh)
        {
            InitializeComponent();
            gioHang = gh;
            checkGH = true;
        }
        ListView gioHang;
        clsTacGia tacgia;
        clsLoaiSach loaisach;
        clsSach sach;
        clsHonLoan honloan;
        clsChiTietPhieuDat ctpd;
        clsKhachHang kh;
        Entity.PhieuDatSach pds = frmLogin.phieuDat;
        clsLogin login = frmLogin.login;
        bool chinhSuaPDCu;
        bool checkGH = false;
        bool checkDH = false;
        string maPDDangChon;
        string maKHDangDatSach;
        bool dangChonKH = false;

        private void frmDatSach_Load(object sender, EventArgs e)
        {
            honloan = new clsHonLoan();
            tacgia = new clsTacGia();
            loaisach = new clsLoaiSach();
            sach = new clsSach();
            ctpd = new clsChiTietPhieuDat();
            kh = new clsKhachHang();
            ThemNhaXuatBan();
            ThemLocTG();
            ThemLocLoaiSach();
            cboLocTheoNXB.Text = "Lọc theo nhà xuất bản";
            cboLocTacGia.Text = "Lọc theo tác giả";
            cboLocLoaiSach.Text = "Lọc theo loại sách";
            dgvListSach.DataSource = honloan.GetThongTinSach();
            dgvListSach.MultiSelect = false;
            //dgvListSach.row
            dgvListSach.AutoResizeColumns();
            TaoTieuDeCot();
            CreateColumn(lstvGioHang);
            WindowState = FormWindowState.Maximized;
            //grbTimKiem.Hide();
            chinhSuaPDCu = false;
            btnHuyDatThem.Enabled = false;
            AnNutChoNhanVien();
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            rdoMaSach.Checked = true;
            if (checkGH)
                loadGioHang(gioHang);
            if (this.dangChonKH)
            {
                btnHuyDatThem.Visible = false;
                btnChonPDCu.Visible = false;
            }
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
        void AnNutChoNhanVien()
        {
            if (KiemTraChucVu() != 4)
            {

            }
            else
            {
                btnChonPDCu.Hide();
                btnHuyDatThem.Hide();
            }
        }

        void TaoTieuDeCot()
        {
            dgvListSach.Columns[0].HeaderText = "Mã Sách";
            dgvListSach.Columns[0].Width = 100;
            dgvListSach.Columns[1].HeaderText = "Tên Sách";
            dgvListSach.Columns[1].Width = 250;
            dgvListSach.Columns[2].HeaderText = "Đơn Giá";
            dgvListSach.Columns[2].DefaultCellStyle.Format = "N0";
            dgvListSach.Columns[2].Width = 130;
            dgvListSach.Columns[3].HeaderText = "Số Lượng";
            dgvListSach.Columns[3].Width = 100;
            dgvListSach.Columns[4].HeaderText = "Tác Giả";
            dgvListSach.Columns[4].Width = 200;
            dgvListSach.Columns[5].HeaderText = "Số Trang";
            dgvListSach.Columns[5].Width = 100;
            dgvListSach.Columns[6].HeaderText = "Tên Nhà Xuất Bản";
            dgvListSach.Columns[6].Width = 200;
            dgvListSach.Columns[7].HeaderText = "Tên Loại";
            dgvListSach.Columns[7].Width = 200;
        }

        /*void CreateColumn(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã sách", 70);
            lvw.Columns.Add("Tên sách", 200);
            lvw.Columns.Add("Đơn giá", 100);
            lvw.Columns.Add("Số lượng", 70);
            lvw.Columns.Add("Tác giả", 100);
            lvw.Columns.Add("Thể loại", 180);
            lvw.Columns.Add("Số trang", 70);
        }
        private void loadSachToListView(ListView lvw, IEnumerable<Sach> listSach)
        {
            lvw.Items.Clear();
            ListViewItem ItemSach;
            foreach (Sach s in listSach)
            {
                ItemSach = GreateItem(s);
                lvw.Items.Add(ItemSach);
            }
        }
        ListViewItem GreateItem(Sach s)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(s.MaSach);
            lvwItem.SubItems.Add(s.TenSach);
            lvwItem.SubItems.Add(s.DonGiaBan.ToString());
            lvwItem.SubItems.Add(s.SoLuongTon.ToString());
            lvwItem.SubItems.Add(s.MaTG);
            lvwItem.SubItems.Add(s.MaLoai);
            lvwItem.SubItems.Add(s.SoTrang.ToString());
            lvwItem.Tag = s;
            return lvwItem;
        }*/
        void ThemLocTG()
        {
            cboLocTacGia.SelectedIndexChanged -= new System.EventHandler(cboLocTacGia_SelectedIndexChanged);
            cboLocTacGia.DataSource = tacgia.GetAllTacGia();
            cboLocTacGia.DisplayMember = "TenTG";
            cboLocTacGia.ValueMember = "MaTG";
            cboLocTacGia.SelectedIndexChanged += new System.EventHandler(cboLocTacGia_SelectedIndexChanged);
        }
       
        void ThemLocLoaiSach()
        {
            cboLocLoaiSach.SelectedIndexChanged -= new System.EventHandler(cboLocLoaiSach_SelectedIndexChanged);
            cboLocLoaiSach.DataSource = loaisach.GetAllLoaiSach();
            cboLocLoaiSach.DisplayMember = "TenLoai";
            cboLocLoaiSach.ValueMember = "MaLoai";
            cboLocLoaiSach.SelectedIndexChanged += new System.EventHandler(cboLocLoaiSach_SelectedIndexChanged);
        }
       
        void ThemNhaXuatBan()
        {
            cboLocTheoNXB.SelectedIndexChanged -= new System.EventHandler(cboLocTheoNXB_SelectedIndexChanged);
            cboLocTheoNXB.DataSource = new clsNhaXuatBan().GetAllNXB();
            cboLocTheoNXB.DisplayMember = "TenNXB";
            cboLocTheoNXB.ValueMember = "MaNXB";
            cboLocTheoNXB.SelectedIndexChanged += new System.EventHandler(cboLocTheoNXB_SelectedIndexChanged);
        }
        private void dgvListSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvListSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtGia.Text = string.Format("{0:#,###}", Convert.ToDouble(row.Cells[2].Value.ToString()));
                txtConLai.Text = row.Cells[3].Value.ToString();
                txtTacGia.Text = row.Cells[4].Value.ToString();
                txtSoTrang.Text = row.Cells[5].Value.ToString();
                txtNhaXB.Text = row.Cells[6].Value.ToString();
                txtTheLoai.Text = row.Cells[7].Value.ToString();
                if (Convert.ToInt32(txtConLai.Text) == 0)
                {
                    txtConLai.Text = "Hết hàng";
                }
            }
            selectAllComumns(dgvListSach);
        }
        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }
        //private void btnĐatSach_Click(object sender, EventArgs e)
        //{
        //    frmLapDonDatSach frm = new QuanLyMuaBanSach.frmLapDonDatSach();
        //    frm.ShowDialog();
        //}
        private void cboLocTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListSach.DataSource = honloan.GetLocSachTheoTGDatSach(cboLocTacGia.SelectedValue.ToString());
            cboLocLoaiSach.Text = "Lọc theo loại sách";
            cboLocTheoNXB.Text = "Lọc theo nhà xuất bản";
            TaoTieuDeCot();
        }

        private void cboLocLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListSach.DataSource = honloan.GetLocSachTheoLoaiSachDatSach(cboLocLoaiSach.SelectedValue.ToString());
            cboLocTacGia.Text = "Lọc theo tác giả";
            cboLocTheoNXB.Text = "Lọc theo nhà xuất bản";
            TaoTieuDeCot();
        }

        private void btnAllSach_Click(object sender, EventArgs e)
        {
            dgvListSach.DataSource = honloan.GetThongTinSach();
            cboLocLoaiSach.Text = "Lọc theo loại sách";
            cboLocTacGia.Text = "Lọc theo tác giả";
            cboLocTheoNXB.Text = "Lọc theo nhà xuất bản";
            TaoTieuDeCot();

        }

        void XuLyHoTroAutocomlet()
        {
            IEnumerable<Sach> listSach;
            listSach = sach.GetAllSach();
            txtTimKiem.AutoCompleteCustomSource.Clear();
            if (rdoMaSach.Checked)
            {
                foreach (Sach s in listSach)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(s.MaSach);
                }
            }
            else//theo Tên Sách
            {
                foreach (Sach s in listSach)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(s.TenSach);
                }
            }
        }

       

        private void rdoTenSach_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
            txtTimKiem.Clear();
            txtTimKiem.Focus();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tk = txtTimKiem.Text;
            if (rdoMaSach.Checked)
                dgvListSach.DataSource = honloan.GetThongTinSachQLSachTheoMaSach(tk);
            else
                dgvListSach.DataSource = honloan.GetThongTinSachQLSachTheoTenSach(tk);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!(dgvListSach.SelectedRows.Count > 0))
            {
                MessageBox.Show("Hãy Chọn Sản phẩm muốn mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtSoLuong.Text == "")
                {
                    MessageBox.Show("Hãy nhập số lượng sách muốn mua", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                if (Int32.Parse(txtSoLuong.Text) == 0)
                {
                    MessageBox.Show("Hãy nhập số sách lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (KtraDaDatChua(dgvListSach.SelectedRows[0], lstvGioHang))
                    // nếu đặt sách này rồi thì sẽ tăng thêm số lượng và tính lại tiền
                    {
                        int viTri = TimViTri(dgvListSach.SelectedRows[0], lstvGioHang);
                        int soLuongMoi = tinhSoLuongMoi(viTri);
                        if (Int32.Parse(txtSoLuong.Text) <= Int32.Parse(dgvListSach.SelectedRows[0].Cells[3].Value.ToString()) 
                            && soLuongMoi <= Int32.Parse(dgvListSach.SelectedRows[0].Cells[3].Value.ToString()))
                        {
                            double tongTienMoi = tinhTongTienMoi(dgvListSach.SelectedRows[0], viTri);
                            lstvGioHang.Items.RemoveAt(viTri);
                            ListViewItem itemAdd = CreateListViewItemAdd(dgvListSach.SelectedRows[0], soLuongMoi, tongTienMoi);
                            lstvGioHang.Items.Add(itemAdd);
                            //int soLuongConLai = Int32.Parse(dgvListSach.SelectedRows[0].Cells[3].Value.ToString())
                            //    - Int32.Parse(txtSoLuong.Text.ToString());
                            //sach.SuaSoLuong(dgvListSach.SelectedRows[0].Cells[0].Value.ToString(), soLuongConLai);
                            //dgvListSach.DataSource = datsach.GetThongTinSach();
                        }
                        else
                        {
                            MessageBox.Show("Không đủ số lượng sách");
                        }
                    }
                    else
                    {
                        if (Int32.Parse(txtSoLuong.Text) <= Int32.Parse(dgvListSach.SelectedRows[0].Cells[3].Value.ToString()))
                        {
                            ListViewItem itemAdd = CreateListViewItem(dgvListSach.SelectedRows[0]);
                            lstvGioHang.Items.Add(itemAdd);
                            //int soLuongConLai = Int32.Parse(dgvListSach.SelectedRows[0].Cells[3].Value.ToString())
                            //    - Int32.Parse(txtSoLuong.Text.ToString());
                            //sach.SuaSoLuong(dgvListSach.SelectedRows[0].Cells[0].Value.ToString(), soLuongConLai);
                            //dgvListSach.DataSource = datsach.GetThongTinSach();
                        }
                        else
                        {
                            MessageBox.Show("Không đủ số lượng sách");
                        }
                    }
                }
            }
        }
        double tinhTongTienMoi(DataGridViewRow selectedRow, int viTri)
        {
            int tongTienCu = Int32.Parse(lstvGioHang.Items[viTri].SubItems[4].Text);
            double tongTienMoi = tongTienCu + (double.Parse(txtSoLuong.Text) * double.Parse(selectedRow.Cells[2].Value.ToString()));
           
 
                return tongTienMoi;
 



            //try
            //{
            //    int tongTienCu = Int32.Parse(lstvGioHang.Items[viTri].SubItems[4].Text);
            //    float tongTienMoi = tongTienCu + (float.Parse(txtSoLuong.Text) * float.Parse(selectedRow.Cells[2].Value.ToString()));
            //    return tongTienMoi;
            //}
            //catch(Exception ex)
            //{
            //    //MessageBox.Show("Số Tiền Quá Nhiều", "Thông Báo", MessageBoxButtons.OK);
            //    //int tongTienCu = Int32.Parse(lstvGioHang.Items[viTri].SubItems[4].Text);
            //    throw new Exception("Lỗi Tông Tiền quá lớn, hãy đặt đơn khác nếu muốn mua thêm");
            //    //return float.Parse(tongTienCu.ToString());
            //};
        }
        int tinhSoLuongMoi(int viTri)
        {
            int soLuongCu = Int32.Parse(lstvGioHang.Items[viTri].SubItems[3].Text);
            int soLuongMoi = soLuongCu + Int32.Parse(txtSoLuong.Text);
            return soLuongMoi;
        }
        int TimViTri(DataGridViewRow selectedRow, ListView lstView)
        {
            foreach (ListViewItem item in lstView.Items)
            {
                if (selectedRow.Cells[0].Value.ToString().Equals(item.SubItems[0].Text)) // Kiểm tra xem đã chọn sách này chưa
                {
                    return item.Index;
                }
            }
            return -1;
        }
        bool KtraDaDatChua(DataGridViewRow selectedRow, ListView lstView)
        {
            foreach (ListViewItem item in lstView.Items)
            {
                if (selectedRow.Cells[0].Value.ToString().Equals(item.SubItems[0].Text)) // Kiểm tra xem đã chọn sách này chưa
                {
                    return true;
                }
            }
            return false;
        }
        ListViewItem CreateListViewItemAdd(DataGridViewRow row, int soLuongMoi, double tongTienMoi)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(row.Cells[0].Value.ToString());
            lvwItem.SubItems.Add(row.Cells[1].Value.ToString());
            lvwItem.SubItems.Add(row.Cells[2].Value.ToString());
            lvwItem.SubItems.Add(soLuongMoi.ToString());
            lvwItem.SubItems.Add(tongTienMoi.ToString());
            lvwItem.Tag = row;
            return lvwItem;
        }
        ListViewItem CreateListViewItem(DataGridViewRow row)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(row.Cells[0].Value.ToString());
            lvwItem.SubItems.Add(row.Cells[1].Value.ToString());
            lvwItem.SubItems.Add(row.Cells[2].Value.ToString());
            lvwItem.SubItems.Add(txtSoLuong.Text);
            double tongTien = double.Parse(txtSoLuong.Text) * double.Parse(row.Cells[2].Value.ToString());
            lvwItem.SubItems.Add(tongTien.ToString());
            lvwItem.Tag = row;
            return lvwItem;
        }

        private void txtSLMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 127 || e.KeyChar == 8) // cho phép nhấn số, delete và backspace
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnDatSach_Click(object sender, EventArgs e)
        {
            if (this.dangChonKH)// đặt cho kh đang được chọn 
            {
                if (lstvGioHang.Items.Count > 0)
                {
                    frmLapPhieuDatSach frm = new frmLapPhieuDatSach(lstvGioHang, true, this.maKHDangDatSach);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        //dgvListSach.DataSource = honloan.GetThongTinSach();
                        lstvGioHang.Items.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy Chọn sách muốn mua và thêm vào Giỏ Hàng", "Thông báo");
                }
            }
            else
            {
                if (this.chinhSuaPDCu == false)
                { // đặt phiếu mới
                    if (lstvGioHang.Items.Count > 0)
                    {
                        frmLapPhieuDatSach frm = new frmLapPhieuDatSach(lstvGioHang);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            //dgvListSach.DataSource = honloan.GetThongTinSach();
                            lstvGioHang.Items.Clear();
                            checkDH = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy Chọn sách muốn mua và thêm vào Giỏ Hàng", "Thông báo");
                    }
                }
                else // sửa phiếu cũ (số item trong giỏ luôn >= 1)
                {
                    frmLapPhieuDatSach frm = new frmLapPhieuDatSach(lstvGioHang, this.maPDDangChon);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        this.chinhSuaPDCu = false;
                        btnHuyDatThem.Enabled = false;
                        //dgvListSach.DataSource = honloan.GetThongTinSach();
                        lstvGioHang.Items.Clear();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            int vitTriThuc;
            if (lstvGioHang.SelectedItems.Count > 0) // nếu có chọn
            {
                if (lstvGioHang.Items.Count > 1 && chinhSuaPDCu == true || chinhSuaPDCu == false)
                {
                    dlgHoiXoa = MessageBox.Show("Bạn có chắc xóa?", "Hỏi xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dlgHoiXoa == DialogResult.Yes)
                    {
                        for (int i = 0; i < lstvGioHang.SelectedItems.Count;)
                        {
                            vitTriThuc = lstvGioHang.SelectedIndices[i];
                            lstvGioHang.Items.RemoveAt(vitTriThuc);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không được xóa hết phiếu đặt cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn sách muốn xóa khỏi giỏ hàng", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLocTheoNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListSach.DataSource = honloan.GetLocSachTheoNXBDatSach(cboLocTheoNXB.SelectedValue.ToString());
            cboLocTacGia.Text = "Lọc theo tác giả";
            cboLocLoaiSach.Text = "Lọc theo loại sách";
            TaoTieuDeCot();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        private void frmDatSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo",
                MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                if (checkDH == true)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
                e.Cancel = true;
        }
        void CreateColumn(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã Sách", 100);
            lvw.Columns.Add("Tên Sách", 280);
            lvw.Columns.Add("Đơn Giá", 130);
            lvw.Columns.Add("Số Lượng", 150);
            lvw.Columns.Add("Thành Tiền", 130);
            //ColumnHeaderAutoResizeStyle n = new ColumnHeaderAutoResizeStyle();
            //lvw.AutoResizeColumns(n);
        }
        private void btnChonPDCu_Click(object sender, EventArgs e)
        {
            frmKhachHangTrongNgay frm = new frmKhachHangTrongNgay();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("ma HD cu la" + pds.MaPhieuDat, "Thông báo");

                if (lstvGioHang.Items.Count > 0)
                {
                    DialogResult rs = MessageBox.Show("Còn sách trong giỏ hàng, xác nhận lấy phiếu đặt cũ không?", 
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;
                    if (rs == DialogResult.Yes)
                    {
                        this.chinhSuaPDCu = true;
                        this.maPDDangChon = pds.MaPhieuDat;
                        btnHuyDatThem.Enabled = true;
                        LayPhieuDatKHMoiDat();
                    }
                }
                else
                {
                    this.chinhSuaPDCu = true;
                    this.maPDDangChon = pds.MaPhieuDat;
                    btnHuyDatThem.Enabled = true;
                    LayPhieuDatKHMoiDat();
                }
            }
        }
        void LayPhieuDatKHMoiDat()
        {
            lstvGioHang.Items.Clear();
            IEnumerable<dynamic> chiTietPD = this.ctpd.GetCTPhieuDatTheoMaPhieuDat(this.maPDDangChon);
            foreach (var ct in chiTietPD)
            {
                lstvGioHang.Items.Add(TaoGioHangDaDat(ct));
            }
        }
        ListViewItem TaoGioHangDaDat(dynamic item)
        {
            ListViewItem row = new ListViewItem(item.MaSach.ToString());
            row.SubItems.Add(item.TenSach.ToString());
            row.SubItems.Add(item.GiaBan.ToString());
            row.SubItems.Add(item.SoLuong.ToString());
            double tongTien = double.Parse(item.GiaBan.ToString()) * double.Parse(item.SoLuong.ToString());
            row.SubItems.Add(tongTien.ToString());
            return row;
        }

        private void btnHuyDatThem_Click(object sender, EventArgs e)
        {
            lstvGioHang.Items.Clear();
            this.chinhSuaPDCu = false;
            btnHuyDatThem.Enabled = false;
        }

       
    }
}
