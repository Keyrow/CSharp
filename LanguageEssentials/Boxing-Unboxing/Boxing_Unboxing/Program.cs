using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> values = new List<object>();
            values.Add(7);
            values.Add(28);
            values.Add(-1);
            values.Add(true);
            values.Add("chair");
            // Loop through all values and print them "foreach" is the inference hint needed for this
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            // Add all the integers and print result, skips the true and string chair
            int sum = 0;
            foreach (var value in values)
            {
                // if statement so that only the integers gets added and skips everything else.
                if (value is int)
                {
                    sum = sum + (int)value;
                }
            }
            System.Console.WriteLine("The sum of all integers in the list is: " + sum);
        }
    }
}
