using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho va Ten: Doan Ngoc Tuong_2415053122348");
            Console.WriteLine("\n\n");

            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();

            Dictionary<char, int> dem = new Dictionary<char, int>();

            foreach (char c in chuoi)
            {
                if (dem.ContainsKey(c))
                {
                    dem[c]++;
                }
                else
                {
                    dem[c] = 1;
                }
            }

            Console.WriteLine("Ket qua:");
            foreach (var i in dem)
            {
                Console.Write(i.Key + ": " + i.Value + " ");
            }
        }
    }
}
