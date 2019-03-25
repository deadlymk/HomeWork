using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public int Password { get; set; }
        public int Age { get; set; }
        
        
        public List<Subjects> StudentSubjects { get; set; }

       
        public string GetFullName()
        {
            return FristName + " " + LastName;
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
        public void SeeallTrainers(List<Trainer> trainers)
        {
            int i = 1;
            Console.WriteLine("all trainers");
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{i} : {trainer.FristName}");
            }
        }
        public void SeeAllAdmins(List<Admin> allAdmins)
        {
            int i = 1;
            Console.WriteLine("all admins:");

            foreach (var admin in allAdmins)
            {
                Console.WriteLine($"{i} : {admin.FristName}  {admin.LastName}" );
            }
        }




    }
 }
