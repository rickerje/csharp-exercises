using System;

namespace AreaRect
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Length of rectangle: ");
            input = Console.ReadLine();
            int length = int.Parse(input);

            Console.Write("Height of rectangle : ");
            input = Console.ReadLine();
            int height = int.Parse(input);

            int area = length * height;
            Console.WriteLine("The area of the rectangle is " + area);
            Console.ReadLine();
        }
    }
}
