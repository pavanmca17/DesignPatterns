﻿using DesignPatterns.Models;
using System;
using System.Threading.Tasks;


namespace LoggerService
{
    public class DataBaseLogger : Logger<Author>
    {
        public override async Task Log(Author obj)
        {
            await Task.Factory.StartNew(() => {
                   Console.WriteLine($"{nameof(DataBaseLogger)},{nameof(Log)},Values:{obj.ID}-{obj.Name}");
            });
        }

        public override void Log()
        {
            base.Log();           
        }
    }
}
