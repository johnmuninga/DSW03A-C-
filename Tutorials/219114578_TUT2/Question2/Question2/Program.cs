using System;

class Program
{
    static void Main(string[] args)
    {
        // prompt the user to enter the code of department and salary
        Console.WriteLine("Enter department code (A, B, or other):");
        string department = Console.ReadLine();

        Console.WriteLine("Enter annual salary:");
        double salary = double.Parse(Console.ReadLine());

        double increase = 0.0;

        // introducing the condition of prices' room and code
        if (department == "A")
        {
            increase = 0.052;
        }
        else if (department == "B")
        {
            increase = 0.048;
        }
        else
        {
            increase = 0.043;
        }

        //formula
        double monthlySalary = salary * (1 + increase) / 12;

        //Output
        Console.WriteLine("Increased monthly salary: {0:C}", monthlySalary);
    }
}