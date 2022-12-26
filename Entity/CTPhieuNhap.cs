using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class CTPhieuNhap
    {
        public CTPhieuNhap()
        {
        }
        public CTPhieuNhap(int soLuong, float giaNhap, string maSach, string maPhieuNhap)
        {
            this.SoLuong = soLuong;
            this.GiaNhap = giaNhap;
            this.MaSach = maSach;
            this.MaPhieuNhap = maPhieuNhap;
        }

        private int soLuong;
        private float giaNhap;
        private string maSach;
        private string maPhieuNhap;

        public int SoLuong
        {
            get => soLuong;
            set => soLuong = value;
        }
        public float GiaNhap
        {
            get => giaNhap;
            set => giaNhap = value;
        }
        public string MaSach
        {
            get => maSach;
            set => maSach = value;
        }
        public string MaPhieuNhap
        {
            get => maPhieuNhap;
            set => maPhieuNhap = value;
        }

    }
}
