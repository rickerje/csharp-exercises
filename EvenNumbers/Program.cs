using System;
using System.Collections.Generic;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>();
            string input;
            int aNumber;

            Console.WriteLine("Enter an integer (or ENTER to end): ");

            do
            {
                input = Console.ReadLine();

                if (input != "")
                {
                    aNumber = int.Parse(input);
                    Numbers.Add(aNumber);
                }
            }
            while (input != "");

            Console.WriteLine("The even numbers in the list are: ");

            foreach (int number in Numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }
    }
}
