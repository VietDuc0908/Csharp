using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBai 3");
            Bai3 bai3 = new Bai3();
            bai3.CheckTK();

            Console.WriteLine("\nBai 6");
            Bai6 bai6 = new Bai6();
            bai6.TinhPS();

            Console.WriteLine("\nBai 9");
            Bai9 bai9 = new Bai9();
            bai9.TinhSV();

            Console.WriteLine("\nBai 12");
            Bai12 bai12 = new Bai12();
            bai12.ChuyenSo();

            Console.WriteLine("\nBai 15");
            Bai15 bai15 = new Bai15();
            bai15.KiemTraChanLe();

            Console.WriteLine("\nBai 18");
            Bai18 bai18 = new Bai18();
            bai18.KiemTra();

            Console.WriteLine("\nBai 21");
            Bai21 bai21 = new Bai21();
            bai21.KT();

            Console.WriteLine("\nBai 24");
            Bai24 bai24 = new Bai24();
            bai24.KT();

            Console.WriteLine("\nBai 27");
            Bai27 bai27 = new Bai27();
            bai27.KT();

            Console.WriteLine("\nBai 30");
            Bai30 bai30 = new Bai30();
            bai30.DocSo();

            Console.WriteLine("\nBai 31");
            Bai31 bai31 = new Bai31();
            bai31.SoNgay();

            Console.WriteLine("\nBai 32");
            Bai32 bai32 = new Bai32();
            bai32.Menu();


            Console.ReadKey();
        }
    }
}
