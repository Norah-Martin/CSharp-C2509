//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment7
//{
//    public class Time
//    {

//        //        Create a Time class with overloaded methods to set the time.Implement
//        //methods to set the time using hours and minutes, and another method to set the time using
//        //seconds. 
//        public void settime(int hr, int min)
//        {
//            Console.WriteLine("using hr and min");
//            Console.WriteLine($"the time is {hr}:{min}:0");
//        }
//        public void settime(int sec)
//        {
//            int hr = sec / 3600;
//            int min = (sec % 3600) / 60;
//            int rsec = sec % 60;
//            Console.WriteLine("using sec");
//            Console.WriteLine($"the time is {hr}:{min}:{rsec}");


//        }
//        static void Main(string[] args)
//        {
//            Time t = new Time();
//            t.settime(5400);
//            Console.WriteLine("\n");
//            t.settime(1, 30);

//            Console.ReadLine();
//        }
//    }

//}