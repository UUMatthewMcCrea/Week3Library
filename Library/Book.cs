using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        string Title;
        string Author;
        string ISBN;

        public Book(string booktitle, string bookauthor, string bookISBN)
        {
            Title = booktitle;
            Author = bookauthor;
            ISBN = bookISBN;
        }

        void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Book mybook = new Book("C# for beginners", "BillGates", "1234");
            

            Book yourbook = new Book("C#Methods", "Microsoft", "3456778");
            

            mybook.DisplayInfo();
            yourbook.DisplayInfo();

           
        }
    }
}
