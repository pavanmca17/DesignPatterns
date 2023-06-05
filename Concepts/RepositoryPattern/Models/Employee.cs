using System;


namespace GenericRepository
{
    public class Employee 
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string GetLogMessage()
        {
            return "Logging using Generics ID:" + ID + "Name is" + Name;
        }

       
    }
}
