//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Assignment7
//{
//    internal class CopyConstructor
//    {

//        //        Write a C# program that implements a copy constructor. The program should:
//        //1. Create a class with several fields.
//        //2. Provide a constructor to initialize those fields.
//        //3. Provide a copy constructor that allows the creation of a new object from an existing
//        //object.
//        //4. Demonstrate how the copy constructor works by comparing objects created using it with
//        //objects created via direct assignment(which just copies references). 
//        public class area
//        {
//            double length;
//            double width;

//            public area(double Length, double Width)
//            {
//                length = Length;
//                width = Width;
//            }
//            public area(area a)
//            {

//                length = a.length + 2;
//                width = a.width + 2;


//            }
//            public void print()
//            {
//                Console.WriteLine($"length: {length} width: {width} area:{length * width}");
//            }
//        }
//        static void Main(string[] args)
//        {
//            area are = new area(2, 3);


//            area are2 = new area(are);
//            are.print();
//            Console.WriteLine("----------------------");
//            Console.WriteLine("\n");

//            are2.print();
//            Console.ReadLine();

//        }


//    }
//}
