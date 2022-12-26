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
    public partial class frmCapNhatTacGia : Form
    {
        public frmCapNhatTacGia()
        {
            InitializeComponent();
        }
        int select = 0;
        clsTacGia tacGia;
        private void frmCapNhatTacGia_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            tacGia = new clsTacGia();
            dgvDSTG.DataSource = tacGia.GetAllTacGia();
            dgvDSTG.AllowUserToAddRows = false;
            dgvDSTG.MultiSelect = false;
            NameColumn();
            enablebFalse();
        }
        void NameColumn()
        {
            dgvDSTG.Columns[0].HeaderText = "Mã tác giả";
            dgvDSTG.Columns[0].Width = 200;
            dgvDSTG.Columns[1].HeaderText = "Tên tác giả";
            dgvDSTG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
         

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        void clearTextBox()
        {
            txtTenTG.Clear();
            txtMaTG.Clear();
        }
        void enablebFalse()
        {
            txtMaTG.Enabled = false;
            txtTenTG.Enabled = false;

        }
        void setButtonDefault()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void dgvDSTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvDSTG.Rows[e.RowIndex];
                txtMaTG.Text = row.Cells[0].Value.ToString();
                txtTenTG.Text = row.Cells[1].Value.ToString();
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
            string maTG = "";
            IEnumerable<TacGia> tg = tacGia.GetAllTacGia();
            string maTGLast = tg.Last().MaTG;
            int so = Convert.ToInt32(maTGLast.Substring(2)) + 1;
            if (so < 10)
                maTG = "TG0000" + so.ToString();
            else if (so < 100)
                maTG = "TG000" + so.ToString();
            else if (so < 1000)
                maTG = "TG00" + so.ToString();
            else if (so < 10000)
                maTG = "TG0" + so.ToString();
            else
                maTG = "TG" + so.ToString();
            return maTG;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                select = 1;
                btnThem.Text = "Hủy Thêm";
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                txtTenTG.Enabled = true;
                clearTextBox();
                txtMaTG.Text = taoMaThem();
                btnLuu.Enabled = true;
                txtTenTG.Focus();
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
                txtTenTG.Enabled = true;
                btnLuu.Enabled = true;
                txtTenTG.Focus();
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
        TacGia TaoTG()
        {
            TacGia tg = new TacGia();
            tg.MaTG = txtMaTG.Text.Trim();
            tg.TenTG = txtTenTG.Text.Trim();
            return tg;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (select == 1)
            {
                if (txtTenTG.Text == "")
                    MessageBox.Show("Chưa nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    TacGia tg = TaoTG();
                    int check = tacGia.themTG(tg);
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
                        dgvDSTG.DataSource = tacGia.GetAllTacGia();
                        NameColumn();
                    }
                }
            }
            if (select == 2)
            {
                if (txtTenTG.Text == "")
                    MessageBox.Show("Chưa nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    TacGia tg = TaoTG();
                    bool check = tacGia.suaTG(tg);
                    if (check == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        btnSua.Text = "Sửa";
                        setButtonDefault();
                        enablebFalse();
                        dgvDSTG.DataSource = tacGia.GetAllTacGia();
                        NameColumn();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlgHoiXoa;
            dlgHoiXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (dlgHoiXoa == DialogResult.Yes)
            {
                TacGia tg = tacGia.GetTGTheoMa(txtMaTG.Text).First();
                int check = tacGia.xoaTG(tg);
                if (check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgvDSTG.DataSource = tacGia.GetAllTacGia();
                    NameColumn();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    clearTextBox();
                }
                else
                    MessageBox.Show("Không tìm thấy tác giả", "Thông báo");
            }
        }

        private void frmCapNhatTacGia_FormClosing(object sender, FormClosingEventArgs e)
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
