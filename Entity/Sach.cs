using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class clsSach
    {
        public clsSach()
        {
        }
        public clsSach(string maSach, string tenSach, float donGiaNhap, float donGiaBan, int soLuongTon,
            int soTrang, string maTG, string maLoai, string maNhaCC)
        {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.DonGiaNhap = donGiaNhap;
            this.DonGiaBan = donGiaBan;
            this.SoLuongTon = soLuongTon;
            this.SoTrang = soTrang;
            this.MaTG = maTG;
            this.MaLoai = maLoai;
            this.MaNhaCC = maNhaCC;
        }

        private string maSach, tenSach, maNhaCC, maLoai, maTG;
        private float donGiaNhap, donGiaBan;
        private int soLuongTon, soTrang;

        public string MaSach
        {
            get => maSach;
            set => maSach = value;
        }
        public string TenSach
        {
            get => tenSach;
            set => tenSach = value;
        }
        public float DonGiaNhap
        {
            get => donGiaNhap;
            set => donGiaNhap = value;
        }
        public float DonGiaBan
        {
            get => donGiaBan;
            set => donGiaBan = value;
        }
        public int SoLuongTon
        {
            get => soLuongTon;
            set => soLuongTon = value;
        }
        public int SoTrang
        {
            get => soTrang;
            set => soTrang = value;
        }
        public string MaTG
        {
            get => maTG;
            set => maTG = value;
        }
        public string MaLoai
        {
            get => maLoai;
            set => maLoai = value;
        }
        public string MaNhaCC
        {
            get => maNhaCC;
            set => maNhaCC = value;
        }

    }
}
