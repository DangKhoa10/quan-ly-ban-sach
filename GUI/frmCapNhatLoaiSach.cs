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

namespace QuanLyMuaBanSach.GUI
{
    public partial class frmCapNhatLoaiSach : Form
    {
        public frmCapNhatLoaiSach()
        {
            InitializeComponent();
        }
        int select = 0;
        clsLoaiSach loaiSach;
        private void frmCapNhatLoaiSach_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            loaiSach = new clsLoaiSach();
            dgvDSLoaiSach.DataSource = loaiSach.GetAllLoaiSach();
            dgvDSLoaiSach.AllowUserToAddRows = false;
            dgvDSLoaiSach.MultiSelect = false;
            NameColumn();
            enablebFalse();
        }
        void NameColumn()
        {
            dgvDSLoaiSach.Columns[0].HeaderText = "Mã loại sách";
            dgvDSLoaiSach.Columns[0].Width = 200;
            dgvDSLoaiSach.Columns[1].HeaderText = "Tên loại sách";
            dgvDSLoaiSach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void clearTextBox()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
        }
        void enablebFalse()
        {
            txtTenLoai.Enabled = false;
            txtMaLoai.Enabled = false;

        }
        void setButtonDefault()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void dgvDSLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvDSLoaiSach.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells[0].Value.ToString();
                txtTenLoai.Text = row.Cells[1].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                enablebFalse();
            }
        }
        string taoMaThem()
        {
            string maLS = "";
            IEnumerable<LoaiSach> ls = loaiSach.GetAllLoaiSach();
            string maLSLast = ls.Last().MaLoai;
            int so = Convert.ToInt32(maLSLast.Substring(2)) + 1;
            if (so < 10)
                maLS = "TL0000" + so.ToString();
            else if (so < 100)
                maLS = "TL000" + so.ToString();
            else if (so < 1000)
                maLS = "TL00" + so.ToString();
            else if (so < 10000)
                maLS = "TL0" + so.ToString();
            else
                maLS = "TL" + so.ToString();
            return maLS;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                select = 1;
                btnThem.Text = "Hủy Thêm";
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtTenLoai.Enabled = true;
                clearTextBox();
                txtMaLoai.Text = taoMaThem();
                btnLuu.Enabled = true;
                txtTenLoai.Focus();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                select = 2;
                btnSua.Text = "Hủy Sửa";
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                txtTenLoai.Enabled = true;
                btnLuu.Enabled = true;
                txtTenLoai.Focus();
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
        LoaiSach TaoLS()
        {
            LoaiSach ls = new LoaiSach();
            ls.MaLoai = txtMaLoai.Text.Trim();
            ls.TenLoai = txtTenLoai.Text.Trim();
            return ls;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                if (txtTenLoai.Text == "")
                    MessageBox.Show("Chưa nhập tên loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    LoaiSach ls = TaoLS();
                    int check = loaiSach.themLS(ls);
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
                        dgvDSLoaiSach.DataSource = loaiSach.GetAllLoaiSach();
                        NameColumn();
                    }
                }
            }
            if (select == 2)
            {
                if (txtTenLoai.Text == "")
                    MessageBox.Show("Chưa nhập tên loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    LoaiSach ls = TaoLS();
                    bool check = loaiSach.suaLS(ls);
                    if (check == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        btnSua.Text = "Sửa";
                        setButtonDefault();
                        enablebFalse();
                        dgvDSLoaiSach.DataSource = loaiSach.GetAllLoaiSach();
                        NameColumn();
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
                LoaiSach ls = loaiSach.GetLSTheoMa(txtMaLoai.Text).First();
                int check = loaiSach.xoaLS(ls);
                if (check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgvDSLoaiSach.DataSource = loaiSach.GetAllLoaiSach();
                    NameColumn();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    clearTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy loại sách", "Thông báo");
            }
        }

        private void frmCapNhatLoaiSach_FormClosing(object sender, FormClosingEventArgs e)
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
