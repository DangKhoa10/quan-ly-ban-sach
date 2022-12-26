using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsSach:clsKetNoi
    {
        public clsSach()
        {
            dt = getDataContext();
        }
        public IEnumerable<Sach> GetAllSach()
        {
            IEnumerable<Sach> q = from n in dt.Saches
                                  select n;
            return q;
        }
        public IEnumerable<Sach> GetSachTheoMa(string ma)
        {
            IEnumerable<Sach> q = from n in dt.Saches
                                  where n.MaSach.Equals(ma)
                                  select n;
            return q;
        }
        public IEnumerable<Sach> GetSachTheoMaLoai(string maLoai)
        {
            IEnumerable<Sach> q = from n in dt.Saches
                                  where n.MaLoai.Equals(maLoai)
                                  select n;
            return q;
        }


        public Sach checkIfExist(string maSach)
        {

            Sach mttemp = (from n in dt.Saches
                           where n.MaSach.Equals(maSach)
                           select n).FirstOrDefault();
            if (mttemp != null)
                return mttemp;
            return null;

        }
        QLMuaBanSachDataContext dt;

        public int themSach(Sach s)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(s.MaSach) != null)// thay
                    return 0;
                else
                {
                    dt.Saches.InsertOnSubmit(s);
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
        public bool suaSach(Sach s)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<Sach> tam = (from n in dt.Saches
                                        where n.MaSach == s.MaSach
                                        select n);
                tam.First().TenSach = s.TenSach;
                tam.First().DonGiaBan = s.DonGiaBan;
                tam.First().MaTG = s.MaTG;
                tam.First().MaLoai = s.MaLoai;
                tam.First().SoTrang = s.SoTrang;
                tam.First().MaNXB = s.MaNXB;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Sửa không thành công ?");

            }
        }
        public bool capNhatSachSauKhiNhap(Sach s)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<Sach> tam = (from n in dt.Saches
                                        where n.MaSach == s.MaSach
                                        select n);
                tam.First().DonGiaNhap = s.DonGiaNhap;
                tam.First().SoLuongTon = s.SoLuongTon;
                //tam.First().MaNCC = s.MaNCC;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Sửa không thành công ?");

            }
        }
        public int xoaSach(Sach s)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                if (checkIfExist(s.MaSach) != null)// thay
                {
                    dt.Saches.DeleteOnSubmit(s);
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
        public bool SuaSoLuong(string maSach, int soLuongMua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<Sach> tam = (from n in dt.Saches
                                        where n.MaSach == maSach
                                        select n);
                tam.First().SoLuongTon = tam.First().SoLuongTon - soLuongMua;
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
