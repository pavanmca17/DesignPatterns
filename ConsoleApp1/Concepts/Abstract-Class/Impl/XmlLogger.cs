using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concepts
{
    class XmlLogger : Logger<Author>
    {
        public override async Task Log(Author obj)
        {
            await Task.Factory.StartNew(() => { Console.WriteLine($"XmlLogger - Logging Details of the Author - ID {obj.ID} and Name {obj.Name}"); });
        }

        public override void Log()
        {
            Console.WriteLine("Hi - I am Logging for Fun in XmlLogger class");
        }
    }
}
