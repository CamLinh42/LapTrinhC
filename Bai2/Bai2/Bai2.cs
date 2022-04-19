using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Bai2
    {
        static void Main(string[] args)
        {
           double xA111, yA111, xB111, yB111, kq111;
            Console.Write("Nhap xA : xA = ");
            xA111 = double.Parse(Console.ReadLine());

            Console.Write("Nhap yA : yA = ");
            yA111 = double.Parse(Console.ReadLine());

            Console.Write("Nhap xB : xB = ");
            xB111 = double.Parse(Console.ReadLine());
            Console.Write("Nhap yB : yB = ");
            yB111 = double.Parse(Console.ReadLine());
            kq111= Math.Sqrt((xB111 - xA111) * (xB111 - xA111) + (yB111 - yA111) * (yB111 - yA111)) ;
            Console.Write("Khoan cach giua A va B la {0}", kq111);
            Console.ReadKey();

        }
    }
}
