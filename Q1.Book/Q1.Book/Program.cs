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
            Book newbook = new Book();

            Console.WriteLine("*** ENTER NEW BOOK DETAILS BELOW ***\n");

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

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public string GetTitle()
        {
            return $"Book Title: {Title}";
        }
        public void SetTitle(string tle)
        {

        }
        public string GetAuthor()
        {
            return $"Author: {Author}";
        }
        public void SetAuthor(string tle)
        {

        }
        public string GetPublisher()
        {
            return $"Publisher: {Publisher}";
        }
        public void SetPublisher(string tle)
        {

        }



    }
}
