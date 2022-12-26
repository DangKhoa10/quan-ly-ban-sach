using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class clsNhanVien
    {
        public clsNhanVien()
        {
        }
        public clsNhanVien(string maNV, string tenNV, string sdt, string diaChi, string chucVu)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.chucVu = chucVu;
        }

        private string maNV;
        private string tenNV;
        private string sdt;
        private string diaChi;
        private string chucVu;

        public string MaNV
        {
            get => maNV;
            set => maNV = value;
        }
        public string TenNV
        {
            get => tenNV;
            set => tenNV = value;
        }
        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }
        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }
        public string ChucVu
        {
            get => chucVu;
            set => chucVu = value;
        }
    }
}
