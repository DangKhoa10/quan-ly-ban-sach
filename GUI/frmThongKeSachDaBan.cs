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
    public partial class frmThongKeSachDaBan : Form
    {
        public frmThongKeSachDaBan()
        {
            InitializeComponent();
        }
        clsHonLoan honLoan;
        private void ThongKeSachDaBan_Load(object sender, EventArgs e)
        {
            honLoan = new clsHonLoan();
            WindowState = FormWindowState.Maximized;
            setTime();
            ennableRdo();
            rdoNam.Checked = true;
            cboSach.Items.Add("Sách bán chạy");
            cboSach.Items.Add("Sách bán chậm");
            cboSach.Items.Add("Sách không bán được");

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
        void NameColumn()
        {
            dgvDSSPDaBan.Columns[0].HeaderText = "Mã sách";
            dgvDSSPDaBan.Columns[0].Width = 180;
            dgvDSSPDaBan.Columns[1].HeaderText = "Tên sách";
            dgvDSSPDaBan.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSSPDaBan.Columns[2].HeaderText = "Số lượng sách đã bán";
            dgvDSSPDaBan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSSPDaBan.Columns[2].Width = 250;
        }
        
        private void checkDGV()
        {
            if (dgvDSSPDaBan.Rows.Count > 0)
            {
                dgvDSSPDaBan.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDSSPDaBan.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvDSSPDaBan.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
               
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (txtTop.Text == "")
            {
                MessageBox.Show("Nhập số lượng sách muốn thống kê", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int top = Convert.ToInt32(txtTop.Text.Trim());
            if (top <= 0)
            {
                MessageBox.Show("Nhập số lượng sách > 0", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime ngayBatDau = Convert.ToDateTime("1/1/2020");
            if (rdoTheoKhoangThoiGian.Checked)
            {
                if (dtmTuNgay.Value < ngayBatDau || dtmDenNgay.Value < ngayBatDau || dtmDenNgay.Value > DateTime.Now || dtmTuNgay.Value > DateTime.Now)
                    MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (dtmTuNgay.Value >= dtmDenNgay.Value)
                    MessageBox.Show("Thời gian không hợp lê !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (chkChonSach.Checked)
                {
                    if (cboSach.Text == "")
                        MessageBox.Show("Chưa chọn tiêu chí thống kê sách nhanh chậm !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        int tc = 0;
                        if (cboSach.SelectedItem.ToString() == "Sách bán chạy")
                            tc = 1;
                        if (cboSach.SelectedItem.ToString() == "Sách bán chậm")
                            tc = 2;
                        if (cboSach.SelectedItem.ToString() == "Sách không bán được")
                            tc = 3;
                        dgvDSSPDaBan.DataSource = honLoan.ThongKeSachDaBanTheoNgayVaTieuChi(dtmTuNgay.Value, dtmDenNgay.Value, tc, top);
                        NameColumn();
                        checkDGV();
                    }
                }
                else
                {
                    dgvDSSPDaBan.DataSource = honLoan.ThongKeSachDaBanTheoNgay(dtmTuNgay.Value, dtmDenNgay.Value);
                    NameColumn();
                    checkDGV();
                }
            }
            if (rdoNgay.Checked)
            {
                if (dtmOneDay.Value > DateTime.Now || dtmOneDay.Value < ngayBatDau)
                    MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (chkChonSach.Checked)
                {
                    if (cboSach.Text == "")
                        MessageBox.Show("Chưa chọn tiêu chí thống kê sách nhanh chậm !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        int tc = 0;
                        if (cboSach.SelectedItem.ToString() == "Sách bán chạy")
                            tc = 1;
                        if (cboSach.SelectedItem.ToString() == "Sách bán chậm")
                            tc = 2;
                        if (cboSach.SelectedItem.ToString() == "Sách không bán được")
                            tc = 3;
                        dgvDSSPDaBan.DataSource = honLoan.ThongKeSachDaBanTheoMotNgayVaTieuChi(dtmOneDay.Value, tc, top);
                        NameColumn();
                        checkDGV();
                    }
                }
                else
                {
                    dgvDSSPDaBan.DataSource = honLoan.ThongKeSachDaBanTheoMotNgay(dtmOneDay.Value);
                    NameColumn();
                    checkDGV();
                }
            }
            if (rdoThang.Checked)
            {
                if (mtbThangNam.Text.KiemTraThangNam() && mtbThangNam.Text.EndsWith("0000") == false)
                {
                    DateTime ngay = Convert.ToDateTime(mtbThangNam.Text);
                    if (ngay < ngayBatDau || ngay > DateTime.Now)
                        MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (chkChonSach.Checked)
                    {
                        if (cboSach.Text == "")
                            MessageBox.Show("Chưa chọn tiêu chí thống kê sách nhanh chậm !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            int tc = 0;
                            if (cboSach.SelectedItem.ToString() == "Sách bán chạy")
                                tc = 1;
                            if (cboSach.SelectedItem.ToString() == "Sách bán chậm")
                                tc = 2;
                            if (cboSach.SelectedItem.ToString() == "Sách không bán được")
                                tc = 3;
                            dgvDSSPDaBan.DataSource = honLoan.ThongKeSachDaBanTheoThangVaTieuChi(ngay, tc, top);
                            NameColumn();
                            checkDGV();
                        }
                    }
                    else
                    {
                        dgvDSSPDaBan.DataSource = honLoan.ThongKeSachDaBanTheoThang(ngay);
                        NameColumn();
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
                    else if (chkChonSach.Checked)
                    {
                        if (cboSach.Text == "")
                            MessageBox.Show("Chưa chọn tiêu chí thống kê sách nhanh chậm !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            int tc = 0;
                            if (cboSach.SelectedItem.ToString() == "Sách bán chạy")
                                tc = 1;
                            if (cboSach.SelectedItem.ToString() == "Sách bán chậm")
                                tc = 2;
                            if (cboSach.SelectedItem.ToString() == "Sách không bán được")
                                tc = 3;
                            dgvDSSPDaBan.DataSource = honLoan.ThongKeSachDaBanTheoMotNamVaTieuChi(nam, tc, top);
                            NameColumn();
                            checkDGV();
                        }
                    }
                    else
                    {
                        dgvDSSPDaBan.DataSource = honLoan.ThongKeSachDaBanTheoMotNam(nam);
                        NameColumn();
                        checkDGV();
                    }
                }
            }
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

        private void chkChonSach_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChonSach.Checked == true)
            {
                cboSach.Enabled = true;
                txtTop.Enabled = true;
                lblTop.Enabled = true;
            }
            else
            {
                txtTop.Enabled = false;
                lblTop.Enabled = false;
                cboSach.Enabled = false;
                txtTop.Text = "5";
                cboSach.Text = "";
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

        private void cboSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSach.SelectedItem.ToString() == "Sách không bán được")
            {
                lblTop.Enabled = false;
                txtTop.Enabled = false;
            }
            else
            {
                lblTop.Enabled = true;
                txtTop.Enabled = true;
            }    
        }

        private void cboSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmThongKeSachDaBan_FormClosing(object sender, FormClosingEventArgs e)
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
