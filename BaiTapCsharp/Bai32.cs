using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai32
    {
        public void Menu()
        {
            int x, r, l, w, b, h;
            double s = 0;

            Console.WriteLine("Chon chuc nang ban muon :");

            Console.WriteLine(" 1: tinh dien tich hinh tron");
            Console.WriteLine(" 2: tinh dien tich hinh chu nhat");
            Console.WriteLine(" 3: tinh dien tich hinh tam giac");
            Console.WriteLine("Nhap lua chon cua ban: ");
            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.Write("Nhap ban kinh hinh tron: ");
                    r = int.Parse(Console.ReadLine());
                    s = Math.PI * r * r;
                    break;
                case 2:
                    Console.Write("Nhap chieu dai HCN: ");
                    l = int.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu rong HCN: ");
                    w = int.Parse(Console.ReadLine());
                    s = l * w;
                    break;
                case 3:
                    Console.Write("Nhap canh day tam giac:");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Nhap chieu cao tam giac:");
                    h = int.Parse(Console.ReadLine());
                    s = 1/2 * b * h;
                    break;
            }
            Console.Write("Dien tich co ket qua la: "+ s);
        }
    }
}
