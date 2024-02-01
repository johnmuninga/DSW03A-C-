using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the the to enter a number 
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        //Called the 3 method in the main method
        displayThreeTimesTheNumber(number);
        displayNumberPlusTen(number);
        displayNumberSquared(number);
    }

    //frist method to calculate the num * 3
    static void displayThreeTimesTheNumber(int number)
    {
        Console.WriteLine("Three times the number is: " + (number * 3));
    }

    // second method to calculate the num + 10
    static void displayNumberPlusTen(int number)
    {
        Console.WriteLine("The number plus ten is: " + (number + 10));
    }

    //third method to calculate the square of the num
    static void displayNumberSquared(int number)
    {
        Console.WriteLine("The number squared is: " + (number * number));
    }
}