using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsLoaiSach:clsKetNoi
    {
        public clsLoaiSach()
        {
            dt = getDataContext();
        }

        public IEnumerable<LoaiSach> GetAllLoaiSach()
        {
            IEnumerable<LoaiSach> q = from n in dt.LoaiSaches
                                      select n;
            return q;
        }
        public IEnumerable<LoaiSach> GetLSTheoMa(string ma)
        {
            IEnumerable<LoaiSach> q = from n in dt.LoaiSaches
                                      where n.MaLoai.Equals(ma)
                                      select n;
            return q;
        }
        QLMuaBanSachDataContext dt;
        public LoaiSach checkIfExist(string ma)
        {

            LoaiSach mttemp = (from n in dt.LoaiSaches
                             where n.MaLoai.Equals(ma)
                             select n).FirstOrDefault();
            if (mttemp != null)
                return mttemp;
            return null;

        }

        public int themLS(LoaiSach ls)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(ls.MaLoai) != null)// tìm thấy mã
                    return 0;
                else
                {
                    dt.LoaiSaches.InsertOnSubmit(ls);
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

        public bool suaLS(LoaiSach ls)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<LoaiSach> tam = (from n in dt.LoaiSaches
                                          where n.MaLoai == ls.MaLoai
                                          select n);
                tam.First().TenLoai = ls.TenLoai;
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

        public int xoaLS(LoaiSach ls)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                if (checkIfExist(ls.MaLoai) != null)// thay
                {
                    dt.LoaiSaches.DeleteOnSubmit(ls);
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
