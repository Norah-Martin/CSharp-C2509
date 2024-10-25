//using System;
//using System.CodeDom;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment7
//{
//    public class Item  //item class with name stock price
//    {
//        //        Create an inventory management system that manages items in a store.
//        //Each item has a name, stock, and price. Implement methods to add, remove, and update items.
//        //Use getters and setters to manage access to the stock and price, ensuring it cannot be set to a
//        //negative value.


//        public string Name { get; set; }
//        private int Stock;
//        private int Price;
//        public Item(string name, int stock, int price)
//        {
//            Name = name;
//            this.stock = stock;
//            this.price = price;
//        }
//        public int stock
//        {
//            get { return Stock; }
//            set
//            {
//                if (value < 0)
//                {
//                    throw new ArgumentException("Stock not acceptable");
//                }
//                Stock = value;
//            }
//        }
//        public int price
//        {
//            get { return Price; }
//            set
//            {
//                if (value < 0)
//                {
//                    throw new ArgumentException("*****Price not allowed");
//                }
//                Price = value;
//            }
//        }

//        public class Inventory
//        { //this class to add remove and dispaly,list here of items;

//            List<Item> items = new List<Item>();
//            public void AddB(Item it)
//            {
//                items.Add(it);
//            }

//            public void display()
//            {
//                Console.WriteLine("\n******************");
//                if (items.Count == 0)
//                {
//                    Console.WriteLine("no books");
//                }
//                foreach (var Item in items)
//                {
//                    Console.WriteLine($"Itemname:{Item.Name}  Stock:{Item.Stock}  Price:{Item.Price}");
//                }
//            }

//            public void Removeb(Item it)
//            {
//                items.Remove(it);

//            }



//        }
//        static void Main(string[] args)
//        {
//            try
//            {
//                Inventory inv = new Inventory();

//                Item item1 = new Item("Books", 1000, 5000);
//                Item item2 = new Item("Pens", 500, 1000);
//                Item item3 = new Item("Laptops", 10, 5000);

//                inv.AddB(item1); //inventory have the functions
//                inv.AddB(item2);
//                inv.AddB(item3);

//                inv.display();

//                inv.Removeb(item2);
//                inv.Removeb(item1);

//                inv.display();

//                inv.Removeb(item3);
//                inv.display();

//                Item item4 = new Item("Lap", 10, -5000);
//                inv.AddB(item4);
//                inv.display();
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }


//            Console.ReadLine();
//        }





//    }

//}
