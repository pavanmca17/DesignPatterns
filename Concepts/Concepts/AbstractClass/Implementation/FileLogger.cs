using DesignPatterns.Models;
using LoggerService;
using System;
using System.Threading.Tasks;


namespace DesignPatterns.Concepts
{
    public class FileLogger : Logger<Author>
    {
        public override async Task Log(Author obj)
        {
            await Task.Factory.StartNew(() => {
                Console.WriteLine($"{nameof(FileLogger)},{nameof(Log)},Values:{obj.ID}-{obj.Name}");
            });
        }

        public override void Log()
        {
            base.Log();          
        }
    }
}
