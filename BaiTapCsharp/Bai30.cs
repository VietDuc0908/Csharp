using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai30
    {
        public void DocSo()
        {
            int n;
            int m=0;

            Console.WriteLine("Nhap vao so: ");
            n = int.Parse(Console.ReadLine());

            if (n < 10)
                Console.WriteLine(DS(n));
            else if (n < 100)
                Console.WriteLine(DS2chuso(n));
            else if (n < 1000)
            {
                Console.WriteLine(DS3chuso(n));
            }
            else if (n < 10000)
                Console.WriteLine(DS(n / 1000) + " nghin " + DS3chuso(n % 1000));
        }
        public string DS3chuso(int n)
        {
            string str = "";
            if (n % 100 == 0)
                str = DS(n / 100) + " tram ";
            else
                str = DS(n / 100) + " tram "  + DS2chuso(n % 100);
            return str;

        }
        public string DS2chuso(int n)
        {
            string str = "";
            if (n < 20)
            {
                if (n % 10 == 4)
                    str = "muoi tu";
                else if (n % 10 == 5)
                    str = "muoi lam";
                else
                    str = "muoi " + DS(n % 10);
            }
            else if (n < 100)
            {
                if (n % 10 == 4)
                    str = DS(n / 10) + " muoi tu";
                else if (n % 10 == 5)
                    str =DS(n / 10) + " muoi lam";
                else
                    str =DS(n / 10) + " muoi " + DS(n % 10);
            }
            return str;
        }
        public string DS(int m)
        {
            string chuoi ="" ;
            switch (m)
            {
                case 0:
                    chuoi = "khong";
                    break;
                case 1:
                    chuoi = "mot";
                    break;
                case 2:
                    chuoi = "hai";
                    break;
                case 3:
                    chuoi = "ba";
                    break;
                case 4:
                    chuoi = "bon";
                    break;
                case 5:
                    chuoi = "nam";
                    break;
                case 6:
                    chuoi = "sau";
                    break;
                case 7:
                    chuoi = "bay";
                    break;
                case 8:
                    chuoi = "tam";
                    break;
                case 9:
                    chuoi = "chin";
                    break;
            }
            return chuoi;
        }
    }
}
