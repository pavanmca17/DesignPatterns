using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Concepts.Generics.implementation
{
    public class DisplayPersonData : IDisplayData<Person>
    {
        public void Display(Action<Person> display, Func<int, string, string, Person> createpersonobject)
        {
            display(createpersonobject(35, "Pavan", "Kumar"));
        }

    }
}
