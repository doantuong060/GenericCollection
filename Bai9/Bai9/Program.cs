using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
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

            List<int> dsnew = new List<int>();
            foreach (int j in ds)
            { 
                if (!dsnew.Contains(j))
                    dsnew.Add(j);
            }

            Console.WriteLine("Danh sach ban dau: ");
            foreach (int k in ds)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Danh sach sau khi loai bo cac phan tu trung lap: ");
            foreach (int k in dsnew)
            {
                Console.Write(k + " ");
            }
        }
    }
}
