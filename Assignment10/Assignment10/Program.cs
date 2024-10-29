using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment10.Class1;


namespace Assignment10
{

    internal class Program
    {
        static void Main(string[] args)
        {

            //1.abstact

            //Car c = new Car();
            //c.StartEngine();
            //c.StopEngine();
            //Console.WriteLine("\n");
            //Motorcycle m = new Motorcycle();
            //m.StartEngine();
            //m.StopEngine();

            //2.virtual-override
            //Animal animal = new Animal();
            //animal.MakeSound();
            //Console.WriteLine("\n");
            //Dog dog = new Dog();
            //dog.MakeSound();
            //Console.WriteLine("\n");
            //cat c = new cat();
            //c.MakeSound();

            //3.interfcae
            //Car car = new Car();
            //car.Drive();
            //Console.WriteLine("\n");
            //Truck truck = new Truck();
            //truck.Drive();

            //4 abstract and interface
            //Parrot p = new Parrot();
            //p.Fly();
            //Console.WriteLine("\n");
            //Pool pool = new Pool();
            //pool.Swim();

            //5. static class
            //MathOperations.Add(2, 3);
            //Console.WriteLine("\n");
            //MathOperations.Multiply(2, 3);

            //6.extension static
            //Even e = new Even();
            //e.display();
            //Sample.IsEven(21);

            //7.partial class---error
            //Partial1 p= new Partial1("Norah");
            //p.showdetails();

            //8.PARTIAL CLASS PARTIAL METHOD
            //Employee e = new Employee(12345);
            //e.CaculateSalary();

            //9.index
            //Library l = new Library();
            //l.Book[0] = "The Lord of Rings";
            //l.Book[1] = "The Kite Runner";
            //l.Book[2] = "I am Malala";
            //l.display();

            //10.exception try catch finally
            //try
            //{
            //    Division d = new Division();
            //    d.num1 = 8;
            //    d.num2 = 2;
            //    d.Divide();
            //    Console.WriteLine("\n");
            //    Division d1 = new Division();
            //    d1.num1 = 28;
            //    d1.num2 = 0;
            //    d1.Divide();
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}finally
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("--program over--");
            //}

            //11.enum
            //Car c=new Car();
            //foreach (Car.CarType i in Enum.GetValues(typeof(Car.CarType)))
            //{

            //    Console.WriteLine($"{(int)i}----{i}");
            //}
            //Console.Write("enter a number :");
            //int num=int.Parse(Console.ReadLine());
            //c.Display(num);
            //Console.WriteLine("\n");
            //c.Type = Car.CarType.Truck;
            //c.Display((int)c.Type);

            //12.attribute
            // Get the type of the Calculator class
            Type type = typeof(Calculator);

            // Retrieve custom attributes--- class
            object[] classAttributes = type.GetCustomAttributes(false);

            foreach (DeveloperAttribute attr in classAttributes)
            {
                Console.WriteLine($"Class Developer: {attr.Name}, Last modified: {attr.Date}");
                Console.WriteLine("\n");
            }

            // Retrieve custom attributes ---Add method
            var methodInfo = type.GetMethod("Add");
            object[] methodAttributes = methodInfo.GetCustomAttributes(false);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------");
            foreach (DeveloperAttribute attr in methodAttributes)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Method Developer: {attr.Name}, Last modified: {attr.Date}");
            }



            Console.ReadLine();
        }
    }
}
