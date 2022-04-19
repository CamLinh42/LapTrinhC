using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    class Bai18
    {
        static void Main(string[] args)
        {
            int gio111, ngay, tuan;
            Console.WriteLine("Nhap gio :");
            gio111 = int.Parse(Console.ReadLine());
            Console.WriteLine(" {0}:Tuan , {1}: Ngay , {2}: Gio ", gio111 / (24 * 7), (gio111 % (24 * 7)) / 24, (gio111 % (24 * 7)) % 24);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
