using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NUnit.Framework;
namespace Assignment14
{
    
    public  class Program
    {
        public static void Main(string[] args)
        {
            ////1 file and directory operations

            //string dirpath = "MyTestDirectory";
            //string filepath = Path.Combine(dirpath, "testfile.txt");

            ////create if directory not exist
            //if(!Directory.Exists(dirpath))
            //{
            //    Directory.CreateDirectory(dirpath);
            //}

            ////creata and write to file 
            //File.WriteAllText(filepath, "Hello, c#!");
            //if(!File.Exists(filepath))
            //{
            //    File.CreateText(filepath);
            //}

            ////read and display content
            //string filecontent = File.ReadAllText(filepath);
            //Console.WriteLine("THE CONTENTS ARE :" + filecontent);

            ////clean up and deleteing file
            //File.Delete(filepath);
            //Directory.Delete(dirpath);

            //Console.WriteLine("\nDELETED

            //2. Write a program in C# that reads a text file "sample.txt" line by line using StreamReader and
            //writes each line to a new file named "copy.txt" using StreamWriter.

            // string source = "sample.txt";
            // string destination = "copy.txt";

            // StreamReader str = new StreamReader(source);
            // StreamWriter str2 = new StreamWriter(destination);
            // using (str)
            // using (str2)
            // {
            //     string line;
            //     while((line=str.ReadLine())!=null)
            //     {
            //         str2.WriteLine(line);
            //         Console.WriteLine(line);

            //     }
            // }
            //Console.WriteLine("\n finished..");

            //3 Define a Person class with properties Name and Age. Write a program to serialize an instance of
            // Person to a JSON file and then deserialize it back to display the object properties on the console.
            //Person person = new Person
            //{
            //    name = "Norah",
            //    age = 22
            //};

            //string filepath = "person.json";

            ////serialize to json and save it
            //string jsonString = JsonSerializer.Serialize(person);
            //File.WriteAllText(filepath, jsonString);
            //Console.WriteLine("object serialized to json string:  "+ jsonString);

            ////deserialize
            //string readJson=File.ReadAllText(filepath);
            //Person deserialize= JsonSerializer.Deserialize<Person>(readJson);
            //Console.WriteLine($"\n \n Name: {deserialize.name}, Age: {deserialize.age}");

            //4. using exception in qn2

            //    string source = "sample.txt";
            //    string destination = "copy.txt";
            //    try
            //    {
            //        StreamReader str = new StreamReader(source);
            //        StreamWriter str2 = new StreamWriter(destination);
            //        using (str)
            //        using (str2)
            //        {
            //            string line;
            //            while ((line = str.ReadLine()) != null)
            //            {
            //                str2.WriteLine(line);
            //            }


            //            Console.WriteLine("copied succesfully");
            //        }


            //    }
            //    catch(FileNotFoundException ex)
            //    {       
            //        Console.WriteLine("\n---------------------------------");
            //            Console.WriteLine(ex.Message);
            //    }
            //    catch(UnauthorizedAccessException ex)
            //    {
            //        Console.WriteLine("\n----------------------------------");
            //        Console.WriteLine(ex.Message);
            //    }
            //    catch(IOException ex)
            //    {
            //        Console.WriteLine("\n----------------------------------");
            //        Console.WriteLine(ex.Message);
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine("\n----------------------------------");
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("\n\n********** END **************");
            //    }

            //5..Write a C# program that searches for all .txt files within a directory named "Logs". For each .txt
            // file found:

            //string dirpath = "Logs";
            //Directory.CreateDirectory(dirpath);

            //string sample = Path.Combine(dirpath, "sample.txt");

            //if(!File.Exists(sample))
            //{
            //    File.WriteAllText(sample, "sample lo entry....");
            //    Console.WriteLine("smaple file created in log");
            //}

            ////search for text and modify
            //foreach(string s in Directory.GetFiles(dirpath,"*.txt"))
            //    {
            //    //append time
            //    string time = DateTime.Now.ToString("yyyy-MM--dd HH:mm:ss");
            //    File.AppendAllText(sample, $":  {time}");

            //    //display file after modification
            //    string content=File.ReadAllText(sample);
            //    Console.WriteLine("\n");
            //    Console.WriteLine($"FILE:  {sample} \n\nCONTENT:  \n\n{content}");
            //}


            //Create a C# program that:
            // Writes an array of integers { 10, 20, 30, 40, 50}
            //  to a binary file named "data.bin".
            //Reads the integers from "data.bin" and displays them on the console.

            //string file = "data.bin";
            //int[] numbers = { 10, 20, 30, 40, 50 };

            ////writing integers to binary file;
            //BinaryWriter bn=new BinaryWriter(File.Open(file, FileMode.Create));
            //using(bn)
            //{
            //    foreach(int number in numbers)
            //    {
            //        bn.Write(number);
            //    }
            //}
            //Console.WriteLine("data written to binary file");

            ////read the integrer

            //BinaryReader br=new BinaryReader(File.Open(file, FileMode.Open));
            //using (br)
            //{
            //    Console.WriteLine("\n\nreading data");
            //    while(br.BaseStream.Position < br.BaseStream.Length)
            //    {
            //        int number = br.ReadInt32();
            //        Console.WriteLine(number);
            //    }


            //}


            //7.Create a custom exception class named FileTooLargeException which is thrown when a file
            //exceeds 1 MB in size.Write a program that reads a file's size and throws this exception if the file
            // size is too large. Otherwise, it should display "File size is acceptable."

            //string file = "C:\\Users\\ASUS\\Desktop\\c#.net\\visual studio\\Assignments\\Assignment14\\Assignment14\\TextFile1.txt";
            //try
            //{

            //    FileInfo file1 = new FileInfo(file);
            //    if (file1.Length > 1024 * 1024)
            //    {
            //        throw new FileTooLargeException("file size exceed 1 mb");//user defined exceptiopn

            //    }
            //    Console.WriteLine("file is okay");

            //}
            //catch (FileTooLargeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //8.Define a Book class with properties Title, Author, and ISBN. Write a program that serializes an
            //instance of Book to an XML file named "book.xml" and then deserializes it back, displaying the
            // details on the console.

            //Book book = new Book { Title = "i am malala", Author = "malala", ISBN = "12345" };
            //string file = "book.xml";
            //XmlSerializer serializer = new XmlSerializer(typeof(Book));
            //FileStream fs=new FileStream(file, FileMode.Create); 
            //using(fs)
            //{
            //    serializer.Serialize(fs, book);
            //}
            //Console.WriteLine("book serialized to xml\n");
            ////deserialize
            //Book deserialize;
            //FileStream fs1=new FileStream(file,FileMode.Open);  
            //using( fs1)
            //{
            //    deserialize= (Book)serializer.Deserialize(fs1);
            //}
            //Console.WriteLine($"\n \n\nTitle: {deserialize.Title}, Author: { deserialize.Author}, ISBN: { deserialize.ISBN}");


            //9.
            Calculator calculator = new Calculator();

            // Testing Add method
            int sum = calculator.Add(3, 2);
            Console.WriteLine($"3 + 2 = {sum}");

            // Testing Divide method
            try
            {
                int quotient = calculator.Divide(6, 2);
                Console.WriteLine($"6 / 2 = {quotient}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Test Divide by zero exception
            try
            {
                int quotient = calculator.Divide(6, 0);
                Console.WriteLine($"6 / 0 = {quotient}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


            Console.ReadLine();
        
        
        
        
        
        
        
        
        }
        //3
        public class Person
        {
            public string name {  get; set; }
            public int age { get; set; }
        }

        //7.  USERDEFINED EXCEPTION
        public class FileTooLargeException:Exception
        {
            public FileTooLargeException(string message):base(message) { }    
        }

        //8.class Book
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }

        
    }
}
