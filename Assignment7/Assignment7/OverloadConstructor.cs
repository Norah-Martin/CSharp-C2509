//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Assignment7
//{
//    internal class OverloadConstructor
//    {
//        //        Create a class named Product with the following:
//        //o Fields for name, price, and discount.

//        public class Product
//        {
//            public string name;
//            public int price;
//            public int discount;
//            //A constructor that initializes only the name.
//            public Product(string Name)
//            {
//                this.name = Name;
//                Console.WriteLine($"Product Name:{name} Price:0 Discount:0");

//            }

//            // A constructor that initializes name and price.
//            public Product(string Name, int Price)
//            {
//                this.name = Name;
//                this.price = Price;
//                Console.WriteLine($"Product Name:{name} Price:{price} Discount:0");

//            }
//            //A constructor that initializes name, price, and discount.
//            public Product(string Name, int Price, int Discount)
//            {
//                this.name = Name;
//                this.price = Price;
//                this.discount = Discount;
//                Console.WriteLine($"Product Name:{name} Price:{price} Discount:{discount}");

//            }
//            //Implement a method CalculateFinalPrice() that computes the final price after applying
//            //the discount(if applicable).

//            public int CalculateFinalPrice()//error
//            {

//                int ans = (price * discount) / 100;
//                int sum = price - ans;
//                return sum;

//            }

//        }

//        //main
//        static void Main(string[] args)
//        {
//            Product PRO1 = new Product("Bottle");
//            Console.WriteLine("-----------------------");
//            Console.WriteLine("\n");

//            Product pro2 = new Product("Pen", 5);
//            Console.WriteLine("-----------------------");
//            Console.WriteLine("\n");

//            Product pro3 = new Product("Phone", 10000, 50);
//            Console.WriteLine("-----------------------");
//            Console.WriteLine("\n");

//            int ans = pro3.CalculateFinalPrice();
//            Console.WriteLine($"price after discount: {ans}");

//            Console.ReadLine();

//        }
//    }
//}
