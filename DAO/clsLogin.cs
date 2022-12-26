using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    public class clsLogin : clsKetNoi
    {
        public clsLogin()
        {
            dt = getDataContext();
        }
        public IEnumerable<TaiKhoan> GetAllTK()
        {
            IEnumerable<TaiKhoan> q = from n in dt.TaiKhoans
                                      select n;
            return q;
        }
        public IEnumerable<TaiKhoan> getTaiKhoan(string strUser)
        {
            IEnumerable<TaiKhoan> user =
                    from lg in dt.TaiKhoans
                    where lg.Username.Equals(strUser)
                    select lg;
            return user;
        }
        QLMuaBanSachDataContext dt;

        public bool SuaMK(TaiKhoan tk)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<TaiKhoan> tam = (from n in dt.TaiKhoans
                                            where n.Username == tk.Username
                                            select n);
                tam.First().Password = tk.Password;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi không sửa được" + ex.Message);
            }

        }
        public bool SuaMK1(string userName, string matKhauMoi)// chỉ cần đưa vào 2 trường cho dễ làm
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<TaiKhoan> tam = (from n in dt.TaiKhoans
                                            where n.Username == userName
                                            select n);
                tam.First().Password = matKhauMoi;
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
        private string username, password; 
        public string Username { get => username; set => username = value; } 
        public string Password { get => password; set => password = value; }
        //public void addNewAccount(string strPass, string strUserName, string strTenKH, string strSdt, string strEmail)
        //{
        //    TaiKhoan objTaiKhoan = new TaiKhoan();
        //    KhachHang objKhachHang = new KhachHang();
        //    int i = 0;
        //    foreach (var item in dt.KhachHangs)
        //    {
        //        i++;
        //    }
        //    objTaiKhoan.MaKH = "KH" + i.ToString();
        //    objTaiKhoan.LoaiUser = "1";
        //    objTaiKhoan.PassWord = strPass;
        //    objTaiKhoan.UserName = strUserName;
        //    objKhachHang.MaKH = "KH" + i.ToString();
        //    objKhachHang.TenKH = strTenKH;
        //    objKhachHang.SDT = strSdt;
        //    objKhachHang.Email = strEmail;
        //    dt.TaiKhoans.InsertOnSubmit(objTaiKhoan);
        //    dt.KhachHangs.InsertOnSubmit(objKhachHang);
        //    dt.SubmitChanges();
        //}
    }
}
