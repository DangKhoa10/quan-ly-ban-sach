using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsKhachHang : clsKetNoi
    {
        public clsKhachHang()
        {
            dt = getDataContext();
        }
        public IEnumerable<KhachHang> GetAllKH()
        {
            IEnumerable<KhachHang> q = from n in dt.KhachHangs
                                       select n;
            return q;
        }
        QLMuaBanSachDataContext dt;

        public IEnumerable<KhachHang> GetKHTheoMa(string strma)
        {
            IEnumerable<KhachHang> q = from n in dt.KhachHangs
                                       where n.MaKH.Equals(strma)
                                       select n;
            return q;
        }
        public IEnumerable<KhachHang> GetKHTheoSDT(string sdt)
        {
            IEnumerable<KhachHang> q = from n in dt.KhachHangs
                                       where n.SDT.Equals(sdt)
                                       select n;
            return q;
        }
        public IEnumerable<KhachHang> GetKHTimKiem(string ma, string ten, string sdt, string dc)
        {
            IEnumerable<KhachHang> q = from n in dt.KhachHangs
                                       where n.MaKH.Contains(ma) && n.TenKH.Contains(ten) && n.SDT.Contains(sdt) && n.DiaChi.Contains(dc)
                                       select n;
            return q;
        }
        public bool checkSDT(string sdt)
        {

            KhachHang mttemp = (from n in dt.KhachHangs
                                where n.SDT.Equals(sdt)
                                select n).FirstOrDefault();
            if (mttemp != null)
                return true;
            return false;

        }
        public KhachHang checkIfExist(string maKH)
        {

            KhachHang mttemp = (from n in dt.KhachHangs
                                where n.MaKH.Equals(maKH)
                                select n).FirstOrDefault();
            if (mttemp != null)
                return mttemp;
            return null;

        }

        public int themKH(KhachHang kh)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(kh.MaKH) != null)// tìm thấy mã
                    return 0;
                else
                {
                    dt.KhachHangs.InsertOnSubmit(kh);
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

        public int suaKH_QLKH(KhachHang kh)
        {
            try
            {
                IQueryable<KhachHang> tam = (from n in dt.KhachHangs
                                             where n.MaKH == kh.MaKH
                                             select n);
                if(tam.First().SDT== kh.SDT)
                {
                    System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
                    dt.Transaction = myTran;
                    tam.First().TenKH = kh.TenKH;
                    tam.First().DiaChi = kh.DiaChi;
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }   
                else
                {
                    if (checkSDT(kh.SDT) == false)
                    {
                        System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
                        dt.Transaction = myTran;
                        tam.First().TenKH = kh.TenKH;
                        tam.First().DiaChi = kh.DiaChi;
                        tam.First().SDT = kh.SDT;
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return 1;
                    }
                    else 
                        return 0;
                }
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Thêm không thành công ?" + ex.Message);

            }
        }

        public int xoaKH(KhachHang kh)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                if (checkIfExist(kh.MaKH) != null)// thay
                {
                    dt.KhachHangs.DeleteOnSubmit(kh);
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

        public bool SuaKH(string maUser, string hoTen, string sdt, string diaChi)
        {
            try
            {
                IQueryable<KhachHang> tam = (from n in dt.KhachHangs
                                             where n.MaKH == maUser
                                             select n);
                if (tam.First().SDT == sdt)
                {
                    System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
                    dt.Transaction = myTran;
                    tam.First().TenKH = hoTen;
                    tam.First().DiaChi = diaChi;
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return true;
                }
                else
                {
                    if (checkSDT(sdt) == false)
                    {
                        System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
                        dt.Transaction = myTran;
                        tam.First().TenKH = hoTen;
                        tam.First().DiaChi = diaChi;
                        tam.First().SDT =sdt;
                        dt.SubmitChanges();
                        dt.Transaction.Commit();
                        return true;
                    }
                    else
                        return false;
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
