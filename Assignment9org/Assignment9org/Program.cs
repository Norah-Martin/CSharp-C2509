using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment9org.Class1;

namespace Assignment9org
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //notes:polymorphism :more than one form,  mainly two types:compile tima and run time


            //1.shape
            //Shape S = new Shape();
            //S.Draw();
            //Console.WriteLine("\n");
            //Circle c=new Circle();
            //c.Draw();
            //Console.WriteLine("\n");
            //Rectangle r=new Rectangle();
            //r.Draw();

            //2.overload

            //Mathmultiply m = new Mathmultiply();
            //m.Multiply(2, 3);
            //m.Multiply(2.4,5);
            //m.Multiply(2, 3, 4);

            //3.override

            //Vehicle v=new Vehicle();
            //v.Drive();
            //Console.WriteLine("\n");
            //Car c= new Car();
            //c.Drive();

            //4.override

            //Payment payment1 = new CreditCardPayment();
            //payment1.ProcessPayment();
            //Payment payment2 = new PayPalPayment();
            //payment2.ProcessPayment();


            //5.static
            //Employee e=new Employee();
            //Manager M=new Manager();
            //Developer d = new Developer();
            //Manager m = new Manager();
            //Developer D= new Developer();
            //Manager MA = new Manager();

            //Console.WriteLine($"The number of employees:{Employee.getcounter()}");

            //6.polymorphism and array
            Employee[] emp = new Employee[]
            {
                new Manager("Norah",new string[]{"presentation","oversee work"}),
                new Developer("martin",new string[]{"develop fromt page","design ui/ux"})
            };
            foreach (var employee in emp)
            {
                employee.display();
                Console.WriteLine();
            }

            //7 override and overload
            //Area a=new Area();
            //a.area(2, 3);
            //Console.WriteLine("\n");

            //a.area(2, 3, 4);
            //Console.WriteLine("\n");
            //a.calc(2, 3);

            //Console.WriteLine("\n");
            //Rectangle r = new Rectangle();
            //r.calc(4, 5);

            //8.runtime
            ////Shape S = new Rectangle();
            ////S.Draw();
            ///
            //Rectangle r = new Rectangle();
            //r.Draw();

            //9.multiple

            //Car c=new Car();
            //c.Move();
            //Console.WriteLine("\n");
            //c.Draw();


            //10 readonly
            //Vehicle v = new Vehicle("Benz");
            //v.info();
            //Console.WriteLine("\n");

            //Car c = new Car("BMW");
            //c.info();

            Console.ReadLine();
        }
    }
}
