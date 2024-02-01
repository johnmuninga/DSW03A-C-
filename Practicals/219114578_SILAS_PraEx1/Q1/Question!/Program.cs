using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for queen bed, 2 for king or 3 for a king and a pull-out couch:");
            int choice = int.Parse(Console.ReadLine());

            int price = 0;

            switch (choice)
            {
                case 1:
                    price = 450;
                    break;
                case 2:
                    price = 690;
                    break;
                case 3:
                    price = 800;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (price > 0)
            {
                Console.WriteLine("You chose option {0}. The price of your room is R{1}.", choice, price);
            }
            else
            {
                Console.WriteLine("Price set to 0 due to invalid choice.");
            }
        }
     }
}
