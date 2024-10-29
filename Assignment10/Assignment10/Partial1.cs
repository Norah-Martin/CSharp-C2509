using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    //7. partial class
    //Create a partial class Person that is defined in two files.One file should have the property Name,
    //and the other file should have the method ShowDetails(). 

    //public partial class Partial1
    //{
    //    public string Name;
    //    public Partial1(string name)
    //    {
    //        this.Name = name;
    //    }
    //}

    //8.partial method
    //Create a partial class Employee with a partial method CalculateSalary(). Implement the partial
    //method in another part of the class and demonstrate its usage.
    public partial class Employee
    {
        public int salary;
        public Employee(int salary)
        {
            this.salary = salary;
        }
        partial void CalculateSalary();

    }

}