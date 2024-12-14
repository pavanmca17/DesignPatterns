using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.LINQ
{
    public class LinqSample
    {
        private TestData testData;

        public LinqSample()
        {
            testData = new TestData();
            testData.CreateData();
        }

        public async Task<Person> GetPersonByAgeFirstOrDefault(int age)
        {
            return await Task.FromResult(testData.persons.Where(p => p.Age == age).FirstOrDefault());
        }

        public async Task<Person> GetPersonByAgeFirst(int age)
        {
            return await Task.FromResult(testData.persons.Where(p => p.Age == age).First());
        }

        public async Task<List<Person>> GetPersonByAgeRange(int age)
        {
            return await Task.FromResult(testData.persons.Where(p => p.Age >= age && p.Age <= age).ToList());
        }

        public async Task<string> GetPersonByAge(int age)
        {
            return await Task.FromResult(testData.persons.Where(p => p.Age == age).Select(p => p.FirstName).First());
        }

        private void AllClause()
        {
            bool allStartWithB = testData.pets.All(pet => pet.Name.StartsWith("B") && pet.Age > 5);
        }


    }
}
