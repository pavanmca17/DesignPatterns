using System;
namespace ConsoleApp1
{
    public class Person
    {
        public Person()
        {

        }

        public int Age { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }        

        
        public string GetAge()
        {
            return $"Age {Age}";

        }

        public String GetName()
        {
            return $"First Name is {FirstName} and Last Name is {LastName}";
        }

        public String GetPersonDetails()
        {
            return $"First Name is {FirstName} and Last Name is {LastName},the Age of the Person {Age}"  ;
        }
    }
}