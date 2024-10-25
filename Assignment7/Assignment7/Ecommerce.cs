//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Security.Policy;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment7
//{
//    public class Ecommerce
//    {
//        //        Design an e-commerce system that manages products and orders.Each
//        //product has a name, price, and stock quantity.Implement methods to create an order that reduces
//        //stock quantity.Implement getters and setters to ensure that the price cannot be negative and the
//        //stock cannot be less than zero.

//        internal class Product
//        {
//            public string Pname { get; set; }
//            private int Price;
//            private int Stock;

//            //constructor
//            public Product(string pname, int price, int stock)
//            {
//                Pname = pname;
//                this.price = price;
//                this.stock = stock;

//            }

//            //getter setter
//            public int price
//            {
//                get { return Price; }
//                set
//                {
//                    if (value < 0)
//                    {
//                        throw new ArgumentException("No negative");
//                    }
//                    Price = value;
//                }
//            }
//            public int stock
//            {
//                get { return Stock; }
//                set
//                {
//                    if (value < 0)
//                    {
//                        throw new ArgumentException("***no Stock less than zero*****");
//                    }
//                    Stock = value;
//                }
//            }
//            //order reduce function

//            public int reduce(int stck)
//            {
//                Stock = Stock - stck;
//                return Stock;

//            }
//            public void Display()
//            {
//                Console.WriteLine("--------------------------------------");
//                Console.WriteLine($"Product Name:{Pname} Price:{Price} Stock:{Stock}");
//            }



//        }
//        static void Main(string[] args)
//        {
//            try
//            {

//                Product pro = new Product("Bottle", 1000, 50);
//                pro.Display();

//                Product pro1 = new Product("Phone", 123400, 500);
//                pro1.Display();

//                pro1.reduce(100);

//                pro1.Display();

//                Product pro3 = new Product("HeadSet", 100000, -70);
//                pro3.Display();
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine($"Error: {ex.Message}");
//            }

//            Console.ReadLine();

//        }

//    }
//}
