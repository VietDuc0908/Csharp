using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai24
    {
        public void KT()
        {
            int a, b, c;
            Console.WriteLine("Nhap canh a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap canh b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap canh c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && a == c)
                {
                    Console.WriteLine("Day la tam giac deu.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Day la tam giac can.");
                }
                else
                {
                    Console.WriteLine("Day la tam giac lech.");
                }
            }
            else
                Console.WriteLine("Do dai 3 canh khong tao thanh tam giac");
        }
    }
}
