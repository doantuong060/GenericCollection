using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho va Ten: Doan Ngoc Tuong_2415053122348");
            Console.WriteLine("\n\n");

            List<string> dsten = new List<string>();

            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            string x;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ten thu {0}: ", i + 1);
                x = Console.ReadLine();
                dsten.Add(x);
            }
            Console.WriteLine("\n");

            Console.Write("Nhap ten can xoa: ");
            string xoa = Console.ReadLine();
            for (int j = dsten.Count - 1; j >= 0; j--)
            {
                if (xoa.Equals(dsten[j]))
                {
                    dsten.RemoveAt(j);
                    Console.WriteLine("Da xoa ten {0} tai vi tri {1}", xoa, j + 1);
                }
            }

            Console.WriteLine("Danh sach sau khi xoa");
            foreach (string ten in dsten)
            {
                Console.WriteLine(ten);
            }
        }
    }
}
