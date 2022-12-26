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
    public partial class frmKHDoiMatKhau : Form
    {
        public frmKHDoiMatKhau()
        {
            InitializeComponent();
        }
        clsLogin login = frmLogin.login;
        //TaiKhoan TaoTK()
        //{
        //string userName = frmLogin.login.Username;
        //login = new clsLogin();
        //IEnumerable<TaiKhoan> tk = login.getTaiKhoan(userName);
        //string user, mkMoi;
        //foreach (TaiKhoan item in tk)
        //{
        //    user = userName;
        //}
        //mkMoi = txtMKMoi.Text;

        //MessageBox.Show("Username:" + tk.Username + "|\nPassword:" + tk.Password + "|\nLoaiTK:" +  
        //    tk.LoaiTaiKhoan + "|\nMaKH:" + tk.MaKH + "|\nMaNV:" + tk.MaNV + "|", "Thông báo");
        //string matk = tk.MaKH;

        //TaiKhoan user = new TaiKhoan();
        //foreach (TaiKhoan item in tk)
        //{
        //    user.Username = item.Username.Trim();
        //    user.MaNV = item.MaNV.Trim();
        //    user.MaKH = item.MaKH;
        //}
        //user.Password = txtMKMoi.Text;
        //if (frmLogin.login.Username.StartsWith("QL"))
        //{
        //    user.LoaiTaiKhoan = 1;
        //}
        //else if (frmLogin.login.Username.StartsWith("BH"))
        //{
        //    user.LoaiTaiKhoan = 2;
        //}
        //else if (frmLogin.login.Username.StartsWith("TK"))
        //{
        //    user.LoaiTaiKhoan = 3;
        //}
        //else
        //{
        //    user.LoaiTaiKhoan = 4;
        //}
        //return user;
        //}

        //TaiKhoan TaoTK()
        //{
        //    string makh;
        //    string userName = frmLogin.login.Username;
        //    login = new clsLogin();
        //    IEnumerable<TaiKhoan> tk = login.getTaiKhoan(userName);
        //    foreach (var item in tk)
        //    {
        //        makh = item.MaKH;
        //    }
        //    TaiKhoan user = new TaiKhoan();
        //    user.Username = frmLogin.login.Username;
        //    user.Password = txtMKMoi.Text;
        //    if (frmLogin.login.Username.StartsWith("QL"))
        //    {
        //        foreach (var item in tk)
        //        {
        //            user.MaNV = item.MaNV;
        //        }
        //        user.LoaiTaiKhoan = 2;
        //    }
        //    else if (frmLogin.login.Username.StartsWith("BH"))
        //    {
        //        foreach (var item in tk)
        //        {
        //            user.MaNV = item.MaNV;
        //        }
        //        user.LoaiTaiKhoan = 3;
        //    }
        //    else if (frmLogin.login.Username.StartsWith("TK"))
        //    {
        //        foreach (var item in tk)
        //        {
        //            user.MaNV = item.MaNV;
        //        }
        //        user.LoaiTaiKhoan = 4;
        //    }
        //    else
        //    {
        //        foreach (var item in tk)
        //        {
        //            user.MaKH = item.MaKH;
        //        }
        //        user.LoaiTaiKhoan = 1;
        //    }
        //    return user;
        //}
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string passHienTai = frmLogin.login.Password;
            string passCu = txtMKCu.Text;
            string passMoi = txtMKMoi.Text;
            string passXacNhan = txtXacNhanMK.Text;
            if (passHienTai.Equals(passCu) == false)
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passMoi == "" || passMoi == null)
            {
                MessageBox.Show("Chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passMoi.KiemTraMK() == false)
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passXacNhan.Equals(passMoi) == false)
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string userName = login.Username; 
                string mkMoi = txtMKMoi.Text;
                bool rs = login.SuaMK1(userName,mkMoi);
                MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo");
                this.Close();
            }
        }

        private void btnHienMKCu_Click(object sender, EventArgs e)
        {
            if (btnHienMKCu.Text == "Hiện")
            {
                btnHienMKCu.Text = "Ẩn";
                txtMKCu.UseSystemPasswordChar = false;
            }
            else
            {
                btnHienMKCu.Text = "Hiện";
                txtMKCu.UseSystemPasswordChar = true;
            }
        }

        private void btnHienMKMoi_Click(object sender, EventArgs e)
        {
            if (btnHienMKMoi.Text == "Hiện")
            {
                btnHienMKMoi.Text = "Ẩn";
                txtMKMoi.UseSystemPasswordChar = false;
            }
            else
            {
                btnHienMKMoi.Text = "Hiện";
                txtMKMoi.UseSystemPasswordChar = true;
            }
        }

        private void btnHienXNMK_Click(object sender, EventArgs e)
        {
            if (btnHienXNMK.Text == "Hiện")
            {
                btnHienXNMK.Text = "Ẩn";
                txtXacNhanMK.UseSystemPasswordChar = false;
            }
            else
            {
                btnHienXNMK.Text = "Hiện";
                txtXacNhanMK.UseSystemPasswordChar = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKHDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void frmKHDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
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
