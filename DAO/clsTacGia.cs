using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsTacGia:clsKetNoi
    {
        public clsTacGia()
        {
            dt = getDataContext();
        }
        public IEnumerable<TacGia> GetAllTacGia()
        {
            IEnumerable<TacGia> q = from n in dt.TacGias
                                    select n;
            return q;
        }
        public IEnumerable<TacGia> GetTGTheoMa(string ma)
        {
            IEnumerable<TacGia> q = from n in dt.TacGias
                                    where n.MaTG.Equals(ma)
                                    select n;
            return q;
        }
       
        QLMuaBanSachDataContext dt;
        public TacGia checkIfExist(string ma)
        {

            TacGia mttemp = (from n in dt.TacGias
                                where n.MaTG.Equals(ma)
                                select n).FirstOrDefault();
            if (mttemp != null)
                return mttemp;
            return null;

        }

        public int themTG(TacGia tg)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(tg.MaTG) != null)// tìm thấy mã
                    return 0;
                else
                {
                    dt.TacGias.InsertOnSubmit(tg);
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

        public bool suaTG(TacGia tg)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<TacGia> tam = (from n in dt.TacGias
                                             where n.MaTG == tg.MaTG
                                             select n);
                tam.First().TenTG = tg.TenTG;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Sửa không thành công ?" + ex.Message);

            }
        }

        public int xoaTG(TacGia tg)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                if (checkIfExist(tg.MaTG) != null)// thay
                {
                    dt.TacGias.DeleteOnSubmit(tg);
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

    }
}
