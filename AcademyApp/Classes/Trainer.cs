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
        public Role RoleOfTrainer { get; set; }

        public Trainer(string fristt, string lastt,int password)
        {
            FristName = fristt;
            LastName = lastt;
            Password = password;
            RoleOfTrainer = Role.Trainer;
        }
    }
}
