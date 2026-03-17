using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
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

            int min = ds[0];
            foreach (int x in ds)
            { 
                if (x < min)
                    min = x;
            }
            Console.WriteLine("Phan tu nho nhat la: {0}", min);
        }
    }
}
