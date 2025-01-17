﻿using Models;
using System.Collections.Generic;

namespace DesignPatterns.LINQ
{
    public class TestData
    {
        public List<Person> persons = new List<Person>();
        public List<Pet> pets;

        public void CreateData()
        {
            // Create an array of Pets.
           pets =  new List<Pet>()
                                { new Pet { Name="Barley", Age=10 ,Vaccinated=true },
                                  new Pet { Name="Boots", Age=4, Vaccinated=true},
                                  new Pet { Name="Whiskers", Age=6, Vaccinated=true } 
                                };

            Person person = null;
            for(int i = 0; i < 100; i++)
            {
                person = new Person() { Age= 30 + i, FirstName="FirstName" + i.ToString(), LastName="LastName" + i.ToString() };
                persons.Add(person); 
            }
        }
    }
}
