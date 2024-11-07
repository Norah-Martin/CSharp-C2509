using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class Class1
    {
        //1. matrix output
        public void Display(int[,] Matrix1)
        {
            for (int i = 0; i < Matrix1.GetLength(0); i++)
            {

                for (int j = 0; j < Matrix1.GetLength(1); j++)
                {
                    Console.Write($"{Matrix1[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }




    }

}

