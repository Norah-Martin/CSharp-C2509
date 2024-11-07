using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
   public  class Lab5
    {
        //Write a C# programs to count vowels, consonants and special characters. 
        int countv = 0;
        int countc = 0;
        int counts = 0;
        public void Counter(string str)
        {
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                char ch= str[i];
                if ("aeiou".Contains(ch))
                {

                    countv++;
                }
                else if ((ch >= 'a' && ch<='z'))
                {
                    countc++;
                }
                else if(char.IsDigit(ch)|| char.IsPunctuation(ch) || char.IsSymbol(ch))
                {
                    counts++;

                }
               
            }
            Console.WriteLine("\n");
            Console.WriteLine($"vowels count:{countv}");
            Console.WriteLine("\n");
            Console.WriteLine($"Consonants count:{countc}");
            Console.WriteLine("\n");
            Console.WriteLine($"Special count:{counts}");  


        }
    }
}
