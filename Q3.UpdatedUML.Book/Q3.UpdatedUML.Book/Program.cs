using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.UpdatedUML.Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ENTER NEW BOOK DETAILS BELOW ***\n");
            Book newbook = new Book();
            Console.Write("Enter Book Title: ");
            newbook.Title = Console.ReadLine();
            Console.Write("Enter Book Author: ");
            newbook.Author = Console.ReadLine();
            Console.Write("Enter Book Publisher: ");
            newbook.Publisher = Console.ReadLine();

            Console.WriteLine("\n******************************************");
            Console.WriteLine($"The following new book has been processed:\nBook Title: {newbook.Title}\nAuthor: {newbook.Author}\nPublisher: {newbook.Publisher}");  
            Console.ReadLine();
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public Book()
        {

        }
        /*
        public Book( string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }
        */
    }

}

