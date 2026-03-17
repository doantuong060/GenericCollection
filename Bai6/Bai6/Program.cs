using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho va Ten: Doan Ngoc Tuong_2415053122348");
            Console.WriteLine("\n\n");

            List<string> ds = new List<string>();

            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            string x;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap chuoi thu {0}: ", i + 1);
                x = Console.ReadLine();
                ds.Add(x);
            }
            Console.WriteLine("\n");

            int dem = 0;
            Console.Write("Nhap chuoi can tim: ");
            string kt = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (ds[i] == kt)
                {
                    dem = 1;
                    break;
                }
            }

            if (dem == 1)
                Console.WriteLine("Co chuoi {0} trong danh sach", kt);
            else
                Console.WriteLine("Khong co chuoi {0} trong danh sach", kt);
        }
    }
}
