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
    public partial class frmTimKiemHoaDon : Form
    {
        public frmTimKiemHoaDon()
        {
            InitializeComponent();
        }
        clsHoaDon hoaDon;
        clsHonLoan honLoan;
        private void frmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            hoaDon = new clsHoaDon();
            honLoan = new clsHonLoan();
            dgvDSHD.DataSource = honLoan.GetTKThongTinHoaDon();
            dgvDSHD.MultiSelect = false;
            NameColumn();
            dgvDSHD.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy hh:MM:ss";


        }
        void XuLyHoTroAutocomlet()
        {
            //IEnumerable<dynamic> listHD;
            //listHD = honLoan.GetTKThongTinHoaDonAutocomlet();
            //txtTimKiem.AutoCompleteCustomSource.Clear();
            //if (rdoMaHD.Checked)
            //{
            //    foreach (dynamic hd in listHD)
            //    {
            //        txtTimKiem.AutoCompleteCustomSource.Add(hd.MaHD);
            //    }
            //}
            //else if (rdoMaNV.Checked)
            //{
            //    foreach (dynamic hd in listHD)
            //    {
            //        txtTimKiem.AutoCompleteCustomSource.Add(hd.MaNV);
            //    }
            //}
            //else if (rdoTenNV.Checked)
            //{
            //    foreach (dynamic hd in listHD)
            //    {
            //        txtTimKiem.AutoCompleteCustomSource.Add(hd.TenNV);
            //    }
            //}
            //else if (rdoMaKH.Checked)
            //{
            //    foreach (dynamic hd in listHD)
            //    {
            //        txtTimKiem.AutoCompleteCustomSource.Add(hd.MaKH);
            //    }
            //}
            //else
            //{
            //    foreach (dynamic hd in listHD)
            //    {
            //        txtTimKiem.AutoCompleteCustomSource.Add(hd.TenKH);
            //    }
            //}
        }
        void NameColumn()
        {//1135
            dgvDSHD.Columns[0].HeaderText = "Mã hóa đơn";
            dgvDSHD.Columns[0].Width = 235;
            dgvDSHD.Columns[1].HeaderText = "Ngày lập hóa đơn";
            dgvDSHD.Columns[1].Width = 235;
            dgvDSHD.Columns[2].HeaderText = "Nhân viên lập hóa đơn";
            dgvDSHD.Columns[2].Width = 332;
            dgvDSHD.Columns[3].HeaderText = "Tên khách hàng";
            dgvDSHD.Columns[3].Width = 333;
        }
        private void dgvDSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectAllComumns(dgvDSHD);
        }
        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }

        private void btnAllHD_Click(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = honLoan.GetTKThongTinHoaDon();
            NameColumn();
            clearTimKiem();
        }
        void clearTimKiem()
        {
            txtMaHD.Clear();
            txtMaKH.Clear();
            txtMaNV.Clear();
            txtTenKH.Clear();
            txtTenNV.Clear();
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

       
        private void dtmLocTheoNgay_ValueChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = honLoan.GetTKHDTheoNgay(dtmLocTheoNgay.Value);
            NameColumn();
            clearTimKiem();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mahd = "", makh = "", tenkh = "", manv = "", tennv = "";
            if (!string.IsNullOrEmpty(txtMaHD.Text))
                mahd = txtMaHD.Text;
            if (!string.IsNullOrEmpty(txtTenKH.Text))
                tenkh = txtTenKH.Text;
            if (!string.IsNullOrEmpty(txtMaKH.Text))
                makh = txtMaKH.Text;
            if (!string.IsNullOrEmpty(txtMaNV.Text))
                manv = txtMaNV.Text;
            if (!string.IsNullOrEmpty(txtTenNV.Text))
                tennv = txtTenNV.Text;
            dgvDSHD.DataSource = honLoan.GetTKHoaDon(mahd, makh, manv, tennv, tenkh);
            NameColumn();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvDSHD.SelectedRows.Count > 0)
            {
                frmChiTietHoaDonTimKiem frm = new frmChiTietHoaDonTimKiem(dgvDSHD.SelectedRows[0].Cells[0].Value.ToString(), dgvDSHD.SelectedRows[0].Cells[1].Value.ToString());
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

        private void frmTimKiemHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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
