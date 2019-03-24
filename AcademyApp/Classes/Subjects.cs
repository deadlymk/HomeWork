using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class Subjects : Person
    {
        
        public  string SubjectName { get; set; }
        public int Grades { get; set; }

        public Subjects(string subjectName, int grade)
        {

            SubjectName = subjectName;
            Grades = grade;
        }

    }
}
