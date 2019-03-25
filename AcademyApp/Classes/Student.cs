using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Student : Person
    {


        public List<Subjects> ListOfSubjects { get; set; } = new List<Subjects>();
        public Dictionary<Subjects, int> GradesOfSubjects { get; set; } = new Dictionary<Subjects, int>();

        public Student(string _frist, string _last, int _password)
        {
            FristName = _frist;
            LastName = _last;
            Password = _password;


        }
        public Student()
        {

        }

        public void AddSubAndGrades(Subjects sub, int gr)
        {
            GradesOfSubjects.Add(sub, gr);
            sub.Count++;
        }


        public void GetSubjects()
        {

            if (ListOfSubjects.Count > 0)
            {
                Console.WriteLine($"{GetFullName()} has this subjects!");
                foreach (var subject in ListOfSubjects)
                {
                    Console.WriteLine($"{subject.SubjectName} ");
                }
            }
            else
            {
                Console.WriteLine($"Sorry but {GetFullName()} doesn't have subjects");
            }
        }

        public bool SeeSubject(string frist, List<Student> allStudents, bool c)
        {
            foreach (var sub in allStudents)
            {
                if (sub.FristName.Equals(frist))
                {
                    foreach (var dict in sub.GradesOfSubjects)
                    {
                        Console.WriteLine($"subject : {dict.Key.SubjectName} \n  Grade : {dict.Value}");
                    }
                }
            }

            return c;

        }
    }
}