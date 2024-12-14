

using System;

namespace DesignPatterns
{
    class ConsoleLogger : ILogger
    {
        public void Log(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
