using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.DAO
{
    class clsTaiKhoan :clsKetNoi
    {
        QLMuaBanSachDataContext dt;
        public clsTaiKhoan()
        {
            dt = getDataContext();
        }
        public IEnumerable<TaiKhoan> GetAllTaiKhoan()
        {
            IEnumerable<TaiKhoan> q = from n in dt.TaiKhoans
                                    select n;
            return q;
        }
        public bool checkIfExist(string user)
        {

            TaiKhoan mttemp = (from n in dt.TaiKhoans
                             where n.Username.Equals(user)
                             select n).FirstOrDefault();
            if (mttemp != null)
                return true;
            return false;

        }
        public int themTK(TaiKhoan tk)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (checkIfExist(tk.Username) == true)// tìm thấy mã
                    return 0;
                else
                {
                    dt.TaiKhoans.InsertOnSubmit(tk);
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
