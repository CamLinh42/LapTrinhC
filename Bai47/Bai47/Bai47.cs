using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai47
{
    class Bai47
    {
        static void Main(string[] args)
        {
            int n111,s111,i111;
            Console.Write("\n Nhap vao so n: ");
            n111 = Convert.ToInt32(Console.ReadLine());
            for (s111 = 0, i111 = n111; i111 > 0; i111 -= 2)
                s111 += i111;
            Console.Write("\n Tong la {0} ",s111);
            Console.ReadKey();

        
        }
    }
}
