using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai15
    {
        public void KiemTraChanLe()
        {
            var stringNumber = "";
            int numericValue = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                Console.WriteLine("Nhap vao so can kiem tra(chuoi nhap vao phai la so):");
                stringNumber = Console.ReadLine();
                isNumber = int.TryParse(stringNumber, out numericValue);

            }
            if (double.Parse(stringNumber) % 2 == 0)
                Console.WriteLine("So nhap vao la chan");
            else
                Console.WriteLine("So nhap vao la le");

        }
    }
}
