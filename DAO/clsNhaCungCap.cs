using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsNhaCungCap:clsKetNoi
    {
        public clsNhaCungCap()
        {
            dt = getDataContext();
        }

        public IEnumerable<NhaCungCap> GetAllNhaCungCap()
        {
            IEnumerable<NhaCungCap> q = from n in dt.NhaCungCaps
                                        select n;
            return q;
        }
        public IEnumerable<NhaCungCap> GetNCCTheoMa(string ma)
        {
            IEnumerable<NhaCungCap> q = from n in dt.NhaCungCaps
                                        where n.MaNCC.Equals(ma)
                                        select n;
            return q;
        }
        QLMuaBanSachDataContext dt;
        public NhaCungCap checkIfExist(string ma)
        {

            NhaCungCap mttemp = (from n in dt.NhaCungCaps
                             where n.MaNCC.Equals(ma)
                             select n).FirstOrDefault();
            if (mttemp != null)
                return mttemp;
            return null;

        }

        public int themNCC(NhaCungCap ncc)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(ncc.MaNCC) != null)// tìm thấy mã
                    return 0;
                else
                {
                    dt.NhaCungCaps.InsertOnSubmit(ncc);
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

        public bool suaNCC(NhaCungCap ncc)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<NhaCungCap> tam = (from n in dt.NhaCungCaps
                                          where n.MaNCC == ncc.MaNCC
                                          select n);
                tam.First().TenNCC = ncc.TenNCC;
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

        public int xoaNCC(NhaCungCap ncc)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                if (checkIfExist(ncc.MaNCC) != null)// thay
                {
                    dt.NhaCungCaps.DeleteOnSubmit(ncc);
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
