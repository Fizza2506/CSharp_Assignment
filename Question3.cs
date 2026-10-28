
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ClassID: 66271 | Registration ID: 120703 | Name: Fizza Batool | Submission Date: 29-10-2026");

        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0)
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else if (year % 100 == 0)
        {
            Console.WriteLine(year + " is not a leap year.");
        }
        else if (year % 4 == 0)
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
}
