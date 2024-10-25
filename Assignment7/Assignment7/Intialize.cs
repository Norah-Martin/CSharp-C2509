//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Assignment7
//{
//    internal class Intialize
//    {
//        //        Create a class named Product with the following:
//        //o Properties for Name, Price, and Category.
//        public class Product
//        {
//            public string Name { get; set; }
//            public int Price { get; set; }
//            public string Category { get; set; }

//            // A constructor that initializes all three properties.
//            public Product(string name, int price, string category)
//            {
//                Name = name;
//                Price = price;
//                Category = category;
//                Console.WriteLine($"Name: {Name} Price: {Price}  Category: {Category}");


//            }
//            //A static method to create a Product object. 
//            public static Product createProduct(string name, int price, string category)
//            {
//                Product product = new Product(name, price, category);


//                return product;

//            }


//            //Implement a constructor that provides default values for the properties. 
//            public Product()
//            {
//                Name = "Bottle";
//                Price = 1234;
//                Category = "Object";

//            }
//        }
//        static void Main(string[] args)
//        {

//            Product pro1 = new Product("Pen ", 5, "object"); //constructor INTIALIZATION
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("\n");

//            Product pro2 = new Product { Name = "Book", Price = 500, Category = "Info" }; //object intialization
//            Console.WriteLine($"Name: {pro2.Name} Price: {pro2.Price}  Category: {pro2.Category}");
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("\n");

//            Product pro3 = Product.createProduct("Keyboard", 123, "Computer");//static method
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("\n");

//            var Anpro = new { Name = "Apple", Price = 12, Category = "fruit" }; //anonymous
//            Console.WriteLine($"Name: {Anpro.Name} Price: {Anpro.Price}  Category: {Anpro.Category}");
//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("\n");

//            Type Producttype = typeof(Product); //reflection
//            Product PRO4 = (Product)Activator.CreateInstance(Producttype, new object[] { "Orange", 14, "fruit" });
//            // Console.WriteLine($"Name: {PRO4.Name} Price: {PRO4.Price}  Category: {PRO4.Category}");
//            Console.WriteLine("\n");
//            Console.WriteLine("---------------------------------");
//            Product product = new Product(); //default valuE
//            Console.WriteLine($"Name: {product.Name} Price: {product.Price}  Category: {product.Category}");
//            Console.ReadLine();
//        }
//    }

//}
