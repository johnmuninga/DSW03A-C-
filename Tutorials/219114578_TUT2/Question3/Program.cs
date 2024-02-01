using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int[] marks = new int[10];
            string[] names = new string[10];
            int highest;
            int lowest;
            string highestN = "";
            string lowestN = "";

            //A loop to prompt the user to enter Name and Marks
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter student {i + 1} name: ");
                names[i] = Console.ReadLine();

                Console.WriteLine($"Enter mark: {i + 1} ");
                marks[i] = int.Parse(Console.ReadLine());

            //If statement to put the condition of if Marks= -1 and break after
                if (marks[i] == -1)
                {
                    break;
                }
            }

            highest = marks[0];
            lowest = marks[0];
            for (int i = 1; i < names.Length; i++)
            {


                if (marks[i] >= highest)
                {
                    highest = marks[i];
                    highestN = names[i];

                }
                if (marks[i] <= lowest)
                {
                    if (marks[i] == -1)
                    {
                        break;
                    }
                    lowest = marks[i];


                    lowestN = names[i];

                }
            }
           //Output the Result
            Console.WriteLine($" Highest mark  {highest} name: {highestN}");
            Console.WriteLine($" Lowest mark  {lowest} name: {lowestN}");

            Console.ReadKey();

        }

    }
}