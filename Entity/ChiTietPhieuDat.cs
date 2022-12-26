using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class ChiTietPhieuDat
    {
        public ChiTietPhieuDat()
        {
        }
        public ChiTietPhieuDat(int soLuong, float giaBan, string maPhieuDat, string maSach)
        {
            this.SoLuong = soLuong;
            this.GiaBan = giaBan;
            this.MaPhieuDat = maPhieuDat;
            this.MaSach = maSach;
        }

        private int soLuong;
        private float giaBan;
        private string maPhieuDat;
        private string maSach;

        public int SoLuong
        {
            get => soLuong;
            set => soLuong = value;
        }
        public float GiaBan
        {
            get => giaBan;
            set => giaBan = value;
        }
        public string MaPhieuDat
        {
            get => maPhieuDat;
            set => maPhieuDat = value;
        }
        public string MaSach
        {
            get => maSach;
            set => maSach = value;
        }
    }
}
