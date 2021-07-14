using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai9
    {
        public void TinhSV()
        {
            double r = 0;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập bán kính hình cầu");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Diện tích hình cầu: " + String.Format("{0:00.00}", 4 *r* r * Math.PI));
            Console.WriteLine("Thể tích hình cầu: " + String.Format("{0:00.00}", 4/3 * Math.Pow(r,3) * Math.PI));
        }
    }
}
