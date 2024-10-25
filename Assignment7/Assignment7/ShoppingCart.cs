//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//using static Assignment7.ShoppingCart;

//namespace Assignment7
//{
//    //    Create a ShoppingCart class that contains:
//    //o A list of Product objects.
//    //o Methods to add products and calculate the total price.

//    public class ShoppingCart
//    {
//        List<Product> products = new List<Product>();
//        int sum = 0;
//        public void addp(Product P)
//        {
//            products.Add(P);
//        }
//        public int totalp(int Price)
//        {

//            sum += Price;
//            return sum;

//        }
//        public void display()
//        {
//            foreach (Product P in products)
//            {
//                Console.WriteLine($"{P.Name}                   {P.Price}                        {P.Quantity}");
//            }
//        }
//        //        Create a nested Product class with properties for Name, Price, and Quantity.
//        //. Demonstrate adding products and displaying the total price in the Main() method
//        public class Product
//        {
//            public string Name;
//            public int Price;
//            public int Quantity;
//            public Product(string name, int price, int quantity)
//            {
//                Name = name;
//                Price = price;
//                Quantity = quantity;
//            }
//        }


//        static void Main(string[] args)
//        {
//            ShoppingCart sc = new ShoppingCart();

//            Console.WriteLine("ENTER THE NUMBER OF PRODUCTS:  ");
//            int NUM = int.Parse(Console.ReadLine());
//            for (int i = 0; i < NUM; i++)
//            {
//                Console.Write("Enter product name: ");
//                string name = Console.ReadLine();

//                Console.Write("Enter product price: ");
//                int pri = int.Parse(Console.ReadLine());
//                sc.totalp(pri);

//                Console.Write("Enter product quantity: ");
//                int quan = int.Parse(Console.ReadLine());

//                Product P = new Product(name, pri, quan);
//                sc.addp(P);
//                Console.WriteLine("-------------------------------");

//            }
//            Console.WriteLine("\n");
//            Console.WriteLine("***The list is:***");
//            Console.WriteLine("\n");
//            Console.WriteLine($"Product Name:       Product Price:      Product Quantity:");

//            sc.display();

//            int sum = sc.totalp(0);
//            Console.WriteLine("\n");
//            Console.WriteLine($"The total price is:{sum}");

//            Console.ReadLine();
//        }
//    }
//}
