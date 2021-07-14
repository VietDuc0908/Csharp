using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai6
    {
        public void TinhPS()
        {
            double r = 0;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập bán kính hình tròn");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Chu vi của hình tròn: " + String.Format("{0:00.00}", 2 * r * Math.PI));
            Console.WriteLine("Diện tích hình tròn: " +  String.Format("{0:00.00}", r * r * Math.PI));
        }
    }
}
