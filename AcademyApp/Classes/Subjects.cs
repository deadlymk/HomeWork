using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Subjects : Person
    {

        public string SubjectName { get; set; }
        public int NumberOfClasses { get; set; }
        public int Count { get; set; }

        public Subjects(string subjectName, int number)
        {

            SubjectName = subjectName;
            NumberOfClasses = number;
            Count = 0;
        }


       

    }
}