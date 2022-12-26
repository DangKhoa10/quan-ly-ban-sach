using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsNhanVien : clsKetNoi
    {
        public clsNhanVien()
        {
            dt = getDataContext();
        }
        public IEnumerable<NhanVien> GetAllNV()
        {
            IEnumerable<NhanVien> q = from n in dt.NhanViens
                                      select n;
            return q;
        }
        public IEnumerable<NhanVien> GetNVTheoMa(string strma)
        {
            IEnumerable<NhanVien> q = from n in dt.NhanViens
                                      where n.MaNV.Equals(strma)
                                      select n;
            return q;
        }
        public IEnumerable<dynamic> GetNVTKDT()
        {
            IEnumerable<dynamic> q = from n in dt.NhanViens
                                     where n.ChucVu == 1 || n.ChucVu == 2
                                      select new {
                                          MaNV = n.MaNV,
                                          TenNV = LayTen(n.TenNV,n.ChucVu),
                                      };
            return q;
        }
        public IEnumerable<dynamic> GetNVTKCSN()
        {
            IEnumerable<dynamic> q = from n in dt.NhanViens
                                     where n.ChucVu == 1
                                     select new
                                     {
                                         MaNV = n.MaNV,
                                         TenNV = LayTen(n.TenNV, n.ChucVu),
                                     };
            return q;
        }
        private string LayTen(string ten, int cv)
        {
            string chuoi = "";
            chuoi = ten + " - [" + LayTenChucVu(cv)+ "]";
            return chuoi;
        }
        public bool checkSDT(string sdt)
        {

            NhanVien mttemp = (from n in dt.NhanViens
                                where n.SDT.Equals(sdt)
                                select n).FirstOrDefault();
            if (mttemp != null)
                return true;
            return false;

        }
        public NhanVien checkIfExist(string maNV)
        {

            NhanVien mttemp = (from n in dt.NhanViens
                               where n.MaNV.Equals(maNV)
                               select n).FirstOrDefault();
            if (mttemp != null)
                return mttemp;
            return null;

        }
        public IEnumerable<NhanVien> GetNVTimKiem(string ma, string ten, string sdt, string dc)
        {
            IEnumerable<NhanVien> q = from n in dt.NhanViens
                                       where n.MaNV.Contains(ma) && n.TenNV.Contains(ten) && n.SDT.Contains(sdt) && n.DiaChi.Contains(dc)
                                       select n;
            return q;
        }
        public IEnumerable<NhanVien> GetNVTheoChucVu(int cv)
        {
            IEnumerable<NhanVien> q = from n in dt.NhanViens
                                      where n.ChucVu == cv
                                      select n;
            return q;
        }
        QLMuaBanSachDataContext dt;
        public bool SuaNV(string maUser, string hoTen, string sdt, string diaChi)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<NhanVien> tam = (from n in dt.NhanViens
                                            where n.MaNV == maUser
                                            select n);
                tam.First().TenNV = hoTen;
                tam.First().SDT = sdt;
                tam.First().DiaChi = diaChi;
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
        private string LayTenChucVu(int maChucVu)
        {

            if (maChucVu == 1)
                return "Quản lí";
            else if (maChucVu == 2)
                return "Nhân viên bán hàng ";
            else if (maChucVu == 3)
                return "Nhân viên thống kê";
            else return null;
        }
        public int themNV(NhanVien nv)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(nv.MaNV) != null)// tìm thấy mã
                    return 0;
                else
                {
                    dt.NhanViens.InsertOnSubmit(nv);
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
        public int xoaNV(NhanVien nv)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                if (checkIfExist(nv.MaNV) != null)// thay
                {
                    dt.NhanViens.DeleteOnSubmit(nv);
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
        public int xoaNVTheoMa(string maNV)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;

                if (checkIfExist(maNV) != null)// thay
                {
                    dt.NhanViens.DeleteOnSubmit(this.GetNVTheoMa(maNV).FirstOrDefault());
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
        public bool SuaNV(NhanVien nv)
        {
            try
            {
                IQueryable<NhanVien> tam = (from n in dt.NhanViens
                                            where n.MaNV == nv.MaNV
                                            select n);
                if (tam.First().SDT == nv.SDT)
                {
                    System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
                    dt.Transaction = myTran;
                    tam.First().TenNV = nv.TenNV;
                    tam.First().DiaChi = nv.DiaChi;
                    tam.First().ChucVu = nv.ChucVu;
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return true;
                }
                else
                {
                    if (checkSDT(nv.SDT) == false)
                    {
                        System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
                        dt.Transaction = myTran;
                        tam.First().TenNV = nv.TenNV;
                        tam.First().DiaChi = nv.DiaChi;
                        tam.First().ChucVu = nv.ChucVu;
                        tam.First().SDT = nv.SDT;
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
                throw new Exception("Xóa không thành công ?" + ex.Message);

            }
        }
        public IEnumerable<dynamic> GetAllNVCAPNHAT()
        {
            var q = from n in dt.NhanViens
                    select new { n.MaNV, n.TenNV, n.SDT, n.DiaChi, ChucVu = LayTenChucVu(n.ChucVu) };
            return q;
        }
    }
}
