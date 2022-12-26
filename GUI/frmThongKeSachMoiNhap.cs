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
    public partial class frmThongKeSachMoiNhap : Form
    {
        public frmThongKeSachMoiNhap()
        {
            InitializeComponent();
        }
        clsHonLoan honLoan;
        clsNhaCungCap nhaCungCap;
        private void frmThongKeSachMoiNhap_Load(object sender, EventArgs e)
        {
            honLoan = new clsHonLoan();
            nhaCungCap = new clsNhaCungCap();
            WindowState = FormWindowState.Maximized;
            setTime();
            ennableRdo();
            rdoNam.Checked = true;
        }
        void NameColumn()
        {
            dgvDSSPMoiNhap.Columns[0].HeaderText = "Mã sách";
            dgvDSSPMoiNhap.Columns[0].Width = 180;
            dgvDSSPMoiNhap.Columns[1].HeaderText = "Tên sách";
            dgvDSSPMoiNhap.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDSSPMoiNhap.Columns[2].HeaderText = "Số lượng sách nhập";
            dgvDSSPMoiNhap.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSSPMoiNhap.Columns[2].Width = 250;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        private void loadTenNCC()
        {
            cboTenNCC.DataSource = new clsNhaCungCap().GetAllNhaCungCap();
            cboTenNCC.ValueMember = "MaNCC";
            cboTenNCC.DisplayMember = "TenNCC";
            cboTenNCC.Text = "";
        }
       

        private void cboTenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void chkNhaCungCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhaCungCap.Checked == true)
            {
                lblChonNCC.Enabled = true;
                cboTenNCC.Enabled = true;
                loadTenNCC();
            }
            else
            {
                lblChonNCC.Enabled = false;
                cboTenNCC.Enabled = false;
                cboTenNCC.Text = "";
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = Convert.ToDateTime("1/1/2020");
            if (rdoTheoKhoangThoiGian.Checked)
            {
                if (dtmTuNgay.Value < ngayBatDau || dtmDenNgay.Value < ngayBatDau || dtmDenNgay.Value > DateTime.Now || dtmTuNgay.Value > DateTime.Now)
                    MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (dtmTuNgay.Value >= dtmDenNgay.Value)
                    MessageBox.Show("Thời gian không hợp lê !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (chkNhaCungCap.Checked)
                {
                    if (cboTenNCC.Text == "")
                        MessageBox.Show("Chưa chọn nhà cung cấp !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        string maNCC = cboTenNCC.SelectedValue.ToString();
                        dgvDSSPMoiNhap.DataSource = honLoan.ThongKeSachNhapTheoNCC(dtmTuNgay.Value, dtmDenNgay.Value, maNCC);
                        NameColumn();
                    }
                }
                else
                {
                    dgvDSSPMoiNhap.DataSource = honLoan.ThongKeSachNhap(dtmTuNgay.Value, dtmDenNgay.Value);
                    NameColumn();
                }
            }
            if (rdoNgay.Checked)
            {
                if (dtmOneDay.Value > DateTime.Now || dtmOneDay.Value < ngayBatDau)
                    MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (chkNhaCungCap.Checked)
                {
                    if (cboTenNCC.Text == "")
                        MessageBox.Show("Chưa chọn nhà cung cấp !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        string maNCC = cboTenNCC.SelectedValue.ToString();
                        dgvDSSPMoiNhap.DataSource = honLoan.ThongKeSachNhapMotNgayTheoNCC(dtmOneDay.Value, maNCC);
                        NameColumn();
                    }
                }
                else
                {
                    dgvDSSPMoiNhap.DataSource = honLoan.ThongKeSachNhapMotNgay(dtmOneDay.Value);
                    NameColumn();
                }
            }
            if (rdoThang.Checked)
            {
                if (mtbThangNam.Text.KiemTraThangNam() && mtbThangNam.Text.EndsWith("0000") == false)
                {
                    DateTime ngay = Convert.ToDateTime(mtbThangNam.Text);
                    if (ngay < ngayBatDau || ngay > DateTime.Now)
                        MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (chkNhaCungCap.Checked)
                    {
                        if (cboTenNCC.Text == "")
                            MessageBox.Show("Chưa chọn nhà cung cấp !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            string maNCC = cboTenNCC.SelectedValue.ToString();
                            dgvDSSPMoiNhap.DataSource = honLoan.ThongKeSachNhapMotThangTheoNCC(ngay, maNCC);
                            NameColumn();
                        }
                    }
                    else
                    {
                        dgvDSSPMoiNhap.DataSource = honLoan.ThongKeSachNhapMotThang(ngay);
                        NameColumn();
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
                    else if (chkNhaCungCap.Checked)
                    {
                        if (cboTenNCC.Text == "")
                            MessageBox.Show("Chưa chọn nhà cung cấp !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            string maNCC = cboTenNCC.SelectedValue.ToString();
                            dgvDSSPMoiNhap.DataSource = honLoan.ThongKeSachNhapMotNamTheoNCC(nam, maNCC);
                            NameColumn();
                        }
                    }
                    else
                    {
                        dgvDSSPMoiNhap.DataSource = honLoan.ThongKeSachNhapMotNam(nam);
                        NameColumn();
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

        private void cboTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmThongKeSachMoiNhap_FormClosing(object sender, FormClosingEventArgs e)
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
