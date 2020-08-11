/* Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and 
"FizzBuzz" for numbers that are multiples of both 3 and 5 */

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // For loop, start at 1, end at 100, re-iterating +1
        for (int num = 1; num <= 100; num++)
        {
            // print "FizzBuzz if divisible by both 3 and 5
            if (num % 3 == 0 && num % 5 == 0)
                System.Console.WriteLine("FizzBuzz");
            // print "Fizz" if divisible by 3
            else if (num % 3 == 0)
                System.Console.WriteLine("Fizz");
            // print "Buzz" if divisible by 5
            else if (num % 5 == 0)
                System.Console.WriteLine("Buzz");
            // print everything else that doesnt meet the criteria
            else
            {
                System.Console.WriteLine(num);
            }
        }
    }
}
