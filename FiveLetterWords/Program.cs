using System;
using System.Collections.Generic;


namespace FiveLetterWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string input;

            Console.WriteLine("Enter a word (or ENTER to quit): ");

            do
            {
                input = Console.ReadLine();

                if (input != "")
                {
                    words.Add(input);
                }
            }
            while (input != "");

            Console.WriteLine("The five-letter words are: ");

            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadLine();

        }
    }
}
