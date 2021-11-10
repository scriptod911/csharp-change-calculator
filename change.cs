using System;


namespace ChangeReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the cost of the item?");
            double cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How much money was given?");
            double moneyGiven = Convert.ToDouble(Console.ReadLine());

            double change = moneyGiven - cost;

            double quarters = change / .25;

            double dimes = (change % .25) / .10;

            double nickels = ((change % .25) % .10) / .05;

            double pennies = (((change % .25) % .10) % .05) / .01;

            double dollars = quarters / 4;

            Console.WriteLine("Your change is {0} dollars, {1} quarters, {2} nickels, and {3} pennies and {4} quarters.", dollars, quarters, nickels, pennies, dimes);
        }
    }
}
