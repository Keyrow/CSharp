using System;
using System.Collections.Generic;

namespace Puzzles_III
{
    class Program
    {
        public static string[] Names()
        {
            // String of 5 names and print each name in random order
            string[] Names = { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            Random rand = new Random();
            for (int i = 0; i < Names.Length; i++)
            {
                int x = rand.Next(Names.Length);
                string temp = Names[x];
                Names[x] = Names[i];
                Names[i] = temp;
            }
            // For names over 5 characters long
            List<string> OverFive = new List<string>();
            foreach (var name in Names)
            {
                Console.WriteLine(name);
                if (name.Length > 5)
                {
                    OverFive.Add(name);
                }
            }

            foreach (var person in OverFive)
            {
                Console.WriteLine(person);
            }
            return OverFive.ToArray();
        }
        // Main that runs the code
        static void Main(string[] args)
        {
            Names();
        }
    }
}
/*
Names
Build a function Names that returns a list of strings.  In this function:

Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
Shuffle the list and print the values in the new order
Return a list that only includes names longer than 5 characters
*/
