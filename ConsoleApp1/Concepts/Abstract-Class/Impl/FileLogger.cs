using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concepts
{
    public class FileLogger : Logger<Author>
    {
        public override async Task Log(Author obj)
        {
            await Task.Factory.StartNew(() => { Console.WriteLine($"FileLogger - Logging Details of the Author - ID {obj.ID} and Name {obj.Name}"); } );
        }

        public override void Log()
        {
            base.Log();
            Console.WriteLine("Hi - I am Logging for Fun in FileLogger class");
        }
    }
}
