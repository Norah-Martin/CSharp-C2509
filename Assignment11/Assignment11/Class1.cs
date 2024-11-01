using Assignment11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.CodeDom;
namespace Assignment11
{
    //    //1.Create a Library class to store and manage books in a single-dimensional array where
    //   // each element represents a book title
    //public class Library
    //{
    //    public string[] Books = new string[3];
    //    public void Display()
    //    {
    //        int i = 0;
    //        //loop to display the books
    //        foreach (var item in Books)
    //        {

    //            Console.WriteLine($"{i}  --   {item}");
    //            Console.WriteLine("\n");
    //            i++;
    //        }
    //    }

    //}
    //         //    use a two-dimensional array in a Classroom class
    //        //where each element represents the seat of a student based on rows and columns.

    //public class Classroom
    //{
    //    public string[,] Seats = new string[2, 2];
    //    public void Display()
    //    {
    //        for (int i = 0; i < Seats.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < Seats.GetLength(1); j++)
    //            {
    //                Console.WriteLine($"Seat:{i}-{j}    -- {Seats[i, j]} ");
    //                Console.WriteLine("\n");
    //            }

    //        }

    //    }
    //}


    //2.array-Define a Movie class with properties like Title and Year. Create a MovieLibrary class
    // that stores an array of Movie objects and displays each movie’s information
    //public class Movie
    //{
    //    public string Title { get; set; }
    //    public string Year { get; set; }
    //    public Movie(string title, string year)
    //    {
    //        Title = title;
    //        Year = year;
    //    }

    //}
    //public class MovieLibrary
    //{
    //    //array to hold object,instaed of string or int we give class name

    //    public Movie[] Movies = new Movie[2];

    //    public void MovieAdd(Movie movie, int index)
    //    {

    //        for (int j = index; j < 2; j++)
    //        {
    //            Movies[j] = movie;

    //        }
    //    }
    //    public void Display()
    //    {
    //        for (int j = 0; j < 2; j++)

    //        {
    //            Console.WriteLine($"{Movies[j].Title}   --  {Movies[j].Year}");
    //            Console.WriteLine("\n");
    //        }
    //    }

    //}

    //3.Create an enumeration OrderStatus with values Pending, Shipped, and Delivered.
    //Define an Order class with an OrderStatus property to manage the status of each order

    //public class Order
    //{
    //    public string Name;
    //    //ENUMERATION
    //    public OrderStatus Status;
    //    public Order(string name, OrderStatus status)
    //    {
    //        Name = name;
    //        Status = status;
    //    }
    //    //ARRAY TO STORE MULTIPLE ORDERS

    //    public Order[] Orders = new Order[4];
    //    public enum OrderStatus
    //    {
    //        Pending,
    //        Shipped,
    //        Delivered
    //    }
    //    public void AddOrder(Order ord, int index)
    //    {
    //        for (int i = index; i < Orders.Length; i++)
    //        {
    //            Orders[i] = ord;
    //        }
    //    }


    //    public void Display()
    //    {
    //        Console.WriteLine("Orders.Name  ----      OrdersStatus---   OrdersStatusId");
    //        Console.WriteLine("\n");

    //        for (int i = 0; i < Orders.Length; i++)
    //        {
    //            Console.WriteLine($"{Orders[i].Name}\t  {Orders[i].Status}\t\t  {(int)Orders[i].Status}");
    //            Console.WriteLine("\n");
    //        }
    //    }
    //}


    //4.struct--Create a Circle struct to represent a circle as a value type, and a Shape class to
    //represent a reference type.Show how changing values affects each.

    //struct Circle
    //{
    //    public int radius;
    //    public void Calculate(int radius)
    //    {
    //        Console.WriteLine($"area is:{3.14 * radius * radius}");

    //        radius = 4;



    //    }
    //}
    //public class Shape
    //{
    //    public int radius;
    //    public void Calculate(int radius)
    //    {
    //        Console.WriteLine($"area is:{3.14 * radius * radius}");

    //        radius = 4;
    //    }

    //}

    //12.user defined exception

    //public class NegativeNumberException : Exception
    //{

    //    public NegativeNumberException()
    //    {
    //        Console.WriteLine("Number less than zerooo");


    //    }
    //}


    //14..user defined
    //public class NegativeNumberException : Exception
    //{
    //    public NegativeNumberException()
    //    {
    //        Console.WriteLine("less than zerooooo");
    //    }

    //}


    //15  a
    //    Create a class FileProcessor with a method ReadFileContent(string filePath).
    //o In this method, attempt to read content from the file located at filePath using
    //StreamReader.
    //o Handle FileNotFoundException by printing a message that says "File not found:
    //<filePath>". 


    //public class FileProcessor
    //{
    //    public void ReadFileContent(string filePath)
    //    {
    //        StreamReader sr = new StreamReader(filePath);
    //        string text = sr.ReadToEnd();
    //        Console.WriteLine(text);

    //        //closing file
    //        sr.Close();
    //    }
    //}


    //15b  Create a class MathOperations with a method Divide(int a, int b).
    //o This method should return the result of dividing a by b.
    //o Handle DivideByZeroException and print "Cannot divide by zero"

    //public class MathOperations
    //{
    //    public int Divide(int a, int b)
    //    {
    //        if (b == 0)
    //        {
    //            throw new DivideByZeroException();
    //        }
    //        return (a / b);
    //    }

    //}


    //15c Create a custom exception called InvalidAgeException that inherits from
    //    Exception.
    //    o Create a class Person with a property Age.
    //    o Add a method SetAge(int age) in Person that throws an InvalidAgeException if
    //age is less than 0 or greater than 120.
    //o Print "Invalid age provided" if the exception is thrown.

    //public class Person
    //{
    //    public int age;
    //    public void SetAge(int age)
    //    {
    //        if (age < 0 || age > 120)
    //        {
    //            Console.WriteLine("\n");
    //            throw new InvalidAgeException();
    //        }
    //        Console.WriteLine($"age is : {age}");
    //    }
    //}

    ////exception
    //public class InvalidAgeException : Exception
    //{
    //    public InvalidAgeException()
    //    {
    //        Console.WriteLine("Invalid age is provided");

    //    }

    //}


    //15d.
}





