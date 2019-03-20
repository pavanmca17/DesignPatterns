using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builder
{
    
    public class Person
    {
        public Person()
        {
            Address = new Address();
        }
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public int Age { get; set; }

        public String Sex { get; set; }

        public Address Address { get; set; }


    }
}
