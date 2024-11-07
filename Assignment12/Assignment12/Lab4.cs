using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment12
{
    public class Lab4
    {
        // write C# programs for finding median, mode value,
        //, second highest and duplicate elements in an array.
        //public void Median()
        //{
        //    Console.WriteLine("ENTER THE SIZE OF ARRAY: ");
        //    int size=int.Parse(Console.ReadLine());
        //    int[] arr = new int[size];
        //    Console.WriteLine("ENTER THE NUMBERS");
        //    for (int i = 0; i < size; i++)
        //    {
        //        arr[i] = int.Parse(Console.ReadLine());

        //    }
        //    //finding median
        //    int mid = 0;
        //    if(size%2==0)
        //    {
        //        mid=size/2;
        //        Console.WriteLine("\n");
        //        Console.WriteLine($"median is :{arr[mid-1]}");
        //    }
        //    else
        //    {
        //        mid = (size + 1) / 2;
        //        Console.WriteLine("\n");
        //        Console.WriteLine($"median is :{arr[mid-1]}");
        //    }

        //}

        //mode
        //public void Mode()
        //{
        //    Console.WriteLine("ENTER THE SIZE OF ARRAY: ");
        //    int size = int.Parse(Console.ReadLine());
        //    int[] arr = new int[size];
        //    Console.WriteLine("ENTER THE NUMBERS");
        //    HashSet<int> set = new HashSet<int>();
            
        //    int max = 0;
        //    int count = 0;
        //    int num = 0;
        //    for (int i = 0; i < size; i++)
        //    {
        //        arr[i] = int.Parse(Console.ReadLine());

        //    }
        //    for (int i = 0; i < size; i++)
        //    {
        //        if (!set.Contains(arr[i]))
        //        {
        //            count = arr.Count(x => x.Equals(arr[i]));
        //            set.Add(arr[i]);

        //        }
        //        if (count > max)
        //        {
        //            max = count;
        //            num = arr[i];


        //        }
        //    }
        //    Console.WriteLine("\n");
        //    Console.WriteLine($"mode is: {num}");


        //    }


            //        //hightest
            //        public void highest()
            //        {
            //            Console.WriteLine("enter the size of array: ");
            //            int size = int.Parse(Console.ReadLine());
            //            Console.WriteLine("enter the array:");
            //            int[] arr = new int[size];
            //            int highest = arr[0];
            //            for (int i = 0; i < size; i++)
            //            {
            //                arr[i] = int.Parse(Console.ReadLine());
            //            }


            //            for (int i = 0; i < size; i++)
            //            {
            //                if (arr[i] > highest)
            //                {
            //                    highest = arr[i];
            //                }
            //            }
            //            Console.WriteLine("\n");
            //            Console.WriteLine($"HIGHEST NUMBER IS {highest}");
            //        }

            //second highest
            //public void SecondHighest()
            //{
            //    Console.WriteLine("enter the size of the array: ");
            //    int size=int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter the array");
            //    int[] ar=new int[size];
            //    for (int i = 0; i < size; i++)
            //    {
            //        ar[i] = int.Parse(Console.ReadLine());

            //    }
            //    //insertion sort
            //    for (int i = 1; i < ar.Length; i++)
            //    {
            //        int value = ar[i];
            //        int j = i - 1;
            //        while (j >= 0 && ar[j] > value)
            //        {
            //            ar[j + 1] = ar[j];
            //            j--;

            //        }
            //        ar[j + 1] = value;

            //    }

            //    Console.WriteLine("\n");
            //    Console.WriteLine($"second highest number is:{ar[size-2]}");

            //}

            //dupliacte

            //   public void Duplicate()
            //{
            //    Console.WriteLine("enter the size of array: ");
            //    int size=int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter the array ");
            //    int[] arr=new int[size];
            //    HashSet<int> set = new HashSet<int>();
            //    HashSet<int> duplicates = new HashSet<int>();
            //        int count = 1;
            //    for (int i = 0; i < size; i++)
            //    {
            //        arr[i]=int.Parse(Console.ReadLine());
            //    }
            //    foreach(int i in arr)
            //    {
            //        if(!set.Contains(i))
            //        { 
            //            count=arr.Count(x=>x==i);
            //            set.Add(i);
            //        }
            //        if(count>1&& !duplicates.Contains(i))
            //        {
            //            Console.WriteLine($"Duplicate entry {i}");
            //            duplicates.Add(i);

            //        }
            //    }

            //}


        }
}
