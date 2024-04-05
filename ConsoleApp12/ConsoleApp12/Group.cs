using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Group
    {
        private Student[] _students;
        public string GroupNo { get; set; }
        private int _studentlimit { get; set; }
        public Group()
        {
            _students = new Student[0];

        }

        

        public int StudentLimit
        {
            get
            { return _studentlimit; }
            set
            {
                if
                    (value >= 5 && value <= 18)
                {
                    _studentlimit = value;
                }
                else
                {
                    Console.WriteLine("telebe sayi deyis");
                }



            }



        }
        public bool CheckGroupNo(string groupNo)
        {
            return groupNo.Length == 5;
                return false;
            if (!char.IsLetter(groupNo[0]) || !char.IsLetter(groupNo[1]) || !char.IsUpper(groupNo[0]) || !char.IsUpper(groupNo[1]))
                return false;

            
            if (!char.IsDigit(groupNo[2]) || !char.IsDigit(groupNo[3]) || !char.IsDigit(groupNo[4]))
                return false;

            
            return true;
        }
        public void AddStudent(Student student)
        {
            if (_students.Length < StudentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);

                _students[_students.Length - 1] = student;


            }
            else { Console.WriteLine("yer qokku"); }
        }
    }
}
