using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCsharp
{
    class Bai3
    {
        public void CheckTK()
        {
            //Tên đăng nhập và mật khẩu mặc định là user và password
            string user = "user", pass = "password";
            Console.WriteLine("Moi ban nhap ten dang nhap va mat khau:");
            Console.Write("Ten dang nhap: ");
            user = Console.ReadLine();
            Console.Write("Mat khau: ");
            pass = Console.ReadLine();
            while (user != "user" && pass != "password")
            {
                Console.WriteLine("Nhap sai ten dang nhap hoac mat khau. Yeu cau nhap lai");
                Console.Write("Ten dang nhap: ");
                user = Console.ReadLine();
                Console.Write("Mat khau: ");
                pass = Console.ReadLine();
            }
            Console.WriteLine("Dang nhap thanh cong!");
        }

    }
}
