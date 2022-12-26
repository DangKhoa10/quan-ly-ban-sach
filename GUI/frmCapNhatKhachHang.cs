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
using System.Text.RegularExpressions;

namespace QuanLyMuaBanSach.GUI
{
    public partial class frmCapNhatKhachHang : Form
    {
        public frmCapNhatKhachHang()
        {
            InitializeComponent();
        }
        int select = 0;
        clsKhachHang khachHang;

        private void frmCapNhatKhachHang_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            khachHang = new clsKhachHang();
            dgvDSKH.DataSource = khachHang.GetAllKH();
            dgvDSKH.MultiSelect = false;
            dgvDSKH.AllowUserToAddRows = false;
            NameColumn();
            enablebFalse();
        }
        void NameColumn()
        {
            dgvDSKH.Columns[0].HeaderText = "Mã khách hàng";
            dgvDSKH.Columns[0].Width = 180;
            dgvDSKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvDSKH.Columns[1].Width = 250;
            dgvDSKH.Columns[2].HeaderText = "Số điện thoại";
            dgvDSKH.Columns[2].Width = 180;
            dgvDSKH.Columns[3].HeaderText = "Địa chỉ";
            dgvDSKH.Columns[3].Width = 550;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void clearTextBox()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }
        void enablebFalse()
        {
            txtDiaChi.Enabled = false;
            txtMaKH.Enabled = false;
            txtSDT.Enabled = false;
            txtTenKH.Enabled = false;

        }
        void setButtonDefault()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvDSKH.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                enablebFalse();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                select = 1;
                btnThem.Text = "Hủy Thêm";
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtDiaChi.Enabled = true;
                clearTextBox();
                txtMaKH.Text = taoMaThem();
                btnLuu.Enabled = true;
                txtTenKH.Focus();
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
        KhachHang TaoKH()
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txtMaKH.Text.Trim();
            kh.TenKH = txtTenKH.Text.Trim();
            kh.SDT = txtSDT.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
            return kh;
        }
        public string LoaiDau(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
                        .Replace('đ', 'd').Replace('Đ', 'D');
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenkh = LoaiDau(txtTenKH.Text.Trim());
            if (select == 1)
            {
                if (tenkh.KiemTraTen() == false)
                    MessageBox.Show("Sai định dạng tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtSDT.Text.Trim().KiemTraSDT() == false)
                    MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (khachHang.checkSDT(txtSDT.Text.Trim()) == true)
                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtDiaChi.Text.Trim() == "")
                    MessageBox.Show("Chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    KhachHang kh = TaoKH();
                    int check = khachHang.themKH(kh);
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
                        dgvDSKH.DataSource = khachHang.GetAllKH();
                        NameColumn();
                    }
                }
            }
            if (select == 2)
            {
                if (tenkh.KiemTraTen() == false)
                    MessageBox.Show("Sai định dạng tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtSDT.Text.Trim().KiemTraSDT() == false)
                    MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtDiaChi.Text.Trim() == "")
                    MessageBox.Show("Chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    KhachHang kh = TaoKH();
                    int check = khachHang.suaKH_QLKH(kh);
                    if (check == 1)
                    {
                        MessageBox.Show("Sửa thành công");
                        btnSua.Text = "Sửa";
                        setButtonDefault();
                        enablebFalse();
                        dgvDSKH.DataSource = khachHang.GetAllKH();
                        NameColumn();
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            dlgHoiXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dlgHoiXoa == DialogResult.Yes)
            {
                KhachHang kh = khachHang.GetKHTheoMa(txtMaKH.Text).First();
                int check = khachHang.xoaKH(kh);
                if (check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgvDSKH.DataSource = khachHang.GetAllKH();
                    NameColumn();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    clearTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy khách hàng", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                select = 2;
                btnSua.Text = "Hủy Sửa";
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                txtTenKH.Enabled = true;
                txtSDT.Enabled = true;
                txtDiaChi.Enabled = true;
                btnLuu.Enabled = true;
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

        private void dgvDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 127 || e.KeyChar == 8) // cho phép nhấn số, delete và backspace
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmCapNhatKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
