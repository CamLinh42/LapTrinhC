using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    class Bai20
    {
        static void Main(string[] args)
        {
            Double kw111, tien;
            Console.WriteLine("Nhap so KW tieu thu :");
            kw111 = double.Parse(Console.ReadLine());
            tien = kw111 * 500;
            /* từ kw 100 trở đi, thêm phụ thu (800 - 500) cho mỗi kw tăng thêm */
            if (kw111 > 100) tien += (kw111- 100) * 300;
            /* từ kw 250 trở đi, thêm phụ thu (1000 - 800) cho mỗi kw tăng thêm */
            if (kw111 > 250) tien += (kw111 - 250) * 200;
            /* từ kw 350 trở đi, thêm phụ thu (1500 - 1000) cho mỗi kw tăng thêm */
            if (kw111 > 350) tien += (kw111 - 350) * 500;
            Console.WriteLine("Chi phi :{0}",tien);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
