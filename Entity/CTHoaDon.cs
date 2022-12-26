using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class CTHoaDon
    {
        public CTHoaDon()
        {

        }
        public CTHoaDon(int soLuong, float giaBan, string maSach, string maHoaDon)
        {
            this.SoLuong = soLuong;
            this.GiaBan = giaBan;
            this.MaSach = maSach;
            this.MaHoaDon = maHoaDon;
        }
        private int soLuong;
        private float giaBan;
        private string maSach, maHoaDon;

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
        public string MaSach 
        { 
            get => maSach; 
            set => maSach = value;
        }
        public string MaHoaDon 
        { 
            get => maHoaDon; 
            set => maHoaDon = value;
        }
    }
}
