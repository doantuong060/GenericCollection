using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho va Ten: Doan Ngoc Tuong_2415053122348");
            Console.WriteLine("\n\n");

            List<int> dssonguyen = new List<int>();

            int n, x;
            Console.Write("Nhap so luong phan tu: ");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                int.TryParse(Console.ReadLine(), out x);
                dssonguyen.Add(x);
            }
            Console.WriteLine("\n");
            int tg = 0;
            foreach (int j in dssonguyen)
            {
                tg = tg + j;
            }
            Console.WriteLine("Tong cac phan tu trong danh sach la: {0}", tg);

        }
    }
}
