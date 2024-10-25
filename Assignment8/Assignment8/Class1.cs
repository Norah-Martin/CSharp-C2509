using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
   public class Class1
    {
        //  1      Create a base class Person with properties like Name and Age.Derive a class Student from
        //Person and add a property Grade.Create objects and display the data.

        //public class Person
        //{
        //    public string Name;
        //    public int age;
        //    public void display()
        //    {
        //        Console.WriteLine($"{Name}----------{age}");
        //    }
        //}
        //public class Student : Person
        //{
        //    public string grade;
        //    public void displays()
        //    {
        //        Console.WriteLine($"{Name}-----{age}------{grade}");
        //    }
        //}


        //2  multilevel   .Create a base class Animal with a method Eat(). Derive a class Dog that inherits Animal and add
        // a method Bark(). Further derive a class Puppy from Dog and add a method Weep(). 

        //public class Animal
        //{
        //    public void Eat()
        //    {
        //        Console.WriteLine("---Eating----");
        //    }

        //}
        //public class Dog:Animal
        //{
        //    public void Bark()
        //    {
        //        Console.WriteLine("----Barking----");
        //    }
        //}
        //public class Puppy:Dog
        //{
        //    public void Weep()
        //    {
        //        Console.WriteLine("----Weeping-----");
        //    }
        //}


        //3.multiple via interface
        //Create two interfaces IPrintable and IScannable with respective methods Print() and Scan().
        //Implement both interfaces in a class PrinterScanner.

        //interface IPrintable
        //{
        //     void Print();
        //}
        //interface IScannable
        //{
        //    void Scan();
        //}
        //public class PrintScanner:IPrintable,IScannable
        //{
        //    public void Scan()
        //    {
        //        Console.WriteLine("--SCAN---");
        //    }

        //    public void Print()
        //    {
        //        Console.WriteLine("--PRINT---");
        //    }
        //}


        //        //4.hierarchial 
        //        Create a base class Shape with a method Draw(). Create two derived classes Circle and
        //Rectangle, both inheriting from Shape, and override the Draw() method to show specific
        //behavior.
        //public class Shape
        //{
        //    public virtual void Draw(int sides)
        //    {
        //        Console.WriteLine($"sides is :{sides}");
        //    }
        //}
        //public class Circle:Shape
        //{
        //    public   override void Draw(int sides)
        //    {
        //        Console.WriteLine($"Circle and sides is:{sides}");
        //    }
        //}
        //public class Rectangle : Shape
        //{
        //    public  override  void Draw(int sides)
        //    {
        //        Console.WriteLine($"Reactangle and side is:{sides}");

        //    }
        //}


        //5.Hybrid Inheritnce
        //Create two interfaces IMovable and IRechargeable.Create a class Vehicle implementing
        //IMovable and derive ElectricCar from Vehicle implementing both interfaces.

        //interface IMovable
        //{
        //    void add(int a, int b);
        //}
        //interface IRechargeable
        //{
        //    void sub(int a, int b);

        //}
        //public class Vehicle:IMovable,IRechargeable
        //{
        //    public void add(int a,int b)
        //    {
        //        int sum = a + b;
        //        Console.WriteLine($"sum is{sum}");
        //    }
        //    public void sub(int a,int b)
        //    {
        //        int diff = a - b;
        //        Console.WriteLine($"diff is{diff}");
        //    }
        //}

        //public class ElectricCar : Vehicle
        //{
        //    public void addsub()
        //    {
        //        Console.WriteLine("--addsub---");
        //    }
        //}


        //6.  overriden
        //Create a class Employee with a method Work(). Derive a class Manager that overrides the
        //Work() method to show a different implementation.

        //public class Employee
        //{
        //    public virtual void Work()
        //    {
        //        Console.WriteLine("--employee work--");
        //    }
        //}

        //public class Manager:Employee
        //{
        //    public override void Work()
        //    {
        //        Console.WriteLine("--Manager work--");
        //    }
        //}

        //7.abstract class
        //Create an abstract class Vehicle with an abstract method Drive(). Create two derived classes Car
        // and Bike that implement the Drive() method.

        //public abstract class Vehicle
        //{
        //    public abstract void Drive();

        //}
        //public class Car:Vehicle
        //{
        //    public override void Drive()
        //    {
        //        Console.WriteLine("--Car is driving--");
        //    }

        //}
        //public class Bike : Vehicle
        //{
        //    public override void Drive()
        //    {
        //        Console.WriteLine("--Bike is driving--");
        //    }
        //}

        //8.sealed
        // Create a sealed class MathOperations with a method Add(). Show that it cannot be inherited.

        //public sealed class MathOperations
        //{
        //    public void Add(int a,int b)
        //    {
        //        int sum = a + b;
        //        Console.WriteLine($"sum is:{sum}");
        //    }
        //}
        //public class Math:MathOperations

        //{
        //    public void print()
        //    {
        //        Console.WriteLine("--------------------");
        //    }
        //}

        //9  CONSTRUCTOR CHAINING
        //Create a base class Person with a parameterized constructor.Create a derived class Employee
        //that calls the base class constructor. 

        //public class Person
        //{
        //    public Person(string name)
        //    {
        //        Console.WriteLine($"name is {name}");
        //    }
        //}
        //public class Employee : Person
        //{
        //    public Employee(string name) : base(name)
        //    {
        //        Console.WriteLine($"employee name:{name}");
        //    }
        //}

        //10 interface inheritance

        //Create an interface IDriveable with a method Drive(). Create another interface IRaceable that
        //inherits from IDriveable and adds a method Race(). 

        //interface IDriveable
        //{
        //    void Drive();
        //}
        //interface Iraceable:IDriveable
        //{
        //    void race();
        //}
        //public class A:IDriveable,Iraceable
        //{
        //    public void Drive()
        //    {
        //        Console.WriteLine("--Drive--");
        //    }

        //    public void race()
        //    {
        //        Console.WriteLine("--Race--");
        //    }
        //}

        //11 Is-a reltionshp
        //Create a base class Animal with properties like Name and methods like Eat(). Create a derived class
        //Dog that inherits from Animal and adds its own method Bark(). Show how the IS-A relationship
        //works.

        //public class Animal
        //{
        //    public string Name;
        //    public void Eat()
        //    {
        //        Console.WriteLine($"{Name} is eating");
        //    }
        //}
        //public class Dog : Animal
        //{
        //    public void Bark()
        //    {
        //        Console.WriteLine("Dog is Barking");
        //    }
        //}

        //12 has 
        //.Create a class Engine with properties like HorsePower. Create a class Car that contains an instance
        //of Engine and shows the HAS-A relationship

        //public class Engine
        //{
        //    public Engine(int HorsePower,string name)
        //    {
        //        Console.WriteLine($"{name} has a Horsepower {HorsePower}");
        //    }
        //}
        //public class  Car:Engine
        //{
        //    public  Car(string carname,int HorsePower,string name): base(HorsePower, name)
        //    {
        //        Console.WriteLine($"{carname} has {name} engine with HorsePower {HorsePower}");
        //    }
        //}

        //13 calling base class method using base
        //Create a base class Person with a method DisplayInfo(). Derive a class Employee that overrides
        //DisplayInfo() but still calls the base class's DisplayInfo() using base. 
        //public class Person
        //{
        //    public string Name { get; set; }
        //    public string Job {  get; set; }
        //    public Person(string name, string job)
        //    {
        //        Name = name;
        //        Job = job;

        //    }
        //    public virtual void DisplayInfo()
        //    {
        //        Console.WriteLine($"{Name} is a {Job}");
        //    }

        //}
        //public class  Employee:Person
        //{
        //    public int Age {  get; set; }
        //    public Employee(string name,string job,int age): base( name,job)
        //    {
        //        Age = age;
        //    }
        //    public override void DisplayInfo()
        //    {
        //        base.DisplayInfo();
        //        Console.WriteLine($"{Name} is a {Job} and Age is  {Age}");

        //    }
        //}

        //14.Create a base class Person with a property Name. In the derived class Student, hide the Name
        // property using the new keyword and use base to access the base class's Name property. 

        //public class Person
        //{
        //    public string Name { get; set; }
        //    public Person(string name)
        //    {
        //        this.Name = name;
        //        Console.WriteLine($"base class name:{Name}");
        //    }
        //}
        //public class Student:Person
        //{
        //    public new string Name { get; set; }
        //    public Student(string name) : base(name)
        //    {
        //       this. Name = name;
        //        Console.WriteLine($"Derived class name:{this.Name}");
        //    }

        //}

        //15.   Create a base class Vehicle with a constructor that accepts brand.Derive a class Car that passes
        //values to the base class constructor using base. 

        public class Vehicle
        {
            public string Brand { get; set; }
            public Vehicle(string brand)
            {
                Brand = brand;
                Console.WriteLine($"Vehicle brand is:{Brand}");
            }
        }
        public class Car:Vehicle
        {  
            
            public Car(string brand):base(brand)
            {
                
            }
        }
    }
}
