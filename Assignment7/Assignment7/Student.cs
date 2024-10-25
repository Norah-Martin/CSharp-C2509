//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Assignment7
//{
//    internal class Student
//    {
//        //        Develop a student management system that stores student details.Each
//        //student has a name, ID, and a list of grades.Implement methods to add a grade and calculate the
//        //average grade.


//        public class Stud
//        {
//            public string name { get; set; }
//            public int id { get; set; }
//            public int[] marks = new int[5];
//            //marks enter function
//            public void getmarks()
//            {
//                for (int i = 0; i < 5; i++)
//                {
//                    Console.Write($"Subject {i + 1} Marks:");
//                    marks[i] = int.Parse(Console.ReadLine());

//                }
//            }
//            //sum and avg function
//            public void addmarks()
//            {
//                int sum = 0;
//                int avg = 0;
//                for (int i = 0; i < 5; i++)
//                {
//                    sum += marks[i];
//                }

//                Console.WriteLine($"The total marks is:{sum}");
//                avg = sum / 5;
//                Console.WriteLine($"The average amrks is:{avg}");
//            }
//        }

//        //main
//        static void Main(string[] args)
//        {
//            Stud s1 = new Stud();
//            s1.name = "Norah";
//            s1.id = 1;
//            Console.WriteLine($"Name: {s1.name}    ID:{s1.id}");
//            s1.getmarks();
//            s1.addmarks();
//            Console.WriteLine("*******************");
//            Stud s2 = new Stud();
//            s2.name = "Martin";
//            s2.id = 2;
//            s2.getmarks();
//            s2.addmarks();
//            Console.WriteLine($"Name:{s2.name}    ID:{s2.id}");

//            Console.ReadLine();

//        }







//    }
//}
