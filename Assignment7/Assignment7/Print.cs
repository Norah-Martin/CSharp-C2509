//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment7
//{
//    public class Print
//    {
//        public string name;
//        public int num;
//        public int[] arr = new int[3];

//        public void type(string str)
//        {
//            Console.WriteLine($"{str} Type is:{str.GetTypeCode()}");
//        }

//        public void type(int num)
//        {
//            Console.WriteLine($"{num} Type is:{num.GetTypeCode()}");
//        }

//        public void type(int[] arr)
//        {
//            Console.WriteLine($"{arr} Type is:{arr.GetType()}");
//        }
//        //main
//        static void Main(string[]args)
//        {
//            Print P = new Print();
//            P.name = "norah";
//            P.num = 20;
//            P.arr[0] = 1;

//            P.type(P.name);
//            P.type(P.num);
//            P.type(P.arr[0]);

//            Console.ReadLine();
//        }

//    }
//}
