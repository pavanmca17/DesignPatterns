

using Models;

namespace DesignPatterns
{
    public class PersonBuilder
    {
        private Person person;
        public PersonBuilder Create()
        {
            person = new Person();
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
        public Person Build()
        {
            return person;
        }
    }
}
