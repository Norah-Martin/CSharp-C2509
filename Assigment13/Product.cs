using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assigment13
{
    //public class Product
    //{
    //    //        Given a list of products with properties Name and Price,
    //    private string Name;
    //    private int Price;

    //    public string name //HERE SMALL LETTER
    //    {
    //        get { return Name; } //HERE PRIVATE 
    //        set { Name = value; }

    //    }
    //    public int price
    //    {
    //        get { return Price; }
    //        set { Price = value; }
    //    }
    //}

    // // 10  Create a delegate called CalculationDelegate that takes two integers and returns an integer.
    ////Implement methods for addition and subtraction, and write a method Calculate that accepts two
    //integers and a delegate as parameters.Use the delegate to perform addition and subtraction
    //operations by passing different methods

    public class Calculate
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }






}
