using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queston1_LabEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  title  fiction book:");
            string Title1 = Console.ReadLine();
            Fiction book1 = new Fiction(Title1);
            book1.setPrice();
            Console.WriteLine("Enter title non fiction book:");
            string bookTitle2 = Console.ReadLine();
            Non_Fiction book2 = new Non_Fiction(bookTitle2);
            book2.setPrice();

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Fiction \n 1.{book1.Title} - R{book1.BookPrice}");
            Console.WriteLine($"Non-Fiction \n 1.{book2.Title} - R{book2.BookPrice}");
        }
    }
}
