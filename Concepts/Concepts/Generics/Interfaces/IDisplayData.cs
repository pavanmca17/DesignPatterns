using System;


namespace DesignPatterns.Concepts
{
    public interface IDisplayData<T> where T : class, new()
    {
       void Display(Action<T> display, Func<string, string,int, T> create);
       
    }
}
