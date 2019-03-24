using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Admin : Person
    {
        public Role RoleOfAdmin { get; set; }
       


        public Admin(string frist, string last,int _password)
        {
            FristName = frist;
            LastName = last;     
            Password = _password;  
            RoleOfAdmin = Role.Admin;

        }

      
           

    }
}
