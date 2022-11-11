using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.DangNhapDangKi
{
    internal class Id
    {
        private string tenTaiKhoan;
        private string matkhau;

        public Id()
        {
        }

        public Id(string tenTaiKhoan, string matkhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matkhau = matkhau;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
