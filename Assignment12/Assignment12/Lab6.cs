using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class Lab6
    {
        //Write a C# program to reverse a string. 

        //public void Reverse()
        //{
        //    Console.Write("enter the string: ");
        //    string str = Console.ReadLine();
        //    char[] StrArray = str.ToCharArray();
        //    Console.WriteLine("\n");
        //    Console.WriteLine("using reverse function ");
        //    Array.Reverse(StrArray);
        //    string RevString = new string(StrArray); 
        //        Console.WriteLine("reversed is: " + RevString);


        //    for (int i = str.Length-1,j=0; i >= 0; i--,j++)
        //    {


        //        StrArray[j] = str[i];
        //    }
        //    Console.WriteLine("\n");
        //    Console.WriteLine("reverse string is:");
        //    string RevString2 = new string(StrArray);
        //    Console.WriteLine("reversed is: " + RevString2);



        // }



        //7. Write a C# program to find substring occurrence within a main string. 

        //public void SubString()
        //{
        //    Console.Write("enter the string: ");
        //    string str = Console.ReadLine();
        //    Console.Write("enter the sub string to be found: ");
        //    string substr = Console.ReadLine();
        //    int index=str.IndexOf(substr); //find the starting index within string
        //    Console.WriteLine($"the substring -- {substr} --found at position :{index}");

        //}

        //Assignment 8. Write a C# program to convert string to uppercase, lowercase, and title case. 

        //public void Convert()
        //{
        //    Console.WriteLine("enter the string: ");
        //    string str= Console.ReadLine();
        //    Console.WriteLine("UPPERCASE: ");
        //    Console.WriteLine(str.ToUpper());

        //    Console.WriteLine("\n");
        //    Console.WriteLine("LOWERCASE");
        //    Console.WriteLine(str.ToLower());

        //    Console.WriteLine("\n");
        //    Console.WriteLine("TITLECASE");

        //    //tottilecase is a part of textinfo which is a part of culture info class in system.gloabaliuzation

        //    //textinfo--Provides information about a specific culture 
        //    //culture info --Provides information about a specific culture 

        //    //currentculture--Gets or sets the CultureInfo object that represents the culture used by the current thread and task-based asynchronous operations.
        //    TextInfo textInfo =CultureInfo.CurrentCulture.TextInfo;
        //    string res = textInfo.ToTitleCase(str);
        //    Console.WriteLine(res);
        //}

        //Assignment 9. Write a C# program to remove whitespace from a string. 
        //public void WhiteSpace()
        //{
        //    Console.WriteLine("enter the string");
        //    string str=Console.ReadLine();
        //    Console.WriteLine("\n");

        //    //remove used for specific position

        //    Console.WriteLine("TRIM--remove the trailing and begining space");
        //    string str2 = str.Trim(); //WILL REMOVE the white space from begining and end
        //    Console.WriteLine(str2);
        //    Console.WriteLine("\n");

        //    //remove used for specific position
        //    Console.WriteLine("REMOVE--specific position(int) removed");
        //     str2 = str.Remove(2,4);
        //    Console.WriteLine(str2);
        //    Console.WriteLine("\n");

        //    //replace all white space including between
        //    Console.WriteLine("REPLACE-- replace the blanckspace");
        //    str = str.Replace(" ","");
        //    Console.WriteLine(str);
        //}


        //Assignment 10. Write a C# program to replace all occurrences of a substring. 
        //public void RemoveSub()
        //{
        //    Console.WriteLine("ENTER THE STRING :");
        //    string str=Console.ReadLine();

        //    Console.WriteLine("\n");
        //    Console.WriteLine("enter the substring to be replace");
        //    string sub = Console.ReadLine();

        //    Console.WriteLine("\n");
        //    Console.WriteLine("replace with which string ");
        //    string str2=Console.ReadLine();

        //    str = str.Replace(sub, str2);
        //    Console.WriteLine("\n");
        //    Console.WriteLine(str);

        //}


    }
}
