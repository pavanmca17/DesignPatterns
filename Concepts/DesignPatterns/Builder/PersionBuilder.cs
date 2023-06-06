using System;
using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder
{
    public class PersonBuilder
    {
        private PersonDTO person;
        public PersonBuilder Create()
        {
            person = new PersonDTO();
            return this;
        }
        public PersonBuilder FirstName(string firstName)
        {
            person.FirstName = firstName;
            return this;
        }
        public PersonBuilder LastName(string lastName)
        {
            person.LastName = lastName;
            return this;
        }
        public PersonBuilder Age(int age)
        {
            person.Age = age;
            return this;
        }     

        public PersonBuilder StreetAddress(string StreetAddress)
        {
            person.Address.StreetAddress = StreetAddress;
            return this;
        }
        public PersonDTO Build()
        {
            return person;
        }
    }
}
