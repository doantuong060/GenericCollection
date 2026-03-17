using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class Program
    {
        class Student
        {
            public string Name;
            public double Score;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ho va ten: Doan Ngoc Tuong - 2415053122348\n\n");

            List<Student> ds = new List<Student>();

            Console.Write("Nhap so luong sinh vien: ");
            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i < n; i++)
            {
                Student sv = new Student();

                Console.Write("Nhap ten: ");
                sv.Name = Console.ReadLine();

                Console.Write("Nhap diem: ");
                sv.Score = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                ds.Add(sv);
            }

            double max = ds[0].Score;
            foreach (Student sv in ds)
            {
                if (sv.Score > max)
                {
                    max = sv.Score;
                }
            }

            Console.Write("\nSinh vien co diem cao nhat la:");
            foreach (Student sv in ds)
            {
                if (sv.Score == max)
                {
                    Console.WriteLine($"{sv.Name} - {sv.Score} diem");
                }
            }
        }
    }
}
