using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMuaBanSach.Entity
{
    class clsTaiKhoan
    {
        public clsTaiKhoan()
        {
        }
        public clsTaiKhoan(string username, string password, string maKH, string maNV, string loaiTaiKhoan)
        {
            this.Username = username;
            this.Password = password;
            this.loaiTaiKhoan = loaiTaiKhoan;
            this.maNV = maNV;
            this.maKH = maKH;
        }

        private string username, password;
        private string loaiTaiKhoan;
        private string maKH;
        private string maNV;

        public string LoaiTaiKhoan
        {
            get => loaiTaiKhoan;
            set => loaiTaiKhoan = value;
        }
        public string MaKH
        {
            get => maKH;
            set => maKH = value;
        }
        public string MaNV
        {
            get => maNV;
            set => maNV = value;
        }
        public string Username
        {
            get => username;
            set => username = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }

    }
}
