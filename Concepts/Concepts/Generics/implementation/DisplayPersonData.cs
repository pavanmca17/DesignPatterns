using Models;
using System;


namespace DesignPatterns.Concepts
{
    public class DisplayPersonData : IDisplayData<Person>
    {
        public void Display(Action<Person> display, Func<string, string, int, Person> create)
        {
            display(create("FirstName","LastName",25));
        }

    }
}
