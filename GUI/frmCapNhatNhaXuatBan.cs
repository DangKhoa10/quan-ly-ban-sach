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
    public partial class frmCapNhatNhaXuatBan : Form
    {
        
        public frmCapNhatNhaXuatBan()
        {
            InitializeComponent();
        }
        int select = 0;
        clsNhaXuatBan nhaXuatBan;
        private void frmCapNhatNhaXuatBan_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            nhaXuatBan = new clsNhaXuatBan();
            dgvDSNXB.DataSource = nhaXuatBan.GetAllNXB();
            dgvDSNXB.AllowUserToAddRows = false;
            dgvDSNXB.MultiSelect = false;
            NameColumn();
            enablebFalse();
        }
        void NameColumn()
        {
            dgvDSNXB.Columns[0].HeaderText = "Mã nhà xuất bản";
            dgvDSNXB.Columns[0].Width = 200;
            dgvDSNXB.Columns[1].HeaderText = "Tên nhà xuất bản";
            dgvDSNXB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        void clearTextBox()
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
        }
        void enablebFalse()
        {
            txtMaNXB.Enabled = false;
            txtTenNXB.Enabled = false;

        }
        void setButtonDefault()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void dgvDSNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvDSNXB.Rows[e.RowIndex];
                txtMaNXB.Text = row.Cells[0].Value.ToString();
                txtTenNXB.Text = row.Cells[1].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                enablebFalse();
            }
        }
        string taoMaThem()
        {
            string maNXB = "";
            IEnumerable<NhaXuatBan> nxb = nhaXuatBan.GetAllNXB();
            string maNXBLast = nxb.Last().MaNXB;
            int so = Convert.ToInt32(maNXBLast.Substring(2)) + 1;
            if (so < 10)
                maNXB = "XB0000" + so.ToString();
            else if (so < 100)
                maNXB = "XB000" + so.ToString();
            else if (so < 1000)
                maNXB = "XB00" + so.ToString();
            else if (so < 10000)
                maNXB = "XB0" + so.ToString();
            else
                maNXB = "XB" + so.ToString();
            return maNXB;

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            dlgHoiXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dlgHoiXoa == DialogResult.Yes)
            {
                NhaXuatBan nxb = nhaXuatBan.GetNXBTheoMa(txtMaNXB.Text).First();
                int check = nhaXuatBan.xoaNXB(nxb);
                if (check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgvDSNXB.DataSource = nhaXuatBan.GetAllNXB();
                    NameColumn();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    clearTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy nhà xuất bản", "Thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                select = 1;
                btnThem.Text = "Hủy Thêm";
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtTenNXB.Enabled = true;
                clearTextBox();
                txtMaNXB.Text = taoMaThem();
                btnLuu.Enabled = true;
                txtTenNXB.Focus();
            }
            else
            {
                btnThem.Text = "Thêm";
                clearTextBox();
                setButtonDefault();
                enablebFalse();
                select = 0;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                select = 2;
                btnSua.Text = "Hủy Sửa";
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                txtTenNXB.Enabled = true;
                btnLuu.Enabled = true;
                txtTenNXB.Focus();
            }
            else
            {
                btnSua.Text = "Sửa";
                setButtonDefault();
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                enablebFalse();
                select = 0;
            }
        }
        NhaXuatBan TaoNXB()
        {
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.MaNXB = txtMaNXB.Text.Trim();
            nxb.TenNXB = txtTenNXB.Text.Trim();
            return nxb;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                if (txtTenNXB.Text == "")
                    MessageBox.Show("Chưa nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    NhaXuatBan nxb = TaoNXB();
                    int check = nhaXuatBan.themNXB(nxb);
                    if (check == 0)
                    {
                        MessageBox.Show("Trùng mã");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công");
                        btnThem.Text = "Thêm";
                        setButtonDefault();
                        enablebFalse();
                        dgvDSNXB.DataSource = nhaXuatBan.GetAllNXB();
                        NameColumn();
                    }
                }
            }
            if (select == 2)
            {
                if (txtTenNXB.Text == "")
                    MessageBox.Show("Chưa nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    NhaXuatBan nxb = TaoNXB();
                    bool check = nhaXuatBan.suaNXB(nxb);
                    if (check == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        btnSua.Text = "Sửa";
                        setButtonDefault();
                        enablebFalse();
                        dgvDSNXB.DataSource = nhaXuatBan.GetAllNXB();
                        NameColumn();
                    }
                }
            }
        }

        private void frmCapNhatNhaXuatBan_FormClosing(object sender, FormClosingEventArgs e)
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
