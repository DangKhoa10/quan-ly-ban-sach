using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class HoaDon
    {
        public HoaDon()
        {
        }
        public HoaDon(string maHD, string ngayLapHD, string maNV, string maKH)
        {
            this.maHD = maHD;
            this.NgayLapHD = ngayLapHD;
            this.MaNV = maNV;
            this.MaKH = maKH;
        }

        private string maHD;
        private string ngayLapHD;
        private string maNV;
        private string maKH;
        public string MaHD
        {
            get => maHD;
            set => maHD = value;
        }
        public string NgayLapHD
        {
            get => ngayLapHD;
            set => ngayLapHD = value;
        }
        public string MaNV
        {
            get => maNV;
            set => maNV = value;
        }
        public string MaKH
        {
            get => maKH;
            set => maKH = value;
        }
    }
}
