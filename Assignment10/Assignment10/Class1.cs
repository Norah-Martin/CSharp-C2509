using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Assignment10.Class1;

namespace Assignment10
{
    //extension method should be in top level cannot be in nested class
    //public static class Sample
    //{
    //    public static void IsEven(this int num )
    //    {
    //        bool b = true;
    //        if (num % 2 == 0)
    //        {
    //            Console.WriteLine($"{b} -even");
    //        }
    //        else
    //        {
    //            b = false;
    //            Console.WriteLine($"{b}-odd");

    //        }
    //    }
    //}

    public class Class1
    {

        //1.Create an abstract class Vehicle that has an abstract method StartEngine() and a concrete method
        //StopEngine(). Create derived classes Car and Motorcycle that implement the StartEngine()
        //method and override it to show specific behavior for each type of vehicle.
        //concrete methos -declaraton and definiton
        //public abstract class Vehicle
        //{
        //    public abstract void StartEngine();
        //    public void StopEngine()
        //    {
        //        Console.WriteLine($"stopping engine....");
        //    }

        //}
        //public class Car : Vehicle
        //{
        //    public override void StartEngine()
        //    {

        //        Console.WriteLine($"car engine is starting...");
        //    }

        //}
        //public class Motorcycle : Vehicle
        //{
        //    public override void StartEngine()
        //    {
        //        Console.WriteLine($"motocycle is starting...");
        //    }

        //}

        //2.Create a base class Animal with a virtual method MakeSound(). Derive classes Dog and Cat that
        //override the MakeSound() method to provide their specific implementation.

        //public class Animal
        //{
        //    public virtual void MakeSound()
        //    {
        //        Console.WriteLine($"Animal --Sound");
        //    }
        //}
        //public class Dog : Animal
        //{

        //    public override void MakeSound()
        //    {
        //        Console.WriteLine($"dog--sound");
        //    }

        //}
        //public class cat : Animal
        //{
        //    public override void MakeSound()
        //    {
        //        Console.WriteLine($"Cat--sound");
        //    }
        //}

        //3.Create an interface IDrive with a method Drive(). Implement this interface in a Car and Truck
        //class, with each class having its own implementation of Drive(). 

        //interface IDrive
        //{
        //    void Drive();
        //}
        //public class Car : IDrive
        //{
        //    public void Drive()
        //    {
        //        Console.WriteLine("Car Driving");
        //    }
        //}
        //public class Truck : IDrive
        //{
        //    public void Drive()
        //    {
        //        Console.WriteLine("TRUCK  Driving");
        //    }
        //}

        //4.Write a program that demonstrates the difference between an abstract class and an interface by
        //creating an abstract class Bird with an abstract method Fly(), and an interface ISwim with a
        //method Swim(). 

        //public abstract class Bird
        //{
        //    public abstract void Fly();
        //}
        //public class Parrot : Bird
        //{
        //    public override void Fly()
        //    {
        //        Console.WriteLine("PARROT flying");
        //    }
        //}

        //interface Iswim
        //{
        //    void Swim();
        //}
        //public class Pool : Iswim
        //{
        //    public void Swim()
        //    {
        //        Console.WriteLine("swimming..");
        //    }
        //}

        //5.
        //Create a static class MathOperations with a static method Add() and Multiply(). Demonstrate
        //calling these methods without creating an instance of the class
        //public static class MathOperations
        //{
        //    public static void Add(int a, int b)
        //    {
        //        int sum = a + b;
        //        Console.WriteLine($"add....sum is:{sum}");
        //    }
        //    public static void Multiply(int a, int b)
        //    {
        //        int product = a * b;
        //        Console.WriteLine($"multiply...product is: {product}");
        //    }

        //    }

        //6.Create an extension method IsEven() for the int type that returns true if the number is even and
        //false if it is odd.

        //public class Even
        //{
        //    public void display()
        //    {
        //        Console.WriteLine("Extension method");
        //    }
        //}




        //8.partial method
        //Create a partial class Employee with a partial method CalculateSalary(). Implement the partial
        //method in another part of the class and demonstrate its usage.

        //public partial class Employee
        //{
        //    public int salary;
        //    public Employee(int salary)
        //    {
        //        this.salary = salary;
        //    }

        //    partial void CalculateSalary();

        //}
        //public void CaculateSalary(Employee employee)
        //{
        //    Console.WriteLine($"salar is {employee.salary}");
        //}


        //9.INDEXER
        //Create a Library class that contains an array of Book objects.Implement an indexer that allows
        //accessing the books by index.Write a method to display all the books in the library
        //public class Library
        //{
        //    public string[] Book = new string[3];
        //    public string this[int index]
        //    {
        //        get { return Book[index]; }
        //        set
        //        {
        //            Book[index] = value;
        //        }
        //    }
        //    public void display()
        //    {
        //        foreach (var item in Book)
        //        {
        //            Console.WriteLine($"---{item}---");
        //        }
        //    }
        //}

        //10.Exception handling
        //Write a method Divide that takes two integers as input and returns their division.If a division by
        //zero occurs, catch the exception and display a custom error message.Demonstrate exception
        //handling with a try-catch-finally block.

        //public class Division
        //{
        //    public int num1 { get; set; }
        //    private int Num2;
        //   public int num2
        //    {
        //        get
        //        {
        //            return Num2;
        //        }
        //        set
        //        {
        //            if (value == 0)
        //            {
        //                throw new ArgumentException("XX NOT POSSIBLE XX");
        //            }
        //            Num2 = value;
        //        }
        //    }
        //    public void Divide()
        //    {
        //        int div = num1 / Num2;
        //        Console.WriteLine($"quotient is:{div}");
        //    }
        //}

        //11.Create an enum CarType with values Sedan, SUV, Truck, and Coupe. Write a Car class with a
        //property Type of type CarType.Write a method that takes a CarType value and displays a
        //message specific to that type of car.

        //public class Car
        //{
        //    public CarType Type {  get; set; }
        //    public enum CarType
        //    {
        //        Sedan,
        //        SUV,
        //        Truck,
        //        Coupe
        //    }
        //    public void Display(int num)
        //    {
        //        switch (num)
        //        {
        //            case 0:  Console.WriteLine("--Sedan--");
        //                     break;
        //            case 1: Console.WriteLine("--SUV--");
        //                      break;
        //            case 2: Console.WriteLine("--Truck--");
        //                    break;
        //            case 3: Console.WriteLine("--Coupe--");
        //                    break;
        //            default: Console.WriteLine("no number");
        //                   break;
        //        }


        //    }

        //}


        //12.Define a custom attribute DeveloperAttribute that takes the name of the developer and the date
        //when the code was last modified.Apply this attribute to a class Calculator and its method Add.
        //Retrieve and display the attribute information at runtime

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
        public class DeveloperAttribute : Attribute
        {
            public string Name { get; set; }
            public string Date { get; set; }
            public DeveloperAttribute(string name, string date)
            {
                Name = name;
                Date = date;
            }
        }
        [Developer("Norah","2023-10-24")]
        [Developer("Chelsa", "2010-3-22")]

        public class Calculator
        {
            [Developer("Martin", "2024-3-25")]
            [Developer("Isabella", "2001-8-1")]
            public int Add(int a,int b)
            {
                return a + b;
            }
        }
    }

}







