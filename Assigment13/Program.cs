using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assigment13
{
    internal class Program
    {
        //3 delegate
        public delegate double OperationDelegate(double x, double y);
        public delegate double add(double x, double y);
        public delegate double sub(double x, double y);
        public delegate double mult(double x, double y);
        public delegate double div(double x, double y);

        //4
        private static bool flag = true;

        //5
        public delegate void GreetDelegate(string str);

        //8.
        public delegate string StringOperationDelegate(string str);

        //10.
        public delegate int CalculationDelegate(int x, int y);
        
        
        static void Main(string[] args)
       //static  async Task Main(string[] args)  //for qn no:13
        {

            //1.Create an anonymous type to represent a book with properties for Title, Author, and Price.
            //Display the details of the book. 

            // var b1 = new { Title = " I AM MALALA", Author = "MALALA", price = 350 };
            // Book.Display(b1);


            // 2. Declare a var variable to hold a list of integers, add some numbers to it, and print them. 

            //var v1 = new VarDynamic();
            //var v2 = new VarDynamic();
            //var v3 = new VarDynamic();
            //var v4 = new VarDynamic();
            //v1.add(1);
            //v1.Display();
            //v2.add(2);
            //v2.Display();
            //v3.add(3);
            //v3.Display();

            ////2.Declare a dynamic variable, assign different types of values to it, and observe the
            //////behavior
            //dynamic d1 = 21;
            //dynamic d2 = 1.2;
            //dynamic d3 = "Norah";
            //dynamic[] d4 = { 1, 2, 3 };
            //Console.WriteLine("\n");
            //Console.WriteLine($"{d1}------{d1.GetTypeCode()}");
            //Console.WriteLine($"{d2}------{d2.GetTypeCode()}");
            //Console.WriteLine($"{d3}------{d3.GetTypeCode()}");
            //Console.WriteLine($"{d4}------{d4.GetType()}");


            //3. delegate

            //Calculator cal = new Calculator();
            //Console.WriteLine("ENTER THE FIRST NUMBER: ");
            //double Num1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("ENTER THE SECOND NUMBER: ");
            //double Num2 = double.Parse(Console.ReadLine());
            //double ans = cal.Operation(Num1, Num2);
            //Console.WriteLine("\n");
            //Console.WriteLine("Answer is  :" + ans);

            //4.event
            //Event e = new Event();
            //e.OnCompleted += event_handler;
            //while (flag)
            //{
            //    Console.WriteLine("enter the numbers");
            //    int val = int.Parse(Console.ReadLine());
            //    e.counter();
            //    if (val > 50)
            //    {
            //        Console.WriteLine("--greater than 50--");
            //        break;
            //    }

            //}



            //5.Write a delegate GreetDelegate that takes a string parameter. Assign an anonymous method to
            //the delegate that prints a greeting message.

            //GreetDelegate g = delegate (string name)
            //{
            //    Console.WriteLine($"hi----{name}");
            //};
            //g("norah");


            //6.Write a lambda expression that takes two integers and returns their product. Use Func<int, int,
            // int> for the delegate type.

            //Func<int, int, int> func =    //takes two input and return one int=3 int
            //    (x, y) =>
            //    {
            //        return x * y;
            //    };

            //Console.WriteLine($"product is:{func(2, 3)}");


            //7.Create an expression tree for a lambda expression that adds two integers. Compile and execute
            // the expression

            //create expression
            //Expression<Func<int, int, int>> Add = (x, y) => x + y;
            //Func<int, int, int> addFunction = Add.Compile(); //COMPILES USABLE DELEGATE

            //// Execute the compiled function
            //int result = addFunction(5, 3);

            //// Display the result
            //Console.WriteLine($"The sum  is: {result}");

            //8.Create a delegate called StringOperationDelegate that accepts a string parameter and returns a
            //string.Write three different methods that modify the string in different ways(e.g., convert to
            //uppercase, reverse, add a prefix). Use the delegate to call each method. 

            //Event e = new Event();
            //StringOperationDelegate st = new StringOperationDelegate(e.Uppercase);
            //string ans = e.Uppercase("norah");
            //Console.WriteLine($"UPPERCASE:{ans}");
            //Console.WriteLine("\n");

            //st = e.Lowercase;
            //ans = st("HI HOW");
            //Console.WriteLine($"LOWER CASE:{ans}");

            //st += e.Remove;
            //Console.WriteLine("\n");
            //ans = st("martinmanuel");
            //Console.WriteLine($"remove :{ans}");

            //8  Given a list of products with properties Name and Price,

            //Product[] product =
            //{
            //    new Product(){name="keyboard",price=3500},
            //    new Product(){name="mouse",price=200},
            //    new Product(){name="phone",price=35000},
            //    new Product(){name="bottle",price=250},
            //    new Product(){name="ring",price=20}
            //};
            //////Filter the list to find products that cost more than $50

            //Product[] products = product.Where(p => p.price > 50).ToArray();
            //foreach (Product p1 in products)
            //{
            //    Console.WriteLine($"{p1.name}------{p1.price}");

            //}
            //////Sort the list by price in descending ord
            //Product[] product1 = product.OrderByDescending(p => p.price).ToArray();
            //Console.WriteLine("\n");
            //Console.WriteLine("sort......");
            //foreach (Product p2 in product1)
            //{
            //    Console.WriteLine($"{p2.name}------{p2.price}");

            //}
            //////Select and display only the names of products from the filtered list.
            //Product[] product2 = product.OrderBy(p => p.name).ToArray();
            //Console.WriteLine("\n");
            //foreach (Product p3 in product2)
            //{
            //    Console.WriteLine($"{p3.name}");

            //}

            //10.
            //Calculate C = new Calculate();
            //CalculationDelegate c1 = new CalculationDelegate(C.Add);
            //int ans = c1(2, 5);
            //Console.WriteLine($"the sum is:{ans}");
            //Console.WriteLine("\n");
            //c1 += C.Sub;
            //int ans2 = c1(5, 2);
            //Console.WriteLine($"the differnce is:{ans2}");


            // 11   Write a C# program that simulates a long-running operation using Task.Delay() and runs
            //  asynchronously. Display a message before and after the operation completes.



            //Method1(); //2 methods for asynchronous
            //Method2();

            //12.Create a method that downloads data from a sample URL asynchronously. Use HttpClient to
            //    fetch the data and print the length of the content. The method should use async and await
            //
            //keywords

            //try
            //{
            //    string url = "https://www.w3schools.com/"; /*"www.example.com";*/
            //    Download.Call(url);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //13.Write a C# program that calculates the sum of an array of integers asynchronously using
            //Task<int>.Return the result from the asynchronous method and display it. 
            //14.Modify the previous example to handle exceptions that might occur during the sum calculation.
            //Catch the exception in the Main method and display an error message.

            //try
            //{
            //    await Common();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("\n--finally--");
            //}


            //15.Create a program that runs multiple tasks in parallel to simulate multiple operations, such as
            //calculating the factorial of different numbers. Print the result of each task when completed.
            //int[] numbers = { 5, 12, 3 };

            //// Use Parallel.ForEach to calculate factorials in parallel
            //Parallel.ForEach(numbers, number =>
            //{
            //    long result = ParallelClass.Factorial(number);
            //    Console.WriteLine("Factorial of " + number + " is " + result);
            //});

            //Console.WriteLine("Complete.");

            //16.
            //Write a LINQ query using both query syntax and method syntax to retrieve all
            //  numbers greater than 5 from a list of integers.

            //int[] arr = { 1, 2, 78, 34, 56, 79, 100, 34, 3 };

            ////QEURY SYNTAX
            //var result = from x in arr
            //             where x > 5 
            //             select x;
            //foreach(var i in result)
            //{
            //    Console.WriteLine(i);

            //}
            ////METHOD
            //Console.WriteLine("\n");
            //var result2 = arr.Where(x => x > 5);
            //foreach(var i in result2)
            //{
            //    Console.WriteLine(i);

            //}

            //17.Given a list of strings representing student names, write a LINQ query that selects
            //the names starting with the letter 'A' and orders them alphabetically. 

            //List<string> list = new List<string>();
            //list.Add("Aorah");
            //list.Add("Martin");
            //list.Add("Ahelsa");
            //list.Add("Isabella");
            //var result = from x in list
            //             where x.StartsWith("A")
            //             orderby x
            //             select x;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //method2
            //var result2 = list.Where(x => x.StartsWith("A")).OrderBy(x => x);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //18.Write a LINQ query to find the sum of all even numbers in an array of integers.
            //int[] arr = { 1, 2, 3, 4, 5 };
            //var result = arr.Where(x =>x %2==0).Sum();
            //Console.WriteLine($"sum is:{result}");

            //19.: Create an XML document representing a list of books, and use LINQ to XML to
            //query the titles of books published after 2015.
            //XDocument xmlDocument = XDocument.Load("C:\\Users\\ASUS\\Desktop\\c#.net\\visual studio\\Assignments\\Assigment13\\Books.xml");
            //var books = xmlDocument.Descendants("Book")
            //                       .Where(book => (int)book.Element("Year") > 2015)
            //                       .Select(book => book.Element("Title").Value);
            //Console.WriteLine("Books published after 2015:");
            //foreach (var book in books)
            //{ 
            //    Console.WriteLine("\n");
            //    Console.WriteLine(book);
            //}



            //20.Given a database table Employees with columns ID, Name, and Department, write a
            //LINQ to SQL query to select all employees from the "IT" department.

            //var itEmployees = from emp in db.Employees
            //                  where emp.Department == "IT"
            //                  select emp;
            ////Selecting employees in IT Department.
            //foreach (var emp in itEmployees)
            //{
            //    Console.WriteLine($"ID:{emp.ID}, Name: {emp.Name}, Department: {emp.Department}");
            //}
            ////Displaying details of IT Employees.


            Console.ReadLine();

        }
        //EVENT
        private static void event_handler(object sender, EventArgs e)
        {
            Console.WriteLine("--maximum times exceeded--");
            flag = false;


        }

        //asyncronous--11
        public static async void Method1()
        {
            await Task.Run(() =>
            {
                for(int i=0;i<5;i++)
                {
                    Console.WriteLine("method--1");
                    Task.Delay(1000).Wait();
                }

            });

        }
        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("method--2");
                Task.Delay(1000).Wait();
                Console.WriteLine("\n");
            }
        }  
        
        //13. task
        public static async Task Common()
        {
            Console.WriteLine("enter the size of array");
            int size=int.Parse(Console.ReadLine());
            int[] arr= new int[size];
            Console.WriteLine("enter the numbers");
            for(int i=0;i<size;i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Task<int> task = Sum(arr);
            int result=await task;
            Console.WriteLine($"sum is: {result} ");
        }
        public static async Task<int> Sum(int[] arr)
        {
            int sum = 0;
            await Task<int>.Run(() =>
            {
               
                for(int i=0;i<arr.Length;i++)
                {
                    sum+= arr[i];
                }

               
            });
            return sum;
        }



    }
}
