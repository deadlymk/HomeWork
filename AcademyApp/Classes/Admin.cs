using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Admin : Person
    {
        public Admin(string frist, string last,int _password)
        {
            FristName = frist;
            LastName = last;     
            Password = _password;  
            

        }
        public Admin()
        {

        }
        public void RemoveStudent(List<Student> allStudents)
        {
            Console.WriteLine("type the name of the student to delete it ");
            string inputRemoveStudent = Console.ReadLine();
            // Student asda = new Student(FristName,LastName,Password);

            foreach (var person in allStudents)
            {

                if (person.FristName.Equals(inputRemoveStudent))
                {
                    allStudents.Remove(person);
                    break;
                }
            }
        }
           public void RemoveTrainer(List<Trainer> allTrainers)
            {
            Console.WriteLine("type the name of the trainer to delete it ");
            
            
            string inputRemoveTrainer = Console.ReadLine();

            foreach (var person in allTrainers)
            {
                if (person.FristName.Equals(inputRemoveTrainer))
                {
                    allTrainers.Remove(person);
                     break;
                }
            }

           }
        public void RemoveAdmin(List<Admin> allAdmins, Admin admince)
        {
            Console.WriteLine("type the name of the admin to delete it ");
            string adminName = Console.ReadLine();
            Console.WriteLine("type the lastname of the admin to delete it ");
            string adminLastName = Console.ReadLine();


        }
        

      
           

    }
}
