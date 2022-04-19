using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Bai7
    {
        static void Main(string[] args)
        {
            int a111, b111;
            double x111;
            Console.Write("Nhap vao so a: ");
            a111 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Nhap vao so b: ");
            b111 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Chuong trinh ban vua nhap la {0}x + {1} = 0.", a111, b111);
            if (a111 == 0)
            {
                if (b111 == 0)
                {
                    Console.WriteLine("\n Phuong trinh co vo so nghiem.");
                }
                else
                {
                    Console.WriteLine("\n Phuong trinh vo nghiem.");
                }
            }
            else
            {
                x111 = (double)-b111 / a111;
                Console.WriteLine("\n Phuong trinh co nghiem x = {0}", Math.Round(x111, 2));
            }
            Console.ReadKey();

           
        }
    }
}
