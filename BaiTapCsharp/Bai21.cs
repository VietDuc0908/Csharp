using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai21
    {
        public void KT()
        {
            int x, y;
            Console.WriteLine("Nhap hoanh do: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tung do: ");
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("Diem co toa do (" + x + "," + y + ") nam tren goc phan tu thu I");
            else if (x < 0 && y > 0)
                Console.WriteLine("Diem co toa do (" + x + "," + y + ") nam tren goc phan tu thu II");
            else if (x < 0 && y < 0)
                Console.WriteLine("Diem co toa do (" + x + "," + y + ") nam tren goc phan tu thu III");
            else if (x > 0 && y < 0)
                Console.WriteLine("Diem co toa do (" + x + "," + y + ") nam tren goc phan tu thu IV");
            else if (x == 0 && y == 0)
                Console.WriteLine("Diem co toa do("+x+","+y+")  la goc toa do");

        }
    }
}
