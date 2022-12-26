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
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.GUI
{
    public partial class frmKHChiTietPhieuDat : Form
    {
        public frmKHChiTietPhieuDat()
        {
            InitializeComponent();
        }
        public frmKHChiTietPhieuDat(string maPhieuDat, string ngayDat)
        {
            InitializeComponent();
            this.maPhieuDat = maPhieuDat;
            this.ngayDat = ngayDat;
        }
        clsLogin login = frmLogin.login;
        clsChiTietPhieuDat ctPhieuDat;
        string maPhieuDat;
        string ngayDat;
        private void frmKHChiTietDonDat_Load(object sender, EventArgs e)
        {
            ctPhieuDat = new clsChiTietPhieuDat();
            dgvDSSP.DataSource = ctPhieuDat.GetCTPhieuDatTheoMaPhieuDat(maPhieuDat);
            dgvDSSP.MultiSelect = false;
            txtMaDonDat.Text = maPhieuDat;
            ChinhDoRongCotVaTieuDe(dgvDSSP);
            LayNgayDatPhieu();
            TinhTongPhieuDat();
        }

        void TinhTongPhieuDat()
        {
            float tong = 0;
            for (int i =0; i < dgvDSSP.Rows.Count; i++)
            {
                tong = tong + (float.Parse(dgvDSSP.Rows[i].Cells[2].Value.ToString()) *
                    float.Parse(dgvDSSP.Rows[i].Cells[3].Value.ToString()));
            }
            lblTongTien.Text = string.Format("{0:#,###}", tong) + " VNĐ";
        }
        void ChinhDoRongCotVaTieuDe(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "Mã Phiếu Đặt";
            dgv.Columns[0].Width = 120;
            dgv.Columns[1].HeaderText = "Tên Sách";
            dgv.Columns[1].Width = 280;
            dgv.Columns[2].HeaderText = "Đơn Giá";
            dgv.Columns[2].Width = 150;
            dgv.Columns[3].HeaderText = "Số Lượng";
            dgv.Columns[3].Width = 130;
        }

        void LayNgayDatPhieu()
        {
            dtmNgayDat.Value = DateTime.Parse(this.ngayDat);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void frmKHChiTietPhieuDat_FormClosing(object sender, FormClosingEventArgs e)
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
