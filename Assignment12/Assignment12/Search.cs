using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class Search
    {
        //3.linear SEARCH AND BNARY SEARCH

        //entering the array
        public void Enter(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the number to be found");
            //entering the item
            int item = int.Parse(Console.ReadLine());


            //calling linear search
            LinearSearch(item, arr);
            Console.WriteLine("\n");
            //sorting array
            InsertionSort(arr);


            //calling binary serach
            BinarySearch(item, arr);
        }

        public void LinearSearch(int item, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"{arr[i]} found at position :{i + 1}");
                    
                }
                
            }
        }

        //INSERTION SORT
        public void InsertionSort(int[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n BINARY SEARCH");

            for (int i = 1; i < arr.Length; i++)
            {
                int value = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;

                }
                arr[j + 1] = value;

            }
            Console.WriteLine();
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");

            }
        }

        public void BinarySearch(int item, int[] arr)
        {

            //binary search 
            int low = 0;
            int high = arr.Length;

            while (low < high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == item)
                {

                    Console.WriteLine();
                    Console.WriteLine($"{item} found at position:{mid}");
                    break;

                }
                else if (arr[mid] < item)
                {
                    low = mid + 1;
                }
                else if(arr[mid]>item)
                {
                    high = mid - 1;
                }
                else
                {
                    Console.WriteLine("--not found--");
                }
            }
        }
    }
}

