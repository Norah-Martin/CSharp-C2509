using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;
using System.Runtime.Remoting.Messaging;
using System.CodeDom;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. library and array declaration
            //try
            //{
            //    Library library = new Library();
            //    library.Books[0] = "I am Malala";
            //    library.Books[1] = "The kite Runner";
            //    library.Books[2] = "Born a Crime";
            //    library.Display();

            //    Console.WriteLine("--------------------");
            //    Classroom classroom = new Classroom();
            //    classroom.Seats[0, 0] = "Norah";
            //    classroom.Seats[0, 1] = "Martin";
            //    classroom.Seats[1, 0] = "Isabella";
            //    classroom.Seats[1, 1] = "Edvin";

            //    classroom.Display();
            //    //to show the error
            //    classroom.Seats[2, 3] = "xxxxx";
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine("ERROR");
            //}
            //finally
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("---------------end-----------------");
            //}



            ////2.movie array
            //try
            //{
            //    Movie movie1 = new Movie("JanaGanaMana", "2021");
            //    Movie movie2 = new Movie("SpderMAN", "2008");
            //    MovieLibrary movieLibrary = new MovieLibrary();
            //    movieLibrary.MovieAdd(movie1, 0);
            //    movieLibrary.MovieAdd(movie2, 1);

            //    movieLibrary.Display();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine("ERROR");

            //}
            //finally
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("-----------end-------------");
            //}


            //3.order status
            //Order order = new Order("Keyboard", Order.OrderStatus.Pending);
            //Order order1 = new Order("Mouse", Order.OrderStatus.Shipped);
            //Order order2 = new Order("Phone", Order.OrderStatus.Pending);
            //Order order3 = new Order("Bottle", Order.OrderStatus.Delivered);
            //order.AddOrder(order, 0);
            //order.AddOrder(order1, 1);
            //order.AddOrder(order2, 2);
            //order.AddOrder(order3, 3);

            //order.Display();

            ////4.struct and circle
            //try
            //{
            //    Circle circle1 = new Circle();
            //    circle1.radius = 10;
            //    Circle circle2 = new Circle();

            //    Console.WriteLine($"value before:{circle1.radius}");
            //    Console.WriteLine($"value before:{circle2.radius}");
            //    circle1.radius = 5;

            //   // circle1.Calculate(circle1.radius);

            //    Console.WriteLine($"Value After :{circle1.radius}");
            //    Console.WriteLine($"value before:{circle2.radius}");

            //    Console.WriteLine("\n");
            //    Shape shape = new Shape();
            //    shape.radius = 10;
            //    Console.WriteLine($"value before:{shape.radius}");
            //    shape.Calculate( shape.radius);
            //    Console.WriteLine($"Value After :{shape.radius}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine("ERROR");
            //}
            //finally
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("-----------the end-----------");
            //}

            //5.. Create a method IncreaseScore that takes a ref integer parameter representing a
            //player’s score and increases it by 10.

            //int Score = 4;
            //Console.WriteLine($"Score Before:{Score}");
            //IncreaseScore(ref Score);
            //Console.WriteLine("\n");
            //Console.WriteLine($"Score After:{Score}");
            ////function
            //void IncreaseScore(ref int num)
            //{
            //    Score = num + 10;

            //}


            //6.Create a method Divide that takes two integers, calculates their quotient and
            // remainder, and returns both values using the out keyword.

            //int num1 = 20; //just to show the difference before this
            //int num2 = 30;
            //Console.WriteLine($"number1 is {num1} and num2:  {num2}");
            //Divide(out num1, out num2);
            //Console.WriteLine("\n");
            //Console.WriteLine($"number1 is {num1} and num2:  {num2}");

            //void Divide(out int number1, out int number2)
            //{
            //    number1 = 1000; //this value used
            //    number2 = 100;
            //    if (number2 == 0)
            //    {
            //        Console.WriteLine("no division");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"division is:{number1 / number2}");
            //    }

            //}

            //7.Write a C# program that demonstrates a FileNotFoundException and an
            // IndexOutOfRangeException.Explain what causes these exceptions.

            ////FILE NOT FOUND EXCEPTION
            //try
            //{
            //    using (StreamReader read = new StreamReader("demo.txt")) //using --automatic closing
            //    {
            //        read.ReadToEnd();
            //    }

            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("--error--");
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine("\n");
            //    Console.WriteLine(ex.StackTrace);

            //}

            ////index out of range
            //try
            //{
            //    int[] arr = { 1, 2, 3 };
            //    Console.WriteLine($"{arr[0]}");
            //    Console.WriteLine("\n");
            //    Console.WriteLine($"{arr[5]}"); //error
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("--error--");

            //    Console.WriteLine("\n");
            //    Console.WriteLine(ex.Message);

            //}

            //8.Question: Create a method GetUserInput that prompts the user to enter an integer. If the input is
            //  invalid, catch the exception and prompt the user again until they enter a valid integer.

            //GetUserInput();
            //void GetUserInput()
            //{
            //    int number;
            //    //to loop till we get number
            //    while (true)
            //    {
            //        Console.WriteLine("\n");
            //        Console.WriteLine("enter the number:");
            //        try
            //        {
            //            number = int.Parse(Console.ReadLine());
            //            Console.WriteLine($"entered number: {number}");
            //            break;

            //        }
            //        catch (FormatException ex) //if not integer //small letter
            //        {

            //            Console.WriteLine(ex.Message);
            //        }
            //    }

            //}

            //9.Create a method that calculates the division of two integers. Use multiple catch blocks
            //to handle DivideByZeroException and FormatException.
            //try
            //{
            //    //get the input of two numbers;
            //    Console.Write("enter the first number: ");
            //    int number1 = int.Parse(Console.ReadLine());

            //    Console.Write("\n enter the second number: ");
            //    int number2 = int.Parse(Console.ReadLine());

            //    //check second number zero?
            //    if (number2 == 0)
            //    {
            //        throw new DivideByZeroException();
            //    }
            //    Console.Write($"quotient is: {number1 / number2}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine(ex.StackTrace);

            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("------");
            //    Console.WriteLine("\n");
            //    Console.WriteLine(ex.StackTrace);
            //}
            //finally
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("\nend---------");
            //}

            //10.  Write a method ReadFile that opens a file, reads its contents, and closes it. Use a
            //finally block to ensure the file is closed, even if an exception occurs.
            //ReadFile();
            //void ReadFile()
            //{//reading a file

            //    try
            //    {
            //        StreamReader reader = new StreamReader("C:/Users/ASUS/Desktop/c#.net/sample.txt");
            //        string text = reader.ReadToEnd();
            //        Console.WriteLine(text);

            //        reader.Close();
            //    }
            //    catch (FileNotFoundException ex)
            //    {
            //        Console.WriteLine("File not found.");
            //        Console.WriteLine("\n");
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("An error occurred.");
            //        Console.WriteLine("\n");
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //    finally
            //    {
            //        // Ensure the file is closed, even if an exception occurred

            //        Console.WriteLine("\n");
            //        Console.WriteLine("File closed.");



            //          }

            //        }


            //11 Create a method ValidateAge that
            // throws an exception if the age is below 18, and handle it in the calling method.
            //ValidateAge();
            //void ValidateAge()
            //{
            //    try
            //    {
            //        Console.WriteLine("ENTER THE AGE: ");
            //        int age = int.Parse(Console.ReadLine());

            //        if (age < 18)
            //        {
            //            throw new ArgumentException();

            //        }
            //        else
            //        {
            //            Console.WriteLine($"age is:{age}");
            //        }
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine("\n");
            //        Console.WriteLine(ex.StackTrace);
            //        Console.WriteLine("\n");
            //        Console.WriteLine("------error------");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("------end-------");
            //    }

            //}

            //12. Create a custom exception class NegativeNumberException to handle negative inputs.
            //Write a method CheckNumber that throws this exception if the number is negative.

            //try
            //{
            //    Console.WriteLine("enter the number");
            //    int number = int.Parse(Console.ReadLine());
            //    CheckNumber(number);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("\n");
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine("--error--");
            //}
            //finally
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("----end-----");
            //}
            //void CheckNumber(int number)
            //{
            //    if (number < 0)
            //    {
            //        throw new NegativeNumberException();
            //    }
            //    Console.WriteLine($"number is : {number}");

            //}

            //14.. Create a custom exception NegativeNumberException to handle scenarios where a
            //negative number is passed to a method that only accepts positive numbers.Write code to throw
            // this exception if the number is negative.

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("\n");
            //        Console.WriteLine("ENTER THE NUMBER: ");
            //        int number = int.Parse(Console.ReadLine());
            //        CheckNumber(number);
            //        break;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("\n");
            //        Console.WriteLine(ex.StackTrace);
            //        Console.WriteLine("--error--");
            //    }
            //    finally
            //    {

            //        Console.WriteLine("\n");
            //        Console.WriteLine("---------END------------");
            //    }
            //}
            //    void CheckNumber(int number)
            //    {
            //        if(number<0)
            //        {
            //            throw new NegativeNumberException();
            //        }
            //        Console.WriteLine($"number is:{number}");

            //    }



            //15.a fileproceesor
            //try
            //{
            //    FileProcessor file = new FileProcessor();
            //    file.ReadFileContent("C:/Users/ASUS/Desktop/c#.net/sample.txt");


            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("FILE NOT FOUND");
            //    Console.WriteLine("\n");
            //    Console.WriteLine(ex.StackTrace);

            //}
            //finally
            //{
            //    Console.WriteLine("----END-----");
            //}


            //15b mathoperations
            //try
            //{
            //    MathOperations maths = new MathOperations();
            //    int ans = maths.Divide(8, 2);
            //    Console.WriteLine($"quotient is: {ans}");
            //    int res = maths.Divide(8, 0);


            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("cannot divide by zero..");
            //    Console.WriteLine("\n");
            //    Console.WriteLine(ex.StackTrace);
            //}


            //15c custom invalid exception
            //try
            //{
            //    Person person = new Person();
            //    person.SetAge(24);
            //    person.SetAge(150);
            //}
            //catch (InvalidAgeException ex)
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine(ex.StackTrace);
            //}



            Console.ReadLine();
        }
    }
}
