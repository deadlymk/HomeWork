using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
namespace Classes
{
    public class Trainer : Person
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Subjects> AllSubject { get; set; } = new List<Subjects>();


        public Trainer(string fristt, string lastt,int password)
        {
            FristName = fristt;
            LastName = lastt;
            Password = password;
           
        }
        public Trainer()
        {

        }

        public void SeeAllStudent(List<Student> students)
        {
            int i = 1;
            Console.WriteLine("All students : ");
            foreach (var student in students)
            {
                Console.WriteLine($"{i} : {student.FristName} {student.LastName} ");
                i++;
            }
        }
      

        public void GetAllSubPerPerson(List<Student> allStudents)
        {
            foreach (var item in allStudents)
            {

            }
        }

    }
}
