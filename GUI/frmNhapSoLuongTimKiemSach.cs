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
    public partial class frmNhapSoLuongTimKiemSach : Form
    {
        public frmNhapSoLuongTimKiemSach(string ma)
        {
            InitializeComponent();
            maSach = ma;
        }
        public string sl;
        string maSach;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Nhập số lượng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if(Convert.ToInt32(txtSoLuong.Text)==0)
                MessageBox.Show("Số lượng > 0", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(checkSL())
                MessageBox.Show("Cửa hàng không đủ số lượng sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                sl = txtSoLuong.Text;
                this.DialogResult = DialogResult.OK;
            }
                
        }
        bool checkSL()
        {
            Sach s = new clsSach().GetSachTheoMa(maSach).First();
            if (Convert.ToInt32(txtSoLuong.Text) > s.SoLuongTon)
                return true;
            return false;
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 127 || e.KeyChar == 8) // cho phép nhấn số, delete và backspace
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmNhapSoLuongTimKiemSach_Load(object sender, EventArgs e)
        {

        }
    }
}
