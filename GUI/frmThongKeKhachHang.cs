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
    public partial class frmThongKeKhachHang : Form
    {
        public frmThongKeKhachHang()
        {
            InitializeComponent();
            
        }
        clsHonLoan honLoan;
        private void frmThongKeKhachHang_Load(object sender, EventArgs e)
        {
            honLoan = new clsHonLoan();
            WindowState = FormWindowState.Maximized;
            setTime();
            ennableRdo();
            rdoNam.Checked = true;
            rdoTopDT.Checked = true;
        }
        private void checkDGV()
        {
            if (dgvDSKH.Rows.Count > 0)
            {
                dgvDSKH.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDSKH.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDSKH.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }
        void NameColumnDT()
        {
            dgvDSKH.Columns[0].HeaderText = "Mã khách hàng";
            dgvDSKH.Columns[0].Width = 180;
            dgvDSKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvDSKH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSKH.Columns[2].HeaderText = "Doanh thu mang lại (VNĐ)";
            dgvDSKH.Columns[2].DefaultCellStyle.Format = "N0";
            dgvDSKH.Columns[2].Width = 550;
        }
        void NameColumnHD()
        {
            dgvDSKH.Columns[0].HeaderText = "Mã khách hàng";
            dgvDSKH.Columns[0].Width = 180;
            dgvDSKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvDSKH.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSKH.Columns[2].HeaderText = "Số lần lập hóa đơn";
            dgvDSKH.Columns[2].Width = 550;
        }
        private void setTime()
        {
            dtmDenNgay.Value = DateTime.Now;
            dtmTuNgay.Value = GetYesterday();
            mtbNam.Text = DateTime.Now.Year.ToString();
            mtbThangNam.Text = DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            dtmOneDay.Value = DateTime.Now;
        }
        public static DateTime GetYesterday()
        {
            DateTime today = DateTime.Today;
            return today.AddDays(-1);
        }
        private void ennableRdo()
        {
            lblNhapNam.Enabled = false;
            lblNhapNgay.Enabled = false;
            lblNhapThangNam.Enabled = false;
            lblTuNgay.Enabled = false;
            lblDenNgay.Enabled = false;
            mtbNam.Enabled = false;
            mtbThangNam.Enabled = false;
            dtmOneDay.Enabled = false;
            dtmDenNgay.Enabled = false;
            dtmTuNgay.Enabled = false;
        }
        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNam.Checked)
            {
                ennableRdo();
                lblNhapNam.Enabled = true;
                mtbNam.Enabled = true;
            }
            else ennableRdo();
        }

        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThang.Checked)
            {
                ennableRdo();
                lblNhapThangNam.Enabled = true;
                mtbThangNam.Enabled = true;
            }
            else ennableRdo();
        }

        private void rdoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNgay.Checked)
            {
                ennableRdo();
                lblNhapNgay.Enabled = true;
                dtmOneDay.Enabled = true;
            }
            else ennableRdo();
        }

        private void rdoTheoKhoangThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTheoKhoangThoiGian.Checked)
            {
                ennableRdo();
                lblTuNgay.Enabled = true;
                lblDenNgay.Enabled = true;
                dtmTuNgay.Enabled = true;
                dtmDenNgay.Enabled = true;
            }
            else ennableRdo();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (txtTop.Text == "")
            {
                MessageBox.Show("Nhập số lượng khách hàng muốn thống kê", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int top = Convert.ToInt32(txtTop.Text.Trim());
            if (top<=0)
            {
                MessageBox.Show("Nhập số lượng khách hàng > 0", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime ngayBatDau = Convert.ToDateTime("1/1/2020");
            if (rdoTheoKhoangThoiGian.Checked)
            {
                if (dtmTuNgay.Value < ngayBatDau || dtmDenNgay.Value < ngayBatDau || dtmDenNgay.Value > DateTime.Now || dtmTuNgay.Value > DateTime.Now)
                    MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (dtmTuNgay.Value >= dtmDenNgay.Value)
                    MessageBox.Show("Thời gian không hợp lê !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (rdoTopDT.Checked)
                {
                        dgvDSKH.DataSource = honLoan.ThongKeKHTopDT(dtmTuNgay.Value, dtmDenNgay.Value,top);
                        NameColumnDT();
                    checkDGV();
                }
                else
                {
                    dgvDSKH.DataSource = honLoan.ThongKeKHTopHD(dtmTuNgay.Value, dtmDenNgay.Value,top);
                    NameColumnHD();
                    checkDGV();
                }
            }
            if (rdoNgay.Checked)
            {
                if (dtmOneDay.Value > DateTime.Now || dtmOneDay.Value < ngayBatDau)
                    MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (rdoTopDT.Checked)
                {
                        dgvDSKH.DataSource = honLoan.ThongKeKHTopDTMotNgay(dtmOneDay.Value,top);
                        NameColumnDT();
                    checkDGV();
                }
                else
                {
                    dgvDSKH.DataSource = honLoan.ThongKeKHTopHDMotNgay(dtmOneDay.Value,top);
                    NameColumnHD();
                    checkDGV();
                }
            }
            if (rdoThang.Checked)
            {
                if (mtbThangNam.Text.KiemTraThangNam() && mtbThangNam.Text.EndsWith("0000") == false)
                {
                    DateTime ngay = Convert.ToDateTime(mtbThangNam.Text);
                    if (ngay < ngayBatDau || ngay > DateTime.Now)
                        MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (rdoTopDT.Checked)
                    {
                            dgvDSKH.DataSource = honLoan.ThongKeKHTopDTMotThang(ngay,top);
                            NameColumnDT();
                        checkDGV();
                    }
                    else
                    {
                        dgvDSKH.DataSource = honLoan.ThongKeKHTopHDMotThang(ngay,top);
                        NameColumnHD();
                        checkDGV();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập đúng định dạng tháng năm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (rdoNam.Checked)
            {
                if (mtbNam.Text == "")
                    MessageBox.Show("Nhập năm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    int nam = Convert.ToInt32(mtbNam.Text);
                    if (nam > DateTime.Now.Year || nam < 2020)
                        MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (rdoTopDT.Checked)
                    {
                            dgvDSKH.DataSource = honLoan.ThongKeKHTopDTMotNam(nam,top);
                            NameColumnDT();
                        checkDGV();
                    }
                    else
                    {
                        dgvDSKH.DataSource = honLoan.ThongKeKHTopHDMotNam(nam,top);
                        NameColumnHD();
                        checkDGV();
                    }
                }
            }
        }

        private void txtTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 127 || e.KeyChar == 8) // cho phép nhấn số, delete và backspace
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmThongKeKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
