using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Salary
    {
        public Salary()
        {

        }
        double[,] salaries = new double[4, 3];
       

    public void populateArray()
        {
            for (int i = 0; i < salaries.GetLength(0); i++)
            {
                Console.WriteLine($"Department {i}");
                for (int j = 0; j < salaries.GetLength(1); j++)
                {
                    Console.WriteLine($"Month {j}:");
                    double sala = double.Parse(Console.ReadLine());
                    salaries[i, j] = sala;
                }
            }
            
        }


        public void ShowArray()
        {
            for (int i = 0; i < salaries.GetLength(0); i++)
            {
                for (int j = 0; j < salaries.GetLength(1); j++)
                {
                    Console.Write(salaries[i, j] + ",");
                }
                Console.WriteLine();
            }
        }
       
         public double[] calculateAvgSalaryPerDept()
         {
            double[] averageSalaryPerDept = new double[4];

            for (int i = 0; i < salaries.GetLength(0); i++)
            {
                double sumOfDep = 0;

                for (int j = 0; j < salaries.GetLength(1); j++)
                {
                    sumOfDep += salaries[i,j];    
                }
                averageSalaryPerDept[i] = sumOfDep / 3;
            }
            return averageSalaryPerDept;
         }
        public double[] calculateAvgSalaryPerMonth()
        {
            double[] averageSalaryPerMonth = new double[3];

            for (int i = 0; i < salaries.GetLength(1); i++)
            {
                double sumOfMonth = 0;
                for (int j = 0; j < salaries.GetLength(0); j++)
                {
                    sumOfMonth += salaries[j, i];
                }
                averageSalaryPerMonth[i] = sumOfMonth / 4;
            }
            return averageSalaryPerMonth;
        }
       