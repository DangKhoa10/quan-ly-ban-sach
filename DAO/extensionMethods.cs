using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using QuanLyMuaBanSach.DAO;

namespace QuanLyMuaBanSach.DAO
{
    public static class extensionMethods
    {
        public static Boolean KiemTraTen(this String s)
        {
            return Regex.Match(s, @"^([A-Z][a-zA-Z]+(\s[A-Z][a-zA-Z]*)+)$").Success;
        }
        public static Boolean KiemTraDau(this String s)
        {
            return Regex.Match(s, @"^([a-zA-Z0-9]{5,20})$").Success;
        }
        public static Boolean KiemTraSDT(this String s)
        {
            return Regex.Match(s, @"^((09|03|07|05|08)[0-9]{8})$").Success;
        }
        public static Boolean KiemTraMK(this String s)
        {
            return Regex.Match(s, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$").Success;
        }
        public static Boolean KiemTraThangNam(this String s)
        {
            return Regex.Match(s, @"^((01|02|03|04|05|06|07|08|09|10|11|12)[/|-][0-9]{4})$").Success;
        }
    }
}
