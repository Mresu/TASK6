using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Point { get; set; }

        public void StudentInfo()
        {
            Console.WriteLine($"name:{Fullname},point:{Point},id:{Id}");
        }

        internal void ShowInfo()
        {
            throw new NotImplementedException();
        }

        public Student(string name, int point, int id)
        {
            Id = id;
            Fullname = name;
            Point = point;
        }

        public Student()
        {
        }
    }
}
