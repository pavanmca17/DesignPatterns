﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IDisplayData<T> where T : class
    {
       void Display(Action<T> display, Func<int, string, string, T> createT);
       
    }
}