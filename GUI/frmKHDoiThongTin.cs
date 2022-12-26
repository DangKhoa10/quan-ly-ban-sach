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
    public partial class frmKHDoiThongTin : Form
    {
        public frmKHDoiThongTin()
        {
            InitializeComponent();
        }
        clsLogin login = frmLogin.login;
        clsNhanVien nv;
        clsKhachHang kh;
        //string ma;

        private void frmKHDoiThongTin_Load(object sender, EventArgs e)
        {
            TaiDuLieuCoSan();
        }
        void TaiDuLieuCoSan()
        {
            //this.ma = LayMaTuTenDangNhap(login.Username);
            string ten = "", diaChi = "", sdt = "";
            if (login.Username.StartsWith("QL") || login.Username.StartsWith("BH") || login.Username.StartsWith("TK"))
            {
                string maNV = LayMaNV();
                nv = new clsNhanVien();
                NhanVien nhanVien = nv.GetNVTheoMa(maNV).FirstOrDefault();
                ten = nhanVien.TenNV;
                diaChi = nhanVien.DiaChi;
                sdt = nhanVien.SDT;
            }
            else
            {
                string maKH = LayMaKH();
                kh = new clsKhachHang();
                KhachHang khachHang = kh.GetKHTheoMa(maKH).FirstOrDefault();
                ten = khachHang.TenKH;
                diaChi = khachHang.DiaChi;
                sdt = khachHang.SDT;
            }
            txtDiaChi.Text = diaChi;
            txtSDT.Text = sdt;
            txtTen.Text = ten;
        }
        //string LayMaTuTenDangNhap(string tenDangNhap)
        //{
        //    TaiKhoan tk = login.getTaiKhoan(tenDangNhap).FirstOrDefault();
        //    if(tenDangNhap.StartsWith("QL") || tenDangNhap.StartsWith("BH") || tenDangNhap.StartsWith("BH"))
        //    {
        //        return tk.MaNV;
        //    }
        //    else
        //    {
        //        return tk.MaKH;
        //    }

        //}
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenMoi = txtTen.Text.Trim();
            string sDTMoi = txtSDT.Text.Trim();
            string diaChiMoi = txtDiaChi.Text.Trim();
            if (tenMoi == "" || sDTMoi == "" || diaChiMoi == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (BoDau(tenMoi).KiemTraTen() == false)
            {
                MessageBox.Show("Sai định dạng tên", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            if (sDTMoi.KiemTraSDT() == false)
            {
                MessageBox.Show("Sai định dạng số điện thoại", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có đồng ý cập nhật thông tin không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(rs == DialogResult.Yes)
                {
                    if (login.Username.StartsWith("QL") || login.Username.StartsWith("BH") || login.Username.StartsWith("TK"))
                    {
                        string maNV = LayMaNV();
                        nv = new clsNhanVien();
                        nv.SuaNV(maNV, tenMoi, sDTMoi, diaChiMoi);
                        MessageBox.Show("Đã cập nhật thông tin thành công", "Thông Báo", MessageBoxButtons.OK);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                    else
                    {
                        string maKH = LayMaKH();
                        kh = new clsKhachHang();
                        bool check = kh.SuaKH(maKH, tenMoi, sDTMoi, diaChiMoi);
                        if (check == true)
                        {
                            MessageBox.Show("Đã cập nhật thông tin thành công", "Thông Báo", MessageBoxButtons.OK);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            return;
                        }
                        else { 
                            MessageBox.Show("Số điện thoại đã tồn tại", "Thông Báo", MessageBoxButtons.OK); 
                            return; 
                        }
                    }
                    MessageBox.Show("Cập nhật không thành công", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    
                }
            }
        }
        public string BoDau(string s)// Hàm bỏ dấu để check tên vd: Trung Hoài => Trung Hoai
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }
        private string LayMaKH()
        {
            string userName = login.Username;
            TaiKhoan tk = login.getTaiKhoan(userName).FirstOrDefault();
            return tk.MaKH;
        }
        private string LayMaNV()
        {
            string userName = login.Username;
            TaiKhoan tk = login.getTaiKhoan(userName).FirstOrDefault();
            return tk.MaNV;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKHDoiThongTin_FormClosing(object sender, FormClosingEventArgs e)
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
