using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTSV
{
    class Program
    {
        public struct sinhvien
        {
            public string maso111;
            public string hoten111;
            public double diemtoan111;
            public gioitinh gioitinh111;
            public double diemly111;
            public double diemhoa111;
        }
        public enum gioitinh
        {
            Nam,
            Nu
        };
        public enum hocluc
        {
            Yeu,
            TrungBinh,
            Kha,
            Gioi
        };
        public static void nhapDS(ref sinhvien[] sv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1));
                Console.Write("Ho ten: ");
                string ht111 = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                string msv111 = Console.ReadLine();
                Console.Write("Gioi tinh (0: nam  1: nu): ");
                int gt111 = int.Parse(Console.ReadLine());
                Console.Write("Diem toan: ");
                double dt111 = double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                double dl111 = double.Parse(Console.ReadLine());
                Console.Write("Diem hoa: ");
                double dh111 = double.Parse(Console.ReadLine());


                sv[i].hoten111 = ht111;
                sv[i].maso111 = msv111;
                if (gt111 == 0)
                    sv[i].gioitinh111 = gioitinh.Nam;
                else
                    sv[i].gioitinh111 = gioitinh.Nu;
                sv[i].diemtoan111 = dt111;
                sv[i].diemly111 = dl111;
                sv[i].diemhoa111 = dh111;

            }
        }
        public static void xuatDS(sinhvien[] sv, int n)
        {
            int i = 1;
            foreach (sinhvien item111 in sv)
            {
                Console.WriteLine("----- " + i + " -----");
                Console.WriteLine("Ho ten: " + item111.hoten111);
                Console.WriteLine("Ma sinh vien: " + item111.maso111);
                int gt = (int)item111.gioitinh111;
                if (gt == 0)
                    Console.WriteLine("Gioi tinh: Nam");
                else
                    Console.WriteLine("Gioi tinh: Nữ");
                Console.WriteLine("Diem toan: " + item111.diemtoan111);
                Console.WriteLine("Diem ly: " + item111.diemly111);
                Console.WriteLine("Diem hoa: " + item111.diemhoa111);
                int hocluc = (int)diemTB(item111.diemtoan111, item111.diemly111, item111.diemhoa111);
                switch (hocluc)
                {
                    case 0:
                        Console.WriteLine("Hoc luc: Yeu");
                        break;
                    case 1:
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;
                    case 2:
                        Console.WriteLine("Hoc luc: Kha");
                        break;
                    case 3:
                        Console.WriteLine("Hoc luc:Gioi");
                        break;

                }

                i++;
            }
        }
        public static hocluc diemTB(double toan, double ly, double hoa)
        {
            double dtb = (toan + ly + hoa) / 3;
            if (dtb <= 4)
                return hocluc.Yeu;
            else if (dtb <= 5)
                return hocluc.TrungBinh;
            else if (dtb <= 7)
                return hocluc.Kha;
            else
                return hocluc.Gioi;
        }
        public static void timKiem(sinhvien[] sv, int n, string ht)
        {
            foreach (sinhvien item117 in sv)
            {
                if (item117.hoten111 == ht)
                {
                    Console.WriteLine("Ho ten: " + item117.hoten111);
                    Console.WriteLine("Ma sinh vien: " + item117.maso111);
                    int gt = (int)item117.gioitinh111;
                    if (gt == 0)
                        Console.WriteLine("Gioi tinh: Nam");
                    else
                        Console.WriteLine("Gioi tinh: Nữ");
                    Console.WriteLine("Diem toan: " + item117.diemtoan111);
                    Console.WriteLine("Diem ly: " + item117.diemly111);
                    Console.WriteLine("Diem hoa: " + item117.diemhoa111);
                    int hocluc = (int)diemTB(item117.diemtoan111, item117.diemly111, item117.diemhoa111);
                    switch (hocluc)
                    {
                        case 0:
                            Console.WriteLine("Hoc luc: Yeu");
                            break;
                        case 1:
                            Console.WriteLine("Hoc luc: Trung Binh");
                            break;
                        case 2:
                            Console.WriteLine("Hoc luc: Kha");
                            break;
                        case 3:
                            Console.WriteLine("Hoc luc:Gioi");
                            break;

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n111 = int.Parse(Console.ReadLine());
            sinhvien[] sv111 = new sinhvien[n111];
            nhapDS(ref sv111, n111);
            Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
            xuatDS(sv111, n111);

            Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
            Console.Write("Nhap ten sinh vien: ");
            string ht111 = Console.ReadLine();
            timKiem(sv111, n111, ht111);

            Console.ReadLine();
        }


    }
}
