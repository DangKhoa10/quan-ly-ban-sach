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
using QuanLyMuaBanSach.GUI;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.GUI
{
    public partial class frmThongTinKhachHang : Form
    {
        public frmThongTinKhachHang()
        {
            InitializeComponent();
        }
        clsLogin login;
        clsKhachHang khachHang;
        clsNhanVien nhanVien;
        clsPhieuDatSach phieuDatSach;
        private void frmThongTinKhachHang_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            login = frmLogin.login;
            phieuDatSach = new clsPhieuDatSach();
            string maKH = LayMaKH();
            dgvDanhSachDonDaDat.DataSource = phieuDatSach.GetPhieuDatSachTheoMaKH(maKH);
            ChinhDoRongCotVaTieuDe(dgvDanhSachDonDaDat);
            dataToText();
            btnHuyDonDat.Enabled = true;
            dgvDanhSachDonDaDat.MultiSelect = false;
        }
        private void dgvDanhSachDonDaDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectAllComumns(dgvDanhSachDonDaDat);
        }
        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }
        void ChinhDoRongCotVaTieuDe(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "Tên Khách Hàng";
            dgv.Columns[0].Width = 300;
            dgv.Columns[1].HeaderText = "Mã Phiếu Đặt";
            dgv.Columns[1].Width = 300;
            dgv.Columns[2].HeaderText = "Ngày Đặt";
            dgv.Columns[2].Width = 300;
            dgv.Columns[3].HeaderText = "Tình Trạng";
            dgv.Columns[3].Width = 300;
        }
        private string LayMaKH()
        {
            string userName = login.Username;
            TaiKhoan tk = login.getTaiKhoan(userName).FirstOrDefault();
            if(tk.LoaiTaiKhoan==4)
                return tk.MaKH;
            return tk.MaNV;
        }
        void dataToText()
        {
            string maUser, hoTen = "", sdt = "", diaChi ="", tenTK;
            string taiKhoan = frmLogin.login.Username;
            TaiKhoan tk = login.getTaiKhoan(taiKhoan).FirstOrDefault();
            tenTK = tk.Username;
            if (tenTK.StartsWith("QL") || tenTK.StartsWith("TK") || tenTK.StartsWith("BH"))// nếu là tài khoản của nhân viên
            {
                maUser = tk.MaNV;
                nhanVien = new clsNhanVien();
                NhanVien nv = nhanVien.GetNVTheoMa(maUser).FirstOrDefault();
                hoTen = nv.TenNV;
                sdt = nv.SDT;
                diaChi = nv.DiaChi;
            }
            else // nếu là TK khách hàng
            {
                maUser = tk.MaKH;
                khachHang = new clsKhachHang();
                KhachHang kh = khachHang.GetKHTheoMa(maUser).FirstOrDefault();
                hoTen = kh.TenKH;
                sdt = kh.SDT;
                diaChi = kh.DiaChi;
            }
            txtTen.Text = hoTen;
            txtSoDienThoai.Text = sdt;
            txtDiaChi.Text = diaChi;
            txtTenDangNhap.Text = tenTK;
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmKHDoiMatKhau frm = new frmKHDoiMatKhau();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataToText();
            }
        }

        private void btnDoiThongTin_Click(object sender, EventArgs e)
        {
            frmKHDoiThongTin frm = new frmKHDoiThongTin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataToText();
            }
        }
        private void btnChiTietDonDat_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachDonDaDat.SelectedRows.Count > 0)
            {
                string maPhieuDat = dgvDanhSachDonDaDat.SelectedRows[0].Cells[1].Value.ToString();
                string ngayDat = dgvDanhSachDonDaDat.SelectedRows[0].Cells[2].Value.ToString();
                frmKHChiTietPhieuDat frm = new frmKHChiTietPhieuDat(maPhieuDat, ngayDat);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
            else
            {
                MessageBox.Show("Hãy chọn phiếu muốn xem");
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        
        private void btnHuyDonDat_Click(object sender, EventArgs e)
        {

            string maPhieuDat = dgvDanhSachDonDaDat.SelectedRows[0].Cells[1].Value.ToString();
            string tinhTrang = dgvDanhSachDonDaDat.SelectedRows[0].Cells[3].Value.ToString();
            string maKH = LayMaKH();
            if (tinhTrang == "Chưa xử lí")
            {
                DialogResult dlgHoiXoa;
                dlgHoiXoa = MessageBox.Show("Bạn có chắc chắn muốn hủy đơn đặt?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dlgHoiXoa == DialogResult.Yes)
                {
                    PhieuDatSach pd = phieuDatSach.GetPhieuDatTheoMa(maPhieuDat).FirstOrDefault();
                    int check = phieuDatSach.xoaPhieuDat(pd);
                    if (check == 1)
                    {
                        MessageBox.Show("Hủy đơn đặt thành công", "Thông báo");
                        dgvDanhSachDonDaDat.DataSource = phieuDatSach.GetPhieuDatSachTheoMaKH(maKH);
                    }
                    else
                        MessageBox.Show("Lỗi không hủy được", "Thông báo");
                }
            }
            else MessageBox.Show("Không hủy được đơn đã xử lý", "Thông báo");

        }

        private void frmThongTinKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
