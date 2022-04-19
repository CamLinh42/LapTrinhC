using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    class Bai19
    {
        static void Main(string[] args)
        {
            int h111, m111, s111;
            long time;
            Console.WriteLine(" Nhap gio :");
            h111 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap phut :");
            m111 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap giay :");
            s111 = int.Parse(Console.ReadLine());
            time = 3600 * h111 + 60 * m111 + s111;
            Console.WriteLine(" Nhap gio 2 :");
            h111 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap phut 2 :");
            m111 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap giay 2 :");
            s111 = int.Parse(Console.ReadLine());
            time -= 3600 * h111 + 60 * m111 + s111;
            if (time < 0) time = -time;
            Console.WriteLine("Hieu thoi gian: {0} gio, {1} phut, {2} giay\n", time / 3600, (time % 3600) / 60, (time % 3600) % 60);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
