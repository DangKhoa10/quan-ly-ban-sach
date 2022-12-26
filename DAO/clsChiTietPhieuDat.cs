using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsChiTietPhieuDat : clsKetNoi
    {
        public clsChiTietPhieuDat()
        {
            dt = getDataContext();
        }
        public IEnumerable<CTPhieuDat> GetAllChiTietPhieuDat()
        {
            IEnumerable<CTPhieuDat> q = from n in dt.CTPhieuDats
                                        select n;
            return q;
        }   
        public void ThemCTPhieuDat(CTPhieuDat ctPhieuDat)
        {
            dt.CTPhieuDats.InsertOnSubmit(ctPhieuDat);
            dt.SubmitChanges();
        }
        public IEnumerable<dynamic> GetCTPhieuDatTheoMaPhieuDat(string maPhieuDat)
        {

            var q = from n in dt.PhieuDatSaches
                    join x in dt.CTPhieuDats
                    on n.MaPhieuDat equals x.MaPhieuDat
                    join k in dt.Saches
                    on x.MaSach equals k.MaSach
                    where x.MaPhieuDat.Contains(maPhieuDat)
                    select new { x.MaSach, k.TenSach, x.GiaBan, x.SoLuong};
            return q;

        }
        QLMuaBanSachDataContext dt;


    }
}
