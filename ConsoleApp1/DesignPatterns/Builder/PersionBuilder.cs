using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builder
{
    public class PersonBuilder
    {
        private Person person;

        public PersonBuilder Create()
        {
            person = new Person();
            return this;

        }

        public PersonBuilder FirstName(String firstName)
        {
            person.FirstName = firstName;
            return this;
        }

        public PersonBuilder LastName(String lastName)
        {
            person.LastName = lastName;
            return this;
        }

        public PersonBuilder Age(int age)
        {
            person.Age = age;
            return this;
        }

        public PersonBuilder City(String City)
        {
            person.Address.City = City;
            return this;
        }

        public PersonBuilder StreetAddress(String StreetAddress)
        {
            person.Address.StreetAddress = StreetAddress;
            return this;
        }

        public Person Build()
        {
            return person;
        }
    }
}
