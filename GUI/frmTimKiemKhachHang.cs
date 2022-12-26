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
    public partial class frmTimKiemKhachHang : Form
    {
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
        }
        clsKhachHang khachHang;
        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            khachHang = new clsKhachHang();
            dgvDSKH.DataSource = khachHang.GetAllKH();
            dgvDSKH.AllowUserToAddRows = false;
            dgvDSKH.MultiSelect = false;
            NameColumn();
            //txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //rdoMaKH.Checked = true;
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
        void XuLyHoTroAutocomlet()
        {
            //IEnumerable<KhachHang> listKH;
            //listKH = khachHang.GetAllKH();
            //txtTimKiem.AutoCompleteCustomSource.Clear();
            //if (rdoMaKH.Checked)
            //{
            //    foreach (KhachHang kh in listKH)
            //    {
            //        txtTimKiem.AutoCompleteCustomSource.Add(kh.MaKH);
            //    }
            //}
            //else if(rdoTenKH.Checked)
            //{
            //    foreach (KhachHang kh in listKH)
            //    {
            //        txtTimKiem.AutoCompleteCustomSource.Add(kh.TenKH);
            //    }
            //}
            //else
            //{
            //    foreach (KhachHang kh in listKH)
            //    {
            //        txtTimKiem.AutoCompleteCustomSource.Add(kh.SDT);
            //    }
            //}
        }




        private void clearTextBox()
        {
            txtDiaChi.Clear();
            txtTenKH.Clear();
            txtMaKhachHang.Clear();
            txtSDT.Clear();
        }
        private void btnAllKH_Click(object sender, EventArgs e)
        {
            dgvDSKH.DataSource = khachHang.GetAllKH();
            NameColumn();
            clearTextBox();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = "", ten = "", sdt = "", dc = "";
            if (!string.IsNullOrEmpty(txtMaKhachHang.Text))
                ma = txtMaKhachHang.Text;
            if (!string.IsNullOrEmpty(txtTenKH.Text))
                ten = txtTenKH.Text;
            if (!string.IsNullOrEmpty(txtSDT.Text))
                sdt = txtSDT.Text;
            if (!string.IsNullOrEmpty(txtDiaChi.Text))
                dc = txtDiaChi.Text;
            dgvDSKH.DataSource = khachHang.GetKHTimKiem(ma, ten, sdt, dc);
            NameColumn();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (dgvDSKH.SelectedRows.Count > 0)
            {
                GUI.frmLapHoaDon frm = new GUI.frmLapHoaDon(dgvDSKH.SelectedRows[0].Cells[0].Value.ToString(), true);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("hãy chọn khách hàng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvDSKH.SelectedRows.Count > 0)
            {
                GUI.frmDatSach frm = new GUI.frmDatSach(dgvDSKH.SelectedRows[0].Cells[0].Value.ToString());
                frm.ShowDialog();
                //this.DialogResult = DialogResult.OK;
                //this.Close();
            }
            else
                MessageBox.Show("hãy chọn khách hàng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectAllComumns(dgvDSKH);
        }
        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }

        private void frmTimKiemKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
