using QuanLyMuaBanSach.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyMuaBanSach.GUI
{
    public partial class frmLapPhieuNhap : Form
    {
        public frmLapPhieuNhap()
        {
            InitializeComponent();
        }
        clsSach sach;
        clsHonLoan honLoan;
        clsNhaCungCap nhaCungCap;
        clsLoaiSach loaiSach;
        private void frmLapPhieuNhap_Load(object sender, EventArgs e)
        {
            sach = new clsSach();
            honLoan = new clsHonLoan();
            nhaCungCap = new clsNhaCungCap();
            loaiSach = new clsLoaiSach();
            WindowState = FormWindowState.Maximized;
            dgvListSach.DataSource = honLoan.GetThongTinSachNhap();
            dgvListSach.AutoResizeColumns();
            dgvListSach.MultiSelect = false;
            NameColumn();
            CreateColumn(lstvDanhSachNhap);
            ThemLocNXB();
            ThemLocTG();
            ThemTenLoaiVaoCbo();
            ThemNhaCungCap();
            cboNXB.Text = "Lọc theo nhà xuất bản";
            cboTG.Text = "Lọc theo tác giả";
            cboLoaiSach.Text = "Lọc theo loại sách";
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            rdoMaSach.Checked = true;
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

        void NameColumn()
        {
            dgvListSach.Columns[0].HeaderText = "Mã Sách";
            dgvListSach.Columns[0].Width = 100;
            dgvListSach.Columns[1].HeaderText = "Tên Sách";
            dgvListSach.Columns[1].Width = 250;
            dgvListSach.Columns[2].HeaderText = "Đơn Giá Nhập";
            dgvListSach.Columns[2].DefaultCellStyle.Format = "N0";
            dgvListSach.Columns[2].Width = 130;
            dgvListSach.Columns[3].HeaderText = "Đơn Giá Bán";
            dgvListSach.Columns[3].DefaultCellStyle.Format = "N0";
            dgvListSach.Columns[3].Width = 130;
            dgvListSach.Columns[4].HeaderText = "Số Lượng";
            dgvListSach.Columns[4].Width = 100;
            dgvListSach.Columns[5].HeaderText = "Số Trang";
            dgvListSach.Columns[5].Width = 100;
            dgvListSach.Columns[6].HeaderText = "Loại Sách";
            dgvListSach.Columns[6].Width = 200;
            dgvListSach.Columns[7].HeaderText = "Tác Giả";
            dgvListSach.Columns[7].Width = 200;
            dgvListSach.Columns[8].HeaderText = "Nhà Xuất Bản";
            dgvListSach.Columns[8].Width = 200;
        }

        private void cboLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListSach.DataSource = honLoan.GetLocLSSachNhap(cboLoaiSach.SelectedValue.ToString());
            cboNXB.Text = "Lọc theo nhà xuất bản";
            cboTG.Text = "Lọc theo tác giả";
            NameColumn();
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
        void ThemLocNXB()
        {
            cboNXB.SelectedIndexChanged -= new System.EventHandler(cboNXB_SelectedIndexChanged);
            cboNXB.DataSource = new clsNhaXuatBan().GetAllNXB();
            cboNXB.ValueMember = "MaNXB";
            cboNXB.DisplayMember = "TenNXB";
            cboNXB.SelectedValue = new clsNhaXuatBan().GetAllNXB().ToList()[0];
            cboNXB.SelectedIndexChanged += new System.EventHandler(cboNXB_SelectedIndexChanged);
        }

        void ThemLocTG()
        {
            cboTG.SelectedIndexChanged -= new System.EventHandler(cboTG_SelectedIndexChanged);
            cboTG.DataSource = new clsTacGia().GetAllTacGia();
            cboTG.ValueMember = "MaTG";
            cboTG.DisplayMember = "TenTG";
            cboTG.SelectedValue = new clsTacGia().GetAllTacGia().ToList()[0];
            cboTG.SelectedIndexChanged += new System.EventHandler(cboTG_SelectedIndexChanged);
        }
        void ThemTenLoaiVaoCbo()
        {
            cboLoaiSach.SelectedIndexChanged -= new System.EventHandler(cboLoaiSach_SelectedIndexChanged);
            cboLoaiSach.DataSource = loaiSach.GetAllLoaiSach();
            cboLoaiSach.ValueMember = "MaLoai";
            cboLoaiSach.DisplayMember = "TenLoai";
            cboLoaiSach.SelectedValue = loaiSach.GetAllLoaiSach().ToList()[0];
            cboLoaiSach.SelectedIndexChanged += new System.EventHandler(cboLoaiSach_SelectedIndexChanged);
        }

        void ThemNhaCungCap()
        {
            cboChonNhaCungCap.SelectedIndexChanged -= new System.EventHandler(cboChonNhaCungCap_SelectedIndexChanged);
            cboChonNhaCungCap.DataSource = nhaCungCap.GetAllNhaCungCap();
            cboChonNhaCungCap.DisplayMember = "TenNCC";
            cboChonNhaCungCap.ValueMember = "MaNCC";
            cboChonNhaCungCap.SelectedValue = nhaCungCap.GetAllNhaCungCap().ToList()[0];
            cboChonNhaCungCap.SelectedIndexChanged += new System.EventHandler(cboChonNhaCungCap_SelectedIndexChanged);
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            
            if (lstvDanhSachNhap.Items.Count <= 0)
            {
                MessageBox.Show("Chưa thêm sách nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cboChonNhaCungCap.Text == "")
            {
                MessageBox.Show("Chưa chọn nhà cung cấp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GUI.frmPhieuNhapSach frm = new GUI.frmPhieuNhapSach(lstvDanhSachNhap, cboChonNhaCungCap.SelectedValue.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    lstvDanhSachNhap.Items.Clear();
                    dgvListSach.DataSource = honLoan.GetThongTinSachNhap();
                    cboNXB.Text = "Lọc theo nhà xuất bản";
                    cboTG.Text = "Lọc theo tác giả";
                    cboLoaiSach.Text = "Lọc theo loại sách";
                    cboChonNhaCungCap.Text = "";
                }
                
            }

        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            GUI.frmQuanLyNhaCungCap frm = new GUI.frmQuanLyNhaCungCap();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                ThemNhaCungCap();
            }
        }


        ListViewItem CreateItem()
        {
            double tt = Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(txtDonGia.Text);
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(txtMaSach.Text);
            lvwItem.SubItems.Add(txtTenSach.Text);
            lvwItem.SubItems.Add(txtSoLuong.Text);
            lvwItem.SubItems.Add(txtDonGia.Text);
            lvwItem.SubItems.Add(tt.ToString());
            return lvwItem;
        }
        ListViewItem CreateListViewItemAdd(int soLuongMoi)
        {
            double tt = soLuongMoi * Convert.ToInt32(txtDonGia.Text);
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(txtMaSach.Text);
            lvwItem.SubItems.Add(txtTenSach.Text);
            lvwItem.SubItems.Add(soLuongMoi.ToString());
            lvwItem.SubItems.Add(txtDonGia.Text);
            lvwItem.SubItems.Add(tt.ToString());
            return lvwItem;
        }

        
        bool checkTrungMa()
        {
            for (int i = 0; i < lstvDanhSachNhap.Items.Count; i++)
            {
                if (txtMaSach.Text.Equals(lstvDanhSachNhap.Items[i].SubItems[0].Text))
                    return true;
            }
            return false;
        }
        int TimViTri(ListView lstView)
        {
            foreach (ListViewItem item in lstView.Items)
            {
                if (txtMaSach.Text.Equals(item.SubItems[0].Text))
                {
                    return item.Index;
                }
            }
            return -1;
        }
        int tinhSoLuongMoi(int viTri)
        {
            int soLuongCu = Int32.Parse(lstvDanhSachNhap.Items[viTri].SubItems[2].Text);
            int soLuongMoi = soLuongCu + Int32.Parse(txtSoLuong.Text);
            return soLuongMoi;
        }

        void clearAll()
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

      
       
        private void cboNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListSach.DataSource = honLoan.GetLocNXBSachNhap(cboNXB.SelectedValue.ToString());
            cboLoaiSach.Text = "Lọc theo loại sách";
            cboTG.Text = "Lọc theo tác giả";
            NameColumn();
        }

        private void cboTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListSach.DataSource = honLoan.GetLocTGSachNhap(cboTG.SelectedValue.ToString());
            cboLoaiSach.Text = "Lọc theo loại sách";
            cboNXB.Text = "Lọc theo nhà xuất bản";
            NameColumn();
        }

       
       
        private void dgvListSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvListSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtGiaNhap.Text = string.Format("{0:#,###}", Convert.ToDouble(row.Cells[2].Value.ToString()));
                txtGiaBan.Text = string.Format("{0:#,###}", Convert.ToDouble(row.Cells[3].Value.ToString()));
                txtSoLuongTon.Text = row.Cells[4].Value.ToString();
                txtSoTrang.Text = row.Cells[5].Value.ToString();
                txtLoaiSach.Text = row.Cells[6].Value.ToString();
                txtTacGia.Text = row.Cells[7].Value.ToString();
                txtNhaXuatBan.Text = row.Cells[8].Value.ToString();
                
                if (Convert.ToInt32(txtSoLuongTon.Text) == 0)
                {
                    txtSoLuongTon.Text = "Hết hàng";
                }
                selectAllComumns(dgvListSach);
            }
        }
        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }
        private void btnAllSach_Click(object sender, EventArgs e)
        {
            dgvListSach.DataSource = honLoan.GetThongTinSachNhap();
            cboLoaiSach.Text = "Lọc theo loại sách";
            cboTG.Text = "Lọc theo tác giả";
            cboNXB.Text = "Lọc theo nhà xuất bản";
            NameColumn();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tk = txtTimKiem.Text;
            if (rdoMaSach.Checked)
                dgvListSach.DataSource = honLoan.GetTimKiemSachNhapTheoMaSach(tk);
            else
                dgvListSach.DataSource = honLoan.GetTimKiemSachNhapTheoTenSach(tk);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!(dgvListSach.SelectedRows.Count > 0))
            {
                MessageBox.Show("Chọn sách muốn nhập !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string dGia = txtDonGia.Text, sl = txtSoLuong.Text;
                int value;
                if (int.TryParse(dGia.Trim(), out value) == false)
                    MessageBox.Show("Nhập đơn giá !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (Int32.Parse(dGia.Trim()) < 1000)
                    MessageBox.Show("Đơn giá >= 1000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (int.TryParse(sl.Trim(), out value) == false)
                    MessageBox.Show("Nhập số lượng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (Int32.Parse(sl.Trim()) <= 0)
                    MessageBox.Show("Số lượng > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (checkTrungMa())
                {

                    int viTri = TimViTri(lstvDanhSachNhap);
                    int soLuongMoi = tinhSoLuongMoi(viTri);
                    lstvDanhSachNhap.Items.RemoveAt(viTri);
                    ListViewItem itemAdd = CreateListViewItemAdd(soLuongMoi);
                    lstvDanhSachNhap.Items.Add(itemAdd);
                    clearAll();
                }
                else
                {
                    ListViewItem lvw = CreateItem();
                    lstvDanhSachNhap.Items.Add(lvw);
                    clearAll();
                }
            }
               
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstvDanhSachNhap.SelectedItems.Count > 0)
            {
                int viTriThuc;
                DialogResult dl = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    for (int i = 0; i < lstvDanhSachNhap.SelectedItems.Count;)
                    {
                        viTriThuc = lstvDanhSachNhap.SelectedIndices[i];
                        lstvDanhSachNhap.Items.RemoveAt(viTriThuc);
                    }
                }
                //lstvDanhSachNhap.Items.Remove(lstvDanhSachNhap.SelectedItems[0]);
            }
            else MessageBox.Show("Chọn sách muốn xóa");
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 127 || e.KeyChar == 8) // cho phép nhấn số, delete và backspace
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void cboTG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void rdoTenSach_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
            txtTimKiem.Clear();
            txtTimKiem.Focus();
        }

        private void cboChonNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmLapPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
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
