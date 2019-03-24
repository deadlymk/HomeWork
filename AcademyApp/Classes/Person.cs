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
        public Role RoleOfppl { get; set; }
        
        public List<Subjects> StudentSubjects { get; set; }

        public Person()
        {
            StudentSubjects = new List<Subjects>();
        }
        public string GetFullName()
        {
            return FristName + " " + LastName;
        }

        public Person(string fristName,string lastName,int pw)
        {
            FristName = fristName;
            LastName = lastName;
            Password = pw;
        }

      


    }
 }
