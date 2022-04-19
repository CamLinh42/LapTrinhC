using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Bai4
    {
        static void Main(string[] args)
        {
            Double a111, b111, c111,p111,s111;
            Console.Write("Nhap canh a: ");
            a111 = Double.Parse(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            b111 = Double.Parse(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            c111 = Double.Parse(Console.ReadLine());

            /* Kiem tra xem tong ba goc co bang 180 do */
            if (a111 <= 0 || b111 <= 0 || c111 <= 0)
                Console.Write("khong phai 3 canh cua tam giac\n");
            else
            {
                if (a111 == b111 && b111 == c111 && a111 == c111)
                {
                    Console.Write("Day la tam giac deu.\n");
                }
                else
                {
                    if (a111 == b111 || b111 == c111 || a111 == c111)
                    {
                        Console.Write("Day la tam giac can.\n");
                    }
                    else
                    {
                        if (a111 * a111 + b111 * b111 == c111 * c111 || a111 * c111 + c111 * c111 == b111 * b111 || b111 * b111 + c111 * c111 == a111 * c111)
                        {
                            Console.Write("Day la tam giac vuong.\n");
                        }
                        else
                            Console.Write("Day la tam giac thuong.\n");
                    }
                }
            }
            p111 = (a111 + b111 + c111) / 2;
            s111 = Math.Sqrt( p111 * (p111 - a111) * (p111 - b111) * (p111 - c111));
            Console.Write("Dien tich tam giac la S={0}",s111);
            Console.ReadKey();
        }
    }
}
