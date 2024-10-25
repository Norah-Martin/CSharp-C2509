//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Policy;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment7
//{
//    internal class Reactangle
//    {
//        //        Create a Rectangle class with overloaded methods to calculate the area.
//        //Implement methods that take either width and height or just one side length (for a square). 

//        public void area(int length)
//        {
//            int ans = length * length;
//            Console.WriteLine($"The area of square is{ans} ");
//        }
//        public void area(int length, int breadth)
//        {
//            int ans = length * breadth;
//            Console.WriteLine($"The area of square is{ans} ");
//        }

//        static void Main(string[] args)
//        {
//            Reactangle square = new Reactangle();
//            square.area(5);

//            Reactangle rect = new Reactangle();
//            rect.area(5, 6);

//            Console.ReadLine();
//        }
//    }
//}
