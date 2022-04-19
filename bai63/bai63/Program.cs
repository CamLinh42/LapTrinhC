using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do dai cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            mang = taoMang(mang, n);
            xuatMang(mang, n);
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (mang[i] % 4 == 0 && Math.Abs(mang[i]) % 10 == 6)
                {
                    count++;
                }
            }
            Console.Write("\n");
            Console.Write("Co {0} phan tu chia het cho 4, tan cung 6 ", count);
            Console.Write("\n");
            nhandoi(mang, n);
           
            Console.ReadLine();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        public static int[] taoMang(int[] mang, int n)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = rd.Next(-100, 100);
            }
            return mang;
        }

        public static void xuatMang(int[] mang, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
        }
        public static int dem(int[] mang,int n)
        {
            int c;
            for (int i = c=0; i < n ; i++)
                if (mang[i] % 4 == 0 && Math.Abs(mang[i]) % 10 == 6)
                    c++;
            return c;
        }
        public static void nhandoi(int[] mang, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (mang[i] % 2!=0)
                {
                    mang[i] *= 2;
                }
                    
            }
            for (int i = 0; i < n; i++)
            { Console.Write(mang[i] + " "); }
        }
       
        }

             
    }

