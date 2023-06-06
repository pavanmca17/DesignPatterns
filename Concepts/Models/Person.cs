
namespace DesignPatterns
{
    public class Person
    {
        public Person()
        {

        }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }   
               
        public string GetAge()
        {
            return $"Age {Age}";
        }
        public string GetName()
        {
            return $"First Name is {FirstName} and Last Name is {LastName}";
        }
        public string GetPersonDetails()
        {
            return $"First Name is {FirstName} and Last Name is {LastName},the Age of the Person {Age}"  ;
        }
    }
}