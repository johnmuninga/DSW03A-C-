using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using queston1_LabEx4;

namespace BookArray
{
    internal class Program
    {
        public static Book book;
        static void Main(string[] args)
        {       
            Book[] Book = new Book[10];
            for (var i = 0; i < Book.Length; i++)
            {
                Console.WriteLine($"Book number {i + 1}:");
                string Title = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine($"Fiction or Non-Fiction (F or N)?:");
                    var Type = Console.ReadLine();
                    if (Type == "F"|| Type =="f")
                    {
                        book = new Fiction(Title);
                        break;
                        
                    }
                    else if (Type == "N" || Type == "n")
                    {
                        book = new Non_Fiction(Title);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                Book[i] = book;
                book.setPrice();

            }
            for (int i = 0; i < Book.Length; i++)
            {
                Book book = Book[i];
                Console.WriteLine($"Title: {book.Title}, Price: {book.BookPrice}");

            }
        }
    }
}
