
using GenericRepository;
using GenericRepositorySample;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesignPatterns.Concepts;
using DesignPatterns.Strategy.Models;
using DesignPatterns.Builder;
using DesignPatterns.Adapter;
using DesignPatterns.Concepts.AbstractClass;
using DesignPatterns.DesignPatterns.Strategy;
using DesignPatterns.DesignPatterns.EntityFactory;
using DesignPatterns.DesignPatterns;
using DesignPatterns.Concepts.Models;
using DesignPatterns.Concepts.Generics;

namespace DesignPatterns
{
    class Program
    {
        public static async Task Main(string[] args)
        {
           
            Console.ReadLine();

        }
        private static async Task GenericRepository()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<Employee> employees = await employeeRepository.GetData();            
        }

        static async Task StrategyPatternExample()
        {
            const float costPrice = 1200;
            float sellingPrice = 0;
            Discount _discount = null;

            IPriceStrategy _priceStrategy = null;     
            IEntityFactory _entityFactory = new EntityFactor();

            _priceStrategy = await _entityFactory.GeneratePriceStrategyEntity(PriceStrategyType.Null);
            _discount = await _priceStrategy.GetDiscount();
            sellingPrice = costPrice - _discount.DiscountAmount;
            Console.WriteLine($"Cost Price, {costPrice} - Discount, {_discount.DiscountAmount} - Selling Price {sellingPrice}");

            _priceStrategy = await _entityFactory.GeneratePriceStrategyEntity(PriceStrategyType.SilverMember);
            _discount = await _priceStrategy.GetDiscount();
            sellingPrice = costPrice - _discount.DiscountAmount;
            Console.WriteLine($"Cost Price, {costPrice} - Discount, {_discount.DiscountAmount} - Selling Price {sellingPrice}");

            _priceStrategy = await _entityFactory.GeneratePriceStrategyEntity(PriceStrategyType.GoldMember);
            _discount = await _priceStrategy.GetDiscount();
            sellingPrice = costPrice - _discount.DiscountAmount;
            Console.WriteLine($"Cost Price, {costPrice} - Discount, {_discount.DiscountAmount} - Selling Price {sellingPrice}");
        }

        private static async Task CreateLoggerTaskUsingFactorPattern()
        {
            Logger<Author> logger = LoggerFactory.CreateLogger(LoggerType.File);
            logger.Log();
            Func<Author> createAuthor = () => { return new Author() { ID = 1, Name = "First-Name" }; };          
            await logger.Log(createAuthor());
           
            logger = LoggerFactory.CreateLogger(LoggerType.Xml);
            logger.Log();
            await logger.Log(createAuthor());       

        }
        private static async Task GenericRepositoryUsage()
        {
            PostsRepository PostsRepository = new PostsRepository();
            Posts Posts = await PostsRepository.GetData();           
            Result<int> result = await PostsRepository.SaveData(Posts);
            Console.WriteLine($"Return Value{result}");
        }

        private static async Task TasksWithActionsExample()
        {
           // Action Delegates
            Action<int> getint = (i) => { Console.WriteLine($"Action method Displaying Integer {i}"); };

            Action<string> getstring = (str) => { Console.WriteLine($"Action method Displaying String {str}"); };

            Action<Person> displayPerson = (person) =>
            {
                person.GetPersonDetails();
            };


            //Use a Function to Create and Return a Object of Person Type
            Func<int, string, string, Person> createpersonobject = (_Age, _FirstName, _LastName) => {
                   return new Person() { Age = _Age, FirstName = _FirstName, LastName = _LastName };
            };

           // Passing Actions to Tasks
            await Task.Factory.StartNew(() => { getint(10); });

            await Task.Factory.StartNew(() => {  getstring("Hello Test");
                                              }).ContinueWith(t => { 
                                                  Console.WriteLine("Starting After Completion of Hello Test");
                                                 });

            await Task.Factory.StartNew(() => { displayPerson(createpersonobject(35, "FirstName", "LastName")); });

        }

        private static async Task<bool> TasksWithFunctionsExample()
        {
           // Function Delegates
            Func<Person, string> getName = (person) => { return person.GetName(); };

            Func<string, bool> checkfilepath = System.IO.File.Exists;

          //  Task < String > using Functions
            Task<string> dataTask = Task.Factory.StartNew(() => { return "data"; });
            var data = await dataTask;
            Console.WriteLine(data);

           // Use a Function to Create and Return a Object of Person Type
            Func<int, string, string, Person> createperson = (_Age, _FirstName, _LastName) => { 
                 return new Person() { Age = _Age, FirstName = _FirstName, LastName = _LastName }; 
            };

            Func<Person> getperson = () => { return new Person() {  }; };

            Func<int, int> calcsquare = (i) => { return i * i; };

            GetAllSquares(new List<int>() { 1, 2, 3 }, calcsquare);

            Task<string> nameTask = Task.Factory.StartNew(() => getName(createperson(35, "FirstName", "LastName")));
            var name = await nameTask;
            Console.WriteLine(name);

            var task1 = new Task(() => { Console.WriteLine("StartTasksAfterCreation"); });
            task1.Start();

            Task<bool> booltask1 = Task.Factory.StartNew(() => checkfilepath("D://Testfile1.txt"));

            Task<bool> booltask2 = Task.Factory.StartNew(() => checkfilepath("D://Testfile2.txt"));

            Task<bool> completedTask = await Task.WhenAny(booltask1, booltask2);           

            return await completedTask; ;

        }

        private static void DisplayPersonData()
        {
            DisplayPersonData displayPersonData = new DisplayPersonData();
            Func<int, string, string, Person> createpersonobject = (_Age, _FirstName, _LastName) => { return new Person() { Age = _Age, FirstName = _FirstName, LastName = _LastName }; };
            Action<Person> displayperson = (p) => { Console.WriteLine(p.ToString()); };
            displayPersonData.Display(displayperson, createpersonobject);
        }

        private static void GetAllSquares(List<int> values, Func<int, int> calcsquare)
        {
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(calcsquare(values[i]));
            }
        }

        private static void BuilderTest()
        {
            Person person = new PersonBuilder().Create()
                                                    .FirstName("Pavan Kumar")
                                                    .LastName("Pannala")
                                                    .Age(35)
                                                    .StreetAddress("Moti Nagar")
                                                    .City("Hyderabad")
                                                    .Build();

        }

        private static void AdapterTest()
        {
            String data = string.Empty;
            IGetDataAdapter getDataAdapter;
            getDataAdapter = new JsonAdapter();
            data = getDataAdapter.GetData();

        }
    }
}

