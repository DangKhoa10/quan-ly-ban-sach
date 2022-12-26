using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class NhaXuatBan
    {
        public NhaXuatBan()
        {

        }
        public NhaXuatBan(string maNXB, string tenNXB)
        {
            this.MaNXB = maNXB;
            this.TenNXB = tenNXB;
        }
        string maNXB, tenNXB;

        public string MaNXB 
        {
            get => maNXB; 
            set => maNXB = value;
        }
        public string TenNXB 
        { 
            get => tenNXB;
            set => tenNXB = value;
        }
    }
}
