using System;
using System.Threading.Tasks;
using DesignPatterns.Concepts.AbstractClass;
using DesignPatterns.Concepts.Models;

namespace DesignPatterns.Concepts
{
    class XmlLogger : Logger<Author>
    {
        public override async Task Log(Author obj)
        {
            await Task.Factory.StartNew(() => {
                Console.WriteLine($"{nameof(XmlLogger)},{nameof(Log)},Values:{obj.ID}-{obj.Name}");
            });
        }
        
    }
}
