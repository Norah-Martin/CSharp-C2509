using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////greatest among three number
            //Console.WriteLine("ENTER NUMBERS:");
            ////num1 = num1.convertToInt32(num1);
            //int num1,num2, num3;
            //num1 = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());
            //num3 = int.Parse(Console.ReadLine());



            //if ((num1 > num2) && (num1 > num3))
            //{

            //    Console.WriteLine(num1 + " is greater");
            //}
            //else if (num2 > num3)

            //{ Console.WriteLine(num2 + " is greater"); }

            //else


            //{ Console.WriteLine(num3 + " is greater"); }

            //-----for loop-----
            //for(int i=0;i<=10;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //-----nested for loop----
            //for(int i=0;i<=2;i++)
            //{
            //    for(int j=0;j<=2;j++)
            //    {
            //        Console.WriteLine($" {i}{j} ");
            //    }
            //}

            //----1,3,5...
            //for(int i=1; i<=11;i=i+2)
            //{
            //    Console.WriteLine(i);
            //}

            //*
            //**
            //Console.WriteLine("Enter the rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //for(int i = 0; i < rows; i++)
            //{
            //   for(int j=0;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //--------while loop---
            //int i = 0;
            //while(i<=10)
            //    {
            //    Console.WriteLine(i);
            //    i++;

            //}
            //do while loop
            //int k = 0;
            //do
            //{
            //    Console.WriteLine(k);
            //    k++;

            //} while (k <= 10);

            //--sum of five first natural numbers
            //int sum = 0;
            //for(int i=1;i<=5;i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine($"The sum is {sum}");




            //break and continue
            //for(int i=0;i<=10;i++)
            //{
            //    if(i==4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //10 30 50 ...using continue

            //for (int i = 10; i <= 190; i = i + 10)
            //{
            //    if (i % 20 == 0)
            //    {
            //        continue;

            //    }
            //    if (i >190)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);

            //}

            //-----switch case-------
            //Console.WriteLine("Enter num: ");
            //int num =int.Parse(Console.ReadLine());
            //int Flag;
            //if(num%2==0)
            //{
            //    //flag
            //    Flag = 1;
            //}
            //else
            //{

            //    Flag = 0;

            //}

            //switch (Flag)
            //{
            //    case 1: Console.WriteLine("even");
            //                   break;
            //    case 0:Console.WriteLine("odd");
            //        break;

            //    default:
            //        Console.WriteLine("sorry");
            //        break;

            //}

            //arrays:
            //int[] num = { 1, 2, 3, 4, 5 };
            //string[] days = { "Monday", "Tuesday" };
            //for (int i = 0; i <=num.Length; i++) {
            //    Console.WriteLine(num[i]);

            //}

            //    1
            //   2 3
            //  4 5 6
            //7 8 9 10
            int space = 50;
            int x = 0;
            for(int i=0;i<=10;i++)
            {
                for (int j = 0; j >= i; j--)
                {
                    Console.Write(" ");



                }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write(++x+" ");
                    
                    }
               
                
                Console.WriteLine();
                
            }

            Console.ReadLine();
            //int space = 50;
            //int x = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = space; j >= i; j--)
            //    {
            //        Console.Write(" ");


            //    }
            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write(++x + " ");

            //    }


            //    Console.WriteLine();

            //}

            //Console.ReadLine();
        }
    }
}
