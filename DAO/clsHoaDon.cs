using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    class clsHoaDon:clsKetNoi
    {
        public clsHoaDon()
        {
            dt = getDataContext();
        }
       
        public IEnumerable<HoaDon> GetAllHD()
        {
            IEnumerable<HoaDon> q = from n in dt.HoaDons
                                       select n;
            return q;
        }
        public void ThemHoaDon(HoaDon hoaDon)
        {
            dt.HoaDons.InsertOnSubmit(hoaDon);
            dt.SubmitChanges();
        }
        public IEnumerable<HoaDon> GetHoaDonTheoMa(string strma)
        {
            IEnumerable<HoaDon> q = from n in dt.HoaDons
                                    where n.MaHD.Equals(strma)
                                    select n;
            return q;
        }
        QLMuaBanSachDataContext dt;


    }
}
