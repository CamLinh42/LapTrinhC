using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai23
{
    class Bai23
    {
        static void Main(string[] args)
        {
            double n111, i, j, sum;
            Console.WriteLine("Nhap n :");
            n111 = double.Parse(Console.ReadLine());
            Console.WriteLine("Cac so hoan hao nho hon {0} :",n111);
            
            for (i = 1; i < n111; ++i)
            {
                for (sum = 0, j = 1; sum <= i && j < i; ++j)
                    if (i % j == 0) sum += j;
                if (sum == i)
                    Console.WriteLine("{0}",i);
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
