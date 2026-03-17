using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho va Ten: Doan Ngoc Tuong_2415053122348");
            Console.WriteLine("\n\n");

            List<int> dssonguyen = new List<int>();

            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            { 
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                int.TryParse(Console.ReadLine(), out int x);
                dssonguyen.Add(x);
            }
            Console.WriteLine("\n");
            int max = dssonguyen[0];
            foreach (int j in dssonguyen)
            { 
                if (j > max)
                    max = j;
            }

            Console.WriteLine("Phan tu lon nhat trong danh sach la: {0}", max);
        }
    }
}
