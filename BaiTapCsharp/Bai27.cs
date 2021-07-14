using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai27
    {
        public void KT()
        {
            float doanhThu, chiPhi;

            Console.WriteLine("Nhap vao doanh thu: ");
            doanhThu = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao chi phi: ");
            chiPhi = int.Parse(Console.ReadLine());

            if (doanhThu - chiPhi >= 0)
                Console.WriteLine("Loi nhuan.");
            else
                Console.WriteLine("Thua lo.");
        }
    }
}
