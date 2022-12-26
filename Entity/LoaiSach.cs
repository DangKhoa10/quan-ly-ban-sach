using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class LoaiSach
    {
        public LoaiSach()
        {
        }
        public LoaiSach(string maLoai, string tenLoai)
        {
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
        }

        private string maLoai;
        private string tenLoai;

        public string MaLoai
        {
            get => maLoai;
            set => maLoai = value;
        }
        public string TenLoai
        {
            get => tenLoai;
            set => tenLoai = value;
        }
    }
}
