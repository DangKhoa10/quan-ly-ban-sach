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
    public partial class frmThongKeTonKho : Form
    {
        public frmThongKeTonKho()
        {
            InitializeComponent();
        }
        clsHonLoan honLoan;
        private void frmThongKeTonKho_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            honLoan = new clsHonLoan();
            rdoTatCa.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        void NameColumn()
        {
            dgvDSSPTonKho.Columns[0].HeaderText = "Mã sách";
            dgvDSSPTonKho.Columns[0].Width = 180;
            dgvDSSPTonKho.Columns[1].HeaderText = "Tên sách";
            dgvDSSPTonKho.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSSPTonKho.Columns[2].HeaderText = "Số lượng sách còn lại";
            dgvDSSPTonKho.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSSPTonKho.Columns[2].Width = 250;
        }
        private void checkDGV()
        {
            if (dgvDSSPTonKho.Rows.Count > 0)
            {
                dgvDSSPTonKho.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDSSPTonKho.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDSSPTonKho.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (rdoTatCa.Checked)
            {
                dgvDSSPTonKho.DataSource = honLoan.ThongKeTonKho();
                NameColumn();
                checkDGV();
            }
            else if (rdoGanHet.Checked)
            {
                if (txtSoLuong.Text == "")
                    MessageBox.Show("Nhập số lượng !","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                {
                    int sl = Convert.ToInt32(txtSoLuong.Text);
                    dgvDSSPTonKho.DataSource = honLoan.ThongKeSachGanHet(sl);
                    NameColumn();
                    checkDGV();
                } 
            }
            else
            {
                dgvDSSPTonKho.DataSource = honLoan.ThongKeTonKhoSachDaHet();
                NameColumn();
                checkDGV();
            }    
        }

        private void rdoTatCa_CheckedChanged(object sender, EventArgs e)
        {
            lblSL.Enabled = false;
            txtSoLuong.Enabled = false;
        }

        private void rdoGanHet_CheckedChanged(object sender, EventArgs e)
        {
            lblSL.Enabled = true;
            txtSoLuong.Enabled = true;
        }

        private void rdoDaHet_CheckedChanged(object sender, EventArgs e)
        {
            lblSL.Enabled = false;
            txtSoLuong.Enabled = false;
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

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmThongKeTonKho_FormClosing(object sender, FormClosingEventArgs e)
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
