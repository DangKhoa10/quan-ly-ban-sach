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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static Entity.PhieuDatSach phieuDat;
        public static clsLogin login;
        int count = 0;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo",
                MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
                this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            login = new clsLogin();
            phieuDat = new Entity.PhieuDatSach();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (count < 3)
            {
                IEnumerable<TaiKhoan> tks = login.GetAllTK();
                int ktra = 0;
                foreach (TaiKhoan item in tks)
                {
                    if (item.Username.Trim() == txtUserName.Text)
                    {
                        ktra = 1;
                    }
                }

                if (ktra == 1)
                {
                    var tk = login.getTaiKhoan(txtUserName.Text.ToString()).FirstOrDefault();

                    if (tk.Password.Trim().Equals(txtPassWord.Text))// phải có trim vì dữ liệu bên csdl có thể có khoảng trắng
                    {
                        login.Username = tk.Username;
                        login.Password = txtPassWord.Text;
                        this.Hide();
                        GUI.frmMain frmMain = new GUI.frmMain();
                        frmMain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng", "Thông báo");
                        this.count++;
                    }
                }
                else
                {
                    MessageBox.Show("Không có tài khoản này", "Thông báo");
                    this.count = 0;
                }
            }
            else
            {
                MessageBox.Show("Nhập mật khẩu sai quá 3 lần", "Thông báo");
            }
        }

        private void lblTaoTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKi frm = new frmDangKi();
            frm.ShowDialog();
        }
    }
}