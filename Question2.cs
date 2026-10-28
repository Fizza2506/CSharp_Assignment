
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ClassID: 66271 | Registration ID: 120703 | Name: Fizza Batool | Submission Date: 29-10-2026");

        Console.Write("Enter purchase amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double discountPercentage;
        double discountAmount;
        double finalAmount;

        if (amount >= 5000)
        {
            discountPercentage = 20;
        }
        else if (amount >= 2000)
        {
            discountPercentage = 10;
        }
        else
        {
            discountPercentage = 0;
        }

        discountAmount = amount * discountPercentage / 100;
        finalAmount = amount - discountAmount;

        Console.WriteLine("Discount Percentage: " + discountPercentage + "%");
        Console.WriteLine("Discount Amount: " + discountAmount);
        Console.WriteLine("Final Payable Amount: " + finalAmount);
    }
}
