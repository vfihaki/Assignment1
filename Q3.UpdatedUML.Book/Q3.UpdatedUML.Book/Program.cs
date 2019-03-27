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
            Book newbook = new Book();

            Console.WriteLine("*** ENTER NEW BOOK DETAILS BELOW ***\n");

            Console.Write("Enter Book Title: ");
            string BookTitle = Console.ReadLine();
            Console.Write("Enter Book Author: ");
            string BookAuthor = Console.ReadLine();
            Console.Write("Enter Book Publisher: ");
            string BookPublisher = Console.ReadLine();

            Book b1 = new Book(BookTitle, BookAuthor, BookPublisher);
            newbook = b1;

            Console.WriteLine("\n******************************************");
            Console.WriteLine(newbook.GetBookDetail());
            
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
        public Book( string _title, string _author, string _publisher)
        {
            Title = _title;
            Author = _author;
            Publisher = _publisher;
        }
        public string GetBookDetail()
        {
            return $"The following new book has been processed:\nBook Title: {Title}\nAuthor: {Author}\nPublisher: {Publisher}";
        }
    }

}

