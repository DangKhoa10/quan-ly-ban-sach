using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsPhieuNhapSach:clsKetNoi
    {
        public clsPhieuNhapSach()
        {
            dt = getDataContext();
        }
  
        public IEnumerable<PhieuNhapSach> GetAllPhieuNhap()
        {
            IEnumerable<PhieuNhapSach> q = from n in dt.PhieuNhapSaches
                                           select n;
            return q;
        }
        public PhieuNhapSach checkIfExist(string maPN)
        {

            PhieuNhapSach mttemp = (from n in dt.PhieuNhapSaches
                                where n.MaPhieuNhap.Equals(maPN)
                                select n).FirstOrDefault();
            if (mttemp != null)
                return mttemp;
            return null;

        }
        public IEnumerable<PhieuNhapSach> GetPhieuNhapTheoMa(string strma)
        {
            IEnumerable<PhieuNhapSach> q = from n in dt.PhieuNhapSaches
                                           where n.MaPhieuNhap.Equals(strma)
                                           select n;
            return q;
        }
        QLMuaBanSachDataContext dt;

        public int themPNS(PhieuNhapSach pns)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(pns.MaPhieuNhap) != null)// tìm thấy mã
                    return 0;
                else
                {
                    dt.PhieuNhapSaches.InsertOnSubmit(pns);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Thêm không thành công ?" + ex.Message);

            }
        }
    }
}
