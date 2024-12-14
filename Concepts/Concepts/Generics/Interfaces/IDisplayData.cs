using System;


namespace DesignPatterns.Concepts
{
    public interface IDisplayData<T> where T : class
    {
       void Display(Action<T> display, Func<int, string, string, T> createT);
       
    }
}
