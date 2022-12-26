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
    public partial class frmTimKiemSach : Form
    {
        public frmTimKiemSach()
        {
            InitializeComponent();
        }
        clsTacGia tacGia;
        clsLoaiSach loaiSach;
        clsSach sach;
        clsNhaXuatBan nhaXuatBan;
        clsHonLoan honloan;
        clsLogin login = frmLogin.login;
        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            tacGia = new clsTacGia();
            loaiSach = new clsLoaiSach();
            sach = new clsSach();
            nhaXuatBan = new clsNhaXuatBan();
            honloan = new clsHonLoan();
            dgvDSSach.DataSource = honloan.GetThongTinSachQLSach();
            dgvDSSach.MultiSelect = false;
            NameColumn();
            themlocloaisach();
            themlocnhaxuatban();
            themloctacgia();
            //cboLocTheoNXB.Text = "Lọc theo nhà xuất bản";
            //cboLocTheoTheLoai.Text = "Lọc theo loại sách";
            //cboLocTheoTG.Text = "Lọc theo tác giả";
            AnNutChoNhanVien();
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
            if (KiemTraChucVu() == 3)
            {
                btnThemGH.Hide();
                btnXemGH.Hide();
            }
        }
        void NameColumn()
        {
            dgvDSSach.Columns[0].HeaderText = "Mã sách";
            dgvDSSach.Columns[1].HeaderText = "Tên sách";
            dgvDSSach.Columns[2].HeaderText = "Giá nhập";
            dgvDSSach.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDSSach.Columns[3].HeaderText = "Giá bán";
            dgvDSSach.Columns[3].DefaultCellStyle.Format = "N0";
            dgvDSSach.Columns[4].HeaderText = "Số lượng";
            dgvDSSach.Columns[5].HeaderText = "Tác giả";
            dgvDSSach.Columns[6].HeaderText = "Thể loại";
            dgvDSSach.Columns[7].HeaderText = "Số trang";
            dgvDSSach.Columns[8].HeaderText = "Nhà xuất bản";
            dgvDSSach.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void themlocnhaxuatban()
        {
           // cboloctheonxb.datasource = nhaxuatban.getallnxb();
           // cboloctheonxb.displaymember = "tennxb";
            cboTimNXB.DataSource = nhaXuatBan.GetAllNXB();
            cboTimNXB.DisplayMember = "TenNXB";
            cboTimNXB.Text = "";
        }

        void themlocloaisach()
        {
            //cboloctheotheloai.datasource = loaisach.getallloaisach();
            //cboloctheotheloai.displaymember = "tenloai";
            cboTimLS.DataSource = loaiSach.GetAllLoaiSach();
            cboTimLS.DisplayMember = "TenLoai";
            cboTimLS.Text = "";
        }
        void themloctacgia()
        {
            //cboloctheotg.datasource = tacgia.getalltacgia();
            //cboloctheotg.displaymember = "tentg";
            cboTimTG.DataSource = tacGia.GetAllTacGia();
            cboTimTG.DisplayMember = "TenTG";
            cboTimTG.Text = "";
        }




        //void XuLyHoTroAutocomlet()
        //{
        //IEnumerable<Sach> listSach;
        //IEnumerable<TacGia> listTG;
        //listSach = sach.GetAllSach();
        //listTG = tacGia.GetAllTacGia();
        //txtTenSach.AutoCompleteCustomSource.Clear();
        //if (rdoMaSach.Checked)
        //{
        //    foreach (Sach s in listSach)
        //    {
        //        txtTenSach.AutoCompleteCustomSource.Add(s.MaSach);
        //    }
        //}
        //else if (rdoTenSach.Checked)
        //{
        //    foreach (Sach s in listSach)
        //    {
        //        txtTenSach.AutoCompleteCustomSource.Add(s.TenSach);
        //    }
        //}
        //else
        //{
        //    foreach (TacGia tg in listTG)
        //    {
        //        txtTenSach.AutoCompleteCustomSource.Add(tg.TenTG);
        //    }
        //}

        //}



        private void btnAllSach_Click(object sender, EventArgs e)
        {
            dgvDSSach.DataSource = honloan.GetThongTinSachQLSach();
            NameColumn();
            //cboLocTheoNXB.Text = "Lọc theo nhà xuất bản";
            //cboLocTheoTheLoai.Text = "Lọc theo loại sách";
            //cboLocTheoTG.Text = "Lọc theo tác giả";
            txtTenSach.Clear();
            txtMaSach.Clear();
            cboTimLS.Text = "";
            cboTimNXB.Text = "";
            cboTimTG.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = "", ten = "";
            if (!string.IsNullOrEmpty(txtMaSach.Text))
                ma = txtMaSach.Text;
            if (!string.IsNullOrEmpty(txtTenSach.Text))
                ten = txtTenSach.Text;
            dgvDSSach.DataSource = honloan.GetTimKiemSach(ma, ten,cboTimTG.Text,cboTimLS.Text,cboTimNXB.Text);
            NameColumn();
            //cboLocTheoNXB.Text = "Lọc theo nhà xuất bản";
            //cboLocTheoTheLoai.Text = "Lọc theo loại sách";
            //cboLocTheoTG.Text = "Lọc theo tác giả";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private ListViewItem CreateItem(DataGridViewRow row,string sl)
        {
            
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(row.Cells[0].Value.ToString());
            Sach s = sach.GetSachTheoMa(row.Cells[0].Value.ToString()).FirstOrDefault();
            lvwItem.SubItems.Add(s.TenSach);
            lvwItem.SubItems.Add(s.DonGiaBan.ToString());
            lvwItem.SubItems.Add(sl);
            double tt = Convert.ToInt32(sl) * Convert.ToDouble(s.DonGiaBan.ToString());
            lvwItem.SubItems.Add(tt.ToString());
            return lvwItem;
        }
        private void btnThemGH_Click(object sender, EventArgs e)
        {
            string soLuong="";
            if (!(dgvDSSach.SelectedRows.Count > 0))
                MessageBox.Show("Chọn sách muốn mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                GUI.frmNhapSoLuongTimKiemSach frm = new GUI.frmNhapSoLuongTimKiemSach(dgvDSSach.SelectedRows[0].Cells[0].Value.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    soLuong = frm.sl;
                    if (KtraDaDatChua(dgvDSSach.SelectedRows[0].Cells[0].Value.ToString(), lvwGioHang))
                    {
                        MessageBox.Show("Sách đã tồn tại trong giỏ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        ListViewItem lvw = CreateItem(dgvDSSach.SelectedRows[0], soLuong);
                        lvwGioHang.Items.Add(lvw);
                        lblSoLuongSach.Text = lvwGioHang.Items.Count.ToString();
                    }

                }
            }
            
        }
       
        
        bool KtraDaDatChua(string ma, ListView lstView)
        {
            foreach (ListViewItem item in lstView.Items)
            {
                if (ma.Equals(item.SubItems[0].Text)) // Kiểm tra xem đã chọn sách này chưa
                {
                    return true;
                }
            }
            return false;
        }

        private void dgvDSSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectAllComumns(dgvDSSach);
        }
        void selectAllComumns(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            row.Selected = true;
        }

        private void btnXemGH_Click(object sender, EventArgs e)
        {
            GUI.frmGioHangTimKiemSach frm = new GUI.frmGioHangTimKiemSach(lvwGioHang);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                lvwGioHang = frm.gioHangNew;
                lblSoLuongSach.Text = lvwGioHang.Items.Count.ToString();
                dgvDSSach.DataSource = honloan.GetThongTinSachQLSach();
            }
        }

        private void frmTimKiemSach_FormClosing(object sender, FormClosingEventArgs e)
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
        //private void cboLocTheoNXB_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    dgvDSSach.DataSource = honloan.GetTimKiemTheoNXB(cboLocTheoNXB.Text);
        //    NameColumn();
        //    cboLocTheoTheLoai.Text = "Lọc theo loại sách";
        //    cboLocTheoTG.Text = "Lọc theo tác giả";
        //}

        //private void cboLocTheoTG_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    dgvDSSach.DataSource = honloan.GetTimKiemSachTheoTG(cboLocTheoTG.Text);
        //    NameColumn();
        //    cboLocTheoNXB.Text = "Lọc theo nhà xuất bản";
        //    cboLocTheoTheLoai.Text = "Lọc theo loại sách";
        //}

        //private void cboLocTheoTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //        dgvDSSach.DataSource = honloan.GetTimKiemSachTheoLoaiSach(cboLocTheoTheLoai.Text);
        //        NameColumn();
        //        cboLocTheoNXB.Text = "Lọc theo nhà xuất bản";
        //        cboLocTheoTG.Text = "Lọc theo tác giả";
        //}
    }
}
