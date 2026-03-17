using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    internal class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Student(int Id, string Name)
            {
                this.Id = Id;
                this.Name = Name;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ho va Ten: Doan Ngoc Tuong_2415053122348");
            Console.WriteLine("\n\n");

            List<Student> dshs = new List<Student>();

            dshs.Add(new Student(151, "Le Van Kien"));
            dshs.Add(new Student(152, "Nguyen Dang Khoa"));
            dshs.Add(new Student(153, "Vo Van Nam"));
            dshs.Add(new Student(154, "Tran Thi Ly Na"));

            Console.WriteLine("Danh sach hoc sinh");
            foreach (Student s in dshs)
            {
                Console.WriteLine($"{s.Id} - {s.Name}");
            }

            Console.WriteLine($"So hoc sinh co trong danh sach là: {dshs.Count}");
        }
    }
}
