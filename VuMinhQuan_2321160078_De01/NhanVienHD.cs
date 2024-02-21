using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuMinhQuan_2321160078_De01
{
    class NhanVienHD: NhanVien
    {
        private int doanhthu;
        public NhanVienHD(): base() { }
        public NhanVienHD(string maso,string hoten,int luongcung,int doanhthu): base(maso,hoten,luongcung)
        {
            this.doanhthu = doanhthu;
        }
        public int DoanhThu
        {
            set { this.doanhthu = value; }
            get { return this.doanhthu; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc doanh thu: ");
            this.doanhthu = int.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            double thuong= 0.05 * doanhthu;
            double luongthuclanh = thuong + LuongCung;
            return (int)luongthuclanh;
        }
    }
}
