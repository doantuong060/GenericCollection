using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho va Ten: Doan Ngoc Tuong_2415053122348");
            Console.WriteLine("\n\n");

            List<int> ds = new List<int>();

            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                int.TryParse(Console.ReadLine(), out int x);
                ds.Add(x);
            }
            Console.WriteLine("\n");

            ds.Reverse();
            Console.WriteLine("Danh sach sau khi dao nguoc: ");
            foreach (int j in ds)
            {
                Console.Write(j + " ");
            }
        }
    }
}
