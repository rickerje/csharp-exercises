using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            string input;

            Console.Write("Enter a radius: ");
            input = Console.ReadLine();
            radius = double.Parse(input);

            double thisArea = 3.14 * radius * radius;

            Console.WriteLine("The area of the circle is " + thisArea);
            Console.ReadLine();

        }
    }
}
