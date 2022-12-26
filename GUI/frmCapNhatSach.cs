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
    public partial class frmCapNhatSach : Form
    {
        public frmCapNhatSach()
        {
            InitializeComponent();
        }
        int select = 0;
        clsSach sach;
        clsHonLoan honLoan;
        clsTacGia tacGia;
        clsLoaiSach loaiSach;
        clsNhaXuatBan nhaXuatBan;

        private void frmCapNhatSach_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            WindowState = FormWindowState.Maximized;
            tacGia = new clsTacGia();
            loaiSach = new clsLoaiSach();
            sach = new clsSach();
            nhaXuatBan = new clsNhaXuatBan();
            honLoan = new clsHonLoan();
            dgvDSSach.DataSource = honLoan.GetThongTinSachQLSach();
            dgvDSSach.AllowUserToAddRows = false;
            dgvDSSach.MultiSelect = false;
            NameColumn();
            ThemcboTG();
            ThemcboLoaiSach();
            ThemcboNXB();
            enablebFalse();
            clearTextBox();

        }

        void ThemcboTG()
        {
            cboTacGia.DataSource = tacGia.GetAllTacGia();
            cboTacGia.ValueMember = "MaTG";
            cboTacGia.DisplayMember = "TenTG";
        }

        void ThemcboLoaiSach()
        {
            cboTheLoai.DataSource = loaiSach.GetAllLoaiSach();
            cboTheLoai.ValueMember = "MaLoai";
            cboTheLoai.DisplayMember = "TenLoai";
        }
        void ThemcboNXB()
        {
            cboNhaXuatBan.DataSource = nhaXuatBan.GetAllNXB();
            cboNhaXuatBan.ValueMember = "MaNXB";
            cboNhaXuatBan.DisplayMember = "TenNXB";
        }

        void NameColumn()
        {
            dgvDSSach.Columns[0].HeaderText = "Mã sách";
            dgvDSSach.Columns[1].HeaderText = "Tên sách";
            dgvDSSach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSSach.Columns[2].HeaderText = "Giá nhập";
            dgvDSSach.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDSSach.Columns[3].HeaderText = "Giá bán";
            dgvDSSach.Columns[3].DefaultCellStyle.Format = "N0";
            dgvDSSach.Columns[4].HeaderText = "Số lượng";
            dgvDSSach.Columns[5].HeaderText = "Tác giả";
            dgvDSSach.Columns[6].HeaderText = "Thể loại";
            dgvDSSach.Columns[7].HeaderText = "Số trang";
            dgvDSSach.Columns[8].HeaderText = "Nhà xuất bản";
        }
        void clearTextBox()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtDonGiaBan.Clear();
            txtDonGiaNhap.Clear();
            txtSoLuongTon.Clear();
            cboNhaXuatBan.Text = "";
            cboTheLoai.Text = "";
            txtSoTrang.Clear();
            cboTacGia.Text = "";
        }
        void enablebFalse()
        {
            txtSoLuongTon.Enabled = false;
            txtMaSach.Enabled = false;
            cboTacGia.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtSoTrang.Enabled = false;
            txtTenSach.Enabled = false;
            txtDonGiaBan.Enabled = false;
            cboTheLoai.Enabled = false;
            cboNhaXuatBan.Enabled = false;
            btnTG.Enabled = false;
            btnNXB.Enabled = false;
            btnTL.Enabled = false;
        }
        void setButtonDefault()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                select = 1;
                btnThem.Text = "Hủy Thêm";
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtTenSach.Enabled = true;
                txtDonGiaBan.Enabled = true;
                cboTacGia.Enabled = true;
                cboTheLoai.Enabled = true;
                cboNhaXuatBan.Enabled = true;
                txtSoTrang.Enabled = true;
                btnTG.Enabled = true;
                btnNXB.Enabled = true;
                btnTL.Enabled = true;
                clearTextBox();
                txtMaSach.Text = taoMaThem();
                btnLuu.Enabled = true;
                txtTenSach.Focus();
            }
            else
            {
                btnThem.Text = "Thêm";
                clearTextBox();
                setButtonDefault();
                enablebFalse();
                select = 0;
            }
        }
        string taoMaThem()
        {
            string maSach = "";
            IEnumerable<Sach> s = sach.GetAllSach();
            string maSachLast = s.Last().MaSach;
            int so = Convert.ToInt32(maSachLast.Substring(2)) + 1;
            if (so < 10)
                maSach = "SA0000" + so.ToString();
            else if (so < 100)
                maSach = "SA000" + so.ToString();
            else if (so < 1000)
                maSach = "SA00" + so.ToString();
            else if (so < 10000)
                maSach = "SA0" + so.ToString();
            else
                maSach = "SA" + so.ToString();
            return maSach;

        }
        private void dgvDSSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvDSSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells[0].Value.ToString();
                txtTenSach.Text = row.Cells[1].Value.ToString();
                txtDonGiaNhap.Text = row.Cells[2].Value.ToString();
                txtDonGiaBan.Text = row.Cells[3].Value.ToString();
                txtSoLuongTon.Text = row.Cells[4].Value.ToString();
                cboTacGia.Text = row.Cells[5].Value.ToString();
                cboTheLoai.Text = row.Cells[6].Value.ToString();
                txtSoTrang.Text = row.Cells[7].Value.ToString();
                cboNhaXuatBan.Text = row.Cells[8].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                enablebFalse();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                double gb = Convert.ToDouble(txtDonGiaBan.Text);
                select = 2;
                btnSua.Text = "Hủy Sửa";
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                txtTenSach.Enabled = true;
                txtDonGiaBan.Enabled = true;
                txtDonGiaBan.Text = gb.ToString();
                cboTacGia.Enabled = true;
                cboTheLoai.Enabled = true;
                cboNhaXuatBan.Enabled = true;
                txtSoTrang.Enabled = true;
                btnLuu.Enabled = true;
                btnTG.Enabled = true;
                btnNXB.Enabled = true;
                btnTL.Enabled = true;
            }
            else
            {
                btnSua.Text = "Sửa";
                setButtonDefault();
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                enablebFalse();
                select = 0;
            }
        }
        Sach TaoSach()
        {
            string maTG = "", maTL = "", manxb = "";
            maTG = cboTacGia.SelectedValue.ToString();
            maTL = cboTheLoai.SelectedValue.ToString();
            manxb = cboNhaXuatBan.SelectedValue.ToString();
            Sach s = new Sach();
            s.MaSach = txtMaSach.Text;
            s.TenSach = txtTenSach.Text;
            s.DonGiaBan = Convert.ToDecimal(txtDonGiaBan.Text);
            s.DonGiaNhap = 0;
            s.SoLuongTon = 0;
            s.SoTrang = Convert.ToInt32(txtSoTrang.Text);
            s.MaTG = maTG;
            s.MaLoai = maTL;
            s.MaNXB = manxb;
            return s;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                int value;
                if (txtTenSach.Text.Trim() == "")
                    MessageBox.Show("Chưa nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (int.TryParse(txtDonGiaBan.Text.Trim(), out value) == false)
                    MessageBox.Show("Chưa nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (Int32.Parse(txtDonGiaBan.Text.Trim()) < 1000)
                    MessageBox.Show("Đơn giá >= 1000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (int.TryParse(txtSoTrang.Text.Trim(), out value) == false)
                    MessageBox.Show("Chưa nhập số trang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (Int32.Parse(txtSoTrang.Text.Trim()) <= 0)
                    MessageBox.Show("Số trang > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (cboNhaXuatBan.Text == "" || cboTacGia.Text == "" || cboTheLoai.Text == "")
                    MessageBox.Show("Chọn đầy đủ tên tác giả , thể loại , nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Sach s = TaoSach();
                    int check = sach.themSach(s);
                    if (check == 0)
                    {
                        MessageBox.Show("Trùng mã");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công");
                        btnThem.Text = "Thêm";
                        setButtonDefault();
                        enablebFalse();
                        dgvDSSach.DataSource = honLoan.GetThongTinSachQLSach();
                        NameColumn();
                    }
                }
            }
            if (select == 2)
            {
                int value;
                if (txtTenSach.Text.Trim() == "")
                    MessageBox.Show("Chưa nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (int.TryParse(txtDonGiaBan.Text.Trim(), out value) == false)
                    MessageBox.Show("Chưa nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (Int32.Parse(txtDonGiaBan.Text.Trim()) < 1000)
                    MessageBox.Show("Đơn giá >= 1000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (int.TryParse(txtSoTrang.Text.Trim(), out value) == false)
                    MessageBox.Show("Chưa nhập số trang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (Int32.Parse(txtSoTrang.Text.Trim()) <= 0)
                    MessageBox.Show("Số trang > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (cboNhaXuatBan.Text == "" || cboTacGia.Text == "" || cboTheLoai.Text == "")
                    MessageBox.Show("Chọn đầy đủ tên tác giả , thể loại , nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    Sach s = TaoSach();
                    bool check = sach.suaSach(s);
                    if (check == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        btnSua.Text = "Sửa";
                        setButtonDefault();
                        enablebFalse();
                        dgvDSSach.DataSource = honLoan.GetThongTinSachQLSach();
                        NameColumn();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            dlgHoiXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgHoiXoa == DialogResult.Yes)
            {
                Sach s = sach.GetSachTheoMa(txtMaSach.Text).First();
                int check = sach.xoaSach(s);
                if (check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgvDSSach.DataSource = honLoan.GetThongTinSachQLSach();
                    NameColumn();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    clearTextBox();
                }
                else
                    MessageBox.Show("Xóa không thành công", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 127 || e.KeyChar == 8) // cho phép nhấn số, delete và backspace
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 127 || e.KeyChar == 8) // cho phép nhấn số, delete và backspace
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTG_Click(object sender, EventArgs e)
        {
            frmCapNhatTacGia frm = new frmCapNhatTacGia();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                ThemcboTG();
            }

        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            frmCapNhatLoaiSach frm = new frmCapNhatLoaiSach();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                ThemcboLoaiSach();
            }
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            frmCapNhatNhaXuatBan frm = new frmCapNhatNhaXuatBan();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                ThemcboNXB();
            }
        }

        private void cboTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmCapNhatSach_FormClosing(object sender, FormClosingEventArgs e)
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
