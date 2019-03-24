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

        

      


    }
 }
