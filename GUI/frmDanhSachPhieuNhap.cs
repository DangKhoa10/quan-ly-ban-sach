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
    public partial class frmDanhSachPhieuNhap : Form
    {
        public frmDanhSachPhieuNhap()
        {
            InitializeComponent();
        }

        clsHonLoan honLoan;
        clsNhaCungCap nhaCungCap;
        clsNhanVien nhanVien;
        private void frmDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            this.honLoan = new clsHonLoan();
            this.nhaCungCap = new clsNhaCungCap();
            this.nhanVien = new clsNhanVien();
            WindowState = FormWindowState.Maximized;
            dgvDSPN.MultiSelect = false;
            ThemLocNV();
            ThemLocNhaCungCap();
            dgvDSPN.DataSource = this.honLoan.GetToanBoPhieuNhapSach();
            KhongChoPhepNhap();
            DoiTenCot();
            //ThemLocNCC();

        }
        private void btnChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dgvDSPN.SelectedRows.Count > 0)
            {
                frmNVChiTietPhieuNhap frm = new frmNVChiTietPhieuNhap(dgvDSPN.SelectedRows[0].Cells[0].Value.ToString(), dgvDSPN.SelectedRows[0].Cells[1].Value.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //XoaHetSach();
                    //lstvDanhSachSP.Clear();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn phiếu muốn xem", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        void DoiTenCot()
        {
            dgvDSPN.Columns[0].HeaderText = "Mã phiếu nhập";
            dgvDSPN.Columns[0].Width = 150;
            dgvDSPN.Columns[1].HeaderText = "Ngày lập phiếu";
            dgvDSPN.Columns[1].Width = 220;
            dgvDSPN.Columns[2].HeaderText = "Tên nhân viên";
            dgvDSPN.Columns[2].Width = 180;
            dgvDSPN.Columns[3].HeaderText = "Mã nhân viên";
            dgvDSPN.Columns[3].Width = 140;
            dgvDSPN.Columns[4].HeaderText = "Tên nhà cung cấp";
            dgvDSPN.Columns[4].Width = 280;
            dgvDSPN.Columns[5].HeaderText = "Mã nhà cung cấp";
            dgvDSPN.Columns[5].Width = 160;
        }
        private void dgvDSPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSPN.Rows[e.RowIndex];
                txtMaPhieuNhap.Text = row.Cells[0].Value.ToString();
                dtmNgayNhap.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                txtTenNhanVien.Text = row.Cells[2].Value.ToString();
                txtMaNhanVien.Text = row.Cells[3].Value.ToString();
                txtTenNhaCungCap.Text = row.Cells[4].Value.ToString();
                txtMaNhaCungCap.Text = row.Cells[5].Value.ToString();
            }
            selectAllComumns(dgvDSPN);
        }

        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }
        private void btnHienToanBo_Click(object sender, EventArgs e)
        {
            cboNhaCungCap.Text = "Lọc theo nhà cung cấp";
            cboNhanVien.Text = "Lọc theo nhân viên";
            dgvDSPN.DataSource = honLoan.GetToanBoPhieuNhapSach();
        }
        private void cboNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNhanVien.Text = "Lọc theo nhân viên";
            dgvDSPN.DataSource = honLoan.GetPhieuNhapSachTheoMaNhaCungCap(cboNhaCungCap.SelectedValue.ToString());
        }

        //void ThemLocNCC()
        //{
        //    IEnumerable<NhaCungCap> nccs;
        //    nccs = this.nhaCungCap.GetAllNhaCungCap();
        //    foreach (NhaCungCap ncc in nccs)
        //    {
        //        if (KiemTraTonTaiCboNCC(ncc.MaNCC) == false)
        //        {
        //            cboNhaCungCap.Items.Add(ncc.MaNCC);
        //        }
        //    }
        //}
        //bool KiemTraTonTaiCboNCC(string tg)
        //{
        //    for (int i = 0; i < cboNhaCungCap.Items.Count; i++)
        //    {
        //        if (cboNhaCungCap.Items[i].Equals(tg))
        //            return true;
        //    }
        //    return false;
        //}
        void ThemLocNhaCungCap()
        {
            cboNhaCungCap.DataSource = this.nhaCungCap.GetAllNhaCungCap();
            cboNhaCungCap.ValueMember = "MaNCC";
            cboNhaCungCap.DisplayMember = "TenNCC";
        }
        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNhaCungCap.Text = "Lọc theo nhà cung cấp";
            dgvDSPN.DataSource = honLoan.GetPhieuNhapSachTheoMaNhanVien(cboNhanVien.SelectedValue.ToString());
        }
        //void ThemLocNV()
        //{
        //    IEnumerable<NhanVien> nvs;
        //    nvs = this.nhanVien.GetAllNV();
        //    foreach (NhanVien nv in nvs)
        //    {
        //        //if (nv.MaNV.StartsWith("QL") || nv.MaNV.StartsWith("BH"))
        //        //{
        //            if (KiemTraTonTaiCboNV(nv.MaNV) == false)
        //            {
        //                cboNhanVien.Items.Add(nv.MaNV);
        //            }
        //        //}
        //    }
        //}
        //bool KiemTraTonTaiCboNV(string maNV)
        //{
        //    for (int i = 0; i < cboNhanVien.Items.Count; i++)
        //    {
        //        if (cboNhanVien.Items[i].Equals(maNV))
        //            return true;
        //    }
        //    return false;
        //}
        void ThemLocNV()
        {
            cboNhanVien.DataSource = this.nhanVien.GetNVTKCSN();
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.DisplayMember = "TenNV";

        }
        void KhongChoPhepNhap()
        {
            txtMaNhaCungCap.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtMaPhieuNhap.Enabled = false;
            txtTenNhaCungCap.Enabled = false;
            txtTenNhanVien.Enabled = false;
            dtmNgayNhap.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void frmDanhSachPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
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
