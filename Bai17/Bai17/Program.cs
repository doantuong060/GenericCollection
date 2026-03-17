using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
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


            Dictionary<int, int> dem = new Dictionary<int, int>();

            foreach (int x in ds)
            {
                if (dem.ContainsKey(x))
                    dem[x]++;
                else
                    dem[x] = 1;
            }

            int sodem = 0, num = ds[0];
            foreach (var x in dem)
            {
                if (x.Value > sodem)
                {
                    sodem = x.Value;
                    num = x.Key;
                }
            }

            Console.WriteLine($"So xuat hien nhieu nhat: {num} ({sodem} lan)");
        }
    }
}
