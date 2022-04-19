using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    class Bai22
    {
        static void Main(string[] args)
        {
            double n111, i, count=0 ,sum=0;
            Console.WriteLine("Nhap n :");
            n111 = double.Parse(Console.ReadLine());
            Console.WriteLine("Cac uoc so :");
            
            for ( i = 1; i <= n111;i++)
                if (n111 % i == 0)
                {
                    Console.WriteLine("{0}",i);
                    sum =sum+  i;  
                    count++;
                    
                }
            
            Console.WriteLine("Co {0} uoc so, tong la : {1}", count, sum);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
