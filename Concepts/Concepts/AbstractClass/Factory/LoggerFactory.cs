﻿

using DesignPatterns.Concepts.AbstractClass;
using DesignPatterns.Concepts.Models;

namespace DesignPatterns.Concepts
{
    public static class LoggerFactory
    {
        public static Logger<Author> CreateLogger(LoggerType type)
        {
            Logger<Author> _logger = null;

            if (type == LoggerType.File)
            {
                _logger = new FileLogger();
               
            }
            else if(type == LoggerType.Xml)
            {
                _logger = new XmlLogger();
            }
            else if(type == LoggerType.DataBase)
            {
                _logger = new DataBaseLogger();
            }

            return _logger;
        }
    }
}
