using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Concepts
{
    public static class LoggerFactory
    {
        public static Logger<Author> CreateLogger(LoggerType type)
        {
            Logger<Author> logger = null;
            if (type == LoggerType.File)
            {
                logger = new FileLogger();
               
            }
            else if(type == LoggerType.Xml)
            {
                logger = new XmlLogger();
            }
            return logger;
        }
    }
}
