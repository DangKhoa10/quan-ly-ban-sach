using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach
{
    public class clsKetNoi
    {
        QLMuaBanSachDataContext dt;
        public QLMuaBanSachDataContext getDataContext()
        {
            string str = @"Data Source=DANGKHOA;Initial Catalog=QLMuaBanSach;Integrated Security=True";
            //string str = @"Data Source=DESKTOP-R2SFBLB\SQLEXPRESS;Initial Catalog=QLMuaBanSach;Integrated Security=True";
            dt = new QLMuaBanSachDataContext(str);
            dt.Connection.Open();
            return dt;
        }
    }
}
