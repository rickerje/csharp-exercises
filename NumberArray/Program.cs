using System;
using System.Collections.Generic;


namespace NumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {1, 1, 2, 3, 5, 8 };

            foreach (int myInteger in myArray)
            {
                Console.WriteLine(myInteger);
            }
            Console.ReadLine();
        }
    }
}
