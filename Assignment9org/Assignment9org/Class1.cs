using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9org
{
    internal class Class1
    {
        //1.polymorphism 
        //Create a C# program demonstrating polymorphism by using a base class Shape and derived
        //classes Circle and Rectangle.Each derived class should implement a method Draw().

        //public class Shape
        //{
        //    public virtual void Draw()
        //    {
        //        Console.WriteLine("** Shape is called **");
        //    }
        //}
        //public class Circle : Shape
        //{
        //    public override void Draw()
        //    {
        //        Console.WriteLine("** Circle is called **");
        //    }
        //}
        //public class Rectangle : Shape
        //{
        //    public override void Draw()
        //    {
        //        Console.WriteLine("** Rectangle is called");
        //    }
        //}

        //2.Create a C# program to show method overloading by implementing a Multiply method with
        //  different parameter types, numbers and order.
        //public class Mathmultiply
        //{
        //    public void Multiply(int a, int b)
        //    {
        //        int ans = a * b;
        //        Console.WriteLine($"Product is :{ans}");

        //    }
        //    public void Multiply(double a, int b)
        //    {
        //        int ans = (int)a * b;
        //        Console.WriteLine($"Product is :{ans}");

        //    }
        //    public void Multiply(int a, int b, int c)
        //    {
        //        int ans = (int)a * b * c;
        //        Console.WriteLine($"Product is :{ans}");

        //    }
        //}

        //3.Write a program demonstrating method overriding by creating a base class Vehicle and a derived
        //class Car that overrides the Drive() method.

        //public class Vehicle
        //{
        //    public virtual void Drive()
        //    {
        //        Console.WriteLine("--VEHICLE---driving");
        //    }
        //}
        //public class Car:Vehicle
        //{
        //    public override void Drive()
        //    {
        //        Console.WriteLine("--CAR--driving");
        //    }
        //}

        //4.Consider a scenario of payment processing where different payment methods (e.g.,
        //CreditCardPayment, PayPalPayment) override the ProcessPayment() method of a base class
        //Payment. Write a C# program to demonstrate this scenario. 

        // public class Payment
        // {
        //     public virtual void ProcessPayment()
        //     {
        //         Console.WriteLine("Processing a generic payment.");
        //     }
        // }
        //public class CreditCardPayment : Payment
        // {

        //     public override void ProcessPayment()
        //     {
        //         Console.WriteLine("credit card payment.");
        //     }
        // }
        //public  class PayPalPayment : Payment
        // {

        //     public override void ProcessPayment()
        //     {
        //         Console.WriteLine(" PayPal payment.");
        //     }
        // }

        //5 .Create a C# program that demonstrates polymorphism using a base class Employee and derived
        //classes Manager and Developer.Include a static field to keep track of the total number of
        //employees and a static method to display the total count

        //public class Employee
        //{
        //    public static int count;
        //    public static int getcounter()
        //    {
        //        int ans1 = Manager.count1();
        //        int ans2 = Developer.count2();
        //        int ans3 = ans1 + ans2;
        //        return ans3;

        //    }
        //}
        //public class Manager : Employee
        //{
        //    public static int countm=0;
        //    public Manager()
        //    {
        //        countm = countm + 1;
        //    }
        //    public static int count1()
        //    {
        //        return countm;
        //    }
        //}
        //public class Developer:Employee
        //{
        //    public static int countd = 0;
        //    public Developer()
        //    {
        //        countd = countd + 1;
        //    }
        //    public static int count2()
        //    {
        //        return countd;
        //    }
        //}


        //6.Create a C# program demonstrating polymorphism using a base class Employee and derived
        //  classes Manager and Developer., each employee should have a collection of
        //tasks(stored in an array) assigned to them.Use arrays as properties in the class to handle this
        //data, and demonstrate how polymorphism and arrays work together in the solution. 

        public abstract class Employee  //since display infor is public 
        {
            public string Name { get; set; }
            public string[] task { get; set; }
            public abstract void display(); //else we need to define body and override to implemnt polymorphism
            public Employee(string name, string[] task)
            {
                Name = name;
                this.task = task;
            }
        }
        public class Manager : Employee
        {
            public Manager(string name, string[] task) : base(name, task)
            {

            }
            public override void display()
            {
                Console.WriteLine($"{Name}---Tasks:");
                foreach (var t in task)
                {
                    Console.WriteLine($"{t}");
                }
            }

        }
        public class Developer : Employee
        {
            public Developer(string name, string[] task) : base(name, task)
            {

            }
            public override void display()
            {
                Console.WriteLine($"{Name}---Tasks:");
                foreach (var t in task)
                {
                    Console.WriteLine($"{t} ");
                }
            }
        }





        //7 method overloading -early binding method overriding-late binding
        //Create a C# program that demonstrates early binding (compile-time polymorphism) using
        //method overloading and late binding(runtime polymorphism) using method overriding.

        //public class Area
        //{
        //    public int length;
        //    public int breadth;
        //    public int height;

        //    public void area(int length, int breadth)
        //    {
        //        int ar = length * breadth;
        //        Console.WriteLine($"--Area is {ar}");
        //    }
        //    public void area(int length, int breadth, int height)
        //    {
        //        int ar = length * breadth * height;
        //        Console.WriteLine($"--Area is {ar}");
        //    }
        //    public virtual void calc(int length, int breadth)
        //    {
        //        int ar = length * breadth;
        //        Console.WriteLine($"--Calculation area  is {ar}");

        //    }
        //}
        //public class Rectangle : Area
        //{

        //    public override void calc(int length, int breadth)
        //    {
        //        int ar = length * breadth;
        //        Console.WriteLine($"--Calculation area  is {ar}");
        //        //base.calc(length, breadth);
        //    }
        //}


        //8.runtime- Define an abstract class Shape and an interface IShape, implementing
        //   these in derived classes to showcase polymorphism.
        //public abstract class Shape
        //{
        //    public virtual void Draw()
        //    {
        //        Console.WriteLine("--shape is drawing");

        //    }
        //}
        //interface Ishape
        //{
        //    void Draw();

        //}
        //public class Rectangle : Shape, Ishape
        //{
        //    public override void Draw()
        //    {
        //        base.Draw(); //SHAPE IS DRAWING
        //        Console.WriteLine("--Rectangle is drawing");
        //    }
        //}


        //9.The program will define two interfaces, IMovable and IDrawable, and implement them in a class
        //Car that showcases how a class can inherit from multiple interfaces.

        //interface IMovable
        //{
        //    void Move();
        //}
        //interface IDrawable
        //{
        //    void Draw();
        //}
        //public class Car : IMovable, IDrawable
        //{
        //    public void Move()
        //    {
        //        Console.WriteLine(" --Move---");
        //    }
        //    public void Draw()
        //    {
        //        Console.WriteLine("--Draw--");

        //    }
        //}

        //10 readonly
        //Create a C# program that demonstrates polymorphism with a readonly property. Define a base
        //class and derived classes where each class provides specific behavior for a method, while using a
        //readonly property to ensure that certain values cannot be modified after initialization.


        //  public class Vehicle
        //  {
        //    public readonly string Type; //or assign value here as,public readonly string Type="benz"
        //    public Vehicle(string type)  //assigning value in constructor
        //    {
        //        Type = type;
        //    }
        //    public virtual void info()
        //    {
        //        Console.WriteLine($"vehicle type is {Type}");
        //    }
        //  }
        //public class Car:Vehicle
        //{
        //    public Car(string type) : base(type)
        //    {
        //    }

        //    public override void info()
        //    {
        //        Console.WriteLine($"car type is {Type}");
        //    }
        //}





    }
}
