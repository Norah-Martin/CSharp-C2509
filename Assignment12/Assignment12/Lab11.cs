using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment12
{
    public  class Lab11
    {
        //Assignment 11. Write a C# program to find the longest word in a sentence
        //    public void Longest()
        //    {
        //        Console.WriteLine("enter the string");
        //        string str = Console.ReadLine();

        //        string[] strings = str.Split(' ');
        //        int count = strings[0].Length;
        //        string word = strings[0];
        //        foreach (string s in strings)
        //        {
        //            if (s.Length > count)
        //            {
        //                count = s.Length;
        //                word = s;
        //            }
        //        }
        //        Console.WriteLine("\n");
        //        Console.WriteLine($"longest word is: {word}");
        //    }


        //Assignment 12. Write a C# program to count words in a sentence. 
        //public void CountWords()
        //{
        //    Console.WriteLine("enter the string");
        //    string str=Console.ReadLine();

        //    string[] strings = str.Split(' ');
        //    int count = 0;
        //    foreach(string s in strings)
        //    {
        //        count++;
        //    }
        //    Console.WriteLine($"count : {count}");
        //}


        //Assignment 13. Write a C# program to remove duplicate characters from a string. 

        //public void RemoveDuplicate()
        //{
        //    Console.WriteLine("ENTER THE STRING");
        //    string str = Console.ReadLine();

        //    //hashset--  HashSet to track unique characters
        //    HashSet<char>seenchar=new HashSet<char>();
        //    String result = "";
        //    foreach(char c in str) 
        //    {
        //        if(!seenchar.Contains(c)) //Determines whether a sequence contains a specified element by using the default equality comparer.
        //        {
        //            seenchar.Add(c);
        //            result += c;
        //        }
        //    }
        //    Console.WriteLine($"RESULT IS: {result}" );
        //}


        //Assignment 14. Write a C# program to check if two strings are anagrams. 
        //public void Anagram()
        //{
        //    Console.WriteLine("enter the first string");
        //    string str = Console.ReadLine();   //listen
        //    Console.WriteLine("\n");          
        //    Console.WriteLine("enter the second string");
        //    string str2 = Console.ReadLine();

        //    //frist remove all the spaces and convert to lower case
        //    str = str.Replace(" ", "").ToLower();    
        //    str2 = str2.Replace(" ", "").ToLower();

        //    //SORT USING LINQ --CONCAT
        //    string sortstr1 = string.Concat((str.OrderBy(x => x)));  //sort then concat sort ['e','i\..] concat==ei
        //    string sortstr2=string.Concat((str2.OrderBy(x => x)));

        //    if(sortstr1 == sortstr2)
        //    {
        //        Console.WriteLine("\n");
        //        Console.WriteLine("ANAGRAM");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\n");
        //        Console.WriteLine("NOT ANAGRAM");
        //    }

        // Assignment 15. Write a C# program to find the frequency of each character in a string.
        //public void Frequency()

        //{
        //   Console.WriteLine("enter the string");
        //   string str=Console.ReadLine();

        //   str = str.Replace(" ", "").ToLower();
        //   HashSet<char> seen = new HashSet<char>();
        //   string sortstr = str;
        //   foreach(char c in sortstr)
        //   {
        //       if (!seen.Contains(c))
        //       {


        //           int count = sortstr.Count(x => x.Equals(c));
        //           Console.WriteLine($"{c}--{count}");
        //           seen.Add(c);
        //       }
        //   }
        //}


        // Assignment 16. Write a C# program to find the first non-repeating character in a string. 
        //public void First()
        // {
        //     Console.WriteLine("ENTER THE STRING: ");
        //     string str= Console.ReadLine();
        //     char[] strings = new char[str.Length];

        //     str = str.Replace(" ","").ToLower();

        //     HashSet<char> seen = new HashSet<char>();

        //     foreach (char c in str)
        //     {
        //         if (!seen.Contains(c) && str.Count(x => x==c)==1)
        //         {
        //             Console.WriteLine("\n");
        //             Console.WriteLine("The first non-repeating character is: " + c);
        //             break;

        //         }
        //         seen.Add(c);
        //     }

        // }

        //Assignment 17. Write a C# program to reverse words in a sentence. 
        //public void Reverse()
        //{
        //    Console.WriteLine("enter the string");
        //    string str=Console.ReadLine();
        //    foreach(string s in str.Split())
        //    {
        //        //    Console.WriteLine(s.Reverse );//retrun ienumerable

        //        string ans = new string(s.Reverse().ToArray());
        //        Console.Write(ans + " ");

        //    }


        //}

        //Assignment 18. Write a C# program to check if a string contains only digits. 
        //public void Digit()
        //{
        //    Console.WriteLine("enter the string");
        //    string str=Console.ReadLine();
        //    char[] chars = str.ToCharArray();
        //    bool flag = false;
        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        if (char.IsDigit(chars[i]))
        //        {
        //            flag = true;
        //        }
        //        else
        //        {
        //            flag = false;
        //            break;
        //        }
        //    }
        //    if(flag==true)
        //    {
        //        Console.WriteLine("\n");
        //        Console.WriteLine("ONLY DIGITS");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\n");
        //        Console.WriteLine(" characters");
        //    }
        //}




    }
}
