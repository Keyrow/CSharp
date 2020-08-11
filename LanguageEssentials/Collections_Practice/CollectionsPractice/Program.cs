using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basics Arrays
            int[] zeroToNine = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var item in zeroToNine)
            {
                System.Console.WriteLine(item);
            }
            string[] names = { "Tim", "Martin", "Nikki", "Sara" };
            foreach (var item in names)
            {
                System.Console.WriteLine(item);
            }
            bool[] trueFalse = { true, false, true, true, true, true, false, false, true, false };
            foreach (var item in trueFalse)
            {
                System.Console.WriteLine(item);
            }

            // List of Flavors
            List<string> flavors = new List<string>
            {
                "Cookies n' Cream",
                "Mint Chocolate",
                "Butter Pecan",
                "Cookie Dough",
                "Snickers",
            };
            System.Console.WriteLine(flavors.Count);
            System.Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            System.Console.WriteLine(flavors.Count);

            // User Info Dictionary
            Dictionary<string, string> profile = new Dictionary<string, string>();
            Random rand = new Random();
            foreach (string name in names)
            {
                profile.Add(name, flavors[rand.Next(0, flavors.Count)]);
            }

            // Output each user and their favorite flavor
            foreach (var name in profile)
            {
                Console.WriteLine("Name: " + "{0}" + "\n" + "Favorite flavor: " + "{1}", name.Key, name.Value);
            }
        }
    }
}
