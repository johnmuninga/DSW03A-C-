using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for two double variables
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        // Pass both variables to computePercentage() method
        computePercentage(num1, num2);

        // Call the method again, passing the values in reversed order
        computePercentage(num2, num1);

        // Wait for user input before closing the console window
        Console.ReadLine();
    }

    static void computePercentage(double num1, double num2)
    {
        double percentage = (num1 / num2) * 100;
        Console.WriteLine($"{num1} is {percentage}% of {num2}");
    }
}
