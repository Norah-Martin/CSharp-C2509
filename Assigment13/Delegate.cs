using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static Assigment13.Program;

namespace Assigment13
{
    //3.Create a simple calculator using delegates. Define a delegate OperationDelegate that can
    //represent different arithmetic operations(addition, subtraction, multiplication, division).
    //Implement methods for each operation and allow the user to select an operation to perform on
    //two input numbers.

    public class Calculator
    {
        public double Operation(double x,double y)
        {
            
            Console.WriteLine("enter your choice: 1. Addition" +
                "   2. Subtraction" +
                "   3. Multiplication" +
                "    4. Division");
            int choice=int.Parse(Console.ReadLine());
            Calculator c1 = new Calculator();

            switch (choice)
            {
                case 1:

                    add  a1 = new add(c1.Addition);
                            double ans=a1(x, y);
                            return ans;
                        
                case 2:sub s1 = new sub(c1.Subtraction);
                           double ans2= s1(x, y);
                            return ans2;
                       
                       
                case 3:mult m1 = new mult(c1.Multiplication);
                           double ans3= m1(x, y);
                             return ans3;



                case 4:div d1 = new div(c1.Division);
                                double ans4=  d1(x, y);
                    return ans4;


                default:
                    Console.WriteLine("sorry");
                    return 0;
                             
            }
        }
        public double Addition(double x, double y)
        {
            return x + y;
        }
        public double Subtraction(double x, double y)
        {
            return x - y;

        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }
        public double Division(double x,double y)
        {
            if(y!=0)
            {
                return x / y;
            }
            else
            {
                Console.WriteLine("no division");
                return 0;
            }
        }

    }

}
