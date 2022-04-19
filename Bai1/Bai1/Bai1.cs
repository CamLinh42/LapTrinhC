using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Bai1
    {
        static void Main(string[] args)
        {
            Double S111,V111;
            Console.WriteLine("Nhap dien tich S = ");
            S111 = double.Parse(Console.ReadLine());
            V111 = 4 * 3.14 * Math.Pow(Math.Sqrt(S111 / (4 * 3.14)), 3) / 3;
            Console.WriteLine("The tich V ={0}",V111);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
