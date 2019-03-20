using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concepts
{
    public abstract class Logger<T> where T : class, new()
    {
        public abstract Task Log(T obj); 
        
        public virtual void Log()
        {
            Console.WriteLine("Hi - I am Logging for Fun in base class");
        }
    }
}
