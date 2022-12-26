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

namespace QuanLyMuaBanSach.GUI
{
    public partial class frmGioHangTimKiemSach : Form
    {
        ListView gioHang;
        clsLogin login = frmLogin.login;
        bool checkGH = false;
        public ListView gioHangNew;
        public frmGioHangTimKiemSach(ListView gh)
        {
            InitializeComponent();
            gioHang = gh;
        }
        private void frmGioHangTimKiemSach_Load(object sender, EventArgs e)
        {
            CreateColumn(lvwDSSach);
            loadGioHang(gioHang);
            AnNutChoNhanVien();
        }
        void loadGioHang(ListView gioHang)
        {
            foreach (ListViewItem item in gioHang.Items)
            {
                ListViewItem newItem = CreateListViewItem(item);
                lvwDSSach.Items.Add(newItem);
            }
        }
        ListViewItem CreateListViewItem(ListViewItem item)
        {
            ListViewItem newItem;
            newItem = new ListViewItem(item.SubItems[0].Text);
            newItem.SubItems.Add(item.SubItems[1].Text);
            newItem.SubItems.Add(item.SubItems[2].Text);
            newItem.SubItems.Add(item.SubItems[3].Text);
            newItem.SubItems.Add(item.SubItems[4].Text);
            return newItem;
        }
        void CreateColumn(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã sách", 100);
            lvw.Columns.Add("Tên sách", 300);
            lvw.Columns.Add("Đơn giá", 150);
            lvw.Columns.Add("Số lượng", 100); 
            lvw.Columns.Add("Thành tiền", 300);
        }

        private int KiemTraChucVu()
        {
            TaiKhoan tk = new clsTaiKhoan().GetAllTaiKhoan().Where(o => o.Username == login.Username).FirstOrDefault();
            if (tk.MaNV != null)
            {
                NhanVien nv = new clsNhanVien().GetNVTheoMa(tk.MaNV).FirstOrDefault();
                int chucVu = nv.ChucVu;
                return chucVu;
            }
            else
            {
                return 4;
            }
        }
        void AnNutChoNhanVien()
        {
            if (KiemTraChucVu() == 4)
            {
                btnMuaSach.Hide();
            }
        }

        private void btnMuaSach_Click(object sender, EventArgs e)
        {
            if (lvwDSSach.Items.Count > 0)
            {
                GUI.frmLapHoaDon frm = new GUI.frmLapHoaDon(lvwDSSach);
                if(frm.ShowDialog() == DialogResult.OK)
                    lvwDSSach.Items.Clear();

                gioHangNew = lvwDSSach;
                this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.frmGioHangTimKiemSach_FormClosing);
                this.DialogResult = DialogResult.OK;

            }
            else
                MessageBox.Show("Giỏ hàng rỗng","Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDatSach_Click(object sender, EventArgs e)
        {
            if (lvwDSSach.Items.Count > 0)
            {
                GUI.frmDatSach frm = new GUI.frmDatSach(lvwDSSach);
                if (frm.ShowDialog() == DialogResult.OK)
                    lvwDSSach.Items.Clear();

                gioHangNew = lvwDSSach;
                this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.frmGioHangTimKiemSach_FormClosing);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Giỏ hàng rỗng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                
                this.Close();
                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwDSSach.SelectedItems.Count > 0)
            {
                int viTriThuc;
                DialogResult dl = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    for (int i = 0; i < lvwDSSach.SelectedItems.Count;)
                    {
                        viTriThuc = lvwDSSach.SelectedIndices[i];
                        lvwDSSach.Items.RemoveAt(viTriThuc);
                    }
                }
                //lstvDanhSachNhap.Items.Remove(lstvDanhSachNhap.SelectedItems[0]);
                gioHangNew = lvwDSSach;
                checkGH = true;
            }
            else MessageBox.Show("Chọn sách muốn xóa");
        }

        private void frmGioHangTimKiemSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo",
                MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                if (checkGH == true)
                {
                    this.DialogResult = DialogResult.OK;
                }
            } 
            else
                e.Cancel = true;
        }
    }
}
