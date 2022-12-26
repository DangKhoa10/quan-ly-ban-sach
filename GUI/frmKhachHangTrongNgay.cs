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
    public partial class frmKhachHangTrongNgay : Form
    {
        public frmKhachHangTrongNgay()
        {
            InitializeComponent();
        }
        //public frmKhachHangTrongNgay(string maHDCu)
        //{
        //    InitializeComponent();
        //    this.maHDCu = maHDCu;
        //}
        clsPhieuDatSach phieuDat;
        clsHonLoan honLoan;
        clsChiTietPhieuDat ctPD;
        //string maHDCu;

        private void frmKhachHangTrongNgay_Load(object sender, EventArgs e)
        {
            UnenablText();
            dgvDSSP.MultiSelect = false;
            honLoan = new clsHonLoan();
            phieuDat = new clsPhieuDatSach();
            ctPD = new clsChiTietPhieuDat();
            dgvDSSP.DataSource = honLoan.GetThongTinPhieuDatTheoNgay1(DateTime.Now);
            TaoTieuDeCot();
        }
        void TaoTieuDeCot()
        {
            dgvDSSP.Columns[0].HeaderText = "Mã Phiếu Đặt";
            dgvDSSP.Columns[0].Width = 130;
            dgvDSSP.Columns[1].HeaderText = "Ngày Đặt";
            dgvDSSP.Columns[1].DefaultCellStyle.Format = "dd/MM/yy";
            dgvDSSP.Columns[1].Width = 120;
            dgvDSSP.Columns[2].HeaderText = "Tình Trạng";
            dgvDSSP.Columns[2].Width = 120;
            dgvDSSP.Columns[3].HeaderText = "Mã Khách Hàng";
            dgvDSSP.Columns[3].Width = 150;
            dgvDSSP.Columns[4].HeaderText = "Tên Khách Hàng";
            dgvDSSP.Columns[4].Width = 220;
            dgvDSSP.Columns[5].HeaderText = "Số Điện Thoại";
            dgvDSSP.Columns[5].Width = 160;
            dgvDSSP.Columns[6].HeaderText = "Địa Chỉ";
            dgvDSSP.Columns[6].Width = 250;
        }
        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSSP.Rows[e.RowIndex];
                txtMaPhieuDat.Text = row.Cells[0].Value.ToString();
                txtTenKhachHang.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
                txtDiaChi.Text = row.Cells[6].Value.ToString();
                TinhTongTienPhieuDat(row.Cells[0].Value.ToString());
            }
            selectAllComumns(dgvDSSP);
        }
        void TinhTongTienPhieuDat(string maPD)
        {
            double tongTien = 0;
            PhieuDatSach pd = this.phieuDat.GetPhieuDatTheoMa(maPD).FirstOrDefault();
            IEnumerable<dynamic> ctPDs = this.ctPD.GetCTPhieuDatTheoMaPhieuDat(maPD);

            foreach (var chiTiet in ctPDs)
            {
                tongTien += double.Parse(chiTiet.GiaBan.ToString()) * double.Parse(chiTiet.SoLuong.ToString());
            }

            lblTongTien.Text = String.Format("{0:N} VND", tongTien);

        }
        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }
        void UnenablText()
        {
            txtMaPhieuDat.Enabled = false;
            txtSDT.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
        }
        clsLogin lg = frmLogin.login;
        Entity.PhieuDatSach phieuDatTruyen = frmLogin.phieuDat;

        private void btnChon_Click(object sender, EventArgs e)
        {

            if (dgvDSSP.SelectedRows.Count == 1)
            {
                if (dgvDSSP.SelectedRows[0].Cells[2].Value.ToString() != "đã xử lý")
                {
                    phieuDatTruyen.MaPhieuDat = dgvDSSP.SelectedRows[0].Cells[0].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Phiếu đặt đã được thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void frmKhachHangTrongNgay_FormClosing(object sender, FormClosingEventArgs e)
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
