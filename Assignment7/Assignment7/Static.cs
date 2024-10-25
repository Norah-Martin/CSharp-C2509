//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.InteropServices.WindowsRuntime;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment7
//{
//    internal class Static
//    {
//        //        //        Create a class Bank that has a static field for the interest rate and a nonstatic field for the account holder’s balance.
//        //        //            Write a static constructor to initialize the interest
//        //        //        //            rate to a default value and a regular constructor for setting up the account balance
//        //        public class Bank
//        //{
//        //    public static int Irate;
//        //    public int Balance;
//        //    static Bank()
//        //    {
//        //        Irate = 5;

//        //    }
//        //    public Bank(int balance)
//        //    {

//        //        Balance = balance;
//        //        Console.WriteLine($"Account Balance:{Balance}");
//        //    }
//        //}

//        //        //        12.
//        //Create a class Car that counts how many instances of Car have been
//        //created using a static counter.Initialize this counter using a static constructor.

//        //public class Car
//        //{

//        //    private static int counter = 0;
//        //    public Car()
//        //    {
//        //        counter = counter + 1;

//        //    }
//        //    public static int GetCounter()
//        //    {
//        //        return counter;
//        //    }
//        //}


//        //        //    }

//        //        //        13  Create a class MathOperations that initializes a static field representing the
//        //        //        value of Pi.Write a static constructor to assign this value.

//        //public class MathOperations
//        //{
//        //    private static double pi;
//        //    public static double constr()
//        //    {
//        //        const double pi = 3.14;
//        //        return pi;

//        //    }
//        //    static MathOperations()
//        //    {
//        //        Console.WriteLine($"the pi values is {MathOperations.constr()}");
//        //    }
//        //}

//        //        //        14.: Create a class Configuration to load system-wide settings(e.g., application
//        //        //        name) using a static constructor.Allow individual users to set preferences using an instance
//        //        //        constructor.

//        public class Configuration
//        {
//            public static string application;
//            public static string application_type;
//            public string Os;


//            static Configuration()
//            {
//                application = "windows";
//                application_type = "computer";



//            }

//            public Configuration(string os)
//            {
//                Os = os;
//                Console.WriteLine($"APPLICATION OS:{Os}");
//            }


//        }





//        //        //    main
//        static void Main(string[] args)
//         {
//            //    Bank bank = new Bank(300);
//            //  Console.WriteLine($"Interest rate:{Bank.Irate}");

//            //Car c1 = new Car();
//            //Car c2 = new Car();
//            //Car c3 = new Car();
//            //Console.WriteLine($"the number is {Car.GetCounter()}");


//            //   MathOperations mat = new MathOperations();

//            Console.WriteLine($"APPLICATION:{Configuration.application} and type:{Configuration.application_type}");
//            Configuration con = new Configuration("linux");




//            Console.ReadLine();
//}

//}
//}
