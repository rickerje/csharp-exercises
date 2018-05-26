using System;

namespace AliceString
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting " +
                "by her sister on the bank, and of having nothing to do: once or twice " +
                "she had peeped into the book her sister was reading, but it had no pictures " +
                "or conversations in it, 'and what is the use of a book,' thought Alice " +
                "'without pictures or conversation?'";

            Console.Write("Enter string to search for: ");
            string searchString = Console.ReadLine();
            string searchStringLower = searchString.ToLower();

            string firstSentenceLower = firstSentence.ToLower();
            bool result = firstSentenceLower.Contains(searchStringLower);
            Console.WriteLine("Is the string " + searchString + " in the sentence? " + result);
            Console.ReadLine();


        }
    }
}
