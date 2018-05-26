using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Number of miles driven: ");
            input = Console.ReadLine();
            double milesDriven = double.Parse(input);

            Console.Write("Number of gallons used: ");
            input = Console.ReadLine();
            double gallonsUsed = double.Parse(input);

            double mpg = milesDriven / gallonsUsed;

            Console.Write("Your MPG was " + mpg + ".");
            Console.ReadLine();


        }
    }
}
