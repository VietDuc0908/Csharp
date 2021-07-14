using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai18
    {
        public void KiemTra()
        {
            var stringNumber = "";
            int numericValue = 0;
            int n;
            bool isNumber = false;
            while (!isNumber)
            {
                Console.WriteLine("Nhap vao so m (chuoi nhap vao phai la so):");
                stringNumber = Console.ReadLine();
                isNumber = int.TryParse(stringNumber, out numericValue);
            }
            if (int.Parse(stringNumber) != 0)
                if (int.Parse(stringNumber) > 0)
                    n = 1;
                else
                    n = -1;
            else
                n = 0;
            Console.WriteLine("Gia tri cua m: " + int.Parse(stringNumber));
            Console.WriteLine("Gia tri tuong ung cua n: " + n);
        }
}
}
