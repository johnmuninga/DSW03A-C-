using System;

namespace TUT1_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Variable

            int hrsWork = 0;
            int rPlan = 0;
            int shift = 0;  
            double hourlyPay = 0;
            double regularPay = 0;
            double overtimePay = 0;
            double totalPay = 0;
            double retirement = 0;
            double netPay = 0;


            Console.WriteLine("Enter Hour Worked: ");
            hrsWork = Convert.ToInt32(Console.ReadLine());

            // Introduce the Shift Condition

            Console.WriteLine("Enter Shift(1,2,3): ");
            shift = Convert.ToInt32(Console.ReadLine());

            if (shift == 1)
            {
                hourlyPay = 17;
            }
            else if (shift == 2)
            {
                hourlyPay = 18.5;
                Console.WriteLine("Do you want retirement plan(1 for yes, 2 for no)?");
                rPlan = Convert.ToInt32(Console.ReadLine());

            }
            else if (shift == 3)
            {
                hourlyPay = 22;
                Console.WriteLine("Do you want retirement plan(1 for yes, 2 for no)?");
                rPlan = Convert.ToInt32(Console.ReadLine());
            }
                
            //Calculate Over Time and NetPay

            if (hrsWork > 40)
            {
                overtimePay = (hrsWork - 40) * hourlyPay * 1.5;
                regularPay = 40 * hourlyPay;
                totalPay = overtimePay + regularPay;
            }
            else
            {
                regularPay = hrsWork * hourlyPay;
                totalPay = overtimePay + regularPay;
            }

            if (rPlan == 1)
            {
                retirement = totalPay * .03;
                netPay = totalPay - retirement;
            }
            else
            {
                netPay = totalPay;
            }

            //Output the results

            Console.WriteLine("Shift= " + shift);
            Console.WriteLine("Hours Worked= " + hrsWork);
            Console.WriteLine("Hourly Pay " + hourlyPay);
            Console.WriteLine("Regular Pay= " + regularPay);
            Console.WriteLine("Overtime Pay= " + overtimePay);
            Console.WriteLine("Total Pay= " + totalPay);
            Console.WriteLine("Retirement Deduction= " + retirement);
            Console.WriteLine("Net Pay= " + netPay);

        }
    }
}