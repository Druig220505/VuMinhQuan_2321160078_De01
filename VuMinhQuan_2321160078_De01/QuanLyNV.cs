using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuMinhQuan_2321160078_De01
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>(); 
        }
        public void NhapDS()
        {
            string tieptuc = "y"; 
            int chon;
            NhanVien nv;
            do
            {
                Console.Write("Ban hay chon loai nhan vien:[1:Bien che, 2:Hop dong]:");
                chon = int.Parse(Console.ReadLine());
                switch(chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.Write("Ban da chon sai.Vui long chon 1 hoac 2:");
                        break;
                }
                Console.Write("Ban co mun tiep tuc khong? Y/N:");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");    
        }
        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",-10}  {"Ho ten",20}  {"Luong thuc lanh",15} ");
            foreach(NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.MaSo,-10}  {x.HoTen,20}  {x.TinhLuong(),15}");
            }    
        }    
        public int TinhTongLuong()
        {
            int sum = 0;
            foreach(NhanVien nv in dsNV)
            {
                sum += nv.TinhLuong();
            }
            return sum;
        }
    }
}
