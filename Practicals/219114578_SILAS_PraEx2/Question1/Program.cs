// C# program to illustrate how
// to read a file in C#
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        // Store the path of the textfile in your system
        string file = @"dataset.txt";
       

        Console.WriteLine("***********************************************************************");
        Console.WriteLine("*                       BIG DATA APPLICATION                          * ");
        Console.WriteLine("***********************************************************************");

        Console.WriteLine("1: Display all the data from the dataset");
        Console.WriteLine("2: Display all data based on the given year (2013 - 2018)");
        Console.WriteLine("3: Display all data based on the level (1 -4)");
        Console.WriteLine("0: Exit........");

        Console.WriteLine("Enter Number: ");
        int num=int.Parse(Console.ReadLine());

        Console.WriteLine("Reading File using File.ReadAllLines()");

        // To read a text file line by line
        if (num == 1)
        {
            if (File.Exists(file))
            {
                // Store each line in array of strings
                string[] lines = File.ReadAllLines(file);

                foreach (string ln in lines)
                    Console.WriteLine(ln);
            }
            Console.WriteLine();
        }



        else if (num == 0)
        {
            System.Environment.Exit(0);
        }

       
    }
}
