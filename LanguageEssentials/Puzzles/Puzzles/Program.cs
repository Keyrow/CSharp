using System;

using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static void randomArray()
        {
            List<int> randomArray = new List<int>();
            Random rand = new Random();
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                randomArray.Add(rand.Next(5, 25));
            }
            int min = randomArray[0];
            int max = randomArray[0];
            for (int i = 0; i < randomArray.Count; i++)
            {
                sum += randomArray[i];
                if (randomArray[i] > max)
                {
                    max = randomArray[i];
                }
                if (randomArray[i] < min)
                {
                    min = randomArray[i];
                }
            }
            randomArray.ForEach(number => Console.WriteLine(number));
            Console.WriteLine($"Min: {min}\nMax: {max}\nSum: {sum}");
        }
        static void Main(string[] args)
        {
            randomArray();
        }
    }
}

/* 
Random Array
Create a function called RandomArray() that returns an integer array

Place 10 random integer values between 5-25 into the array
Print the min and max values of the array
Print the sum of all the values
*/

