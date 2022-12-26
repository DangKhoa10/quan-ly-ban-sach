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
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }
        clsHonLoan honLoan;
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            honLoan = new clsHonLoan();
            WindowState = FormWindowState.Maximized;
            setTime();
            ennableRdo();
            rdoNam.Checked = true;
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
        private void loadTenNV()
        {
            cboTenNhanVien.DataSource = new clsNhanVien().GetNVTKDT();
            cboTenNhanVien.DisplayMember = "TenNV";
            cboTenNhanVien.ValueMember = "MaNV";
            cboTenNhanVien.Text = "";
        }
        void NameColumn()
        {
            dgvDSHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvDSHoaDon.Columns[0].Width = 180;
            dgvDSHoaDon.Columns[1].HeaderText = "Ngày lập hóa đơn";
            dgvDSHoaDon.Columns[1].Width = 180;
            dgvDSHoaDon.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSHoaDon.Columns[2].HeaderText = "Nhân viên lập hóa đơn";
            dgvDSHoaDon.Columns[2].Width = 250;
            dgvDSHoaDon.Columns[3].HeaderText = "Tổng giá trị hóa đơn (VNĐ)";
            dgvDSHoaDon.Columns[3].DefaultCellStyle.Format = "N0";
            dgvDSHoaDon.Columns[3].Width = 550;
        }
        private void tinhTongTien(List<dynamic> listHD)
        {
            double tt = 0;
            if (listHD.Count==0)
            {
                tt = 0;
                lblTongTien.Text = "0 VNĐ";
            }
            else
            {
                tt = listHD.Sum(x => (double)x.TongTien);
                lblTongTien.Text = string.Format("{0:#,###}", tt) + " VNĐ";
            }
            lblThanhChu.Text = NumberToText(tt);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = Convert.ToDateTime("1/1/2020");
            if (rdoTheoKhoangThoiGian.Checked)
            {
                if( dtmTuNgay.Value < ngayBatDau || dtmDenNgay.Value < ngayBatDau || dtmDenNgay.Value > DateTime.Now || dtmTuNgay.Value > DateTime.Now)
                    MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (dtmTuNgay.Value >= dtmDenNgay.Value)
                    MessageBox.Show("Thời gian không hợp lê !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (chkNhanVien.Checked)
                {
                    if (cboTenNhanVien.Text == "")
                        MessageBox.Show("Chưa chọn nhân viên !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        dgvDSHoaDon.DataSource = honLoan.ThongKeDoanhThuTheoNhanVien(dtmTuNgay.Value, dtmDenNgay.Value, cboTenNhanVien.SelectedValue.ToString());
                        NameColumn();
                        tinhTongTien(honLoan.ThongKeDoanhThuTheoNhanVien(dtmTuNgay.Value, dtmDenNgay.Value, cboTenNhanVien.SelectedValue.ToString()).ToList());
                    }
                }
                else
                {
                    dgvDSHoaDon.DataSource = honLoan.ThongKeDoanhThu(dtmTuNgay.Value, dtmDenNgay.Value);
                    NameColumn();
                    tinhTongTien(honLoan.ThongKeDoanhThu(dtmTuNgay.Value, dtmDenNgay.Value).ToList());
                }
            }
            if (rdoNgay.Checked)
            {
                if (dtmOneDay.Value > DateTime.Now || dtmOneDay.Value < ngayBatDau)
                    MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (chkNhanVien.Checked)
                {
                    if (cboTenNhanVien.Text == "")
                        MessageBox.Show("Chưa chọn nhân viên !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        dgvDSHoaDon.DataSource = honLoan.ThongKeDoanhThuTheoNhanVienMotNgay(dtmOneDay.Value, cboTenNhanVien.SelectedValue.ToString());
                        NameColumn();
                        tinhTongTien(honLoan.ThongKeDoanhThuTheoNhanVienMotNgay(dtmOneDay.Value, cboTenNhanVien.SelectedValue.ToString()).ToList());
                    }
                }
                else
                {
                    dgvDSHoaDon.DataSource = honLoan.ThongKeDoanhThuMotNgay(dtmOneDay.Value);
                    NameColumn();
                    tinhTongTien(honLoan.ThongKeDoanhThuMotNgay(dtmOneDay.Value).ToList());
                }
            }
            if (rdoThang.Checked)
            {
                if (mtbThangNam.Text.KiemTraThangNam() &&  mtbThangNam.Text.EndsWith("0000")==false)
                {
                    DateTime ngay = Convert.ToDateTime(mtbThangNam.Text);
                    if (ngay < ngayBatDau || ngay > DateTime.Now)
                        MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (chkNhanVien.Checked)
                    {
                        if (cboTenNhanVien.Text == "")
                            MessageBox.Show("Chưa chọn nhân viên !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            dgvDSHoaDon.DataSource = honLoan.ThongKeDoanhThuTheoNhanVienThang(ngay, cboTenNhanVien.SelectedValue.ToString());
                            NameColumn();
                            tinhTongTien(honLoan.ThongKeDoanhThuTheoNhanVienThang(ngay, cboTenNhanVien.SelectedValue.ToString()).ToList());
                        }
                    }
                    else
                    {
                        dgvDSHoaDon.DataSource = honLoan.ThongKeDoanhThuMotThang(ngay);
                        NameColumn();
                        tinhTongTien(honLoan.ThongKeDoanhThuMotThang(ngay).ToList());
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
                        MessageBox.Show("Thống kê chỉ tính từ năm 2020 đến hiện tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (chkNhanVien.Checked)
                    {
                        if (cboTenNhanVien.Text == "")
                            MessageBox.Show("Chưa chọn nhân viên !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            dgvDSHoaDon.DataSource = honLoan.ThongKeDoanhThuTheoNhanVienNam(nam, cboTenNhanVien.SelectedValue.ToString());
                            NameColumn();
                            tinhTongTien(honLoan.ThongKeDoanhThuTheoNhanVienNam(nam, cboTenNhanVien.SelectedValue.ToString()).ToList());
                        }
                    }
                    else
                    {
                        dgvDSHoaDon.DataSource = honLoan.ThongKeDoanhThuMotNam(nam);
                        NameColumn();
                        tinhTongTien(honLoan.ThongKeDoanhThuMotNam(nam).ToList());
                    }
                }
            }
        }

     
        public static string NumberToText(double inputNumber, bool suffix = true)
        {
            if (inputNumber == 0)
                return "không đồng";
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng chẵn" : "");
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

        private void chkNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhanVien.Checked == true)
            {
                lblChonNV.Enabled = true;
                cboTenNhanVien.Enabled = true;
                loadTenNV();
            }
            else
            {
                lblChonNV.Enabled = false;
                cboTenNhanVien.Enabled = false;
                cboTenNhanVien.Text = "";
            }
        }

        private void cboTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmThongKeDoanhThu_FormClosing(object sender, FormClosingEventArgs e)
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
