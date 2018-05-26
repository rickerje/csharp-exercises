using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Write("Name: ");
            string myName = Console.ReadLine();
            Console.WriteLine("Hello " + myName + "!");
            Console.ReadLine();
        }
    }
}
