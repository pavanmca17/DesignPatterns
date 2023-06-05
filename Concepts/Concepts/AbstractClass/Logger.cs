using System;
using System.Threading.Tasks;

namespace DesignPatterns.Concepts
{
    public abstract class Logger<T> where T : class, new()
    {
        public abstract Task Log(T obj); 
        
        public virtual void Log()
        {
            Console.WriteLine($"{nameof(Logger<T>)},{nameof(Log)}");
        }
    }
}
