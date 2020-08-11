// Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // For loop, start at 1, end at 100, re-iterating +1
        for (int num = 1; num <= 100; num++)
        {
            // If statement, dont print if divisible by both 3 & 5
            if (num % 3 == 0 && num % 5 == 0)
                continue;
            // If statement, print if divisible by 3 or 5
            if (num % 3 == 0 || num % 5 == 0)
                System.Console.WriteLine(num);
        }
    }
}
