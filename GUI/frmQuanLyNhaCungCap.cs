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
    public partial class frmQuanLyNhaCungCap : Form
    {
        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }
        int select = 0;
        clsNhaCungCap nhaCungCap;

        private void frmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            //WindowState = FormWindowState.Maximized;
            nhaCungCap = new clsNhaCungCap();
            dgvDSNCC.DataSource = nhaCungCap.GetAllNhaCungCap();
            dgvDSNCC.AllowUserToAddRows = false;
            dgvDSNCC.MultiSelect = false;
            NameColumn();
            enablebFalse();
        }
        void NameColumn()
        {
            dgvDSNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvDSNCC.Columns[0].Width = 200;
            dgvDSNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvDSNCC.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        void clearTextBox()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
        }
        void enablebFalse()
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;

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

        private void dgvDSNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvDSNCC.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
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
            string maNCC = "";
            IEnumerable<NhaCungCap> ncc = nhaCungCap.GetAllNhaCungCap();
            string maNCCLast = ncc.Last().MaNCC;
            int so = Convert.ToInt32(maNCCLast.Substring(2)) + 1;
            if (so < 10)
                maNCC = "CC0000" + so.ToString();
            else if (so < 100)
                maNCC = "CC000" + so.ToString();
            else if (so < 1000)
                maNCC = "CC00" + so.ToString();
            else if (so < 10000)
                maNCC = "CC0" + so.ToString();
            else
                maNCC = "CC" + so.ToString();
            return maNCC;

        }
        NhaCungCap TaoNCC()
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = txtMaNCC.Text.Trim();
            ncc.TenNCC = txtTenNCC.Text.Trim();
            return ncc;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            dlgHoiXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dlgHoiXoa == DialogResult.Yes)
            {
                NhaCungCap ncc = nhaCungCap.GetNCCTheoMa(txtMaNCC.Text).First();
                int check = nhaCungCap.xoaNCC(ncc);
                if (check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgvDSNCC.DataSource = nhaCungCap.GetAllNhaCungCap();
                    NameColumn();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    clearTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy nhà cung cấp", "Thông báo");
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
                txtTenNCC.Enabled = true;
                clearTextBox();
                txtMaNCC.Text = taoMaThem();
                btnLuu.Enabled = true;
                txtTenNCC.Focus();
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
                txtTenNCC.Enabled = true;
                btnLuu.Enabled = true;
                txtTenNCC.Focus();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                if (txtTenNCC.Text == "")
                    MessageBox.Show("Chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    NhaCungCap ncc = TaoNCC();
                    int check = nhaCungCap.themNCC(ncc);
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
                        dgvDSNCC.DataSource = nhaCungCap.GetAllNhaCungCap();
                        NameColumn();
                    }
                }
            }
            if (select == 2)
            {
                if (txtTenNCC.Text == "")
                    MessageBox.Show("Chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    NhaCungCap ncc = TaoNCC();
                    bool check = nhaCungCap.suaNCC(ncc);
                    if (check == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        btnSua.Text = "Sửa";
                        setButtonDefault();
                        enablebFalse();
                        dgvDSNCC.DataSource = nhaCungCap.GetAllNhaCungCap();
                        NameColumn();
                    }
                }
            }
        }

        private void frmQuanLyNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
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
