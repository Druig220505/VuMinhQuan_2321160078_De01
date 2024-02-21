using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuMinhQuan_2321160078_De01
{
    class NhanVienBC: NhanVien
    {
        private string mucxeploai;
        public NhanVienBC(): base() { }
        public NhanVienBC(string maso,string hoten,int luongcung,string mucxeploai): base(maso,hoten,luongcung)
        {
            this.mucxeploai = mucxeploai;
        }
        public string MucXepLoai
        {
            set { this.mucxeploai = value; }
            get { return this.mucxeploai; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc xep loai: ");
            this.mucxeploai = Console.ReadLine();
        }
        public override int TinhLuong()
        {
            double thuong;
            if(this.mucxeploai=="a")
            {
                thuong = 1.8 * LuongCung+LuongCung ;
            }    
            else if(this.mucxeploai=="b")
            {
                thuong = 1.2 * LuongCung +LuongCung;
            }
            else
            {
                thuong = 0.8 * LuongCung+LuongCung ;
            }
            double luongthuclanh = thuong + LuongCung;
            return (int)luongthuclanh;
        }
    }
}
