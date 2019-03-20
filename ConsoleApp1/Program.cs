
using GenericRepository;
using GenericRepositorySample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Concepts;
using ConsoleApp1.Strategy;
using ConsoleApp1.Strategy.Models;
using ConsoleApp1;
using ConsoleApp1.Builder;
using ConsoleApp1.Adapter;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TasksWithActionsExample().GetAwaiter().GetResult();
            // DisplayPersonData();
            // CreateLoggerTask().GetAwaiter().GetResult();
            // PostRepositoryTask().GetAwaiter().GetResult();
            // GetEmployeeDataTask().GetAwaiter().GetResult();
            //Test();
            Test().GetAwaiter().GetResult();
            BuilderTest();
            AdapterTest();
            Console.ReadLine();


        }


        private static async Task GetEmployeeDataTask()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<Employee> employees = await employeeRepository.GetData();

        }

        private static async Task Test()
        {
            float costPrice = 1200;
            float sellingPrice;
            IPricestrategy pricestrategy;
            Discount discount;
            pricestrategy = new NullPriceStrategy();
            discount = await pricestrategy.GetDiscount();
            sellingPrice = costPrice - discount.DiscountAmount;
            Console.WriteLine($"Cost Price, {costPrice} - Discount, {discount.DiscountAmount} - Selling Price {sellingPrice}");
            pricestrategy = new GoldMemberPriceStrategy();
            discount = await pricestrategy.GetDiscount();
            sellingPrice = costPrice - discount.DiscountAmount;
            Console.WriteLine($"Cost Price, {costPrice} - Discount, {discount.DiscountAmount} - Selling Price {sellingPrice}");
            pricestrategy = new SilverMemberPriceStrategy();
            discount = await pricestrategy.GetDiscount();
            sellingPrice = costPrice - discount.DiscountAmount;
            Console.WriteLine($"Cost Price, {costPrice} - Discount, {discount.DiscountAmount} - Selling Price {sellingPrice}");
            


        }

        private static async Task CreateLoggerTask()
        {
            Logger<Author> logger = LoggerFactory.CreateLogger(LoggerType.File);
            Func<Author> createAuthor = () => { return new Author() { ID = 1, Name = "Pavan Kumar Pannala" }; };
            await logger.Log(createAuthor());
            logger.Log();
            logger = LoggerFactory.CreateLogger(LoggerType.Xml);
            await logger.Log(createAuthor());
            logger.Log();

        }

        private static async Task PostRepositoryTask()
        {
            PostRepository postRepository = new PostRepository();
            Task<Post> postTask = postRepository.GetData();
            Post post = await postTask;
            Task<Result<int>> resultTask = postRepository.SaveData(post);
            Result<int> result = await resultTask;
        }

        private static async Task TasksWithActionsExample()
        {
           // Action Delegates
            Action<int> getint = (i) => { Console.WriteLine("Action method Displaying Integer" + i); };

            Action<String> getstring = (s) => { Console.WriteLine("Action method Displaying String" + s); };

            Action<Person> displayPerson = (p) =>
            {
                p.GetPersonDetails();
            };


            //Use a Function to Create and Return a Object of Person Type
            Func<int, string, string, Person> createpersonobject = (_Age, _FirstName, _LastName) => { return new Person() { Age = _Age, FirstName = _FirstName, LastName = _LastName }; };

           // Passing Actions to Tasks
            await Task.Factory.StartNew(() => { getint(10); });

            await Task.Factory.StartNew(() => { getstring("Hello Test"); }).ContinueWith(t => { Console.WriteLine("Starting After Completion of Hello Test"); });

            await Task.Factory.StartNew(() => { displayPerson(createpersonobject(35, "Pavan", "Kumar")); });

        }

        private static async Task<bool> TasksWithFunctionsExample()
        {
           // Function Delegates
            Func<Person, String> getName = (p) => { return p.GetName(); };

            Func<String, bool> checkfilepath = (filepath) =>
            {
                return System.IO.File.Exists(filepath);

            };

          //  Task < String > using Functions
            Task<String> dataTask = Task.Factory.StartNew<String>(() => { return "Pavan Kumar Pannala"; });
            String data = await dataTask;
            Console.WriteLine(data);

           // Use a Function to Create and Return a Object of Person Type
            Func<int, string, string, Person> createpersonobject = (_Age, _FirstName, _LastName) => { return new Person() { Age = _Age, FirstName = _FirstName, LastName = _LastName }; };

            Func<Person> getperson = () => { return new Person() {  }; };

            Func<int, int> calcsquare = (i) => { return i * i; };

            GetAllSquares(new List<int>() { 1, 2, 3 }, calcsquare);

            Task<String> nameTask = Task.Factory.StartNew<String>(() => getName(createpersonobject(35, "Pavan", "Kumar")));

            String name = await nameTask;

            Console.WriteLine(name);

            var Task1 = new Task(() => { Console.WriteLine("StartTasksAfterCreation"); });
            Task1.Start();

            Task<bool> booltask1 = Task.Factory.StartNew(() => checkfilepath("D://Testfile1.txt"));

            Task<bool> booltask2 = Task.Factory.StartNew(() => checkfilepath("D://Testfile2.txt"));

            Task<bool> completedTask = await Task.WhenAny(booltask1, booltask2);

            bool retvalue = await completedTask;

            return retvalue;

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
            ConsoleApp1.Builder.Person person = new PersonBuilder().Create()
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

