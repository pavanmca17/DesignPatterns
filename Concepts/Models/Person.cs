﻿namespace Models
{
    public class Person
    {
        public Person()
        {
            Address = new Address();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return FirstName;
        }
    }
}
