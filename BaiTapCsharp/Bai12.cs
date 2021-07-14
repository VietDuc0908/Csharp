using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai12
    {
        public void ChuyenSo()
        {
            Console.OutputEncoding = Encoding.Unicode;
            int n;
            int binary = 0;
            Console.WriteLine("Nhập vào số n: ");
            n = int.Parse(Console.ReadLine());
            int d = 1;
            while (n > 0)
            {
                binary = binary + n % 2 * d;
                d = d * 10;
                n = n / 2;
            }
            Console.WriteLine("Số nhị phân sau khi chuyển là: " + binary);
        }
    }
}
