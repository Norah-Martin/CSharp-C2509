using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment8.Class1;

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////single level
            //Person p = new Person();
            //p.Name = "norah";
            //p.age = 23;
            //p.display();

            //Student s = new Student();
            //s.grade = "A";
            //Console.WriteLine("\n");
            //Console.WriteLine("--------------------------");
            //s.Name = "MARTIN";
            //s.age = 21;
            //s.display();
            //s.displays();


            //2.multilevel

            //Animal A= new Animal();
            //A.Eat();
            //Console.WriteLine("\n");

            //Dog D = new Dog();
            //D.Eat();
            //D.Bark(); 

            //Console.WriteLine("\n");
            //Puppy P = new Puppy();
            //P.Eat();
            //P.Bark();
            //P.Weep();

            //3. MULTIPLE

            //PrintScanner P=new PrintScanner();
            //P.Scan();
            //P.Print();

            ////4. override
            ///
            //Shape shape = new Shape();
            //shape.Draw(3);

            //Circle c= new Circle();
            //c.Draw(4);

            //Rectangle r= new Rectangle();
            //r.Draw(6);


            //5.interfcae

            //Vehicle v = new Vehicle();
            //v.add(1, 2);
            //v.sub(4, 3);
            //Console.WriteLine("\n");

            //ElectricCar e=new ElectricCar();
            //e.add(5, 6);
            //e.sub(5, 3);
            //e.addsub();


            //6.override

            //Employee e=new Employee();
            //e.Work();
            //Console.WriteLine("\n");

            //Manager m = new Manager();
            //m.Work();

            //7.abstract
            //Car c = new Car();
            //c.Drive();

            //Console.WriteLine("\n");
            //Bike b = new Bike();
            //b.Drive(); 

            //8 sealed class
            //MathOperations m=new MathOperations();
            //m.Add(2, 3);

            //9. constructor chaining

            //Person p = new Person("norah");
            //Console.WriteLine("\n");
            //Employee e = new Employee("MARTIN");


            //10 interface inheritance
            //A a=new A();
            //a.Drive();
            //Console.Write("\n");
            //a.race();

            //11.is-a relationship
            //Animal animal = new Animal();
            //animal.Name = "Puppy";
            //animal.Eat();
            //Console.WriteLine("\n");

            //Dog dog = new Dog();
            //dog.Name = "German";
            //dog.Eat();
            //dog.Bark();

            //12.HAS 
            //Engine e = new Engine(200,"Honda");
            //Console.WriteLine("\n");
            //Car c = new Car("Benz", 450, "Petrol-Engine");

            //13.base method

            //Person p = new Person("Norah", "engineer");
            //p.DisplayInfo();

            //Console.WriteLine("\n");

            //Employee E = new Employee("Martin","Doctor",23);
            //E.DisplayInfo();

            //14. base

            //Person P = new Person("Norah");

            //Console.WriteLine("\n");
            //Student S = new Student("Martin");


            //15.
            Vehicle V = new Vehicle("Benz");
            Console.WriteLine("\n");
            Car c = new Car("BMW");




            Console.ReadLine();
        }
    }
}
