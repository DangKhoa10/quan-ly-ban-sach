using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class KhachHang
    {
        public KhachHang()
        {
        }
        public KhachHang(string maKH, string tenKH, string sdt, string diaChi)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.sdt = sdt;
            this.diaChi = diaChi;
        }

        private string maKH;
        private string tenKH;
        private string sdt;
        private string diaChi;

        public string MaKH
        {
            get => maKH;
            set => maKH = value;
        }
        public string TenKH
        {
            get => tenKH;
            set => tenKH = value;
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

    }
}
