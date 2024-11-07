using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public  class Sort
    {
        //2. bubble sort
        //inserting array
        int[] arr = new int[5];
       
        public void Enter()
        {
            Console.WriteLine("enter the array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            BubbleSort(arr);
            InsertionSort(arr);
            
        }
        // 6 2 8 4 10
        //2 6 8 4 10
        //2 6 4 8 10
        //2 4 6 8 10

        public void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("\n---BUBBLE SORT---");
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");

            }
        }



        //3.INSERTION SORT
        public void InsertionSort(int[] arr)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n---INSERTION SORT---");
            
            for(int i = 1; i < arr.Length; i++)
            {
                int value=arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;

                }
              arr[j+1] = value;
                
            }
            Console.WriteLine();
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");

            }
        }



    }
}
