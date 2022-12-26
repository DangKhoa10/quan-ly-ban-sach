using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.DAO
{
    class clsCTHoaDon : clsKetNoi
    {
        QLMuaBanSachDataContext dt;

        public clsCTHoaDon()
        {
            dt = getDataContext();
        }
        public IEnumerable<CTHD> GetAllChiTietHoaDon()
        {
            IEnumerable<CTHD> q = from n in dt.CTHDs
                                         select n;
            return q;
        }
        public void ThemCTHoaDon(CTHD ctHoaDon)
        {
            dt.CTHDs.InsertOnSubmit(ctHoaDon);
            dt.SubmitChanges();
        }
        public IEnumerable<dynamic> GetCTHDTheoMa2(string ma)
        {

            var q = from n in dt.CTHDs
                    join x in dt.Saches
                    on n.MaSach equals x.MaSach
                    where n.MaHD == ma
                    select new { n.MaSach, x.TenSach, n.SoLuong, n.GiaBan };
            return q;
        }
    }
}
