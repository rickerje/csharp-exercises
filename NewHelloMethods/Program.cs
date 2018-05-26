using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewHelloMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("en");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
