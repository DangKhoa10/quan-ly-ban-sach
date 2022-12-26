using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class clsNhaCungCap
    {
        public clsNhaCungCap()
        {
        }

        public clsNhaCungCap(string maNhaCC, string tenNhaCC)
        {
            this.MaNhaCC = maNhaCC;
            this.TenNhaCC = tenNhaCC;
        }

        private string maNhaCC;
        private string tenNhaCC;

        public string MaNhaCC
        {
            get => maNhaCC;
            set => maNhaCC = value;
        }
        public string TenNhaCC
        {
            get => tenNhaCC;
            set => tenNhaCC = value;
        }
    }
}
