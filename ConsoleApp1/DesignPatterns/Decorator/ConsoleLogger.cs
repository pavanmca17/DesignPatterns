using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Decorator
{
    class ConsoleLogger : ILogger
    {
        public void Log(String Message)
        {
            Console.WriteLine(Message);
        }
    }
}
