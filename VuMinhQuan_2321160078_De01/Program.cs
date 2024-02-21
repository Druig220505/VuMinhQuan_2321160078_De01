using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuMinhQuan_2321160078_De01
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyNV ql = new QuanLyNV();
            int chon=0;
            do
            {
                Console.WriteLine("*****CHUONG TRINH QUAN LY NHAN VIEN*****");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1.Nhap danh sach nhan vien:");
                Console.WriteLine("2.Xuat danh sach nhan vien:");
                Console.WriteLine("3.Tong tien luong nhan vien:");
                Console.WriteLine("4.Tien thuc lanh trung binh cua nhan vien:");
                Console.WriteLine("5.Thoat chuong trinh:");
                Console.Write("Ban hay chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());
                switch(chon)
                {
                    case 1:
                        ql.NhapDS();
                        break;
                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($"Tong so tien nhan vien:{ql.TinhTongLuong():#,##0 vnđ}");
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Ban da ket thuc chuong trinh.Hen gap lai!");
                        Console.ReadLine();
                        break;
                }    
                Console.WriteLine("------------------------------");

            } while (chon != 5);    
        }
    }
}
