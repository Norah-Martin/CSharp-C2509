//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment7
//{
//    internal class Libarary
//    {



//        public class Book
//        {
//            public string Title { get; set; }
//            public string Author { get; set; }
//            public int Isbn { get; set; }

//            public Book(string title, string author, int isbn)
//            {
//                Title = title;
//                Author = author;
//                Isbn = isbn;

//            }
//            public override string ToString()
//            {
//                return $"Title: {Title}, Author: {Author}, ISBN: {Isbn}";
//            }
//        }


//        //library
//        public class Library
//        {
//            private List<Book> books = new List<Book>();

//            public void Addbook(Book book)
//            {
//                books.Add(book);
//            }

//            public void Removebook(Book book)
//            {
//                books.Remove(book);
//            }

//            public void DisplayBooks()
//            {
//                if (books.Count < 0)
//                {
//                    Console.WriteLine("no book");
//                }
//                foreach (var Book in books)
//                {
//                    Console.WriteLine(Book);

//                }
//            }
//        }
//        //main
//        static void Main(string[] args)
//        {
//            Library lib = new Library();

//            Book b1 = new Book("XYQ", "ABC", 1);
//            Book b2 = new Book("the great", "norah", 2);
//            Book b3 = new Book("wow", "qwe", 3);

//            lib.Addbook(b1);
//            lib.Addbook(b2);
//            lib.Addbook(b3);


//            lib.DisplayBooks();

//            lib.Removebook(b2);
//            Console.WriteLine("\nAfter removing ");
//            lib.DisplayBooks();
//            Console.ReadLine();
//        }


//    }
//}
