using System;

class MedicalAidScheme
{
    // function to calculate monthly premium based on income and number of dependants
    static double CalculateMonthlyPremium(double monthlyIncome, int numAdults, int numChildren)
    {
        double monthlyPremium = 0;
        double memberPre = 1000;


        if (monthlyIncome <= 7000)
        {
            monthlyPremium = 582 + numAdults * 476 + Math.Min(numChildren, 3) * 264;
        }
        else if (monthlyIncome <= 12000)
        {
            monthlyPremium = 868 + numAdults * 709 + Math.Min(numChildren, 3) * 470;
        }
        else
        {
            monthlyPremium = 1084 + numAdults * 887 + Math.Min(numChildren, 3) * 586;
        }

        return monthlyPremium;
    }

    // function to calculate premium penalty based on member's age and monthly premium
    static double CalculatePremiumPenalty(int age, double monthlyPremium)
    {
        double penalty = 0;

        int yearsAfter35 = age - 35;
        if (yearsAfter35 >= 1 && yearsAfter35 <= 4)
        {
            penalty = monthlyPremium * 0.05;
        }
        else if (yearsAfter35 >= 5 && yearsAfter35 <= 14)
        {
            penalty = monthlyPremium * 0.15;
        }
        else if (yearsAfter35 >= 15 && yearsAfter35 <= 24)
        {
            penalty = monthlyPremium * 0.25;
        }
        else if (yearsAfter35 >= 25)
        {
            penalty = monthlyPremium * 0.35;
        }

        return penalty;
    }

    static void Main(string[] args)
    {
        string memberName;
        int age, numAdults, numChildren;
        double monthlyIncome, monthlyPremium, premiumPenalty, totalPremium = 0;

        // loop to prompt user to enter member data until sentinel is used to stop
        while (true)
        {
            Console.Write("Enter main member name (or 'ZZZ' to terminate): ");
            memberName = Console.ReadLine();

            if (memberName == "ZZZ")
            {
                break;
            }

            Console.Write("Enter main age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter number of adult dependants: ");
            numAdults = int.Parse(Console.ReadLine());

            Console.Write("Enter number of child dependants: ");
            numChildren = int.Parse(Console.ReadLine());

            Console.Write("Enter main monthly income: ");
            monthlyIncome = double.Parse(Console.ReadLine());

            monthlyPremium = CalculateMonthlyPremium(monthlyIncome, numAdults, numChildren);
            premiumPenalty = CalculatePremiumPenalty(age, monthlyPremium);

            // add premium and penalty to total premium for all members
            totalPremium += monthlyPremium + premiumPenalty;

            Console.WriteLine($"Monthly premium (excl. penalty) for {memberName}: R{monthlyPremium:F2}");
            Console.WriteLine($"Premium penalty for {memberName}: R{premiumPenalty:F2}\n");

        }
        Console.WriteLine("======================================================================================");
        Console.WriteLine($"Total monthly contributions for all members: R{totalPremium:F2}");
    }
}
