//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Runtime.ConstrainedExecution;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment7
//{
//    internal class ChainedConstrutcor
//    {
//        //        Create a class named Car with the following:
//        //o Fields for make, model, year, and price.
//        public class Car
//        {
//            public string make { get; set; }
//            public string model { get; set; }
//            public int year { get; set; }
//            public int price { get; set; }
//            public Car()
//            {
//                make = "Unknown";
//                model = "Unknown";
//                year = 0;
//                price = 0;
//                Console.WriteLine($"Make:{make}  model:{model}   year{year} price:  {price}");
//                //Console.WriteLine("-------------------------");
//            }
//            // A constructor that initializes only the make
//            public Car(string Make) : this()
//            {
//                make = Make;
//                Console.WriteLine($"make: {make}");

//            }
//            //A constructor that initializes make and model.
//            public Car(string Make, string Model) : this(Make)
//            {

//                model = Model;
//                Console.WriteLine($"Make: {make} model: {model} ");

//            }

//            // A constructor that initializes make, model, and year.
//            public Car(string Make, string Model, int Year) : this(Make, Model)
//            {

//                year = Year;
//                Console.WriteLine($"Make:{make}  model:{model}  year{year}");
//            }

//            //A constructor that initializes all fields: make, model, year, and price.
//            public Car(string Make, string Model, int Year, int Price) : this(Make, Model, Year)
//            {

//                price = Price;
//                Console.WriteLine($"Make:{make} model: {model}  year{year}   price:{price}");
//            }

//        }
//        static void Main(string[] args)
//        {
//            Car c1 = new Car();
//            Console.WriteLine("\n");

//            c1 = new Car("BENZ");
//            Console.WriteLine("\n");
//            c1 = new Car("BENZ", "Mercedez");
//            Console.WriteLine("\n");
//            c1 = new Car("BENZ", "Mercedez", 1994);
//            Console.WriteLine("\n");
//            c1 = new Car("BENZ", "Mercedez", 1994, 12000);

//            Console.ReadLine();
//        }
//    }
//}
