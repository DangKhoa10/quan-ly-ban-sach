using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsHonLoan : clsKetNoi
    {
        QLMuaBanSachDataContext dt;
        public clsHonLoan()
        {
            dt = getDataContext();
        }

        public IEnumerable<dynamic> GetThongTinSachQLSach()
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaNhap, n.DonGiaBan, SoLuong = n.SoLuongTon, x.TenTG, k.TenLoai, n.SoTrang, m.TenNXB };
            return q;

        }
        //Lập phiếu nhập
        public IEnumerable<dynamic> GetThongTinSachQLSachTheoMa(string ma)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    where n.MaSach.Equals(ma)
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach,n.DonGiaBan,n.SoLuongTon, x.TenTG, n.SoTrang, k.TenLoai };
            return q;

        }
        public IEnumerable<dynamic> GetTimKiemTheoNXB(string nxb)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    where m.TenNXB.Contains(nxb)
                    select new { n.MaSach, n.TenSach, n.DonGiaNhap, n.DonGiaBan, n.SoLuongTon, x.TenTG, k.TenLoai, n.SoTrang, m.TenNXB };
            return q;

        }

        public IEnumerable<dynamic> GetTimKiemSachTheoTG(string tg)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    where x.TenTG.Contains(tg)
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaNhap, n.DonGiaBan, n.SoLuongTon, x.TenTG, k.TenLoai, n.SoTrang, m.TenNXB };
            return q;

        }
        public IEnumerable<dynamic> GetLocSachTheoTGDatSach(string ma)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    where x.MaTG.Equals(ma)
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaBan, n.SoLuongTon, x.TenTG, n.SoTrang, m.TenNXB, k.TenLoai };
            return q;

        }
        public IEnumerable<dynamic> GetTimKiemSachTheoLoaiSach(string ls)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    where k.TenLoai.Contains(ls)
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaNhap, n.DonGiaBan, n.SoLuongTon, x.TenTG, k.TenLoai, n.SoTrang, m.TenNXB };
            return q;

        }
        public IEnumerable<dynamic> GetLocSachTheoLoaiSachDatSach(string ma)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    where k.MaLoai.Equals(ma)
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaBan, n.SoLuongTon, x.TenTG, n.SoTrang, m.TenNXB, k.TenLoai };
            return q;

        }
        public IEnumerable<dynamic> GetLocSachTheoNXBDatSach(string ma)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    where n.NhaXuatBan.MaNXB.Equals(ma)
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaBan, n.SoLuongTon, x.TenTG, n.SoTrang, m.TenNXB, k.TenLoai };
            return q;

        }
        public IEnumerable<dynamic> GetTimKiemSach(string ms, string ten,string tg, string tl,string nxb)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    where n.MaSach.Contains(ms) && n.TenSach.Contains(ten) && x.TenTG.Contains(tg) && k.TenLoai.Contains(tl) && m.TenNXB.Contains(nxb)
                    select new { n.MaSach, n.TenSach, n.DonGiaNhap, n.DonGiaBan, n.SoLuongTon, x.TenTG, k.TenLoai, n.SoTrang, m.TenNXB };
            return q;

        }
        public IEnumerable<dynamic> GetThongTinSachQLSachTheoMaSach(string ms)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    where n.MaSach.Contains(ms)
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaBan, SoLuong = n.SoLuongTon, x.TenTG , n.SoTrang, m.TenNXB , k.TenLoai };
            return q;

        }
        public IEnumerable<dynamic> GetThongTinSachQLSachTheoTenSach(string ts)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    where n.TenSach.Contains(ts)
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaBan, SoLuong = n.SoLuongTon, x.TenTG, n.SoTrang, m.TenNXB, k.TenLoai };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinHoaDon()
        {

            var q = from n in dt.HoaDons
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.KhachHangs
                    on n.MaKH equals k.MaKH
                    select new { n.MaHD, n.NgayLapHD, x.TenNV, k.TenKH };
            return q;

        }
        public IEnumerable<dynamic> GetTKHoaDon(string mahd, string makh, string manv, string tennv, string tenkh)
        {

            var q = from n in dt.HoaDons
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.KhachHangs
                    on n.MaKH equals k.MaKH
                    where n.MaHD.Contains(mahd) && k.MaKH.Contains(makh) && k.TenKH.Contains(tenkh) && x.MaNV.Contains(manv) && x.TenNV.Contains(tennv)
                    select new { n.MaHD, n.NgayLapHD, x.TenNV, k.TenKH };
            return q;

        }
        public IEnumerable<dynamic> GetTKHDTheoNgay(DateTime date)
        {

            var q = from n in dt.HoaDons
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    where n.NgayLapHD == date
                    join k in dt.KhachHangs
                    on n.MaKH equals k.MaKH
                    select new { n.MaHD, n.NgayLapHD, x.TenNV, k.TenKH };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinHoaDonAutocomlet()
        {

            var q = from n in dt.HoaDons
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.KhachHangs
                    on n.MaKH equals k.MaKH
                    select new { n.MaHD, x.TenNV, k.TenKH, x.MaNV, k.MaKH };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinPhieuDatSach()
        {

            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    select new { n.MaPhieuDat, n.NgayDat, n.TinhTrang, x.TenKH, x.SDT };

            return q;
        }
        public IEnumerable<dynamic> GetThongTinPhieuDatSachNV()
        {

            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    where n.TinhTrang == 0
                    select new { n.MaPhieuDat, x.TenKH, x.MaKH, x.SDT, n.NgayDat, n.TinhTrang };

            return q;
        }
        public IEnumerable<dynamic> GetTKThongTinPhieuDatAutocomlet()
        {

            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    select new { n.MaPhieuDat, x.TenKH, x.SDT, x.MaKH };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinPhieuDatSachTheoMaPD(string ma)
        {

            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    where n.MaPhieuDat.Contains(ma)
                    select new { n.MaPhieuDat, n.NgayDat, n.TinhTrang, x.TenKH, x.SDT };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinPhieuDatSachTheoMaKH(string ma)
        {

            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    where x.MaKH.Contains(ma)
                    select new { n.MaPhieuDat, n.NgayDat, n.TinhTrang, x.TenKH, x.SDT };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinPhieuDatSachTheoTenKH(string ten)
        {

            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    where x.TenKH.Contains(ten)
                    select new { n.MaPhieuDat, n.NgayDat, n.TinhTrang, x.TenKH, x.SDT };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinPhieuDatSachTheoNgay(DateTime date)
        {

            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    where n.NgayDat == date
                    select new { n.MaPhieuDat, n.NgayDat, n.TinhTrang, x.TenKH, x.SDT };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinPhieuDatSachTheoTinhTrang(int tt)
        {

            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    where n.TinhTrang == tt
                    select new { n.MaPhieuDat, n.NgayDat, n.TinhTrang, x.TenKH, x.SDT };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinPhieuDatSachTheoSDTKH(string sdt)
        {

            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    where x.SDT.Contains(sdt)
                    select new { n.MaPhieuDat, n.NgayDat, n.TinhTrang, x.TenKH, x.SDT };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinPhieuNhapSach()
        {

            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    select new { n.MaPhieuNhap, n.NgayNhap, x.TenNV, k.TenNCC };
            return q;

        }
        public IEnumerable<dynamic> GetTKThongTinPhieuNhapAutocomlet()
        {

            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    select new { n.MaPhieuNhap, x.TenNV, k.TenNCC, x.MaNV, k.MaNCC };
            return q;

        }
        public IEnumerable<dynamic> GetTKPNTheoMaPN(string ma)
        {

            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    where n.MaPhieuNhap.Contains(ma)
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    select new { n.MaPhieuNhap, n.NgayNhap, x.TenNV, k.TenNCC };
            return q;

        }
        string LayTinhTrangPhieuDat(string tinhTrang)
        {
            if (tinhTrang == "0")
                return "Chưa xử lý";
            else
                return "Đã xử lý";
        }
        public IEnumerable<dynamic> GetHDTheoNgay1(DateTime date)
        {

            var q = from n in dt.HoaDons
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    where n.NgayLapHD == date
                    join k in dt.KhachHangs
                    on n.MaKH equals k.MaKH
                    select new { n.MaHD, n.NgayLapHD, x.TenNV, x.MaNV, k.TenKH, k.MaKH };
            return q;
        }
        public IEnumerable<dynamic> GetChiTietPhieuNhapSachTheoMaPhieuNhap(string maPhieuNhap)
        {
            var q = from n in dt.PhieuNhapSaches
                    join m in dt.CTPhieuNhaps
                    on n.MaPhieuNhap equals m.MaPhieuNhap
                    where m.MaPhieuNhap == maPhieuNhap
                    select new { m.SoLuong, m.GiaNhap, m.MaSach };
            return q;
        }
        public IEnumerable<dynamic> GetPhieuNhapSachTheoMaNhanVien(string maNhanVien)
        {
            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    where x.MaNV == maNhanVien
                    select new { n.MaPhieuNhap, n.NgayNhap, x.TenNV, x.MaNV, k.TenNCC, k.MaNCC };
            return q;
        }
        public IEnumerable<dynamic> GetPhieuNhapSachTheoMaNhaCungCap(string maNhaCC)
        {
            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    where n.MaNCC == maNhaCC
                    select new { n.MaPhieuNhap, n.NgayNhap, x.TenNV, x.MaNV, k.TenNCC, k.MaNCC };
            return q;
        }
        public IEnumerable<dynamic> GetToanBoPhieuNhapSach()
        {
            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    select new { n.MaPhieuNhap, n.NgayNhap, x.TenNV, x.MaNV, k.TenNCC, k.MaNCC };
            return q;
        }
        public IEnumerable<dynamic> GetThongTinPhieuDatTheoNgay(DateTime date)
        {
            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    where n.NgayDat == date
                    select new { n.MaPhieuDat, n.NgayDat, TinhTang = LayTinhTrangPhieuDat(n.TinhTrang.ToString()), x.MaKH, x.TenKH, x.SDT };
            return q;
            //var q = from n in dt.HoaDons
            //        join x in dt.NhanViens
            //        on n.MaNV equals x.MaNV
            //        where n.NgayLapHD == date
            //        join k in dt.KhachHangs
            //        on n.MaKH equals k.MaKH
            //        select new { n.MaHD, n.NgayLapHD, x.TenNV, x.MaNV, k.TenKH, k.MaKH };
            //return q;
        }
        string LayTinhTrangSangSo(string tinhTrang)
        {
            if (tinhTrang == "Đã xử lý")
                return "1";
            else return "0";
        }
        public IEnumerable<dynamic> GetChiTietPhieuDatTheoMaPhieuDat(string ma)
        {
            var q = from n in dt.PhieuDatSaches
                    join x in dt.CTPhieuDats
                    on n.MaPhieuDat equals x.MaPhieuDat
                    join m in dt.Saches
                    on x.MaSach equals m.MaSach
                    where x.MaPhieuDat.Contains(ma)
                    select new { m.MaSach, m.TenSach, x.SoLuong, m.DonGiaBan };
            return q;

        }
        public IEnumerable<dynamic> GetThongTinPhieuDatTheoTinhTrang(string tinhTrang)
        {
            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    where n.TinhTrang.ToString() == LayTinhTrangSangSo(tinhTrang)
                    select new { n.MaPhieuDat, n.NgayDat, TinhTang = LayTinhTrangPhieuDat(n.TinhTrang.ToString()), x.MaKH, x.TenKH, x.SDT };
            return q;
        }
        public IEnumerable<dynamic> GetAllThongTinPhieuDatSach()
        {
            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    select new { n.MaPhieuDat, n.NgayDat, TinhTang = LayTinhTrangPhieuDat(n.TinhTrang.ToString()), x.MaKH, x.TenKH, x.SDT };
            return q;
        }
         public IEnumerable<dynamic> GetPDTimKiem(string maKH, string tenKH, string sdt, string maPD,int tt)
        {
            
            if(tt == 2)
            {
                var q = from n in dt.PhieuDatSaches
                        join x in dt.KhachHangs
                        on n.MaKH equals x.MaKH
                        where n.MaKH.Contains(maKH) && x.TenKH.Contains(tenKH) && x.SDT.Contains(sdt) && n.MaPhieuDat.Contains(maPD)
                        select new { n.MaPhieuDat, n.NgayDat, TinhTrang = LayTinhTrangPhieuDat(n.TinhTrang.ToString()), x.MaKH, x.TenKH, x.SDT };
                return q;
            }
            else { 
                var q = from n in dt.PhieuDatSaches
                        join x in dt.KhachHangs
                        on n.MaKH equals x.MaKH
                        where n.MaKH.Contains(maKH) && x.TenKH.Contains(tenKH) && x.SDT.Contains(sdt) && n.MaPhieuDat.Contains(maPD) && n.TinhTrang == tt
                        select new { n.MaPhieuDat, n.NgayDat, TinhTrang = LayTinhTrangPhieuDat(n.TinhTrang.ToString()), x.MaKH, x.TenKH, x.SDT };
                return q;
            }
            

        }
        public IEnumerable<dynamic> GetThongTinHoaDon1()
        {

            var q = from n in dt.HoaDons
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.KhachHangs
                    on n.MaKH equals k.MaKH
                    select new { n.MaHD, n.NgayLapHD, x.TenNV, x.MaNV, k.TenKH, k.MaKH };
            return q;
        }
        public IEnumerable<dynamic> GetTKPNTheoMaNV(string ma)
        {

            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    where x.MaNV.Contains(ma)
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    select new { n.MaPhieuNhap, n.NgayNhap, x.TenNV, k.TenNCC };
            return q;

        }
        public IEnumerable<dynamic> GetTKPNTheoMaNCC(string ma)
        {

            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    where k.MaNCC.Contains(ma)
                    select new { n.MaPhieuNhap, n.NgayNhap, x.TenNV, k.TenNCC };
            return q;

        }
        public IEnumerable<dynamic> GetTKPNTheoTenNCC(string ten)
        {

            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    where k.TenNCC.Contains(ten)
                    select new { n.MaPhieuNhap, n.NgayNhap, x.TenNV, k.TenNCC };
            return q;

        }
        public IEnumerable<dynamic> GetTKPNTheoNgay(DateTime date)
        {
            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    where n.NgayNhap == date
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    select new { n.MaPhieuNhap, n.NgayNhap, x.TenNV, k.TenNCC };
            return q;
        }
        public IEnumerable<dynamic> GetThongTinPhieuDatTheoNgay1(DateTime date)
        {
            var q = from n in dt.PhieuDatSaches
                    join x in dt.KhachHangs
                    on n.MaKH equals x.MaKH
                    where n.NgayDat == date
                    select new { n.MaPhieuDat, n.NgayDat, TinhTang = LayTinhTrangPhieuDat(n.TinhTrang.ToString()), x.MaKH, x.TenKH, x.SDT, x.DiaChi };
            return q;
        }
        public IEnumerable<dynamic> GetTKPNTheoTenNV(string ten)
        {

            var q = from n in dt.PhieuNhapSaches
                    join x in dt.NhanViens
                    on n.MaNV equals x.MaNV
                    where x.TenNV.Contains(ten)
                    join k in dt.NhaCungCaps
                    on n.MaNCC equals k.MaNCC
                    select new { n.MaPhieuNhap, n.NgayNhap, x.TenNV, k.TenNCC };
            return q;
        }
        public IEnumerable<dynamic> GetThongTinSach()
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join b in dt.NhaXuatBans
                    on n.MaNXB equals b.MaNXB
                    select new { n.MaSach, n.TenSach, GiaBan = n.DonGiaBan, SoLuong = n.SoLuongTon, TenTacGia = x.TenTG, n.SoTrang, b.TenNXB, k.TenLoai };
            return q;
        }

        //Lập phiếu nhập
        public IEnumerable<dynamic> GetThongTinSachNhap()
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join b in dt.NhaXuatBans
                    on n.MaNXB equals b.MaNXB
                    select new { n.MaSach, n.TenSach,n.DonGiaNhap, n.DonGiaBan, n.SoLuongTon, n.SoTrang, k.TenLoai , x.TenTG,  b.TenNXB };
            return q;
        }
        public IEnumerable<dynamic> GetLocTGSachNhap(string ma)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    where x.MaTG.Equals(ma)
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaNhap, n.DonGiaBan, n.SoLuongTon, n.SoTrang, k.TenLoai, x.TenTG, m.TenNXB };
            return q;

        }
        public IEnumerable<dynamic> GetLocNXBSachNhap(string ma)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    where m.MaNXB.Equals(ma)
                    select new { n.MaSach, n.TenSach, n.DonGiaNhap, n.DonGiaBan, n.SoLuongTon, n.SoTrang, k.TenLoai, x.TenTG, m.TenNXB };
            return q;

        }
        public IEnumerable<dynamic> GetLocLSSachNhap(string ma)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    where k.MaLoai.Equals(ma)
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaNhap, n.DonGiaBan, n.SoLuongTon, n.SoTrang, k.TenLoai, x.TenTG, m.TenNXB };
            return q;

        }
        public IEnumerable<dynamic> GetTimKiemSachNhapTheoTenSach(string ts)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    where n.TenSach.Contains(ts)
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaNhap, n.DonGiaBan, n.SoLuongTon, n.SoTrang, k.TenLoai, x.TenTG, m.TenNXB };
            return q;

        }
        public IEnumerable<dynamic> GetTimKiemSachNhapTheoMaSach(string ma)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    where n.MaSach.Contains(ma)
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join m in dt.NhaXuatBans
                    on n.MaNXB equals m.MaNXB
                    select new { n.MaSach, n.TenSach, n.DonGiaNhap, n.DonGiaBan, n.SoLuongTon, n.SoTrang, k.TenLoai, x.TenTG, m.TenNXB };
            return q;

        }

        //Thống kê khách hàng
        public IEnumerable<dynamic> ThongKeKHTopDT(DateTime tuNgay, DateTime denNgay,int top)
        {
            var q = from hd in dt.HoaDons
                    join kh in dt.KhachHangs
                    on hd.MaKH equals kh.MaKH
                    where hd.NgayLapHD >= tuNgay && hd.NgayLapHD <= denNgay
                    group hd by hd.MaKH into g
                    select new
                    {
                        MaKH = g.Key,
                        TenKH = (from kh in dt.KhachHangs
                                 where kh.MaKH == g.Key
                                 select kh.TenKH).FirstOrDefault(),
                        TongTien = (from hd in dt.HoaDons
                                    join kh in dt.KhachHangs
                                    on hd.MaKH equals kh.MaKH
                                    join ct in dt.CTHDs
                                    on hd.MaHD equals ct.MaHD
                                    where hd.MaKH == g.Key
                                    select kh.HoaDons.Where(k => k.NgayLapHD >= tuNgay && k.NgayLapHD <= denNgay).Sum(o => o.CTHDs.Sum(e => e.SoLuong * e.GiaBan))
                                    ).FirstOrDefault()
                    };
            return q.OrderByDescending(o => o.TongTien).Take(top);
        }

        public IEnumerable<dynamic> ThongKeKHTopHD(DateTime tuNgay, DateTime denNgay,int top)
        {
            var q = from hd in dt.HoaDons
                    join kh in dt.KhachHangs
                    on hd.MaKH equals kh.MaKH
                    where hd.NgayLapHD >= tuNgay && hd.NgayLapHD <= denNgay
                    group hd by hd.MaKH into g
                    select new
                    {
                        MaKH = g.Key,
                        TenKH = (from kh in dt.KhachHangs
                                 where kh.MaKH == g.Key
                                 select kh.TenKH).FirstOrDefault(),
                        SoLan = (from hd in dt.HoaDons
                                 join kh in dt.KhachHangs
                                 on hd.MaKH equals kh.MaKH
                                 where hd.MaKH == g.Key
                                 select (int)kh.HoaDons.Where(o => o.NgayLapHD >= tuNgay && o.NgayLapHD <= denNgay).Count()).FirstOrDefault()
                    };
            return q.OrderByDescending(o => o.SoLan).Take(top);
        }
        public IEnumerable<dynamic> ThongKeKHTopDTMotNgay(DateTime ngay,int top)
        {
            var q = from hd in dt.HoaDons
                    join kh in dt.KhachHangs
                    on hd.MaKH equals kh.MaKH
                    where hd.NgayLapHD == ngay
                    group hd by hd.MaKH into g
                    select new
                    {
                        MaKH = g.Key,
                        TenKH = (from kh in dt.KhachHangs
                                 where kh.MaKH == g.Key
                                 select kh.TenKH).FirstOrDefault(),
                        TongTien = (from hd in dt.HoaDons
                                    join kh in dt.KhachHangs
                                    on hd.MaKH equals kh.MaKH
                                    join ct in dt.CTHDs
                                    on hd.MaHD equals ct.MaHD
                                    where hd.MaKH == g.Key
                                    select kh.HoaDons.Where(k => k.NgayLapHD == ngay).Sum(o => o.CTHDs.Sum(e => e.SoLuong * e.GiaBan))
                                    ).FirstOrDefault()
                    };
            return q.OrderByDescending(o => o.TongTien).Take(top);
        }

        public IEnumerable<dynamic> ThongKeKHTopHDMotNgay(DateTime ngay,int top)
        {

            var q = from hd in dt.HoaDons
                    join kh in dt.KhachHangs
                    on hd.MaKH equals kh.MaKH
                    where hd.NgayLapHD == ngay
                    group hd by hd.MaKH into g
                    select new
                    {
                        MaKH = g.Key,
                        TenKH = (from kh in dt.KhachHangs
                                 where kh.MaKH == g.Key
                                 select kh.TenKH).FirstOrDefault(),
                        SoLan = (from hd in dt.HoaDons
                                 join kh in dt.KhachHangs
                                 on hd.MaKH equals kh.MaKH
                                 where hd.MaKH == g.Key
                                 select (int)kh.HoaDons.Where(o => o.NgayLapHD == ngay).Count()).FirstOrDefault()
                    };
            return q.OrderByDescending(o => o.SoLan).Take(top);
        }
        public IEnumerable<dynamic> ThongKeKHTopDTMotThang(DateTime ngay,int top)
        {

            var q = from hd in dt.HoaDons
                    join kh in dt.KhachHangs
                    on hd.MaKH equals kh.MaKH
                    where hd.NgayLapHD.Year == ngay.Year && hd.NgayLapHD.Month == ngay.Month
                    group hd by hd.MaKH into g
                    select new
                    {
                        MaKH = g.Key,
                        TenKH = (from kh in dt.KhachHangs
                                 where kh.MaKH == g.Key
                                 select kh.TenKH).FirstOrDefault(),
                        TongTien = (from hd in dt.HoaDons
                                    join kh in dt.KhachHangs
                                    on hd.MaKH equals kh.MaKH
                                    join ct in dt.CTHDs
                                    on hd.MaHD equals ct.MaHD
                                    where hd.MaKH == g.Key
                                    select kh.HoaDons.Where(k => k.NgayLapHD.Year == ngay.Year && k.NgayLapHD.Month == ngay.Month).Sum(o => o.CTHDs.Sum(e => e.SoLuong * e.GiaBan))
                                    ).FirstOrDefault()
                    };
            return q.OrderByDescending(o => o.TongTien).Take(top);
        }

        public IEnumerable<dynamic> ThongKeKHTopHDMotThang(DateTime ngay,int top)
        {
            var q = from hd in dt.HoaDons
                    join kh in dt.KhachHangs
                    on hd.MaKH equals kh.MaKH
                    where hd.NgayLapHD.Year == ngay.Year && hd.NgayLapHD.Month == ngay.Month
                    group hd by hd.MaKH into g
                    select new
                    {
                        MaKH = g.Key,
                        TenKH = (from kh in dt.KhachHangs
                                 where kh.MaKH == g.Key
                                 select kh.TenKH).FirstOrDefault(),
                        SoLan = (from hd in dt.HoaDons
                                 join kh in dt.KhachHangs
                                 on hd.MaKH equals kh.MaKH
                                 where hd.MaKH == g.Key
                                 select (int)kh.HoaDons.Where(o => o.NgayLapHD.Year == ngay.Year && o.NgayLapHD.Month == ngay.Month).Count()).FirstOrDefault()
                    };
            return q.OrderByDescending(o => o.SoLan).Take(top);
        }
        public IEnumerable<dynamic> ThongKeKHTopDTMotNam(int nam,int top)
        {
            var q = from hd in dt.HoaDons
                    join kh in dt.KhachHangs
                    on hd.MaKH equals kh.MaKH
                    where hd.NgayLapHD.Year == nam
                    group hd by hd.MaKH into g
                    select new
                    {
                        MaKH = g.Key,
                        TenKH = (from kh in dt.KhachHangs
                                 where kh.MaKH == g.Key
                                 select kh.TenKH).FirstOrDefault(),
                        TongTien = (from hd in dt.HoaDons
                                    join kh in dt.KhachHangs
                                    on hd.MaKH equals kh.MaKH
                                    join ct in dt.CTHDs
                                    on hd.MaHD equals ct.MaHD
                                    where hd.MaKH == g.Key
                                    select kh.HoaDons.Where(k => k.NgayLapHD.Year == nam).Sum(o => o.CTHDs.Sum(e => e.SoLuong * e.GiaBan))
                                    ).FirstOrDefault()
                    };
            return q.OrderByDescending(o => o.TongTien).Take(top);
        }

        public IEnumerable<dynamic> ThongKeKHTopHDMotNam(int nam,int top)
        {
            var q = from hd in dt.HoaDons
                    join kh in dt.KhachHangs
                    on hd.MaKH equals kh.MaKH
                    where hd.NgayLapHD.Year == nam
                    group hd by hd.MaKH into g
                    select new
                    {
                        MaKH = g.Key,
                        TenKH = (from kh in dt.KhachHangs
                                 where kh.MaKH == g.Key
                                 select kh.TenKH).FirstOrDefault(),
                        SoLan = (from hd in dt.HoaDons
                                 join kh in dt.KhachHangs
                                 on hd.MaKH equals kh.MaKH
                                 where hd.MaKH == g.Key
                                 select (int)kh.HoaDons.Where(o => o.NgayLapHD.Year == nam).Count()).FirstOrDefault()
                    };
            return q.OrderByDescending(o => o.SoLan).Take(top);
        }
        //Thống kê doanh thu
        public IEnumerable<dynamic> ThongKeDoanhThu(DateTime tuNgay, DateTime denNgay)
        {

            var q = from n in dt.HoaDons
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayLapHD >= tuNgay && n.NgayLapHD <= denNgay
                    select new { n.MaHD, n.NgayLapHD, nv.TenNV, TongTien = (double)n.CTHDs.Sum(o => o.SoLuong * o.GiaBan) };
            return q;
        }
        
        public IEnumerable<dynamic> ThongKeDoanhThuTheoNhanVien(DateTime tuNgay, DateTime denNgay, string maNV)
        {

            var q = from n in dt.HoaDons
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayLapHD >= tuNgay && n.NgayLapHD <= denNgay && nv.MaNV.Equals(maNV)
                    select new { n.MaHD, n.NgayLapHD, nv.TenNV, TongTien = (double)n.CTHDs.Sum(o => o.SoLuong * o.GiaBan) };
            return q;
        }
        public IEnumerable<dynamic> ThongKeDoanhThuMotNgay(DateTime ngay)
        {

            var q = from n in dt.HoaDons
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayLapHD == ngay
                    select new { n.MaHD, n.NgayLapHD, nv.TenNV, TongTien = (double)n.CTHDs.Sum(o => o.SoLuong * o.GiaBan) };
            return q;
        }

        public IEnumerable<dynamic> ThongKeDoanhThuTheoNhanVienMotNgay(DateTime ngay,  string maNV)
        {

            var q = from n in dt.HoaDons
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayLapHD == ngay  && nv.MaNV.Equals(maNV)
                    select new { n.MaHD, n.NgayLapHD, nv.TenNV, TongTien = (double)n.CTHDs.Sum(o => o.SoLuong * o.GiaBan) };
            return q;
        }
        public IEnumerable<dynamic> ThongKeDoanhThuMotThang(DateTime ngay)
        {

            var q = from n in dt.HoaDons
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayLapHD.Month == ngay.Month && n.NgayLapHD.Year == ngay.Year
                    select new { n.MaHD, n.NgayLapHD, nv.TenNV, TongTien = (double)n.CTHDs.Sum(o => o.SoLuong * o.GiaBan) };
            return q;
        }
        public IEnumerable<dynamic> ThongKeDoanhThuTheoNhanVienThang(DateTime ngay, string maNV)
        {

            var q = from n in dt.HoaDons
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayLapHD.Month == ngay.Month && n.NgayLapHD.Year == ngay.Year && nv.MaNV.Equals(maNV)
                    select new { n.MaHD, n.NgayLapHD, nv.TenNV, TongTien = (double)n.CTHDs.Sum(o => o.SoLuong * o.GiaBan) };
            return q;
        }
        public IEnumerable<dynamic> ThongKeDoanhThuMotNam(int nam)
        {

            var q = from n in dt.HoaDons
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayLapHD.Year == nam
                    select new { n.MaHD, n.NgayLapHD, nv.TenNV, TongTien = (double)n.CTHDs.Sum(o => o.SoLuong * o.GiaBan) };
            return q;
        }
        public IEnumerable<dynamic> ThongKeDoanhThuTheoNhanVienNam(int nam, string maNV)
        {

            var q = from n in dt.HoaDons
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayLapHD.Year == nam && nv.MaNV.Equals(maNV)
                    select new { n.MaHD, n.NgayLapHD, nv.TenNV, TongTien = (double)n.CTHDs.Sum(o => o.SoLuong * o.GiaBan) };
            return q;
        }
        //Thống kê chi nhập sách 
        public IEnumerable<dynamic> ThongKeChiNhapSach(DateTime tuNgay, DateTime denNgay)
        {

            var q = from n in dt.PhieuNhapSaches
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayNhap >= tuNgay && n.NgayNhap <= denNgay
                    select new { n.MaPhieuNhap, n.NgayNhap, nv.TenNV, TongTien = (double)n.CTPhieuNhaps.Sum(o => o.SoLuong * o.GiaNhap) };
            return q;
        }

        public IEnumerable<dynamic> ThongKeChiNhapSachTheoNhanVien(DateTime tuNgay, DateTime denNgay, string maNV)
        {

            var q = from n in dt.PhieuNhapSaches
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayNhap >= tuNgay && n.NgayNhap <= denNgay && nv.MaNV.Equals(maNV)
                    select new { n.MaPhieuNhap, n.NgayNhap, nv.TenNV, TongTien = (double)n.CTPhieuNhaps.Sum(o => o.SoLuong * o.GiaNhap) };
            return q;
        }
        public IEnumerable<dynamic> ThongKeChiNhapSachMotNgay(DateTime ngay)
        {

            var q = from n in dt.PhieuNhapSaches
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayNhap == ngay
                    select new { n.MaPhieuNhap, n.NgayNhap, nv.TenNV, TongTien = (double)n.CTPhieuNhaps.Sum(o => o.SoLuong * o.GiaNhap) };
            return q;
        }

        public IEnumerable<dynamic> ThongKeChiNhapSachTheoNhanVienMotNgay(DateTime ngay, string maNV)
        {

            var q = from n in dt.PhieuNhapSaches
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayNhap == ngay && nv.MaNV.Equals(maNV)
                    select new { n.MaPhieuNhap, n.NgayNhap, nv.TenNV, TongTien = (double)n.CTPhieuNhaps.Sum(o => o.SoLuong * o.GiaNhap) };
            return q;
        }
        public IEnumerable<dynamic> ThongKeChiNhapSachMotThang(DateTime ngay)
        {

            var q = from n in dt.PhieuNhapSaches
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayNhap.Month == ngay.Month && n.NgayNhap.Year == ngay.Year
                    select new { n.MaPhieuNhap, n.NgayNhap, nv.TenNV, TongTien = (double)n.CTPhieuNhaps.Sum(o => o.SoLuong * o.GiaNhap) };
            return q;
        }
        public IEnumerable<dynamic> ThongKeChiNhapSachTheoNhanVienThang(DateTime ngay, string maNV)
        {

            var q = from n in dt.PhieuNhapSaches
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayNhap.Month == ngay.Month && n.NgayNhap.Year == ngay.Year && nv.MaNV.Equals(maNV)
                    select new { n.MaPhieuNhap, n.NgayNhap, nv.TenNV, TongTien = (double)n.CTPhieuNhaps.Sum(o => o.SoLuong * o.GiaNhap) };
            return q;
        }
        public IEnumerable<dynamic> ThongKeChiNhapSachMotNam(int nam)
        {

            var q = from n in dt.PhieuNhapSaches
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayNhap.Year == nam
                    select new { n.MaPhieuNhap, n.NgayNhap, nv.TenNV, TongTien = (double)n.CTPhieuNhaps.Sum(o => o.SoLuong * o.GiaNhap) };
            return q;
        }
        public IEnumerable<dynamic> ThongKeChiNhapSachTheoNhanVienNam(int nam, string maNV)
        {

            var q = from n in dt.PhieuNhapSaches
                    join nv in dt.NhanViens
                    on n.MaNV equals nv.MaNV
                    where n.NgayNhap.Year == nam && nv.MaNV.Equals(maNV)
                    select new { n.MaPhieuNhap, n.NgayNhap, nv.TenNV, TongTien = (double)n.CTPhieuNhaps.Sum(o => o.SoLuong * o.GiaNhap) };
            return q;
        }
        //Thống kê sách đã bán
        public IEnumerable<dynamic> ThongKeSachDaBanTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            var q = from s in dt.Saches
                    join ct in dt.CTHDs
                    on s.MaSach equals ct.MaSach
                    where ct.HoaDon.NgayLapHD >= tuNgay && ct.HoaDon.NgayLapHD <= denNgay
                    group ct by ct.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SachDaBan = (from s in dt.Saches
                                     join ct in dt.CTHDs
                                     on s.MaSach equals ct.MaSach
                                     join hd in dt.HoaDons
                                     on ct.MaHD equals hd.MaHD
                                     where s.MaSach == g.Key
                                     select s.CTHDs.Where(o => o.HoaDon.NgayLapHD >= tuNgay && o.HoaDon.NgayLapHD <= denNgay).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachDaBanTheoNgayVaTieuChi(DateTime tuNgay, DateTime denNgay, int tc, int top)
        {
            var q = from s in dt.Saches
                    join ct in dt.CTHDs
                    on s.MaSach equals ct.MaSach
                    where ct.HoaDon.NgayLapHD >= tuNgay && ct.HoaDon.NgayLapHD <= denNgay
                    group ct by ct.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SachDaBan = (from s in dt.Saches
                                     join ct in dt.CTHDs
                                     on s.MaSach equals ct.MaSach
                                     join hd in dt.HoaDons
                                     on ct.MaHD equals hd.MaHD
                                     where s.MaSach == g.Key
                                     select s.CTHDs.Where(o => o.HoaDon.NgayLapHD >= tuNgay && o.HoaDon.NgayLapHD <= denNgay).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            

            if (tc == 1)
                return q.OrderByDescending(o => o.SachDaBan).Take(top);
            else if (tc == 2)
                return q.OrderBy(o => o.SachDaBan).Take(top);
            else
            {
                var list1 = from s in dt.Saches
                            select new {s.MaSach,s.TenSach, SachDaBan = 0} ;
                var q2 = list1.Where(p => !q.Any(p2 => p2.MaSach == p.MaSach));
                return q2;
            }
                
        }
        public IEnumerable<dynamic> ThongKeSachDaBanTheoMotNgay(DateTime ngay)
        {
            var q = from s in dt.Saches
                    join ct in dt.CTHDs
                    on s.MaSach equals ct.MaSach
                    where ct.HoaDon.NgayLapHD == ngay
                    group ct by ct.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SachDaBan = (from s in dt.Saches
                                     join ct in dt.CTHDs
                                     on s.MaSach equals ct.MaSach
                                     where s.MaSach == g.Key
                                     select s.CTHDs.Where(o => o.HoaDon.NgayLapHD == ngay).Sum(sl => sl.SoLuong)).FirstOrDefault()
                    };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachDaBanTheoMotNgayVaTieuChi(DateTime ngay, int tc, int top)
        {
            var q = from s in dt.Saches
                    join ct in dt.CTHDs
                    on s.MaSach equals ct.MaSach
                    where ct.HoaDon.NgayLapHD == ngay
                    group ct by ct.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SachDaBan = (from s in dt.Saches
                                     join ct in dt.CTHDs
                                     on s.MaSach equals ct.MaSach
                                     where s.MaSach == g.Key
                                     select s.CTHDs.Where(o => o.HoaDon.NgayLapHD == ngay).Sum(sl => sl.SoLuong)).FirstOrDefault()
                    };
            



            if (tc == 1)
                return q.OrderByDescending(o => o.SachDaBan).Take(top);
            else if (tc == 2)
                return q.OrderBy(o => o.SachDaBan).Take(top);
            else
            {
                var list1 = from s in dt.Saches
                            select new { s.MaSach, s.TenSach, SachDaBan = 0 };
                var q2 = list1.Where(p => !q.Any(p2 => p2.MaSach == p.MaSach));
                return q2;
            }
                
        }
        public IEnumerable<dynamic> ThongKeSachDaBanTheoMotNam(int nam)
        {
            var q = from s in dt.Saches
                    join ct in dt.CTHDs
                    on s.MaSach equals ct.MaSach
                    where ct.HoaDon.NgayLapHD.Year == nam
                    group ct by ct.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SachDaBan = (from s in dt.Saches
                                     join ct in dt.CTHDs
                                     on s.MaSach equals ct.MaSach
                                     where s.MaSach == g.Key
                                     select s.CTHDs.Where(o => o.HoaDon.NgayLapHD.Year == nam).Sum(sl => sl.SoLuong)).FirstOrDefault()
                    };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachDaBanTheoMotNamVaTieuChi(int nam, int tc, int top)
        {
            var q = from s in dt.Saches
                    join ct in dt.CTHDs
                    on s.MaSach equals ct.MaSach
                    where ct.HoaDon.NgayLapHD.Year == nam
                    group ct by ct.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SachDaBan = (from s in dt.Saches
                                     join ct in dt.CTHDs
                                     on s.MaSach equals ct.MaSach
                                     where s.MaSach == g.Key
                                     select s.CTHDs.Where(o => o.HoaDon.NgayLapHD.Year == nam).Sum(sl => sl.SoLuong)).FirstOrDefault()
                    };
            



            if (tc == 1)
                return q.OrderByDescending(o => o.SachDaBan).Take(top);
            else if (tc == 2)
                return q.OrderBy(o => o.SachDaBan).Take(top);
            else
            {
                var list1 = from s in dt.Saches
                            select new { s.MaSach, s.TenSach, SachDaBan = 0 };
                var q2 = list1.Where(p => !q.Any(p2 => p2.MaSach == p.MaSach));
                return q2;
            }
                
        }
        public IEnumerable<dynamic> ThongKeSachDaBanTheoThang(DateTime ngay)
        {
            var q = from s in dt.Saches
                    join ct in dt.CTHDs
                    on s.MaSach equals ct.MaSach
                    where ct.HoaDon.NgayLapHD.Year == ngay.Year && ct.HoaDon.NgayLapHD.Month == ngay.Month
                    group ct by ct.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SachDaBan = (from s in dt.Saches
                                     join ct in dt.CTHDs
                                     on s.MaSach equals ct.MaSach
                                     join hd in dt.HoaDons
                                     on ct.MaHD equals hd.MaHD
                                     where s.MaSach == g.Key
                                     select s.CTHDs.Where(o => o.HoaDon.NgayLapHD.Year == ngay.Year && o.HoaDon.NgayLapHD.Month == ngay.Month).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachDaBanTheoThangVaTieuChi(DateTime ngay, int tc, int top)
        {
            var q = from s in dt.Saches
                    join ct in dt.CTHDs
                    on s.MaSach equals ct.MaSach
                    where ct.HoaDon.NgayLapHD.Year == ngay.Year && ct.HoaDon.NgayLapHD.Month == ngay.Month
                    group ct by ct.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SachDaBan = (from s in dt.Saches
                                     join ct in dt.CTHDs
                                     on s.MaSach equals ct.MaSach
                                     join hd in dt.HoaDons
                                     on ct.MaHD equals hd.MaHD
                                     where s.MaSach == g.Key
                                     select s.CTHDs.Where(o => o.HoaDon.NgayLapHD.Year == ngay.Year && o.HoaDon.NgayLapHD.Month == ngay.Month).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
           


            if (tc == 1)
                return q.OrderByDescending(o => o.SachDaBan).Take(top);
            else if (tc == 2)
                return q.OrderBy(o => o.SachDaBan).Take(top);
            else
            {
                var list1 = from s in dt.Saches
                            select new { s.MaSach, s.TenSach, SachDaBan = 0 };
                var q2 = list1.Where(p => !q.Any(p2 => p2.MaSach == p.MaSach));
                return q2;
            }
            
        }

        //Thống kê sách mới nhập
        public IEnumerable<dynamic> ThongKeSachNhapMotNam(int nam)
        {
            var q = from s in dt.Saches
                    join ctpn in dt.CTPhieuNhaps
                    on s.MaSach equals ctpn.MaSach
                    where ctpn.PhieuNhapSach.NgayNhap.Year == nam
                    group ctpn by ctpn.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SoLuongNhap = (from s in dt.Saches
                                       where s.MaSach == g.Key
                                       select s.CTPhieuNhaps.Where(o => o.PhieuNhapSach.NgayNhap.Year == nam).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachNhapMotNamTheoNCC(int nam, string maNCC)
        {
            var q = from s in dt.Saches
                    join ctpn in dt.CTPhieuNhaps
                    on s.MaSach equals ctpn.MaSach
                    join pn in dt.PhieuNhapSaches
                    on ctpn.MaPhieuNhap equals pn.MaPhieuNhap
                    join ncc in dt.NhaCungCaps
                    on pn.MaNCC equals ncc.MaNCC
                    where ctpn.PhieuNhapSach.NgayNhap.Year == nam && pn.MaNCC.Equals(maNCC)
                    group ctpn by ctpn.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SoLuongNhap = (from s in dt.Saches
                                       where s.MaSach == g.Key
                                       select s.CTPhieuNhaps.Where(o => o.PhieuNhapSach.NgayNhap.Year == nam && o.PhieuNhapSach.MaNCC.Equals(maNCC)).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachNhapMotThang(DateTime ngay)
        {
            var q = from s in dt.Saches
                    join ctpn in dt.CTPhieuNhaps
                    on s.MaSach equals ctpn.MaSach
                    where ctpn.PhieuNhapSach.NgayNhap.Year == ngay.Year && ctpn.PhieuNhapSach.NgayNhap.Month == ngay.Month
                    group ctpn by ctpn.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SoLuongNhap = (from s in dt.Saches
                                       where s.MaSach == g.Key
                                       select s.CTPhieuNhaps.Where(o => o.PhieuNhapSach.NgayNhap.Year == ngay.Year && o.PhieuNhapSach.NgayNhap.Month == ngay.Month).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachNhapMotThangTheoNCC(DateTime ngay, string maNCC)
        {
            var q = from s in dt.Saches
                    join ctpn in dt.CTPhieuNhaps
                    on s.MaSach equals ctpn.MaSach
                    join pn in dt.PhieuNhapSaches
                    on ctpn.MaPhieuNhap equals pn.MaPhieuNhap
                    join ncc in dt.NhaCungCaps
                    on pn.MaNCC equals ncc.MaNCC
                    where ctpn.PhieuNhapSach.NgayNhap.Year == ngay.Year && ctpn.PhieuNhapSach.NgayNhap.Month == ngay.Month && pn.MaNCC.Equals(maNCC)
                    group ctpn by ctpn.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SoLuongNhap = (from s in dt.Saches
                                       where s.MaSach == g.Key
                                       select s.CTPhieuNhaps.Where(o => o.PhieuNhapSach.NgayNhap.Year == ngay.Year && o.PhieuNhapSach.NgayNhap.Month == ngay.Month && o.PhieuNhapSach.MaNCC.Equals(maNCC)).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachNhap(DateTime tuNgay, DateTime denNgay)
        {
            var q = from s in dt.Saches
                    join ctpn in dt.CTPhieuNhaps
                    on s.MaSach equals ctpn.MaSach
                    where ctpn.PhieuNhapSach.NgayNhap >= tuNgay && ctpn.PhieuNhapSach.NgayNhap <= denNgay
                    group ctpn by ctpn.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SoLuongNhap = (from s in dt.Saches
                                       where s.MaSach == g.Key
                                       select s.CTPhieuNhaps.Where(o => o.PhieuNhapSach.NgayNhap >= tuNgay && o.PhieuNhapSach.NgayNhap <= denNgay).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachNhapMotNgay(DateTime ngay)
        {
            var q = from s in dt.Saches
                    join ctpn in dt.CTPhieuNhaps
                    on s.MaSach equals ctpn.MaSach
                    where ctpn.PhieuNhapSach.NgayNhap == ngay
                    group ctpn by ctpn.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SoLuongNhap = (from s in dt.Saches
                                       where s.MaSach == g.Key
                                       select s.CTPhieuNhaps.Where(o => o.PhieuNhapSach.NgayNhap == ngay).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            return q;
        }
        
        public IEnumerable<dynamic> ThongKeSachNhapTheoNCC(DateTime tuNgay, DateTime denNgay, string maNCC)
        {
            var q = from s in dt.Saches
                    join ctpn in dt.CTPhieuNhaps
                    on s.MaSach equals ctpn.MaSach
                    join pn in dt.PhieuNhapSaches
                    on ctpn.MaPhieuNhap equals pn.MaPhieuNhap
                    join ncc in dt.NhaCungCaps
                    on pn.MaNCC equals ncc.MaNCC
                    where ctpn.PhieuNhapSach.NgayNhap >= tuNgay && ctpn.PhieuNhapSach.NgayNhap <= denNgay && pn.MaNCC.Equals(maNCC)
                    group ctpn by ctpn.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SoLuongNhap = (from s in dt.Saches
                                       where s.MaSach == g.Key
                                       select s.CTPhieuNhaps.Where(o => o.PhieuNhapSach.NgayNhap >= tuNgay && o.PhieuNhapSach.NgayNhap <= denNgay && o.PhieuNhapSach.MaNCC.Equals(maNCC)).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachNhapMotNgayTheoNCC(DateTime ngay, string maNCC)
        {
            var q = from s in dt.Saches
                    join ctpn in dt.CTPhieuNhaps
                    on s.MaSach equals ctpn.MaSach
                    join pn in dt.PhieuNhapSaches
                    on ctpn.MaPhieuNhap equals pn.MaPhieuNhap
                    join ncc in dt.NhaCungCaps
                    on pn.MaNCC equals ncc.MaNCC
                    where ctpn.PhieuNhapSach.NgayNhap == ngay && pn.MaNCC.Equals(maNCC)
                    group ctpn by ctpn.MaSach into g
                    select new
                    {
                        MaSach = g.Key,
                        TenSach = (from s in dt.Saches
                                   where s.MaSach == g.Key
                                   select s.TenSach).FirstOrDefault(),
                        SoLuongNhap = (from s in dt.Saches
                                       where s.MaSach == g.Key
                                       select s.CTPhieuNhaps.Where(o => o.PhieuNhapSach.NgayNhap == ngay && o.PhieuNhapSach.MaNCC.Equals(maNCC)).Sum(sl => sl.SoLuong)).FirstOrDefault()

                    };
            return q;
        }
       
        //Thống kê tồn kho
        public IEnumerable<dynamic> ThongKeTonKho()
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join b in dt.NhaXuatBans
                    on n.MaNXB equals b.MaNXB
                    select new { n.MaSach, n.TenSach, n.SoLuongTon };
            return q;
        }
        public IEnumerable<dynamic> ThongKeSachGanHet(int sl)
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join b in dt.NhaXuatBans
                    on n.MaNXB equals b.MaNXB
                    where n.SoLuongTon <= sl
                    select new { n.MaSach, n.TenSach, n.SoLuongTon };
            return q;
        }
        public IEnumerable<dynamic> ThongKeTonKhoSachDaHet()
        {

            var q = from n in dt.Saches
                    join x in dt.TacGias
                    on n.MaTG equals x.MaTG
                    join k in dt.LoaiSaches
                    on n.MaLoai equals k.MaLoai
                    join b in dt.NhaXuatBans
                    on n.MaNXB equals b.MaNXB
                    where n.SoLuongTon == 0
                    select new { n.MaSach, n.TenSach, n.SoLuongTon};
            return q;
        }
        ////nhan vien
        //private string chucVu(int c)
        //{
        //    string cv = "";
        //    if (c == 1)
        //        cv = "Quản lý";
        //    else if (c == 2)
        //        cv = "Nhân viên bán hàng";
        //    else
        //        cv = "Nhân viên thống kê";
        //    return cv;
        //}
        //public IEnumerable<dynamic> GetNhnaVien()
        //{

        //    var q = from n in dt.NhanViens
        //            select new { ChucVu = chucVu(n.ChucVu) };
        //    return q;
        //}

    }
}
