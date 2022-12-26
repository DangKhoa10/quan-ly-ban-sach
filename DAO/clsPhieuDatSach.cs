using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsPhieuDatSach:clsKetNoi
    {
        public clsPhieuDatSach()
        {
            dt = getDataContext();
        }
     
        public IEnumerable<PhieuDatSach> GetAllPhieuDat()
        {
            IEnumerable<PhieuDatSach> q = from n in dt.PhieuDatSaches
                                       select n;
            return q;
        }
        public IEnumerable<PhieuDatSach> GetPhieuDatTheoMa(string maPhieu)
        {
            IEnumerable<PhieuDatSach> q = from n in dt.PhieuDatSaches
                                          where n.MaPhieuDat.Contains(maPhieu)
                                          select n;
            return q;
        }
        private string LayTenTinhTrang(int tinhTrang)
        {

            if (tinhTrang == 0)
                return "Chưa xử lí";
            else if (tinhTrang == 1)
                return "Đã xử lí ";
            else return null;
        }
        public IEnumerable<dynamic> GetPhieuDatSachTheoMaKH(string maKH)
        {

            var q = from n in dt.KhachHangs
                    join x in dt.PhieuDatSaches
                    on n.MaKH equals x.MaKH
                    where n.MaKH.Contains(maKH)
                    select new { n.TenKH, x.MaPhieuDat, x.NgayDat, TinhTrang = LayTenTinhTrang((int)x.TinhTrang) };
            return q;
        }
        QLMuaBanSachDataContext dt;

        public void ThemPhieuDat(PhieuDatSach phieuDat)
        {
            dt.PhieuDatSaches.InsertOnSubmit(phieuDat);
            dt.SubmitChanges();
        }
        public int xoaPhieuDat(PhieuDatSach phieuDat)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (phieuDat.MaPhieuDat != null)
                {
                    dt.PhieuDatSaches.DeleteOnSubmit(phieuDat);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Xóa không thành công ?" + ex.Message);

            }
        }
        public bool SuaPhieuDat(string maPhieuDat, short tinhTrang)// chỉ cần đưa vào 2 trường cho dễ làm
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<PhieuDatSach> tam = (from n in dt.PhieuDatSaches
                                                where n.MaPhieuDat == maPhieuDat
                                                select n);
                tam.First().TinhTrang = tinhTrang;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi Không sửa được");
            }
        }
    }
}
