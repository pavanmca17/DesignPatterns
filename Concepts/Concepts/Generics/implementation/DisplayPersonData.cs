using Models;
using System;


namespace DesignPatterns.Concepts
{
    public class DisplayPersonData : IDisplayData<Person>
    {
        public void Display(Action<Person> display, Func<int, string, string, Person> createpersonobject)
        {
            display(createpersonobject(35, "FirstName", "LastName"));
        }

    }
}
