using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Student : Person
    {
        public Role RoleOfStudent { get; set; }
        public List<Student> Grades { get; set; }
        public List<Subjects> ListOfSubjects { get; set; } = new List<Subjects>();

        public Student(string _frist, string _last, int _password)
        {
            FristName = _frist;
            LastName = _last;
            Password = _password;
            RoleOfStudent = Role.Student;

        }


        public void GetSubjects()
        {
            if (ListOfSubjects.Count > 0)
            {
                Console.WriteLine($"{GetFullName()} has this subjects!");
                foreach (var subject in ListOfSubjects)
                {
                    Console.WriteLine($"{subject.SubjectName}");
                }
            }
            else
            {
                Console.WriteLine($"Sorry but {GetFullName()} doesn't have subjects");
            }
        }


    }
}
