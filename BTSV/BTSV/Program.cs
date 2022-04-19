using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTSV
{
    class Program
    {
        struct sinhvien
        {
            public int maso111;
            public string hoten111;
            public double diemtoan111;
            public double diemly111;
            public double diemhoa111;
        }
        static void thongtinsinhvien(out sinhvien sv)
        {
            Console.Write("Ma so sinh vien: ");
            sv.maso111 = int.Parse(Console.ReadLine());
            Console.Write("Ho ten :");
            sv.hoten111 = Console.ReadLine();
            Console.Write("Diem toan: ");
            sv.diemtoan111 = int.Parse(Console.ReadLine());
            Console.Write("Diem ly: ");
            sv.diemly111 = int.Parse(Console.ReadLine());
            Console.Write("Diem hoa: ");
            sv.diemhoa111 = int.Parse(Console.ReadLine());
        }
        static void xuatTHONGtinsv(sinhvien sv)
        {
            Console.WriteLine("Ma so: " + sv.maso111);
            Console.WriteLine("Ho ten: " + sv.hoten111);
            Console.WriteLine("Diem toan: " + sv.diemtoan111);
            Console.WriteLine("Diem ly: " + sv.diemly111);
            Console.WriteLine("Diem Hoa: " + sv.diemhoa111);

        }
        static double diemTB(sinhvien sv)
        {
            return (sv.diemtoan111 + sv.diemly111 + sv.diemhoa111) / 3;
        }
        static void Main(string[] args)
        {
            sinhvien SV1 = new sinhvien();
            Console.WriteLine("Nhap thong tin sinh vien: ");
            thongtinsinhvien(out SV1);
            Console.WriteLine("---------------------------------------");
            Console.Write("Thong tin sinh viên vua nhap la: ");
            xuatTHONGtinsv(SV1);
            Console.Write("Diem TB cua sinh vien la : " + diemTB(SV1));
            Console.ReadLine();
            Console.ReadKey();
        }

    }
}
