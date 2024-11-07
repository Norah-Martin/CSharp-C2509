
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Policy;
using System.Xml.Linq;

namespace Assignment12
{
    public class Program
    {
        static void Main(string[] args)
        {

            //1.1. Write C# programs on Matrix addition, Matrix Multiplication and Matrix
            //Transpose.
            //addition
            //Class1 c1 = new Class1();
            //int[,] Matrix1 = new int[,]
            //{   {1,2 },
            //    {3,4 }
            //};
            //int[,] Matrix2 = new int[,]
            //{
            //    {1, 2 },
            //    {3,4 }
            //};

            //c1.Display(Matrix1);
            //c1.Display(Matrix2);
            ////adding
            //int[,] Sum = { { 0, 0 }, { 0, 0 } };
            //for (int i = 0; i < Matrix1.GetLength(0); i++)
            //{

            //    for (int j = 0; j < Matrix1.GetLength(1); j++)
            //    {
            //        Sum[i, j] = Matrix1[i, j] + Matrix2[i, j];
            //    }
            //}
            //c1.Display(Sum);


            //matrix multiplication

            //Class1 c1 = new Class1();
            //int[,] Matrix1 = new int[,]
            //{   {1,2 },
            //     {3,4 }
            //};
            //int[,] Matrix2 = new int[,]
            //{
            //     {1, 2 },
            //     {3,4 }
            //};

            //c1.Display(Matrix1);
            //c1.Display(Matrix2);

            ////multiplication
            //int[,] Sum = { { 0, 0 }, { 0, 0 } };
            //for (int i = 0; i < Matrix1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Matrix2.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < Matrix1.GetLength(1); k++)
            //            Sum[i, j] += Matrix1[i, k] * Matrix2[k, j];
            //    }
            //}
            //c1.Display(Sum);


            //transpose

            //Class1 class1 = new Class1();
            //int[,] Matrix1 = new int[,]
            //{
            //    {1, 2 },
            //    {3,4 },


            //};
            //class1.Display(Matrix1);

            //for (int i = 0; i < Matrix1.GetLength(0); i++)

            //{
            //    for (int j = i + 1; j < Matrix1.GetLength(1); j++)
            //    {


            //        int temp = Matrix1[i, j];
            //        Matrix1[i, j] = Matrix1[j, i];
            //        Matrix1[j, i] = temp;


            //    }
            //}
            //class1.Display(Matrix1); //CHANGE IT TO ANOTHER ARRAY;


            //2.bubble and insertion sort
            //Sort sort = new Sort();
            //sort.Enter();



            //3 linear and binary search

            //Console.WriteLine("enter the array");
            //int[] arr = new int[5];
            //Search c1 = new Search();
            //c1.Enter(arr);
            //Console.WriteLine("\n");






            //4.
            //  write C# programs for finding median, mode value,
            //highest, second highest and duplicate elements in an array. 
            //median

            //Lab4 lab4 = new Lab4();
            //  lab4.Median();

            //mode
            Lab4 lab4 = new Lab4();
            lab4.Mode();

            //highest:
            //Lab4 lab4 = new Lab4();
            //lab4.highest
            //

            //second highest
            //Lab4 lab4 = new Lab4();
            //lab4.SecondHighest();

            //duplicate
            //Lab4 lab4 = new Lab4();
            // lab4.Duplicate();



            //STRING MANIPULATIONN

            //5. Write a C# programs to count vowels, consonants and special characters. 
            //Lab5 lab=new Lab5();
            //Console.WriteLine("enter the string");
            //string str=Console.ReadLine();
            //lab.Counter(str);

            //lab6.Write a C# program to reverse a string. 
            //Lab6 lab6 = new Lab6();
            //lab6.Reverse();

            //7. Write a C# program to find substring occurrence within a main string. 

            //Lab6 lab6 = new Lab6();
            //lab6.SubString();

            //8.Assignment 8. Write a C# program to convert string to uppercase, lowercase, and title case. 

            //Lab6 lab6 = new Lab6();
            //lab6.Convert();


            //.Assignment 9. Write a C# program to remove whitespace from a string. 
            //Lab6 lab6 = new Lab6();
            //lab6.WhiteSpace();

            //.Assignment 10. Write a C# program to replace all occurrences of a substring. 
            //Lab6 lab6 = new Lab6();
            //lab6.RemoveSub();

            //Assignment 11. Write a C# program to find the longest word in a sentence
            //Lab11 lab11 = new Lab11();
            //lab11.Longest();


            //Assignment 12. Write a C# program to count words in a sentence. 
            //Lab11 lab11 = new Lab11();
            //lab11.CountWords();


            //Assignment 13. Write a C# program to remove duplicate characters from a string. 
            //Lab11 lab11 = new Lab11();
            //lab11.RemoveDuplicate();

            //Assignment 14. Write a C# program to check if two strings are anagrams. 
            //Lab11 lab11 = new Lab11();
            //lab11.Anagram();


            //Assignment 15.Write a C# program to find the frequency of each character in a string.
            //Lab11 lab11 = new Lab11();
            //lab11.Frequency();

            //Assignment 16.Write a C# program to find the first non-repeating character in a string. 
            //Lab11 lab11 = new Lab11();
            //lab11.First();

            //Assignment 17. Write a C# program to reverse words in a sentence. 

            //Lab11 lab11 = new Lab11();
            //lab11.Reverse
            //

            // Assignment 18.Write a C# program to check if a string contains only digits. 
            // Lab11 lab11 = new Lab11();
            //  lab11.Digit
            //  
            Console.ReadLine();

        }
    }
}
