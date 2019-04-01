using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1.Book
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("*** ENTER NEW BOOK DETAILS BELOW ***\n");
            Book newbook = new Book();
            Console.Write("Enter Book Title: ");
            newbook.SetTitle(Console.ReadLine());
            Console.Write("Enter Book Author: ");
            newbook.SetAuthor(Console.ReadLine());
            Console.Write("Enter Book Publisher: ");
            newbook.SetPublisher(Console.ReadLine());
            
            Console.WriteLine("\n******************************************");
            Console.WriteLine($"The following new book has been processed:\n{newbook.GetTitle()}\n{newbook.GetAuthor()}\n{newbook.GetPublisher()}");

            Console.ReadLine();
        }
    }
    class Book
    {
        private string title;
        private string author;
        private string publisher;
               
        public string GetTitle()
        {
            return $"Book Title: {title}";
        }
        public void SetTitle(string tle)
        {
            title = tle;
        }
        public string GetAuthor()
        {
            return $"Author: {author}";
        }
        public void SetAuthor(string au)
        {
            author = au;
        }
        public string GetPublisher()
        {
            return $"Publisher: {publisher}";
        }
        public void SetPublisher(string pub)
        {
            publisher = pub;
        }        
    }
}
