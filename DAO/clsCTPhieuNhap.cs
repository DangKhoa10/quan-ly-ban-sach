using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsCTPhieuNhap:clsKetNoi
    {
        QLMuaBanSachDataContext dt;

        public clsCTPhieuNhap()
        {
            dt = getDataContext();
        }
        
        public IEnumerable<CTPhieuNhap> GetAllCTPN()
        {
            IEnumerable<CTPhieuNhap> q = from n in dt.CTPhieuNhaps
                                    select n;
            return q;
        }
        public IEnumerable<dynamic> GetCTPNTheoMa(string ma)
        {

            var q = from n in dt.CTPhieuNhaps
                    join x in dt.Saches
                    on n.MaSach equals x.MaSach
                    where n.MaPhieuNhap == ma
                    select new { n.MaSach, x.TenSach, n.SoLuong, n.GiaNhap };
            return q;
        }
        public int themCTPN(CTPhieuNhap ctpn)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                dt.CTPhieuNhaps.InsertOnSubmit(ctpn);
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return 1;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Thêm không thành công ?" + ex.Message);
            }
        }
    }
}
