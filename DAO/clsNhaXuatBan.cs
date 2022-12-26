using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.DAO
{
    class clsNhaXuatBan : clsKetNoi
    {
        QLMuaBanSachDataContext dt;
        public clsNhaXuatBan()
        {
            dt = getDataContext();
        }
        public IEnumerable<NhaXuatBan> GetAllNXB()
        {
            IEnumerable<NhaXuatBan> q = from n in dt.NhaXuatBans
                                        select n;
            return q;
        }
        
        public IEnumerable<NhaXuatBan> GetNXBTheoMa(string ma)
        {
            IEnumerable<NhaXuatBan> q = from n in dt.NhaXuatBans
                                      where n.MaNXB.Equals(ma)
                                      select n;
            return q;
        }
        public NhaXuatBan checkIfExist(string ma)
        {

            NhaXuatBan mttemp = (from n in dt.NhaXuatBans
                             where n.MaNXB.Equals(ma)
                             select n).FirstOrDefault();
            if (mttemp != null)
                return mttemp;
            return null;

        }

        public int themNXB(NhaXuatBan nxb)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(nxb.MaNXB) != null)// tìm thấy mã
                    return 0;
                else
                {
                    dt.NhaXuatBans.InsertOnSubmit(nxb);
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

        public bool suaNXB(NhaXuatBan nxb)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<NhaXuatBan> tam = (from n in dt.NhaXuatBans
                                          where n.MaNXB == nxb.MaNXB
                                          select n);
                tam.First().TenNXB = nxb.TenNXB;
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

        public int xoaNXB(NhaXuatBan nxb)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                if (checkIfExist(nxb.MaNXB) != null)// thay
                {
                    dt.NhaXuatBans.DeleteOnSubmit(nxb);
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
