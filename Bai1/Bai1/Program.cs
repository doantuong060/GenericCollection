using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho va Ten: Doan Ngoc Tuong_2415053122348");
            Console.WriteLine("\n\n");

            List<int> dssonguyen = new List<int>();

            dssonguyen.Add(12);
            dssonguyen.Add(5);
            dssonguyen.Add(67);
            dssonguyen.Add(27);
            dssonguyen.Add(8);

            Console.WriteLine("Danh sach cac phan tu trong danh sach: ");
            foreach (int i in dssonguyen)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
