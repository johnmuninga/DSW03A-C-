using System;

namespace FinalMarkCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double[,] testScores = new double[4, 3];
            double[] finalMarks = new double[4];
            double classAverage = 0;

            // Ask user to input test scores for each student
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter test scores for student " + (i + 1) + ":");
                for (int test = 0; test < 3; test++)
                {
                    Console.Write("Test " + (test + 1) + ": ");
                    testScores[i, test] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }

            // Calculate final marks for each student
            for (int i = 0; i < 4; i++)
            {
                finalMarks[i] = (testScores[i, 0] + testScores[i, 1] + testScores[i, 2]) / 3;
                Console.WriteLine("Final mark for student " + (i + 1) + ": " + finalMarks[i]);
                classAverage += finalMarks[i];
            }

            // Calculate class average
            classAverage /= 4;
            Console.WriteLine("Class average: " + classAverage);
        }
    }
}


