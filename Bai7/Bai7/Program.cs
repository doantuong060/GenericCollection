using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
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

            int tg;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)      
                    if (ds[i] > ds[j])
                    {
                        tg = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tg;
                    }
            Console.WriteLine("Danh sach sau khi sap xep tang dan: ");
            foreach (int k in ds)
            {
                Console.WriteLine("{0} ", k);
            }
        }
    }
}
