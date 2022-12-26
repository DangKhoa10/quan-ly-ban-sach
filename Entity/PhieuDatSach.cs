using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    public class PhieuDatSach
    {
        public PhieuDatSach()
        {
        }
        public PhieuDatSach(string maPhieuDat, string ngayDat, string tinhTrang, string maKH)
        {
            this.MaPhieuDat = maPhieuDat;
            this.NgayDat = ngayDat;
            this.TinhTrang = tinhTrang;
            this.MaKH = maKH;
        }

        private string maPhieuDat;
        private string ngayDat;
        private string tinhTrang;
        private string maKH;

        public string MaPhieuDat
        {
            get => maPhieuDat;
            set => maPhieuDat = value;
        }
        public string NgayDat
        {
            get => ngayDat;
            set => ngayDat = value;
        }
        public string TinhTrang
        {
            get => tinhTrang;
            set => tinhTrang = value;
        }
        public string MaKH
        {
            get => maKH;
            set => maKH = value;
        }
    }
}
