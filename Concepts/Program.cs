﻿using System;
using GenericRepository;
using System.Collections.Generic;
using System.Threading.Tasks;
using DesignPatterns.GenericRepository;
using DesignPatterns.Models;
using Models;
using DesignPatterns.Concepts;
using LoggerService;


namespace DesignPatterns
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await GenericRepository();
            await StrategyPattern();
            await CreateLogger();
            await GenericRepository();           
            BuilderPatternUsage();
            await AdapterPattern();
            Console.ReadLine();
        }
       
        static async Task StrategyPattern()
        {
            Console.WriteLine($"Starting----{nameof(StrategyPattern)}---Demo");
            
            const float costPrice = 1200;
            float sellingPrice = 0;
            Discount _discount = null;

            IPriceStrategy _priceStrategy = new NullPriceStrategy();

           
            _discount = await _priceStrategy.GetDiscount();
            sellingPrice = costPrice - _discount.DiscountAmount;
            Console.WriteLine($"Cost Price, {costPrice} - Discount, {_discount.DiscountAmount} - Selling Price {sellingPrice}");


            _priceStrategy = new SilverMemberPriceStrategy();
            _discount = await _priceStrategy.GetDiscount();
            sellingPrice = costPrice - _discount.DiscountAmount;
            Console.WriteLine($"Cost Price, {costPrice} - Discount, {_discount.DiscountAmount} - Selling Price {sellingPrice}");

            _priceStrategy = new GoldMemberPriceStrategy();
            _discount = await _priceStrategy.GetDiscount();
            sellingPrice = costPrice - _discount.DiscountAmount;
            Console.WriteLine($"Cost Price, {costPrice} - Discount, {_discount.DiscountAmount} - Selling Price {sellingPrice}");

            Console.WriteLine($"End of----{nameof(StrategyPattern)}---Demo");
        }

        private static async Task CreateLogger()
        {
            Console.WriteLine($"Starting----{nameof(CreateLogger)}---Demo");

            Logger<Author> logger = LoggerFactory.CreateLogger(LoggerType.File);
            logger.Log();
            Func<Author> createAuthor = () => { return new Author() { ID = 1, Name = "First-Name" }; };          
            await logger.Log(createAuthor());
           
            logger = LoggerFactory.CreateLogger(LoggerType.Xml);
            logger.Log();
            await logger.Log(createAuthor());

            Console.WriteLine($"End of ----{nameof(CreateLogger)}---Demo");

        }
        private static async Task GenericRepository()
        {
            Console.WriteLine($"Starting----{nameof(GenericRepository)}---Demo");

            IGenericRepository<Employee> employeeRepository = new EmployeeRepository();
            Func<int, string, Employee> createEmployee = (_ID, _Name) => { return new Employee() { ID = _ID, Name = _Name }; };
            employeeRepository.SaveData(createEmployee(1, "Test"));
            List<Employee> employees = await employeeRepository.GetData();


            PostsRepository PostsRepository = new PostsRepository();
            Posts Posts = await PostsRepository.GetData();           
            Result<int> result = await PostsRepository.SaveData(Posts);
            Console.WriteLine($"Return Value{result}");

            Console.WriteLine($"Starting----{nameof(GenericRepository)}---Demo");
        }

        private static async Task ActionDelegate()
        {
            Console.WriteLine($"Starting----{nameof(ActionDelegate)}---Demo");
            // Action Delegates
            Action<int> getint = (i) => { Console.WriteLine($"Action method Displaying Integer {i}"); };

            Action<string> getstring = (str) => { Console.WriteLine($"Action method Displaying String {str}"); };

            Action<Person> displayPerson = (person) =>
            {
                person.ToString();
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

            Console.WriteLine($"End of----{nameof(ActionDelegate)}---Demo");

        }

        private static async Task<bool> FunctionDelegate()
        {
            Console.WriteLine($"Start of----{nameof(FunctionDelegate)}---Demo");

            // Function Delegates
            Func<Person, string> getName = (person) => { return person.FirstName + " " + person.LastName; };

            Func<string, bool> checkfilepath = System.IO.File.Exists;

          
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

            Console.WriteLine($"End of----{nameof(FunctionDelegate)}---Demo");

            return await completedTask; 

        }

        private static void DisplayPersonData()
        {
            Console.WriteLine($"Start----{nameof(DisplayPersonData)}---Demo");

            DisplayPersonData displayPersonData = new DisplayPersonData();
            Func<int, string, string, Person> createpersonobject = (_Age, _FirstName, _LastName) => { return new Person() { Age = _Age, FirstName = _FirstName, LastName = _LastName }; };
            Action<Person> displayperson = (p) => { Console.WriteLine(p.ToString()); };
            displayPersonData.Display(displayperson, createpersonobject);

            Console.WriteLine($"End of----{nameof(DisplayPersonData)}---Demo");
        }

        private static void GetAllSquares(List<int> values, Func<int, int> calcsquare)
        {
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(calcsquare(values[i]));
            }
        }

        private static void BuilderPatternUsage()
        {
            Console.WriteLine($"Start----{nameof(BuilderPatternUsage)}---Demo");
            Person person = new PersonBuilder().Create()
                                                    .FirstName("FirstName")
                                                    .LastName("LastName")
                                                    .Age(40)
                                                    .StreetAddress("StreetAddress")                                                 
                                                    .Build();
            Console.WriteLine(person.ToString());
            Console.WriteLine($"End of----{nameof(BuilderPatternUsage)}---Demo");
        }

        private static async Task AdapterPattern()
        {
            Console.WriteLine($"Start----{nameof(AdapterPattern)}---Demo");
            IGetData getData = null;

            getData = new JsonAdapter();
            var jsonData = await getData.GetData();
            Console.WriteLine($"{jsonData}");

            getData = new XmlAdapter();
            var xmldata = await getData.GetData();
            Console.WriteLine($"{xmldata}");

            Console.WriteLine($"End of----{nameof(AdapterPattern)}---Demo");
        }
    }
}

