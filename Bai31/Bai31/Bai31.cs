using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai31
{
    class Bai31
    {
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("In bang cuu chuong :\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");
            int num111, so_nhan111;
            num111 = 2;
            do
            {
                so_nhan111 = 1;
                do
                {
                    Console.WriteLine("{0} x {1} = {2}", num111, so_nhan111, num111 * so_nhan111);
                    so_nhan111++;
                }
                while (so_nhan111 <= 10);

                Console.WriteLine();
                num111++;
            } while (num111 <= 9);

            Console.ReadKey();

           
        }
    }
}
