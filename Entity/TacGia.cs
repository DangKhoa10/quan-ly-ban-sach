using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class TacGia
    {
        public TacGia()
        {
        }
        public TacGia(string maTG, string tenTG)
        {
            this.MaTG = maTG;
            this.TenTG = tenTG;
        }

        private string maTG;
        private string tenTG;

        public string MaTG
        {
            get => maTG;
            set => maTG = value;
        }
        public string TenTG
        {
            get => tenTG;
            set => tenTG = value;
        }
    }
}
