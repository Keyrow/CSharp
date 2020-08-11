using System;
using System.Collections.Generic;
namespace Functions
{
    public class Program
    {
        public static string SayHello(string firstName = "buddy")
        {
            return $"Hey {firstName}";
        }
        public static void Main(string[] args)
        {
            string greeting = SayHello();
            Console.WriteLine(greeting);
        }
    }
}