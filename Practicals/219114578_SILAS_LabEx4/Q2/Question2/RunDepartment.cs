using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class RunDepartment
    {
        static void Main(string[] args)
        {
            Salary sala = new Salary();
            
            sala.populateArray();
            
            sala.ShowArray();
            Console.WriteLine("=================================");
            
            var averageSalaryPerDept = sala.calculateAvgSalaryPerDept();
            var averageSalaryPerMonth = sala.calculateAvgSalaryPerMonth();
            //DISPLAY THE AVERAGES
            foreach (var aveg in averageSalaryPerDept)
            {
                Console.WriteLine(aveg);
            }
            Console.WriteLine("================================================");
            foreach (var aveg in averageSalaryPerMonth) { Console.WriteLine(aveg); }

            Console.WriteLine("=================================================");
            Console.WriteLine("Enter a numbee: ");
            int month = Convert.ToInt32(Console.ReadLine());
            int department = sala.determineHighestMonthlySalary(month);
            if (department > -1)
                Console.WriteLine(department);
            else
                Console.WriteLine("DOESNT EXIST");
            Console.WriteLine("=================================================");
            Console.WriteLine("Enter a numbee: ");
            int dept = Convert.ToInt32(Console.ReadLine());
            int mnthSal = sala.determineHighestDepartSalary(dept);
            if (department > -1)
                Console.WriteLine(mnthSal);
            else
                Console.WriteLine("DOESNT EXIST");

            Console.ReadKey();
        }
    }
}

