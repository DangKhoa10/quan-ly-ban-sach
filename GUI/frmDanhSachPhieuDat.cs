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
    public partial class frmDanhSachPhieuDat : Form
    {
        public frmDanhSachPhieuDat()
        {
            InitializeComponent();
        }
        
        clsPhieuDatSach phieuDat;
        clsHonLoan honLoan;
        clsHoaDon hd;

        private void frmDanhSachPhieuDat_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            phieuDat = new clsPhieuDatSach();
            honLoan = new clsHonLoan();
            hd = new clsHoaDon();
            dgvDSPhieuDat.DataSource = honLoan.GetAllThongTinPhieuDatSach();
            DoiTenCot();
            dgvDSPhieuDat.MultiSelect = false;
            ThemTinhTrangLoc();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDSPhieuDat.SelectedRows.Count > 0)
            {
                frmNVChiTietPhieuDat frm = new frmNVChiTietPhieuDat(dgvDSPhieuDat.SelectedRows[0].Cells[0].Value.ToString(), dgvDSPhieuDat.SelectedRows[0].Cells[1].Value.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dgvDSPhieuDat.DataSource = honLoan.GetAllThongTinPhieuDatSach();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn phiếu muốn xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

       
        void DoiTenCot()
        {
            dgvDSPhieuDat.Columns[0].HeaderText = "Mã phiếu đặt";
            dgvDSPhieuDat.Columns[0].Width = 150;
            dgvDSPhieuDat.Columns[1].HeaderText = "Ngày lập phiếu";
            dgvDSPhieuDat.Columns[1].Width = 220;
            dgvDSPhieuDat.Columns[2].HeaderText = "Tình trạng";
            dgvDSPhieuDat.Columns[2].Width = 180;
            dgvDSPhieuDat.Columns[3].HeaderText = "Mã khách hàng";
            dgvDSPhieuDat.Columns[3].Width = 140;
            dgvDSPhieuDat.Columns[4].HeaderText = "Tên khách hàng";
            dgvDSPhieuDat.Columns[4].Width = 280;
            dgvDSPhieuDat.Columns[5].HeaderText = "Số điện thoại";
            dgvDSPhieuDat.Columns[5].Width = 160;
        }
       

        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }
        private void btnToanBo_Click(object sender, EventArgs e)
        {
            dtmLocNgay.Value = DateTime.Today;
            cboLocTinhTrang.Text = "Lọc theo tình trạng xử lý";
            dgvDSPhieuDat.DataSource = honLoan.GetAllThongTinPhieuDatSach();
        }
        private void dtmLocNgay_ValueChanged(object sender, EventArgs e)
        {
            cboLocTinhTrang.Text = "Lọc theo tình trạng xử lý";
            dgvDSPhieuDat.DataSource = honLoan.GetThongTinPhieuDatTheoNgay(dtmLocNgay.Value);
        }
        private void cboLocTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDSPhieuDat.DataSource = honLoan.GetThongTinPhieuDatTheoTinhTrang(cboLocTinhTrang.SelectedItem.ToString());
        }
        void ThemTinhTrangLoc()
        {
            cboLocTinhTrang.Items.Add("Đã xử lý");
            cboLocTinhTrang.Items.Add("Chưa xử lý");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maKH = "", tenKH = "", sdt = "", maPD = "";
            int tt = 2;
            if (!string.IsNullOrEmpty(txtMaKH.Text))
                maKH = txtMaKH.Text;
            if (!string.IsNullOrEmpty(txtTenKH.Text))
                tenKH = txtTenKH.Text;
            if (!string.IsNullOrEmpty(txtSDT.Text))
                sdt = txtSDT.Text;
            if (!string.IsNullOrEmpty(txtMaPhieuDat.Text))
                maPD = txtMaPhieuDat.Text;
            if (cboTinhTrang.Text == "Đã xử lý")
                tt = 1;
            if (cboTinhTrang.Text == "Chưa xử lý")
                tt = 0;
            dgvDSPhieuDat.DataSource = honLoan.GetPDTimKiem(maKH, tenKH, sdt, maPD,tt);
            DoiTenCot();
        }

        private void dgvDSPhieuDat_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectAllComumns(dgvDSPhieuDat);
        }

        private void cboTinhTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmDanhSachPhieuDat_FormClosing(object sender, FormClosingEventArgs e)
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
