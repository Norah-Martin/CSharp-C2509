using System;
using static Assignment10.Class1;

namespace Assignment10
{
    //7

    //public partial class Partial1
    //{
    //    public void showdetails()
    //    {
    //        Console.WriteLine($"partal class ,name is {Name}");
    //    }
    //}

    //8.

    partial class Employee
    {
        public void CaculateSalary()
        {
            Console.WriteLine($"salar is {salary}");
        }
    }

}