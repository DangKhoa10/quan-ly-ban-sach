using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class PhieuNhapSach
    {
        public PhieuNhapSach()
        {
        }
        public PhieuNhapSach(string maPhieuNhap, string ngayNhap, string maNV, string maNhaCC)
        {
            this.MaPhieuNhap = maPhieuNhap;
            this.NgayNhap = ngayNhap;
            this.MaNV = maNV;
            this.MaNhaCC = maNhaCC;
        }
        private string maPhieuNhap;
        private string ngayNhap;
        private string maNV;
        private string maNhaCC;

        public string MaPhieuNhap
        {
            get => maPhieuNhap;
            set => maPhieuNhap = value;
        }
        public string NgayNhap
        {
            get => ngayNhap;
            set => ngayNhap = value;
        }
        public string MaNV
        {
            get => maNV;
            set => maNV = value;
        }
        public string MaNhaCC
        {
            get => maNhaCC;
            set => maNhaCC = value;
        }
    }
}
