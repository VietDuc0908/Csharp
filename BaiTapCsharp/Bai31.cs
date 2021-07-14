using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai31
    {
        public void SoNgay()
        {
            int thang;
            Console.Write("Nhap thang trong nam: ");
            thang = int.Parse(Console.ReadLine());
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang co 31 ngay. ");
                    break;
                case 2:
                    KTNamNhuan();
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang co 30 ngay.");
                    break;
                default:
                    Console.WriteLine("Khong phai la thang trong nam!!!");
                    break;
            }
        }
        public void KTNamNhuan()
        {
            int nam;
            Console.WriteLine("Thang 2 co the co 28 hoac 29 ngay tuy theo nam.");
            Console.WriteLine("Nhap them nam vao de tim duoc so ngay chinh xac nhat.");
            nam = int.Parse(Console.ReadLine());
            if (nam % 100 % 4 == 0)
                Console.WriteLine("Thang 2 co 29 ngay.");
            else
                Console.WriteLine("Thang 2 co 28 ngay.");
        }
    }
}
