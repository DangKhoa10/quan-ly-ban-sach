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
    public partial class frmCapNhatNhanVien : Form
    {
        public frmCapNhatNhanVien()
        {
            InitializeComponent();
        }
        int select = 0;
        clsNhanVien nhanVien;
       
        private void frmCapNhatNhanVien_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            nhanVien = new clsNhanVien();
            dgvDSNV.DataSource = nhanVien.GetAllNVCAPNHAT();
            dgvDSNV.AllowUserToAddRows = false;
            dgvDSNV.MultiSelect = false;
            NameColumn();
            enablebFalse();
            string[] dt = { "Quản lí", "Nhân viên bán hàng", "Nhân viên thống kê" };
            foreach (string x in dt)
            {
                cboChucVu.Items.Add(x);
            }
            cboChucVu.Enabled = false;
        }
        
        void NameColumn()
        {
            dgvDSNV.Columns[0].HeaderText = "Mã nhân viên";
            dgvDSNV.Columns[0].Width = 190;
            dgvDSNV.Columns[1].HeaderText = "Tên nhân viên";
            dgvDSNV.Columns[1].Width = 300;
            dgvDSNV.Columns[2].HeaderText = "Số điện thoại";
            dgvDSNV.Columns[2].Width = 200;
            dgvDSNV.Columns[3].HeaderText = "Địa chỉ";
            dgvDSNV.Columns[3].Width = 260;
            dgvDSNV.Columns[4].HeaderText = "Chức vụ";
            dgvDSNV.Columns[4].Width = 220;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                select = 1;
                btnThem.Text = "Hủy Thêm";
                cboChucVu.Text = "";
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
                txtTenNV.Enabled = true;
                txtSDT.Enabled = true;
                txtDiaChi.Enabled = true;
                cboChucVu.Enabled = true;
                clearTextBox();
            }
            else
            {
                btnThem.Text = "Thêm";
                clearTextBox();
                setButtonDefault();
                enablebFalse();
                cboChucVu.Enabled = false;
                cboChucVu.Text = "";
                select = 0;
            }
        }
        string taoMaThemQuanLi()
        {
            string maNV = "";
            if (cboChucVu.Text.Trim() == "Quản lí")
            {

                IEnumerable<NhanVien> ql = nhanVien.GetNVTheoChucVu(1);
                string maNVLast = ql.Last().MaNV;
                int so = Convert.ToInt32(maNVLast.Substring(2)) + 1;
                if (so < 10)
                    maNV = "QL0000" + so.ToString();
                else if (so < 100)
                    maNV = "QL000" + so.ToString();
                else if (so < 1000)
                    maNV = "QL00" + so.ToString();
                else if (so < 10000)
                    maNV = "QL0" + so.ToString();
                else
                    maNV = "QL" + so.ToString();
                return maNV;
            }
            else return null;
        }
        string taoMaThemBanHang()
        {
            string maNV = "";
            if (cboChucVu.Text.Trim() == "Nhân viên bán hàng")
            {

                IEnumerable<NhanVien> bh = nhanVien.GetNVTheoChucVu(2);
                string maNVLast = bh.Last().MaNV;
                int so = Convert.ToInt32(maNVLast.Substring(2)) + 1;
                if (so < 10)
                    maNV = "BH0000" + so.ToString();
                else if (so < 100)
                    maNV = "BH000" + so.ToString();
                else if (so < 1000)
                    maNV = "BH00" + so.ToString();
                else if (so < 10000)
                    maNV = "BH0" + so.ToString();
                else
                    maNV = "BH" + so.ToString();
                return maNV;
            }
            else return null;
        }
        string taoMaThemThongKe()
        {
            string maNV = "";
            if (cboChucVu.Text.Trim() == "Nhân viên thống kê")
            {

                IEnumerable<NhanVien> tk = nhanVien.GetNVTheoChucVu(3);
                string maNVLast = tk.Last().MaNV;
                int so = Convert.ToInt32(maNVLast.Substring(2)) + 1;
                if (so < 10)
                    maNV = "TK0000" + so.ToString();
                else if (so < 100)
                    maNV = "TK000" + so.ToString();
                else if (so < 1000)
                    maNV = "TK00" + so.ToString();
                else if (so < 10000)
                    maNV = "TK0" + so.ToString();
                else
                    maNV = "TK" + so.ToString();
                return maNV;
            }
            else return null;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        void clearTextBox()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }  
        void enablebFalse()
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
        }
        void setButtonDefault()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvDSNV.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                cboChucVu.Text = row.Cells[4].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                cboChucVu.Enabled = false;
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                enablebFalse();
            }
            selectAllComumns(dgvDSNV);
        }
        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }
        NhanVien TaoNV()
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text.Trim();
            nv.TenNV = txtTenNV.Text.Trim();
            nv.SDT = txtSDT.Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.ChucVu = ThemChucVu();
            return nv;
        }
        private short ThemChucVu()
        {

            if (cboChucVu.Text.Trim() == "Quản lí")
                return 1;
            else if (cboChucVu.Text.Trim() == "Nhân viên bán hàng")
                return 2;
            else if (cboChucVu.Text.Trim() == "Nhân viên thống kê")
                return 3;
            else return 0;

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
            string tennv = LoaiDau(txtTenNV.Text.Trim());
            if (select == 1)
            {
                if (tennv.KiemTraTen() == false)
                    MessageBox.Show("Sai định dạng tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (cboChucVu.Text == "")
                    MessageBox.Show("Chưa chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtSDT.Text.Trim().KiemTraSDT() == false)
                    MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (nhanVien.checkSDT(txtSDT.Text.Trim())==true)
                    MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtDiaChi.Text.Trim() == "")
                    MessageBox.Show("Chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else
                {
                    NhanVien nv = TaoNV();
                    int check = nhanVien.themNV(nv);
                    if (check == 0)
                    {
                        MessageBox.Show("Trùng mã");
                    }
                    else if (nv.ChucVu == 0)
                    {
                        MessageBox.Show("Chưa điền chức vụ");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công");
                        btnThem.Text = "Thêm";
                        setButtonDefault();
                        enablebFalse();
                        dgvDSNV.DataSource = nhanVien.GetAllNVCAPNHAT();
                        NameColumn();
                        cboChucVu.Enabled = false;
                    }
                }
            }
            if (select == 2)
            {
                if (tennv.KiemTraTen() == false)
                    MessageBox.Show("Sai định dạng tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (cboChucVu.Text == "")
                    MessageBox.Show("Chưa chọn chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtSDT.Text.Trim().KiemTraSDT() == false)
                    MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txtDiaChi.Text.Trim() == "")
                    MessageBox.Show("Chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    NhanVien nv = TaoNV();

                        bool check = nhanVien.SuaNV(nv);
                        if (check == true)
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo");
                            btnSua.Text = "Sửa";
                            setButtonDefault();
                            enablebFalse();
                            dgvDSNV.DataSource = nhanVien.GetAllNVCAPNHAT();
                            NameColumn();
                            cboChucVu.Enabled = false;
                        }
                        else
                            MessageBox.Show("Số điện thoại đã tồn tại","Thông báo");
                   
                }
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
                txtMaNV.Enabled = false;
                txtSDT.Enabled = true;
                txtDiaChi.Enabled = true;
                txtTenNV.Enabled = true;
                cboChucVu.Enabled = true;
                btnLuu.Enabled = true;
            }
            else
            {
                btnSua.Text = "Sửa";
                setButtonDefault();
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                cboChucVu.Enabled = false;
                enablebFalse();
                select = 0;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            dlgHoiXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dlgHoiXoa == DialogResult.Yes)
            {
                NhanVien nv = nhanVien.GetNVTheoMa(txtMaNV.Text).First();
                int check = nhanVien.xoaNV(nv);
                if (check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgvDSNV.DataSource = nhanVien.GetAllNVCAPNHAT();
                    NameColumn();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    clearTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy nhân viên", "Thông báo");
            }
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

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select == 1)
            {
                if (cboChucVu.Text.Trim() == "Quản lí")
                    txtMaNV.Text = taoMaThemQuanLi();
                else if (cboChucVu.Text.Trim() == "Nhân viên bán hàng")
                    txtMaNV.Text = taoMaThemBanHang();
                else if (cboChucVu.Text.Trim() == "Nhân viên thống kê")
                    txtMaNV.Text = taoMaThemThongKe();
            }
        }

        private void cboChucVu_KeyPress(object sender, KeyPressEventArgs e) // không cho nhập vào combobox
        {
            e.Handled = true;
        }

        private void frmCapNhatNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
