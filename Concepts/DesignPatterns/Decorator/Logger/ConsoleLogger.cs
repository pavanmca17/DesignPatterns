using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Decorator.Logger
{
    class ConsoleLogger : ILogger
    {
        public void Log(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
