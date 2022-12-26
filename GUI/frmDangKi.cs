using QuanLyMuaBanSach.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaBanSach.GUI
{
    public partial class frmDangKi : Form
    {
        clsTaiKhoan taiKhoan;
        public frmDangKi()
        {
            InitializeComponent();
        }
        private void frmDangKi_Load(object sender, EventArgs e)
        {
            taiKhoan = new clsTaiKhoan();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string ten = LoaiDau(txtHoTen.Text.Trim());
            if (ten.KiemTraTen()==false)
                MessageBox.Show("Sai định dạng tên","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else if(txtSDT.Text.Trim().KiemTraSDT()==false)
                MessageBox.Show("Sai định dạng số điện thoại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(txtDC.Text == "")
                MessageBox.Show("Nhập địa chỉ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if((txtTaiKhoan.Text.Trim().StartsWith("QL") || txtTaiKhoan.Text.Trim().StartsWith("BH") || txtTaiKhoan.Text.Trim().StartsWith("TK")))
                MessageBox.Show("Tài khoản không được bắt đầu với QL , BH ,TK", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtTaiKhoan.Text.Trim().KiemTraDau()== false)
                MessageBox.Show("Tài khoản không được có ký tự đặc biệt , tối thiểu 5 kí tự , tối đa 20 kí tự", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (taiKhoan.checkIfExist(txtTaiKhoan.Text.Trim())==true)
                MessageBox.Show("Tên tài khoản đã được sử dụng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMK.Text.Trim().KiemTraMK() == false)
                MessageBox.Show("Mật khẩu trên 8 kí tự gồm số , chũ hoa , chữ thường", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(txtMK.Text != txtXNMK.Text)
                MessageBox.Show("Mật khẩu không khớp", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (new clsKhachHang().checkSDT(txtSDT.Text.Trim())==true)
            {
                IEnumerable<KhachHang> kh = new clsKhachHang().GetKHTheoSDT(txtSDT.Text.Trim());
                new clsKhachHang().SuaKH(kh.First().MaKH, txtHoTen.Text.Trim(), txtSDT.Text.Trim(), txtDC.Text.Trim());
                TaiKhoan tk = taoTaiKhoan(kh.First().MaKH);
                int checktk = taiKhoan.themTK(tk);
                if (checktk == 0)
                    MessageBox.Show("Trùng username");
                else
                {
                    MessageBox.Show("Tạo tài khoản thành công");
                    this.Close();
                }
            }
            else
            {
                KhachHang kh = TaoKH();
                int check = new clsKhachHang().themKH(kh);
                if (check == 0)
                    MessageBox.Show("Trùng mã");
                else
                {
                    TaiKhoan tk = taoTaiKhoan(kh.MaKH);
                    int checktk = taiKhoan.themTK(tk);
                    if (checktk == 0)
                        MessageBox.Show("Trùng username");
                    else
                    {
                        MessageBox.Show("Tạo tài khoản thành công");
                        this.Close();
                    }
                        
                }
            }
        }
        public string LoaiDau(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
                        .Replace('đ', 'd').Replace('Đ', 'D');
        }
        string taoMaThem()
        {
            string maKH = "";
            IEnumerable<KhachHang> kh = new clsKhachHang().GetAllKH();
            string maKHLast = kh.Last().MaKH;
            int so = Convert.ToInt32(maKHLast.Substring(2)) + 1;
            if (so < 10)
                maKH = "KH0000" + so.ToString();
            else if (so < 100)
                maKH = "KH000" + so.ToString();
            else if (so < 1000)
                maKH = "KH00" + so.ToString();
            else if (so < 10000)
                maKH = "KH0" + so.ToString();
            else
                maKH = "KH" + so.ToString();
            return maKH;

        }
        KhachHang TaoKH()
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = taoMaThem();
            kh.TenKH = txtHoTen.Text.Trim();
            kh.SDT = txtSDT.Text.Trim();
            kh.DiaChi = txtDC.Text.Trim();
            return kh;
        }
        TaiKhoan taoTaiKhoan(string makh)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.Username = txtTaiKhoan.Text.Trim();
            tk.Password = txtMK.Text.Trim();
            tk.LoaiTaiKhoan = 4;
            tk.MaKH = makh;
            return tk;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void frmDangKi_FormClosing(object sender, FormClosingEventArgs e)
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
