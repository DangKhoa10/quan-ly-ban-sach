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
    public partial class frmTimKiemNhanVien : Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }
        clsNhanVien nhanVien;
        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            nhanVien = new clsNhanVien();
            WindowState = FormWindowState.Maximized;
            dgvDSNV.DataSource = nhanVien.GetAllNV();
            dgvDSNV.MultiSelect = false;
            NameColumn();
            themChucVu();
        }
        void NameColumn()
        {
            dgvDSNV.Columns[0].HeaderText = "Mã nhân viên";
            dgvDSNV.Columns[0].Width = 180;
            dgvDSNV.Columns[1].HeaderText = "Tên nhân viên";
            dgvDSNV.Columns[1].Width = 250;
            dgvDSNV.Columns[2].HeaderText = "Số điện thoại";
            dgvDSNV.Columns[2].Width = 180;
            dgvDSNV.Columns[3].HeaderText = "Địa chỉ";
            dgvDSNV.Columns[3].Width = 550;
        }
        private void clearTextBox()
        {
            txtDiaChi.Clear();
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
        }
        private void themChucVu()
        {
            cboChucVu.Items.Add("Nhân viên bán hàng");
            cboChucVu.Items.Add("Nhân viên thống kê");
            cboChucVu.Items.Add("Quản lý");
        }
        private void btnAllNV_Click(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = nhanVien.GetAllNV();
            NameColumn();
            clearTextBox();
            cboChucVu.Text = "Lọc theo chức vụ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = "", ten = "", sdt = "", dc = "";
            if (!string.IsNullOrEmpty(txtMaNV.Text))
                ma = txtMaNV.Text;
            if (!string.IsNullOrEmpty(txtTenNV.Text))
                ten = txtTenNV.Text;
            if (!string.IsNullOrEmpty(txtSDT.Text))
                sdt = txtSDT.Text;
            if (!string.IsNullOrEmpty(txtDiaChi.Text))
                dc = txtDiaChi.Text;
            dgvDSNV.DataSource = nhanVien.GetNVTimKiem(ma,ten,sdt,dc);
            NameColumn();
            cboChucVu.Text = "Lọc theo chức vụ";
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chucVu = 0;
            if (cboChucVu.SelectedItem.ToString() == "Quản lý")
                chucVu = 1;
            if (cboChucVu.SelectedItem.ToString() == "Nhân viên thống kê")
                chucVu = 3;
            if (cboChucVu.SelectedItem.ToString() == "Nhân viên bán hàng")
                chucVu = 2;
            dgvDSNV.DataSource = nhanVien.GetNVTheoChucVu(chucVu);
            NameColumn();
            clearTextBox();
        }

        private void frmTimKiemNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
